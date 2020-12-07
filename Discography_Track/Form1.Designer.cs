namespace Discography_Track
{
    partial class Form1
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
            this.btn_adddisgra = new System.Windows.Forms.Button();
            this.cb_artist = new System.Windows.Forms.ComboBox();
            this.cb_album = new System.Windows.Forms.ComboBox();
            this.dgv_musiclist = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pb_albumpic = new System.Windows.Forms.PictureBox();
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musiclist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_albumpic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adddisgra
            // 
            this.btn_adddisgra.Location = new System.Drawing.Point(479, 374);
            this.btn_adddisgra.Name = "btn_adddisgra";
            this.btn_adddisgra.Size = new System.Drawing.Size(78, 49);
            this.btn_adddisgra.TabIndex = 0;
            this.btn_adddisgra.Text = "Add Discography";
            this.btn_adddisgra.UseVisualStyleBackColor = true;
            this.btn_adddisgra.Click += new System.EventHandler(this.btn_adddisgra_Click);
            // 
            // cb_artist
            // 
            this.cb_artist.FormattingEnabled = true;
            this.cb_artist.Location = new System.Drawing.Point(12, 81);
            this.cb_artist.Name = "cb_artist";
            this.cb_artist.Size = new System.Drawing.Size(121, 21);
            this.cb_artist.TabIndex = 1;
            this.cb_artist.SelectedIndexChanged += new System.EventHandler(this.cb_artist_SelectedIndexChanged);
            // 
            // cb_album
            // 
            this.cb_album.Enabled = false;
            this.cb_album.FormattingEnabled = true;
            this.cb_album.Location = new System.Drawing.Point(167, 81);
            this.cb_album.Name = "cb_album";
            this.cb_album.Size = new System.Drawing.Size(121, 21);
            this.cb_album.TabIndex = 2;
            this.cb_album.SelectedIndexChanged += new System.EventHandler(this.cb_album_SelectedIndexChanged);
            // 
            // dgv_musiclist
            // 
            this.dgv_musiclist.AllowUserToAddRows = false;
            this.dgv_musiclist.AllowUserToDeleteRows = false;
            this.dgv_musiclist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musiclist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Length});
            this.dgv_musiclist.Location = new System.Drawing.Point(12, 177);
            this.dgv_musiclist.Name = "dgv_musiclist";
            this.dgv_musiclist.ReadOnly = true;
            this.dgv_musiclist.RowHeadersVisible = false;
            this.dgv_musiclist.Size = new System.Drawing.Size(321, 172);
            this.dgv_musiclist.TabIndex = 3;
            this.dgv_musiclist.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_musiclist_RowsAdded);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 50;
            // 
            // tb_search
            // 
            this.tb_search.Enabled = false;
            this.tb_search.Location = new System.Drawing.Point(12, 134);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(321, 20);
            this.tb_search.TabIndex = 4;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // pb_albumpic
            // 
            this.pb_albumpic.Location = new System.Drawing.Point(389, 81);
            this.pb_albumpic.Name = "pb_albumpic";
            this.pb_albumpic.Size = new System.Drawing.Size(100, 100);
            this.pb_albumpic.TabIndex = 5;
            this.pb_albumpic.TabStop = false;
            // 
            // rtb_info
            // 
            this.rtb_info.Location = new System.Drawing.Point(495, 81);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.ReadOnly = true;
            this.rtb_info.Size = new System.Drawing.Size(293, 96);
            this.rtb_info.TabIndex = 6;
            this.rtb_info.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_info);
            this.Controls.Add(this.pb_albumpic);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv_musiclist);
            this.Controls.Add(this.cb_album);
            this.Controls.Add(this.cb_artist);
            this.Controls.Add(this.btn_adddisgra);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musiclist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_albumpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adddisgra;
        private System.Windows.Forms.ComboBox cb_artist;
        private System.Windows.Forms.ComboBox cb_album;
        private System.Windows.Forms.DataGridView dgv_musiclist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox pb_albumpic;
        private System.Windows.Forms.RichTextBox rtb_info;
    }
}

