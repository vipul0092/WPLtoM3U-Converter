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
    public partial class libFolderSelect : Form
    {
        public libFolderSelect()
        {
            InitializeComponent();
        }

        //The Delegate to be used to pass the data to the Main Form
        public delegate void libfrmUpHandler(object sender, libfrmUpEventArgs e);

        //Declaring the event to be raised when the editing is done...
        public event libfrmUpHandler libfrmUpdated;

        public string libPath = "None";
        public bool iflib = false;
        
        private void libFolButton_Click(object sender, EventArgs e)
        {
            DialogResult result = libFolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                libPath = libFolderBrowserDialog.SelectedPath;
                label3.Text = "";
                label3.Text += libPath;
                iflib = false;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (libPath.CompareTo("None") != 0)
            {
                libfrmUpEventArgs props = new libfrmUpEventArgs(libPath, iflib);

                libfrmUpdated(this, props);
                this.Close();
            }
            else
            {
                iflib = true;
                libfrmUpEventArgs props = new libfrmUpEventArgs(libPath, iflib);

                libfrmUpdated(this, props);
                MessageBox.Show("You have chosen not to select a library folder.\nThe converted playlist might not work!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have chosen not to select a library folder.\nThe converted playlist might not work!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
