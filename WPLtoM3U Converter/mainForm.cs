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
    public partial class mainForm : Form
    {   
        public mainForm()
        {
            InitializeComponent();
            libForm = new libFolderSelect();
        }

        libFolderSelect libForm;
        Playlist playlist;
        bool librarypath = false;
        string openFilePath, saveFilePath, libPath = "None";
        string aboutStr = "WPL to M3U Playlist Converter and Editor 3.0\n\nCoded & Designed By : Vipul Gaur\n(C) Copyright, 2015.";

        private void openPlaylist_Click(object sender, EventArgs e)
        {            
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                playlist = null;
                playlist = new Playlist(openFileDialog1.FileName);

                if (playlist.Valid)
                {
                    labelWPL.Text = openFileDialog1.FileName;
                    labelNumSongs.Text = playlist.NoOfFiles.ToString();

                    if (playlist.LibraryReferralRequired) //if yes, then ask for the Library folder...
                    {
                        libForm.libfrmUpdated += new libFolderSelect.libfrmUpHandler(libForm_libfrmUpdated);
                        libForm.ShowDialog();
                    }

                    if(playlist.NoOfFiles > 0)
                    {
                        defSave.Enabled = customSave.Enabled = songlist.Enabled = true;
                        if (playlist.LibraryReferralRequired) button1.Enabled = true;
                    }

                }
            }
            
        }

        private void defSave_Click(object sender, EventArgs e)
        {
            playlist.SavePlaylistAsM3U("", 1);
            labelInfo.Text = "Conversion Complete. Playlist saved as .m3u";
            defSave.Enabled = false;
            label2.Enabled = false;
        }

        private void customSave_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                playlist.SavePlaylistAsM3U(saveFileDialog1.FileName);
                customSave.Enabled = false;
                label3.Enabled = false;
            }              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aboutStr, "About Playlist Converter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void songlist_Click(object sender, EventArgs e)
        {
            slistForm subform = new slistForm(playlist);
            subform.sfrmUpdated +=new slistForm.sfrmUpHandler(subform_sfrmUpdated);

            subform.ShowDialog();
            customSave.Enabled = true;
            defSave.Enabled = true;

        }

        //The Event Handler method of the main form to deal with the event of the sub form completing...
        private void subform_sfrmUpdated(object sender, sfrmUpEventArgs e)
        {
            this.playlist = e.Playlist;
            labelNumSongs.Text = playlist.NoOfFiles.ToString();
        }

        private void libForm_libfrmUpdated(object sender, libfrmUpEventArgs e)
        {
            this.libPath = e._libPath;
            this.librarypath = e._ifLibPath;

            if (librarypath == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                playlist.ReferralFolder = e._libPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            libForm.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }


    }
}
