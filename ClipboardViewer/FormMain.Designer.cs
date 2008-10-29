namespace ClipboardViewer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormMain ) );
            this.notifyIcon = new System.Windows.Forms.NotifyIcon( this.components );
            this.contextMenuNotifyIcon = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.showClipboardViewerAndRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClipboardViewerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerFormats = new System.Windows.Forms.SplitContainer();
            this.listFormats = new System.Windows.Forms.ListBox();
            this.labelFormats = new System.Windows.Forms.Label();
            this.textBoxNullFormats = new System.Windows.Forms.TextBox();
            this.labelNullFormats = new System.Windows.Forms.Label();
            this.splitContainerViews = new System.Windows.Forms.SplitContainer();
            this.labelFormatContents = new System.Windows.Forms.Label();
            this.textBoxDataObjectType = new System.Windows.Forms.TextBox();
            this.labelDataObjectType = new System.Windows.Forms.Label();
            this.panelControlViews = new System.Windows.Forms.Panel();
            this.tabControlViews = new System.Windows.Forms.TabControl();
            this.tabPageXml = new System.Windows.Forms.TabPage();
            this.checkBoxXmlWrapAttributes = new System.Windows.Forms.CheckBox();
            this.textBoxXmlContent = new System.Windows.Forms.TextBox();
            this.checkBoxXmlWordWrap = new System.Windows.Forms.CheckBox();
            this.tabPageImage = new System.Windows.Forms.TabPage();
            this.panelImageBackground = new System.Windows.Forms.Panel();
            this.pictureBoxImageContent = new System.Windows.Forms.PictureBox();
            this.tabPageListText = new System.Windows.Forms.TabPage();
            this.listBoxListTextContent = new System.Windows.Forms.ListBox();
            this.tabPageRichText = new System.Windows.Forms.TabPage();
            this.textBoxRichTextContent = new System.Windows.Forms.RichTextBox();
            this.checkBoxRichTextWordWrap = new System.Windows.Forms.CheckBox();
            this.tabPagePlainText = new System.Windows.Forms.TabPage();
            this.textBoxPlainTextContent = new System.Windows.Forms.TextBox();
            this.checkBoxPlainTextWordWrap = new System.Windows.Forms.CheckBox();
            this.tabPageHexData = new System.Windows.Forms.TabPage();
            this.textBoxHexContents = new System.Windows.Forms.TextBox();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClearContents = new System.Windows.Forms.Button();
            this.buttonRefreshContents = new System.Windows.Forms.Button();
            this.buttonClearClipboard = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip( this.components );
            this.contextMenuNotifyIcon.SuspendLayout();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.splitContainerFormats.Panel1.SuspendLayout();
            this.splitContainerFormats.Panel2.SuspendLayout();
            this.splitContainerFormats.SuspendLayout();
            this.splitContainerViews.Panel1.SuspendLayout();
            this.splitContainerViews.Panel2.SuspendLayout();
            this.splitContainerViews.SuspendLayout();
            this.panelControlViews.SuspendLayout();
            this.tabControlViews.SuspendLayout();
            this.tabPageXml.SuspendLayout();
            this.tabPageImage.SuspendLayout();
            this.panelImageBackground.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.pictureBoxImageContent ) ).BeginInit();
            this.tabPageListText.SuspendLayout();
            this.tabPageRichText.SuspendLayout();
            this.tabPagePlainText.SuspendLayout();
            this.tabPageHexData.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuNotifyIcon;
            this.notifyIcon.Icon = ( (System.Drawing.Icon)( resources.GetObject( "notifyIcon.Icon" ) ) );
            this.notifyIcon.Text = "Clipboard Viewer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler( this.notifyIcon_DoubleClick );
            // 
            // contextMenuNotifyIcon
            // 
            this.contextMenuNotifyIcon.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.showClipboardViewerAndRefreshToolStripMenuItem,
            this.showClipboardViewerToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem} );
            this.contextMenuNotifyIcon.Name = "contextMenuNotifyIcon";
            this.contextMenuNotifyIcon.Size = new System.Drawing.Size( 284, 76 );
            // 
            // showClipboardViewerAndRefreshToolStripMenuItem
            // 
            this.showClipboardViewerAndRefreshToolStripMenuItem.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.showClipboardViewerAndRefreshToolStripMenuItem.Name = "showClipboardViewerAndRefreshToolStripMenuItem";
            this.showClipboardViewerAndRefreshToolStripMenuItem.Size = new System.Drawing.Size( 283, 22 );
            this.showClipboardViewerAndRefreshToolStripMenuItem.Text = "Show Clipboard Viewer and Refresh";
            this.showClipboardViewerAndRefreshToolStripMenuItem.Click += new System.EventHandler( this.showClipboardViewerAndRefreshToolStripMenuItem_Click );
            // 
            // showClipboardViewerToolStripMenuItem1
            // 
            this.showClipboardViewerToolStripMenuItem1.Name = "showClipboardViewerToolStripMenuItem1";
            this.showClipboardViewerToolStripMenuItem1.Size = new System.Drawing.Size( 283, 22 );
            this.showClipboardViewerToolStripMenuItem1.Text = "&Show Clipboard Viewer";
            this.showClipboardViewerToolStripMenuItem1.Click += new System.EventHandler( this.showClipboardViewerToolStripMenuItem_Click );
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size( 280, 6 );
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 283, 22 );
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.splitMain.Location = new System.Drawing.Point( 8, 8 );
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add( this.splitContainerFormats );
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add( this.splitContainerViews );
            this.splitMain.Size = new System.Drawing.Size( 863, 439 );
            this.splitMain.SplitterDistance = 287;
            this.splitMain.TabIndex = 5;
            // 
            // splitContainerFormats
            // 
            this.splitContainerFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFormats.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerFormats.Location = new System.Drawing.Point( 0, 0 );
            this.splitContainerFormats.Name = "splitContainerFormats";
            this.splitContainerFormats.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFormats.Panel1
            // 
            this.splitContainerFormats.Panel1.Controls.Add( this.listFormats );
            this.splitContainerFormats.Panel1.Controls.Add( this.labelFormats );
            // 
            // splitContainerFormats.Panel2
            // 
            this.splitContainerFormats.Panel2.Controls.Add( this.textBoxNullFormats );
            this.splitContainerFormats.Panel2.Controls.Add( this.labelNullFormats );
            this.splitContainerFormats.Size = new System.Drawing.Size( 287, 439 );
            this.splitContainerFormats.SplitterDistance = 291;
            this.splitContainerFormats.TabIndex = 2;
            // 
            // listFormats
            // 
            this.listFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFormats.FormattingEnabled = true;
            this.listFormats.IntegralHeight = false;
            this.listFormats.Location = new System.Drawing.Point( 0, 16 );
            this.listFormats.Name = "listFormats";
            this.listFormats.Size = new System.Drawing.Size( 287, 275 );
            this.listFormats.TabIndex = 3;
            this.listFormats.SelectedIndexChanged += new System.EventHandler( this.listFormats_SelectedIndexChanged );
            // 
            // labelFormats
            // 
            this.labelFormats.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFormats.Location = new System.Drawing.Point( 0, 0 );
            this.labelFormats.Name = "labelFormats";
            this.labelFormats.Size = new System.Drawing.Size( 287, 16 );
            this.labelFormats.TabIndex = 2;
            this.labelFormats.Text = "&Formats";
            this.toolTip.SetToolTip( this.labelFormats, "Formats provided by clipboard\'s current IDataObject." );
            // 
            // textBoxNullFormats
            // 
            this.textBoxNullFormats.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNullFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNullFormats.Font = new System.Drawing.Font( "Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.textBoxNullFormats.Location = new System.Drawing.Point( 0, 16 );
            this.textBoxNullFormats.Multiline = true;
            this.textBoxNullFormats.Name = "textBoxNullFormats";
            this.textBoxNullFormats.ReadOnly = true;
            this.textBoxNullFormats.Size = new System.Drawing.Size( 287, 128 );
            this.textBoxNullFormats.TabIndex = 7;
            this.textBoxNullFormats.WordWrap = false;
            // 
            // labelNullFormats
            // 
            this.labelNullFormats.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNullFormats.Location = new System.Drawing.Point( 0, 0 );
            this.labelNullFormats.Name = "labelNullFormats";
            this.labelNullFormats.Size = new System.Drawing.Size( 287, 16 );
            this.labelNullFormats.TabIndex = 4;
            this.labelNullFormats.Text = "&Null Formats (contains no data)";
            this.toolTip.SetToolTip( this.labelNullFormats, "These formats returned null values." );
            // 
            // splitContainerViews
            // 
            this.splitContainerViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerViews.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerViews.IsSplitterFixed = true;
            this.splitContainerViews.Location = new System.Drawing.Point( 0, 0 );
            this.splitContainerViews.Name = "splitContainerViews";
            this.splitContainerViews.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerViews.Panel1
            // 
            this.splitContainerViews.Panel1.Controls.Add( this.labelFormatContents );
            this.splitContainerViews.Panel1.Controls.Add( this.textBoxDataObjectType );
            this.splitContainerViews.Panel1.Controls.Add( this.labelDataObjectType );
            // 
            // splitContainerViews.Panel2
            // 
            this.splitContainerViews.Panel2.Controls.Add( this.panelControlViews );
            this.splitContainerViews.Size = new System.Drawing.Size( 572, 439 );
            this.splitContainerViews.SplitterDistance = 46;
            this.splitContainerViews.TabIndex = 7;
            // 
            // labelFormatContents
            // 
            this.labelFormatContents.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFormatContents.Location = new System.Drawing.Point( 0, 0 );
            this.labelFormatContents.Name = "labelFormatContents";
            this.labelFormatContents.Size = new System.Drawing.Size( 572, 16 );
            this.labelFormatContents.TabIndex = 10;
            this.labelFormatContents.Text = "F&ormat Contents";
            // 
            // textBoxDataObjectType
            // 
            this.textBoxDataObjectType.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxDataObjectType.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDataObjectType.Location = new System.Drawing.Point( 40, 20 );
            this.textBoxDataObjectType.Name = "textBoxDataObjectType";
            this.textBoxDataObjectType.ReadOnly = true;
            this.textBoxDataObjectType.Size = new System.Drawing.Size( 532, 20 );
            this.textBoxDataObjectType.TabIndex = 5;
            // 
            // labelDataObjectType
            // 
            this.labelDataObjectType.AutoSize = true;
            this.labelDataObjectType.Location = new System.Drawing.Point( 0, 24 );
            this.labelDataObjectType.Name = "labelDataObjectType";
            this.labelDataObjectType.Size = new System.Drawing.Size( 34, 13 );
            this.labelDataObjectType.TabIndex = 4;
            this.labelDataObjectType.Text = "&Type:";
            // 
            // panelControlViews
            // 
            this.panelControlViews.Controls.Add( this.tabControlViews );
            this.panelControlViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlViews.Location = new System.Drawing.Point( 0, 0 );
            this.panelControlViews.Name = "panelControlViews";
            this.panelControlViews.Size = new System.Drawing.Size( 572, 389 );
            this.panelControlViews.TabIndex = 8;
            // 
            // tabControlViews
            // 
            this.tabControlViews.Controls.Add( this.tabPageXml );
            this.tabControlViews.Controls.Add( this.tabPageImage );
            this.tabControlViews.Controls.Add( this.tabPageListText );
            this.tabControlViews.Controls.Add( this.tabPageRichText );
            this.tabControlViews.Controls.Add( this.tabPagePlainText );
            this.tabControlViews.Controls.Add( this.tabPageHexData );
            this.tabControlViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlViews.Location = new System.Drawing.Point( 0, 0 );
            this.tabControlViews.Name = "tabControlViews";
            this.tabControlViews.SelectedIndex = 0;
            this.tabControlViews.Size = new System.Drawing.Size( 572, 389 );
            this.tabControlViews.TabIndex = 5;
            // 
            // tabPageXml
            // 
            this.tabPageXml.Controls.Add( this.textBoxXmlContent );
            this.tabPageXml.Controls.Add( this.checkBoxXmlWrapAttributes );
            this.tabPageXml.Controls.Add( this.checkBoxXmlWordWrap );
            this.tabPageXml.Location = new System.Drawing.Point( 4, 22 );
            this.tabPageXml.Name = "tabPageXml";
            this.tabPageXml.Size = new System.Drawing.Size( 564, 363 );
            this.tabPageXml.TabIndex = 5;
            this.tabPageXml.Text = "Xml";
            this.tabPageXml.UseVisualStyleBackColor = true;
            // 
            // checkBoxXmlWrapAttributes
            // 
            this.checkBoxXmlWrapAttributes.AutoSize = true;
            this.checkBoxXmlWrapAttributes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxXmlWrapAttributes.Location = new System.Drawing.Point( 0, 329 );
            this.checkBoxXmlWrapAttributes.Name = "checkBoxXmlWrapAttributes";
            this.checkBoxXmlWrapAttributes.Size = new System.Drawing.Size( 564, 17 );
            this.checkBoxXmlWrapAttributes.TabIndex = 8;
            this.checkBoxXmlWrapAttributes.Text = "Place &attributes on new line";
            this.checkBoxXmlWrapAttributes.UseVisualStyleBackColor = true;
            this.checkBoxXmlWrapAttributes.CheckedChanged += new System.EventHandler( this.checkBoxXmlWrapAttributes_CheckedChanged );
            // 
            // textBoxXmlContent
            // 
            this.textBoxXmlContent.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxXmlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxXmlContent.Font = new System.Drawing.Font( "Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.textBoxXmlContent.Location = new System.Drawing.Point( 0, 0 );
            this.textBoxXmlContent.Multiline = true;
            this.textBoxXmlContent.Name = "textBoxXmlContent";
            this.textBoxXmlContent.ReadOnly = true;
            this.textBoxXmlContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxXmlContent.Size = new System.Drawing.Size( 564, 329 );
            this.textBoxXmlContent.TabIndex = 6;
            this.textBoxXmlContent.WordWrap = false;
            // 
            // checkBoxXmlWordWrap
            // 
            this.checkBoxXmlWordWrap.AutoSize = true;
            this.checkBoxXmlWordWrap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxXmlWordWrap.Location = new System.Drawing.Point( 0, 346 );
            this.checkBoxXmlWordWrap.Name = "checkBoxXmlWordWrap";
            this.checkBoxXmlWordWrap.Size = new System.Drawing.Size( 564, 17 );
            this.checkBoxXmlWordWrap.TabIndex = 7;
            this.checkBoxXmlWordWrap.Text = "&Word wrap";
            this.checkBoxXmlWordWrap.UseVisualStyleBackColor = true;
            this.checkBoxXmlWordWrap.CheckedChanged += new System.EventHandler( this.checkBoxXmlWordWrap_CheckedChanged );
            // 
            // tabPageImage
            // 
            this.tabPageImage.Controls.Add( this.panelImageBackground );
            this.tabPageImage.Location = new System.Drawing.Point( 4, 22 );
            this.tabPageImage.Name = "tabPageImage";
            this.tabPageImage.Size = new System.Drawing.Size( 564, 363 );
            this.tabPageImage.TabIndex = 2;
            this.tabPageImage.Text = "Image";
            this.tabPageImage.UseVisualStyleBackColor = true;
            // 
            // panelImageBackground
            // 
            this.panelImageBackground.Controls.Add( this.pictureBoxImageContent );
            this.panelImageBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageBackground.Location = new System.Drawing.Point( 0, 0 );
            this.panelImageBackground.Name = "panelImageBackground";
            this.panelImageBackground.Size = new System.Drawing.Size( 564, 363 );
            this.panelImageBackground.TabIndex = 3;
            this.panelImageBackground.Paint += new System.Windows.Forms.PaintEventHandler( this.panelImageBackground_Paint );
            // 
            // pictureBoxImageContent
            // 
            this.pictureBoxImageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImageContent.Location = new System.Drawing.Point( 0, 0 );
            this.pictureBoxImageContent.Name = "pictureBoxImageContent";
            this.pictureBoxImageContent.Size = new System.Drawing.Size( 564, 363 );
            this.pictureBoxImageContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageContent.TabIndex = 3;
            this.pictureBoxImageContent.TabStop = false;
            // 
            // tabPageListText
            // 
            this.tabPageListText.Controls.Add( this.listBoxListTextContent );
            this.tabPageListText.Location = new System.Drawing.Point( 4, 22 );
            this.tabPageListText.Name = "tabPageListText";
            this.tabPageListText.Size = new System.Drawing.Size( 564, 363 );
            this.tabPageListText.TabIndex = 6;
            this.tabPageListText.Text = "List Text";
            this.tabPageListText.UseVisualStyleBackColor = true;
            // 
            // listBoxListTextContent
            // 
            this.listBoxListTextContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxListTextContent.FormattingEnabled = true;
            this.listBoxListTextContent.HorizontalScrollbar = true;
            this.listBoxListTextContent.IntegralHeight = false;
            this.listBoxListTextContent.Location = new System.Drawing.Point( 0, 0 );
            this.listBoxListTextContent.Name = "listBoxListTextContent";
            this.listBoxListTextContent.ScrollAlwaysVisible = true;
            this.listBoxListTextContent.Size = new System.Drawing.Size( 564, 363 );
            this.listBoxListTextContent.TabIndex = 4;
            // 
            // tabPageRichText
            // 
            this.tabPageRichText.Controls.Add( this.textBoxRichTextContent );
            this.tabPageRichText.Controls.Add( this.checkBoxRichTextWordWrap );
            this.tabPageRichText.Location = new System.Drawing.Point( 4, 22 );
            this.tabPageRichText.Name = "tabPageRichText";
            this.tabPageRichText.Size = new System.Drawing.Size( 564, 363 );
            this.tabPageRichText.TabIndex = 3;
            this.tabPageRichText.Text = "Rich Text";
            this.tabPageRichText.UseVisualStyleBackColor = true;
            // 
            // textBoxRichTextContent
            // 
            this.textBoxRichTextContent.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRichTextContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRichTextContent.Location = new System.Drawing.Point( 0, 0 );
            this.textBoxRichTextContent.Name = "textBoxRichTextContent";
            this.textBoxRichTextContent.ReadOnly = true;
            this.textBoxRichTextContent.Size = new System.Drawing.Size( 564, 346 );
            this.textBoxRichTextContent.TabIndex = 10;
            this.textBoxRichTextContent.Text = "";
            this.textBoxRichTextContent.WordWrap = false;
            // 
            // checkBoxRichTextWordWrap
            // 
            this.checkBoxRichTextWordWrap.AutoSize = true;
            this.checkBoxRichTextWordWrap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxRichTextWordWrap.Location = new System.Drawing.Point( 0, 346 );
            this.checkBoxRichTextWordWrap.Name = "checkBoxRichTextWordWrap";
            this.checkBoxRichTextWordWrap.Size = new System.Drawing.Size( 564, 17 );
            this.checkBoxRichTextWordWrap.TabIndex = 9;
            this.checkBoxRichTextWordWrap.Text = "&Word wrap";
            this.checkBoxRichTextWordWrap.UseVisualStyleBackColor = true;
            this.checkBoxRichTextWordWrap.CheckedChanged += new System.EventHandler( this.checkBoxRichTextWordWrap_CheckedChanged );
            // 
            // tabPagePlainText
            // 
            this.tabPagePlainText.Controls.Add( this.textBoxPlainTextContent );
            this.tabPagePlainText.Controls.Add( this.checkBoxPlainTextWordWrap );
            this.tabPagePlainText.Location = new System.Drawing.Point( 4, 22 );
            this.tabPagePlainText.Name = "tabPagePlainText";
            this.tabPagePlainText.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPagePlainText.Size = new System.Drawing.Size( 564, 363 );
            this.tabPagePlainText.TabIndex = 0;
            this.tabPagePlainText.Text = "Plain Text";
            this.tabPagePlainText.UseVisualStyleBackColor = true;
            // 
            // textBoxPlainTextContent
            // 
            this.textBoxPlainTextContent.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPlainTextContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPlainTextContent.Font = new System.Drawing.Font( "Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.textBoxPlainTextContent.Location = new System.Drawing.Point( 3, 3 );
            this.textBoxPlainTextContent.Multiline = true;
            this.textBoxPlainTextContent.Name = "textBoxPlainTextContent";
            this.textBoxPlainTextContent.ReadOnly = true;
            this.textBoxPlainTextContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPlainTextContent.Size = new System.Drawing.Size( 558, 340 );
            this.textBoxPlainTextContent.TabIndex = 4;
            this.textBoxPlainTextContent.WordWrap = false;
            // 
            // checkBoxPlainTextWordWrap
            // 
            this.checkBoxPlainTextWordWrap.AutoSize = true;
            this.checkBoxPlainTextWordWrap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxPlainTextWordWrap.Location = new System.Drawing.Point( 3, 343 );
            this.checkBoxPlainTextWordWrap.Name = "checkBoxPlainTextWordWrap";
            this.checkBoxPlainTextWordWrap.Size = new System.Drawing.Size( 558, 17 );
            this.checkBoxPlainTextWordWrap.TabIndex = 5;
            this.checkBoxPlainTextWordWrap.Text = "&Word wrap";
            this.checkBoxPlainTextWordWrap.UseVisualStyleBackColor = true;
            this.checkBoxPlainTextWordWrap.CheckedChanged += new System.EventHandler( this.checkBoxPlainTextWordWrap_CheckedChanged );
            // 
            // tabPageHexData
            // 
            this.tabPageHexData.Controls.Add( this.textBoxHexContents );
            this.tabPageHexData.Location = new System.Drawing.Point( 4, 22 );
            this.tabPageHexData.Name = "tabPageHexData";
            this.tabPageHexData.Size = new System.Drawing.Size( 564, 363 );
            this.tabPageHexData.TabIndex = 1;
            this.tabPageHexData.Text = "Hex Data";
            this.tabPageHexData.UseVisualStyleBackColor = true;
            // 
            // textBoxHexContents
            // 
            this.textBoxHexContents.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHexContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHexContents.Font = new System.Drawing.Font( "Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.textBoxHexContents.Location = new System.Drawing.Point( 0, 0 );
            this.textBoxHexContents.Multiline = true;
            this.textBoxHexContents.Name = "textBoxHexContents";
            this.textBoxHexContents.ReadOnly = true;
            this.textBoxHexContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxHexContents.Size = new System.Drawing.Size( 564, 363 );
            this.textBoxHexContents.TabIndex = 5;
            this.textBoxHexContents.WordWrap = false;
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHide.Location = new System.Drawing.Point( 768, 452 );
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size( 104, 32 );
            this.buttonHide.TabIndex = 6;
            this.buttonHide.Text = "&Hide";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler( this.buttonClose_Click );
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonExit.Location = new System.Drawing.Point( 656, 452 );
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size( 104, 32 );
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler( this.buttonExit_Click );
            // 
            // buttonClearContents
            // 
            this.buttonClearContents.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.buttonClearContents.Location = new System.Drawing.Point( 136, 452 );
            this.buttonClearContents.Name = "buttonClearContents";
            this.buttonClearContents.Size = new System.Drawing.Size( 124, 32 );
            this.buttonClearContents.TabIndex = 6;
            this.buttonClearContents.Text = "Clea&r Contents";
            this.buttonClearContents.UseVisualStyleBackColor = true;
            this.buttonClearContents.Click += new System.EventHandler( this.buttonClearContents_Click );
            // 
            // buttonRefreshContents
            // 
            this.buttonRefreshContents.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.buttonRefreshContents.Location = new System.Drawing.Point( 8, 452 );
            this.buttonRefreshContents.Name = "buttonRefreshContents";
            this.buttonRefreshContents.Size = new System.Drawing.Size( 124, 32 );
            this.buttonRefreshContents.TabIndex = 6;
            this.buttonRefreshContents.Text = "&Refresh Contents";
            this.buttonRefreshContents.UseVisualStyleBackColor = true;
            this.buttonRefreshContents.Click += new System.EventHandler( this.buttonRefreshContents_Click );
            // 
            // buttonClearClipboard
            // 
            this.buttonClearClipboard.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.buttonClearClipboard.Location = new System.Drawing.Point( 272, 452 );
            this.buttonClearClipboard.Name = "buttonClearClipboard";
            this.buttonClearClipboard.Size = new System.Drawing.Size( 124, 32 );
            this.buttonClearClipboard.TabIndex = 6;
            this.buttonClearClipboard.Text = "Clea&r Clipboard";
            this.buttonClearClipboard.UseVisualStyleBackColor = true;
            this.buttonClearClipboard.Click += new System.EventHandler( this.buttonClearClipboard_Click );
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonHide;
            this.ClientSize = new System.Drawing.Size( 876, 500 );
            this.Controls.Add( this.buttonExit );
            this.Controls.Add( this.buttonHide );
            this.Controls.Add( this.buttonRefreshContents );
            this.Controls.Add( this.buttonClearContents );
            this.Controls.Add( this.splitMain );
            this.Controls.Add( this.buttonClearClipboard );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.MinimumSize = new System.Drawing.Size( 640, 480 );
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipboard Viewer";
            this.contextMenuNotifyIcon.ResumeLayout( false );
            this.splitMain.Panel1.ResumeLayout( false );
            this.splitMain.Panel2.ResumeLayout( false );
            this.splitMain.ResumeLayout( false );
            this.splitContainerFormats.Panel1.ResumeLayout( false );
            this.splitContainerFormats.Panel2.ResumeLayout( false );
            this.splitContainerFormats.Panel2.PerformLayout();
            this.splitContainerFormats.ResumeLayout( false );
            this.splitContainerViews.Panel1.ResumeLayout( false );
            this.splitContainerViews.Panel1.PerformLayout();
            this.splitContainerViews.Panel2.ResumeLayout( false );
            this.splitContainerViews.ResumeLayout( false );
            this.panelControlViews.ResumeLayout( false );
            this.tabControlViews.ResumeLayout( false );
            this.tabPageXml.ResumeLayout( false );
            this.tabPageXml.PerformLayout();
            this.tabPageImage.ResumeLayout( false );
            this.panelImageBackground.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.pictureBoxImageContent ) ).EndInit();
            this.tabPageListText.ResumeLayout( false );
            this.tabPageRichText.ResumeLayout( false );
            this.tabPageRichText.PerformLayout();
            this.tabPagePlainText.ResumeLayout( false );
            this.tabPagePlainText.PerformLayout();
            this.tabPageHexData.ResumeLayout( false );
            this.tabPageHexData.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem showClipboardViewerAndRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonClearContents;
        private System.Windows.Forms.Button buttonRefreshContents;
        private System.Windows.Forms.ToolStripMenuItem showClipboardViewerToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainerFormats;
        private System.Windows.Forms.ListBox listFormats;
        private System.Windows.Forms.Label labelFormats;
        private System.Windows.Forms.TextBox textBoxNullFormats;
        private System.Windows.Forms.Label labelNullFormats;
        private System.Windows.Forms.SplitContainer splitContainerViews;
        private System.Windows.Forms.TabControl tabControlViews;
        private System.Windows.Forms.TabPage tabPageXml;
        private System.Windows.Forms.TextBox textBoxXmlContent;
        private System.Windows.Forms.CheckBox checkBoxXmlWordWrap;
        private System.Windows.Forms.TabPage tabPageImage;
        private System.Windows.Forms.TabPage tabPageRichText;
        private System.Windows.Forms.RichTextBox textBoxRichTextContent;
        private System.Windows.Forms.CheckBox checkBoxRichTextWordWrap;
        private System.Windows.Forms.TabPage tabPagePlainText;
        private System.Windows.Forms.TextBox textBoxPlainTextContent;
        private System.Windows.Forms.CheckBox checkBoxPlainTextWordWrap;
        private System.Windows.Forms.TabPage tabPageHexData;
        private System.Windows.Forms.TextBox textBoxHexContents;
        private System.Windows.Forms.TextBox textBoxDataObjectType;
        private System.Windows.Forms.Label labelDataObjectType;
        private System.Windows.Forms.Label labelFormatContents;
        private System.Windows.Forms.Panel panelControlViews;
        private System.Windows.Forms.Button buttonClearClipboard;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabPageListText;
        private System.Windows.Forms.ListBox listBoxListTextContent;
        private System.Windows.Forms.CheckBox checkBoxXmlWrapAttributes;
        private System.Windows.Forms.Panel panelImageBackground;
        private System.Windows.Forms.PictureBox pictureBoxImageContent;
    }
}

