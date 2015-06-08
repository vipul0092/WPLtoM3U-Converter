using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPLtoM3U_Converter
{
    public partial class sfrmUpEventArgs : EventArgs
    {
        Playlist playlist;

        public Playlist Playlist{get{return playlist;}}
        public sfrmUpEventArgs(Playlist p)
        {
            playlist = p;
        }
    }
}
