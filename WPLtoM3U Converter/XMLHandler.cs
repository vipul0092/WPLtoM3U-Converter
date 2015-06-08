using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace WPLtoM3U_Converter
{
    /// <summary>
    /// Class for handling XML files
    /// </summary>
    public partial class XMLHandler
    {
        XmlDocument playlist;
        bool _failed = false;

        /// <summary>
        /// Whether Loading the XML file failed or not
        /// </summary>
        public bool Failed { get { return _failed; } }

        /// <summary>
        /// Makes an object of the XMLHandler class
        /// </summary>
        /// <param name="file">Path to the XML file</param>
        public XMLHandler(string file)
        {
            playlist = new XmlDocument();
            try
            {
                playlist.Load(file);
            }
            catch
            {
                _failed = true;
            }
        }

        /// <summary>
        /// Extracts data from the XML file; Currently .WPL files supported
        /// </summary>
        /// <returns></returns>
        public List<string> ExtractData()
        {
            XmlNodeList playlistNodes = playlist.GetElementsByTagName("seq");
            XmlNodeList files;
            List<string> fileNames;

            if (playlistNodes.Count > 0)
            {
                files = playlistNodes[0].ChildNodes;
                fileNames = new List<string>();
                for(int i=0; i<files.Count; i++)
                {
                    fileNames.Insert(i, files[i].Attributes["src"].Value);
                }
                return fileNames;
            }
            else return null;
        }
    }
}
