using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardViewer
{
    public partial class FormMain : Form
    {
        const int HexColumnCount = 16;
        const string BadFormatsFilename = "BadFormats.txt";

        IDataObject _currentDataObject = null;
        bool _hiding = false;
        Dictionary<TabPage, int> _indices = new Dictionary<TabPage, int>();
        List<string> _badFormats = new List<string>();

        public FormMain()
        {
            InitializeComponent();

            // Initialize bad formats
            try
            {
                string badFormatsPath = Path.Combine( Path.GetDirectoryName( Application.ExecutablePath ), BadFormatsFilename );
                if( File.Exists( badFormatsPath ) )
                {
                    using( StreamReader sr = new StreamReader( File.Open( badFormatsPath, FileMode.Open, FileAccess.Read, FileShare.Read ) ) )
                    {
                        while( !sr.EndOfStream )
                        {
                            string line = sr.ReadLine();
                            if( line == null )
                                break;
                            line = line.Trim();
                            if( string.IsNullOrEmpty( line ) )
                                continue;
                            _badFormats.Add( line );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show( "An error occurred while attempting to read the 'BadFormats.txt' file:\n\n" + ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
            }

            // Initialize views
            for( int i = 0; i < tabControlViews.TabPages.Count; ++i )
                _indices.Add( tabControlViews.TabPages[i], i );
            tabControlViews.TabPages.Clear();
            splitContainerViews.Visible = false;
            doRefreshContents();
        }

        #region Event Handlers

        protected override void OnClosing( CancelEventArgs e )
        {
            base.OnClosing( e );
            e.Cancel = _hiding;
            Hide();
            _hiding = false;
        }

        void buttonClose_Click( object sender, EventArgs e )
        {
            doHide();
        }

        void buttonExit_Click( object sender, EventArgs e )
        {
            doExit();
        }

        void notifyIcon_DoubleClick( object sender, EventArgs e )
        {
            doShowAndRefresh();
        }

        void listFormats_SelectedIndexChanged( object sender, EventArgs e )
        {
            doSelectFormat();
            labelFormatContents.Text = "Format Contents" + ( listFormats.SelectedIndex != -1 ? " (" + (string)listFormats.SelectedItem + ")" : string.Empty );
        }

        void checkBoxXmlWordWrap_CheckedChanged( object sender, EventArgs e )
        {
            textBoxXmlContent.WordWrap = checkBoxXmlWordWrap.Checked;
        }

        void checkBoxXmlWrapAttributes_CheckedChanged( object sender, EventArgs e )
        {
            try
            {
                textBoxXmlContent.Text = Util.FormatXml( textBoxXmlContent.Text, checkBoxXmlWrapAttributes.Checked );
            }
            catch
            {
            }
        }

        void checkBoxRichTextWordWrap_CheckedChanged( object sender, EventArgs e )
        {
            textBoxRichTextContent.WordWrap = checkBoxRichTextWordWrap.Checked;
        }

        void checkBoxPlainTextWordWrap_CheckedChanged( object sender, EventArgs e )
        {
            textBoxPlainTextContent.WordWrap = checkBoxPlainTextWordWrap.Checked;
        }

        void pictureBoxImageContent_SizeChanged( object sender, EventArgs e )
        {
            doAdjustImage();
        }

        void buttonRefreshContents_Click( object sender, EventArgs e )
        {
            doRefreshContents();
        }

        void buttonClearContents_Click( object sender, EventArgs e )
        {
            doClearContents();
        }

        void buttonClearClipboard_Click( object sender, EventArgs e )
        {
            doClearClipboard();
        }

        void showClipboardViewerAndRefreshToolStripMenuItem_Click( object sender, EventArgs e )
        {
            doShowAndRefresh();
        }

        void showClipboardViewerToolStripMenuItem_Click( object sender, EventArgs e )
        {
            doShow();
        }

        void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            doExit();
        }

        #endregion

        #region Action Methods

        void doShow()
        {
            Show();
        }

        void doHide()
        {
            _hiding = true;
            Close();
        }

        void doShowAndRefresh()
        {
            doShow();
            doRefreshContents();
        }

        void doExit()
        {
            _hiding = false;
            Close();
        }

        void doClearContents()
        {
            _currentDataObject = null;
            doUpdateContents();
        }

        void doRefreshContents()
        {
            _currentDataObject = Clipboard.GetDataObject();
            doUpdateContents();
        }

        void doClearClipboard()
        {
            Clipboard.Clear();
            doClearContents();
        }

        void doAdjustImage()
        {
            Size containerSize = pictureBoxImageContent.Size;
            Size imageSize = pictureBoxImageContent.Image.Size;
            PictureBoxSizeMode sizeMode = ( imageSize.Width < containerSize.Width && imageSize.Height < containerSize.Height )
                ? PictureBoxSizeMode.CenterImage : PictureBoxSizeMode.Zoom;
            if( pictureBoxImageContent.SizeMode != sizeMode )
                pictureBoxImageContent.SizeMode = sizeMode;
        }

        void doUpdateContents()
        {
            // Clear formats and views
            listFormats.Items.Clear();
            textBoxNullFormats.Clear();

            if( _currentDataObject != null )
            {
                // Refresh contents
                bool updating = false;
                try
                {
                    listFormats.BeginUpdate();
                    updating = true;

                    // Add formats and views
                    foreach( string format in _currentDataObject.GetFormats() )
                    {
                        try
                        {
                            if( !_currentDataObject.GetDataPresent( format, false ) )
                                continue;
                            if( _badFormats.Contains( format ) )
                            {
                                if( MessageBox.Show( this, "Format '" + format + "' was found and is known to crash the program when attempting to read.\n\nClick OK to skip reading this format.", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning ) == DialogResult.OK )
                                    continue;
                            }
                            if( _currentDataObject.GetData( format, false ) != null )
                                listFormats.Items.Add( format );
                            else
                                textBoxNullFormats.Text += format + Environment.NewLine;
                        }
                        catch( Exception ex )
                        {
                            MessageBox.Show( this, "An error occurred when reading from the clipboard:\n\n" + ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
                            return;
                        }
                    }
                }
                finally
                {
                    if( updating )
                        listFormats.EndUpdate();
                }
            }

            // Select first item
            listFormats.SelectedIndex = listFormats.Items.Count != 0 ? 0 : -1;
            splitContainerViews.Visible = listFormats.Items.Count != 0;
        }

        void doSelectFormat()
        {
            bool suspending = false;
            try
            {
                SuspendLayout();
                suspending = true;

                string format = (string)listFormats.SelectedItem;
                object data = _currentDataObject != null ? _currentDataObject.GetData( format, false ) : null;

                if( data != null )
                {
                    // Data object view
                    textBoxDataObjectType.Text = data.GetType().FullName;

                    MemoryStream deleteStream = null;
                    string text = null;
                    string[] listText = null;
                    string xml = null;
                    MemoryStream ms = null;
                    Image image = null;

                    try
                    {
                        // Analyze format
                        if( data is string )
                            text = (string)data;
                        if( text != null && Util.IsValidXml( text ) )
                            xml = Util.FormatXml( text, checkBoxXmlWrapAttributes.Checked );
                        if( data is MemoryStream )
                            ms = (MemoryStream)data;
                        if( data is byte[] )
                            ms = deleteStream = new MemoryStream( (byte[])data );
                        else if( data is Array )
                        {
                            List<string> listTextList = new List<string>();
                            foreach( object item in (Array)data )
                                listTextList.Add( item != null ? item.ToString() : "(null)" );
                            listText = listTextList.ToArray();
                        }
                        if( data is Image )
                        {
                            image = new Bitmap( (Image)data );
                        }
                        else if( ms != null )
                        {
                            try
                            {
                                long position = ms.Position;
                                image = Image.FromStream( ms );
                                ms.Position = position;
                            }
                            catch( ArgumentException )
                            {
                                // Not a valid image
                            }
                            catch( OutOfMemoryException )
                            {
                                // Not a valid bitmap
                            }
                            catch( Exception ex )
                            {
                                MessageBox.Show( this, "An error occurred while attempting to read image data:\n\n" + ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
                            }
                        }

                        // Hex data view
                        AddRemoveTabPage( tabPageHexData, ms != null );
                        if( ms != null )
                        {
                            StringBuilder contentBuilder = new StringBuilder();

                            BinaryReader br = new BinaryReader( ms );
                            int c = 0;
                            while( true )
                            {
                                try
                                {
                                    byte b = br.ReadByte();
                                    contentBuilder.Append( b.ToString( "x" ).PadLeft( 2, '0' ) );
                                    contentBuilder.Append( " " );
                                    if( ++c == HexColumnCount )
                                    {
                                        contentBuilder.AppendLine();
                                        c = 0;
                                    }
                                }
                                catch( EndOfStreamException )
                                {
                                    break;
                                }
                            }

                            textBoxHexContents.Text = contentBuilder.ToString();
                        }

                        // List text view
                        AddRemoveTabPage( tabPageListText, listText != null );
                        if( listText != null )
                        {
                            listBoxListTextContent.Items.Clear();
                            listBoxListTextContent.Items.AddRange( listText );
                        }

                        // Plain text view
                        AddRemoveTabPage( tabPagePlainText, text != null );
                        if( text != null )
                            textBoxPlainTextContent.Text = text;

                        // Rich text view
                        if( !string.IsNullOrEmpty( text ) && text.Trim().Length > 0 )
                        {
                            try
                            {
                                textBoxRichTextContent.Rtf = text;
                                AddRemoveTabPage( tabPageRichText, true );
                            }
                            catch( ArgumentException )
                            {
                                AddRemoveTabPage( tabPageRichText, false );
                            }
                        }
                        else
                            AddRemoveTabPage( tabPageRichText, false );

                        // Image view
                        AddRemoveTabPage( tabPageImage, image != null );
                        if( image != null )
                        {
                            pictureBoxImageContent.Image = image;
                            doAdjustImage();
                        }

                        // Xml view
                        AddRemoveTabPage( tabPageXml, xml != null );
                        if( xml != null )
                            textBoxXmlContent.Text = xml;
                    }
                    finally
                    {
                        if( deleteStream != null )
                            deleteStream.Dispose();
                    }
                }

                // Set visibility
                panelControlViews.Visible = tabControlViews.TabPages.Count > 0;
            }
            catch( Exception ex )
            {
                MessageBox.Show( this, "An error occurred while setting up views:\n\n" + ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            finally
            {
                if( suspending )
                    ResumeLayout();
            }
        }

        void AddRemoveTabPage( TabPage tabPage, bool show )
        {
            if( show )
            {
                if( tabControlViews.TabPages.Contains( tabPage ) )
                    return;
                    // Insert to correct location
                for( int i = 0; i < tabControlViews.TabPages.Count; ++i )
                {
                    if( _indices[tabPage] < _indices[tabControlViews.TabPages[i]] )
                    {
                        tabControlViews.TabPages.Insert( i, tabPage );
                        tabControlViews.SelectedTab = tabPage;
                        return;
                    }
                }
                tabControlViews.TabPages.Add( tabPage );
            }
            else
            {
                if( tabControlViews.TabPages.Contains( tabPage ) )
                    tabControlViews.TabPages.Remove( tabPage );
            }
        }

        #endregion

        void panelImageBackground_Paint( object sender, PaintEventArgs e )
        {
            e.Graphics.FillRectangle( new HatchBrush( HatchStyle.DiagonalCross, Color.LightGray, Color.White ), new Rectangle( new Point( 0, 0 ), panelImageBackground.Size ) );
        }

    }
}
