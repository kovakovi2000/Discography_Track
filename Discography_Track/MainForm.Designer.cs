namespace Discography_Track
{
    partial class MainForm
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
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.btn_addurl = new System.Windows.Forms.Button();
            this.llbl_yt = new System.Windows.Forms.LinkLabel();
            this.btn_editselected = new System.Windows.Forms.Button();
            this.pb_albumpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musiclist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_albumpic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adddisgra
            // 
            this.btn_adddisgra.Location = new System.Drawing.Point(386, 235);
            this.btn_adddisgra.Name = "btn_adddisgra";
            this.btn_adddisgra.Size = new System.Drawing.Size(107, 49);
            this.btn_adddisgra.TabIndex = 0;
            this.btn_adddisgra.Text = "Add Discography";
            this.btn_adddisgra.UseVisualStyleBackColor = true;
            this.btn_adddisgra.Click += new System.EventHandler(this.btn_adddisgra_Click);
            // 
            // cb_artist
            // 
            this.cb_artist.FormattingEnabled = true;
            this.cb_artist.Location = new System.Drawing.Point(12, 33);
            this.cb_artist.Name = "cb_artist";
            this.cb_artist.Size = new System.Drawing.Size(121, 21);
            this.cb_artist.TabIndex = 1;
            this.cb_artist.SelectedIndexChanged += new System.EventHandler(this.cb_artist_SelectedIndexChanged);
            // 
            // cb_album
            // 
            this.cb_album.Enabled = false;
            this.cb_album.FormattingEnabled = true;
            this.cb_album.Location = new System.Drawing.Point(167, 33);
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
            this.Length,
            this.url,
            this.id});
            this.dgv_musiclist.Enabled = false;
            this.dgv_musiclist.Location = new System.Drawing.Point(12, 112);
            this.dgv_musiclist.Name = "dgv_musiclist";
            this.dgv_musiclist.ReadOnly = true;
            this.dgv_musiclist.RowHeadersVisible = false;
            this.dgv_musiclist.Size = new System.Drawing.Size(321, 172);
            this.dgv_musiclist.TabIndex = 3;
            this.dgv_musiclist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_musiclist_CellContentClick);
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
            // url
            // 
            this.url.HeaderText = "url";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // tb_search
            // 
            this.tb_search.Enabled = false;
            this.tb_search.Location = new System.Drawing.Point(12, 86);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(321, 20);
            this.tb_search.TabIndex = 4;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // rtb_info
            // 
            this.rtb_info.Location = new System.Drawing.Point(495, 33);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.ReadOnly = true;
            this.rtb_info.Size = new System.Drawing.Size(224, 96);
            this.rtb_info.TabIndex = 6;
            this.rtb_info.Text = "";
            // 
            // btn_addurl
            // 
            this.btn_addurl.Enabled = false;
            this.btn_addurl.Location = new System.Drawing.Point(499, 235);
            this.btn_addurl.Name = "btn_addurl";
            this.btn_addurl.Size = new System.Drawing.Size(107, 49);
            this.btn_addurl.TabIndex = 7;
            this.btn_addurl.Text = "Add URL";
            this.btn_addurl.UseVisualStyleBackColor = true;
            this.btn_addurl.Click += new System.EventHandler(this.btn_addurl_Click);
            // 
            // llbl_yt
            // 
            this.llbl_yt.AutoSize = true;
            this.llbl_yt.Enabled = false;
            this.llbl_yt.Location = new System.Drawing.Point(492, 195);
            this.llbl_yt.Name = "llbl_yt";
            this.llbl_yt.Size = new System.Drawing.Size(38, 13);
            this.llbl_yt.TabIndex = 8;
            this.llbl_yt.TabStop = true;
            this.llbl_yt.Text = "NONE";
            this.llbl_yt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_yt_LinkClicked);
            // 
            // btn_editselected
            // 
            this.btn_editselected.Enabled = false;
            this.btn_editselected.Location = new System.Drawing.Point(612, 235);
            this.btn_editselected.Name = "btn_editselected";
            this.btn_editselected.Size = new System.Drawing.Size(107, 49);
            this.btn_editselected.TabIndex = 9;
            this.btn_editselected.Text = "Edit Selected";
            this.btn_editselected.UseVisualStyleBackColor = true;
            this.btn_editselected.Click += new System.EventHandler(this.btn_editselected_Click);
            // 
            // pb_albumpic
            // 
            this.pb_albumpic.Location = new System.Drawing.Point(389, 33);
            this.pb_albumpic.Name = "pb_albumpic";
            this.pb_albumpic.Size = new System.Drawing.Size(100, 100);
            this.pb_albumpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_albumpic.TabIndex = 5;
            this.pb_albumpic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "URL (if any):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 299);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editselected);
            this.Controls.Add(this.llbl_yt);
            this.Controls.Add(this.btn_addurl);
            this.Controls.Add(this.rtb_info);
            this.Controls.Add(this.pb_albumpic);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv_musiclist);
            this.Controls.Add(this.cb_album);
            this.Controls.Add(this.cb_artist);
            this.Controls.Add(this.btn_adddisgra);
            this.Name = "MainForm";
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
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox pb_albumpic;
        private System.Windows.Forms.RichTextBox rtb_info;
        private System.Windows.Forms.Button btn_addurl;
        private System.Windows.Forms.LinkLabel llbl_yt;
        private System.Windows.Forms.Button btn_editselected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

