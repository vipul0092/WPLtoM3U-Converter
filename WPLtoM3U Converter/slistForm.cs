using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPLtoM3U_Converter
{
    public partial class slistForm : Form
    {
        
        public slistForm(Playlist playlist)
        {
            InitializeComponent();
            this.playlist = playlist;
        }

        //The Delegate to be used to pass the data to the Main Form
        public delegate void sfrmUpHandler(object sender, sfrmUpEventArgs e);

        //Declaring the event to be raised when the editing is done...
        public event sfrmUpHandler sfrmUpdated;

        Playlist playlist;

        private void slistForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < playlist.NoOfFiles; i++)
            {
                listBox1.Items.Add(playlist.FileNames[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp1;  int index;

                temp1 = listBox1.SelectedItem.ToString();
                index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index - 1, temp1);
                listBox1.SelectedIndex = index - 1;
                playlist.ExchangeSongs(index, index - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string temp1; int index;

                temp1 = listBox1.SelectedItem.ToString();
                index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index + 1, temp1);
                listBox1.SelectedIndex = index + 1;
                playlist.ExchangeSongs(index, index + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index;
            index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                listBox1.Items.RemoveAt(index);
                playlist.DeleteSong(index);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sfrmUpEventArgs props = new sfrmUpEventArgs(playlist);
            sfrmUpdated(this, props);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;


            if (listBox1.SelectedIndex < playlist.NoOfFiles - 1)
                button4.Enabled = true;
            else
                button4.Enabled = false;
        }




    }
}
