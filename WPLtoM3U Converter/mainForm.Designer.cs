namespace WPLtoM3U_Converter
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.openPlaylist = new System.Windows.Forms.Button();
            this.defSave = new System.Windows.Forms.Button();
            this.customSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.songlist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWPL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumSongs = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openPlaylist
            // 
            this.openPlaylist.Location = new System.Drawing.Point(162, 108);
            this.openPlaylist.Name = "openPlaylist";
            this.openPlaylist.Size = new System.Drawing.Size(114, 35);
            this.openPlaylist.TabIndex = 1;
            this.openPlaylist.Text = "Open WPL Playlist";
            this.openPlaylist.UseVisualStyleBackColor = true;
            this.openPlaylist.Click += new System.EventHandler(this.openPlaylist_Click);
            // 
            // defSave
            // 
            this.defSave.Enabled = false;
            this.defSave.Location = new System.Drawing.Point(16, 385);
            this.defSave.Name = "defSave";
            this.defSave.Size = new System.Drawing.Size(92, 42);
            this.defSave.TabIndex = 3;
            this.defSave.Text = "Save Playlist as .m3u";
            this.defSave.UseVisualStyleBackColor = true;
            this.defSave.Click += new System.EventHandler(this.defSave_Click);
            // 
            // customSave
            // 
            this.customSave.Enabled = false;
            this.customSave.Location = new System.Drawing.Point(356, 385);
            this.customSave.Name = "customSave";
            this.customSave.Size = new System.Drawing.Size(92, 42);
            this.customSave.TabIndex = 4;
            this.customSave.Text = "Save Playlist  As...";
            this.customSave.UseVisualStyleBackColor = true;
            this.customSave.Click += new System.EventHandler(this.customSave_Click);
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "This saves the playlist in the same folder as the WPL Playlist.";
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(311, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Click this to save the playlist in your specified location.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(364, 502);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 27);
            this.button4.TabIndex = 8;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckPathExists = false;
            this.openFileDialog1.DefaultExt = "wpl";
            this.openFileDialog1.Filter = "Windows Playlist|*.wpl|All files|*.*";
            this.openFileDialog1.InitialDirectory = "C:";
            this.openFileDialog1.Title = "Open WPL Playlist";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "m3u";
            this.saveFileDialog1.Filter = "M3U Playlist|*.m3u|All files|*.*";
            this.saveFileDialog1.Title = "Save Playlist As...";
            // 
            // songlist
            // 
            this.songlist.Enabled = false;
            this.songlist.Location = new System.Drawing.Point(183, 385);
            this.songlist.Name = "songlist";
            this.songlist.Size = new System.Drawing.Size(103, 42);
            this.songlist.TabIndex = 9;
            this.songlist.Text = "Song List";
            this.songlist.UseVisualStyleBackColor = true;
            this.songlist.Click += new System.EventHandler(this.songlist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WPLtoM3U_Converter.Properties.Resources.plalist;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(183, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Choose Library Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWPL
            // 
            this.labelWPL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWPL.Location = new System.Drawing.Point(16, 191);
            this.labelWPL.Name = "labelWPL";
            this.labelWPL.Size = new System.Drawing.Size(432, 23);
            this.labelWPL.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Selected Playlist:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "No. Of Songs:";
            // 
            // labelNumSongs
            // 
            this.labelNumSongs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNumSongs.Location = new System.Drawing.Point(16, 254);
            this.labelNumSongs.Name = "labelNumSongs";
            this.labelNumSongs.Size = new System.Drawing.Size(432, 23);
            this.labelNumSongs.TabIndex = 15;
            // 
            // labelInfo
            // 
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfo.Location = new System.Drawing.Point(16, 307);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(432, 62);
            this.labelInfo.TabIndex = 16;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 535);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelNumSongs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWPL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.songlist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customSave);
            this.Controls.Add(this.defSave);
            this.Controls.Add(this.openPlaylist);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "WPL To M3U Playlist Converter and Editor";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openPlaylist;
        private System.Windows.Forms.Button defSave;
        private System.Windows.Forms.Button customSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button songlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWPL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumSongs;
        private System.Windows.Forms.Label labelInfo;

    }
}

