using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPLtoM3U_Converter
{
    /// <summary>
    /// Class containing Miscellaneous Utility Methods
    /// </summary>
    public partial class MiscUtility
    {
        /// <summary>
        /// Returns Folder Name from the passed full path of a file
        /// </summary>
        /// <param name="path">Path of a file</param>
        /// <returns></returns>
        public static string GetFolderFromPath(string path)
        {   return path.Substring(0, path.LastIndexOf("\\") + 1); }

        /// <summary>
        /// Returns File Name from the full path of the file with file extension
        /// </summary>
        /// <param name="path">Full path of the file</param>
        /// <returns></returns>
        public static string GetFilenameFromPath(string path)
        { return path.Substring(path.LastIndexOf("\\") + 1, path.Length - path.LastIndexOf("\\") - 1); }

        /// <summary>
        /// Returns File Name from the full path without the file extension
        /// </summary>
        /// <param name="path">Full path of the file</param>
        /// <returns></returns>
        public static string GetFilenameFromPathWOE(string path)
        {  return path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - path.LastIndexOf("\\")-1);  }
    }
}
