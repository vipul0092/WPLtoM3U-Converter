using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WPLtoM3U_Converter
{
    /// <summary>
    /// Class to model a playlist
    /// </summary>
    public partial class Playlist
    {
        #region Private Members
        int nfiles;
        string wplFile;
        string folder;
        string playlistName;
        string referralFolder="";
        List<string> files;
        List<string> fileNames;
        bool libraryReferralNeeded = false;
        bool valid;
        XMLHandler xml;
        #endregion

        #region Public Members

        /// <summary>
        /// Returns whether the playlist is valid or not
        /// </summary>
        public bool Valid { get { return valid; } }

        /// <summary>
        /// The Referral Folder for the files in the playlist
        /// </summary>
        public string ReferralFolder { get { return referralFolder; } set { referralFolder = value; } }

        /// <summary>
        /// Returns whether the playlist requires a Folder Referral
        /// </summary>
        public bool LibraryReferralRequired { get { return libraryReferralNeeded; } }

        /// <summary>
        /// Name of the Playlist
        /// </summary>
        public string PlaylistName { get { return playlistName; } }

        /// <summary>
        /// No. Of Files in the playlist
        /// </summary>
        public int NoOfFiles { get { return files.Count; } }

        /// <summary>
        /// Folder in which the playlist resides
        /// </summary>
        public string PlaylistFolder { get { return folder; } }

        /// <summary>
        /// File Names of the songs in the playlist
        /// </summary>
        public List<string> FileNames { get { return fileNames; } }

        /// <summary>
        /// Full files names of the songs in the playlist
        /// </summary>
        public List<string> Files { get { return files; } }

        #endregion

        /// <summary>
        /// Makes an object of the Playlist class
        /// </summary>
        /// <param name="file">Path to the playlist</param>
        public Playlist(string file)
        {
            wplFile = file;
            xml = new XMLHandler(wplFile);
            valid = !xml.Failed;

            if(valid == true)
            {
                files=xml.ExtractData();
                nfiles = files.Count;
                PopulatePlaylist();
            }

        }

        #region Public Methods
        /// <summary>
        /// Saves current playlist as .M3U
        /// </summary>
        /// <param name="savePath">Path where the playlist should be saved</param>
        /// <param name="defFolder">values other than zero means file will be saved in the same folder as the playlist</param>
        /// <returns></returns>
        public bool SavePlaylistAsM3U(string savePath, int defFolder=0)
        {
            bool retval = true;
            if (defFolder != 0)
            {
                savePath = folder + playlistName + ".m3u";
            }
                try
                {
                    using(StreamWriter writer = new StreamWriter(savePath))
                    {
                        for(int i=0; i<files.Count; i++)
                        {
                            if(referralFolder == "")
                            {
                                writer.WriteLine(files[i]);
                            }
                            else
                            {
                                writer.WriteLine(referralFolder + files[i].Substring(2, files[i].Length - 2));
                            }
                        }
                    }
                }
                catch
                {
                    retval = false;
                }

            return retval;
        }

        /// <summary>
        /// Exchanges songs at the passed positions
        /// </summary>
        /// <param name="index1">Position of the first song</param>
        /// <param name="index2">Position of the second song</param>
        public void ExchangeSongs(int index1, int index2)
        {
            string t1;
            t1 = files[index1]; files[index1] = files[index2]; files[index2] = t1;
            t1 = fileNames[index1]; fileNames[index1] = fileNames[index2]; fileNames[index2] = t1;
        }

        /// <summary>
        /// Deletes a song at a position
        /// </summary>
        /// <param name="index">Position of the song to be deleted</param>
        public void DeleteSong(int index)
        { files.RemoveAt(index); fileNames.RemoveAt(index); nfiles--; }

        /// <summary>
        /// Adds the song to the end or at a position in the playlist
        /// </summary>
        /// <param name="fileName">Full path of the song to be added</param>
        /// <param name="index">Position at which the song is to be added; -1 means add to the end</param>
        public void AddSong(string fileName, int index=-1)
        {
            if(index==-1)
            {  files.Add(fileName); fileNames.Add(MiscUtility.GetFilenameFromPath(fileName));  }
            else
            { files.Insert(index, fileName); fileNames.Insert(index, MiscUtility.GetFilenameFromPath(fileName)); }
            nfiles++;
        }

        #endregion

        void PopulatePlaylist()
        {
            fileNames = new List<string>();
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Length < 4) valid = false;
                else
                {
                    if (files[i][0] == '.' && files[i][1] == '.') libraryReferralNeeded = true;
                    fileNames.Insert(i, MiscUtility.GetFilenameFromPath(files[i]));
                }
            }
            folder = MiscUtility.GetFolderFromPath(wplFile);
            playlistName = MiscUtility.GetFilenameFromPathWOE(wplFile);
        }

        void UpdatePlaylistFiles(List<string> files, List<string> fileNames)
        {
            this.files = files;
            this.fileNames = fileNames;
            nfiles = files.Count;
        }



    }
}
