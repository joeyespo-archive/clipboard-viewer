using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace ClipboardViewer
{
    static class Util
    {
        public static string FormatXml( string xml, XmlWriterSettings writerSettings )
        {
            XmlDocument document = new XmlDocument();
            using( StringReader reader = new StringReader( xml ) )
                document.Load( new StringReader( xml ) );
            StringBuilder sb = new StringBuilder();
            using( XmlWriter writer = XmlWriter.Create( sb, writerSettings ) )
                document.Save( writer );
            sb.AppendLine();
            return sb.ToString();
        }
        public static string FormatXml( string xml, bool wrapAttributes )
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.CheckCharacters = false;
            settings.CloseOutput = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.Indent = true;
            settings.NewLineChars = Environment.NewLine;
            settings.NewLineHandling = NewLineHandling.Replace;
            settings.NewLineOnAttributes = wrapAttributes;
            return FormatXml( xml, settings );
        }
        public static string FormatXml( string xml )
        {
            return FormatXml( xml, false );
        }

        public static bool IsValidXml( string xml )
        {
            XmlDocument document = new XmlDocument();
            using( StringReader reader = new StringReader( xml ) )
            {
                try
                {
                    document.Load( new StringReader( xml ) );
                    return true;
                }
                catch( XmlException )
                {
                    return false;
                }
            }
        }
    }
}
