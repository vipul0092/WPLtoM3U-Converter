using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPLtoM3U_Converter
{
    public partial class libfrmUpEventArgs : EventArgs
    {
        //Properties to be passed along with the event
        string libPath;
        bool ifLibPath;

        public libfrmUpEventArgs(string lib, bool ifLib)
        {
            this.libPath = lib;
            this.ifLibPath = ifLib;
        }

        public bool _ifLibPath
        {
            get
            {
                return ifLibPath;
            }
        }

        public string _libPath
        {
            get
            {
                return libPath;
            }
        }
    }
}
