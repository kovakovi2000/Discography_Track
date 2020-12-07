using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discography_Track
{
    public partial class Form1 : Form
    {
        private static SqlConnection conn;
        private List<DataGridViewRow> Rows = new List<DataGridViewRow>();
        private string LocalPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public Form1()
        {
            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
            conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;" +
                @"AttachDbFileName=|DataDirectory|\Res\Pendulum.mdf;" +
                "Trusted_Connection=True;");
            InitializeComponent();
            RefreshArtist();
        }

        private void btn_adddisgra_Click(object sender, EventArgs e)
        {
            AddFromFile(GetFileLocation());
            RefreshArtist();
        }

        private string GetFileLocation()
        {
            var openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = LocalPath,
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Discography files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            return null;
        }

        private void AddFromFile(string filelocation)
        {
            if (filelocation == null)
            {
                MessageBox.Show($"ERROR - No file selected!");
                return;
            }
            var SQLcon = new List<SqlCommand>();
            using (StreamReader sr = new StreamReader(filelocation))
            {
                var IsAlbum = false;
                var IsTrack = false;
                var count = 0;
                while (!sr.EndOfStream)
                {
                    count++;
                    var line = sr.ReadLine();
                    if (RegexTest(line, @"^\[+[a-z]+\]$") && line.Contains("albums"))
                    {
                        IsAlbum = true;
                        IsTrack = false;
                    }

                    else if (RegexTest(line, @"^\[+[a-z]+\]$") && line.Contains("tracks"))
                    {
                        IsAlbum = false;
                        IsTrack = true;
                    }
                    else
                    {
                        if (IsAlbum)
                        {
                            if (!RegexTest(line, @"^pnd[1-9];[A-Za-z0-9öüóőúéáűíÖÜÓŐÚÉÁŰÍ <>=_.:!\?\*\[\]+\-\–,()]{1,255};[A-Za-z0-9öüóőúéáűíÖÜÓŐÚÉÁŰÍ <>=_.:!\?\*\[\]+\-\–,()]{1,255};[0-9]{4,4}-[0-9]{2,2}-[0-9]{2,2}$"))
                            {
                                MessageBox.Show($"ERROR - File contains wrong format on line {count}!");
                                return;
                            }
                            SQLcon.Add(new SqlCommand(ConvertAlbumStringToMSSQL_Insert(line), conn));
                        }
                        else if (IsTrack)
                        {
                            if (!RegexTest(line, @"^[A-Za-z0-9öüóőúéáűíÖÜÓŐÚÉÁŰÍ <>=_.:!\?\*\[\]+\-\–,()]{1,255};[0-9]{1,2}:[0-9]{1,2};pnd[1-9];(null|[a-zA-Z0-9\-_]{1,30})$"))
                            {
                                MessageBox.Show($"ERROR - File contains wrong format on line {count}!");
                                return;
                            }
                            SQLcon.Add(new SqlCommand(ConvertTrackStringToMSSQL_Insert(line), conn));
                        }
                        else
                        {
                            MessageBox.Show($"ERROR - File has no head tag!\n[album] or [track]");
                            return;
                        }
                    }
                }
            }

            conn.Open();
            foreach (var item in SQLcon)
                item.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show($"File successfuly loaded into database!");
        }

        private bool RegexTest(string text, string pattern)
        {
            var regex = new Regex(pattern);
            var match = regex.Match(text);
            return match.Success;
        }

        private string ConvertAlbumStringToMSSQL_Insert(string line)
        {
            string[] split = line.Split(';');
            return $"INSERT INTO albums(id, artist, title, rel) VALUES ('{split[0]}', '{split[1]}', '{split[2]}', '{split[3]}');";
        }
        private string ConvertTrackStringToMSSQL_Insert(string line)
        {
            string[] split = line.Split(';');
            return $"INSERT INTO tracks (tile, lenght, album, url) VALUES ('{split[0]}', '{split[1]}', '{split[2]}', {(split[3] == "null" ? "null" : "\'"+split[3]+"\'")});";
        }

        private void RefreshArtist()
        {
            cb_artist.Items.Clear();
            conn.Open();
            var sql = new SqlCommand("SELECT DISTINCT Artist FROM albums;", conn);
            var r = sql.ExecuteReader();
            while (r.Read()) cb_artist.Items.Add(r[0]);
            conn.Close();
        }

        private void RefreshAlbum()
        {
            cb_album.Items.Clear();
            conn.Open();
            var sql = new SqlCommand($"SELECT title FROM albums WHERE Artist LIKE '{cb_artist.SelectedItem.ToString()}';", conn);
            var r = sql.ExecuteReader();
            while (r.Read()) cb_album.Items.Add(r[0]);
            conn.Close();
        }

        private void cb_artist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_artist.SelectedItem != null)
            {
                cb_album.Enabled = true;
                RefreshAlbum();
            }
            else
                cb_album.Enabled = false;
        }

        private void cb_album_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_musiclist.Rows.Clear();
            dgv_musiclist.Rows.Add("","");
            conn.Open();
            string selectedalbumindex = "";
            DateTime reldate = DateTime.MinValue;
            var sqlgetindex = new SqlCommand($"SELECT id, rel FROM albums WHERE title LIKE '{cb_album.SelectedItem.ToString()}';", conn);
            var read = sqlgetindex.ExecuteReader();
            while (read.Read())
            {
                selectedalbumindex = read[0].ToString();
                reldate = DateTime.Parse(read[1].ToString());
            }
            read.Close();
            var sql = new SqlCommand($"SELECT tile, lenght FROM tracks WHERE album LIKE '{selectedalbumindex}';", conn);
            var r = sql.ExecuteReader();
            Rows.Clear();
            while (r.Read()) 
            {
                DataGridViewRow row = (DataGridViewRow)dgv_musiclist.Rows[0].Clone();
                row.Cells[0].Value = r[0].ToString();
                row.Cells[1].Value = r[1].ToString();
                Rows.Add(row);
            }
            dgv_musiclist.Rows.Clear();
            dgv_musiclist.Rows.AddRange(Rows.ToArray());
            conn.Close();
            if (cb_album.SelectedItem != null)
            {
                tb_search.Enabled = true;
                pb_albumpic.Image = GetImageByName(cb_album.SelectedItem.ToString());
            }
            else
                tb_search.Enabled = false;

            UpdatePicNText(reldate);
        }

        private Image GetImageByName(string name)
        {
            MessageBox.Show(LocalPath);
            return Image.FromFile(LocalPath + @"\imgs\" + name.ToLower().Replace(" ", "_") + ".jpg");
        }

        private void UpdatePicNText(DateTime reldate)
        {
            TimeSpan totaltime = new TimeSpan(0,0,0);
            Rows.ForEach(x => {
                var split = x.Cells[1].Value.ToString().Split(':');
                totaltime += new TimeSpan(0, int.Parse(split[0]), int.Parse(split[1]));
            });
            rtb_info.Text = "Kiadási dátum: " + reldate.ToString("yyyy. MMMM dd.") + "\n" +
                            "Teljes hossz: " + string.Format("{0}:{1:00}", (int)totaltime.TotalMinutes, totaltime.Seconds);
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dgv_musiclist.Rows.Clear();
            dgv_musiclist.Rows.AddRange(Rows.Where(x => x.Cells[0].Value.ToString().ToLower().Contains(tb_search.Text.ToLower())).ToArray());
        }

        private void dgv_musiclist_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow item in dgv_musiclist.Rows)
            {
                var a = item.Cells[1].Value.ToString();
                if (item.Cells[1].Value.ToString() != "")
                    item.Cells[1].Value = item.Cells[1].Value.ToString().Substring(0, 5);
            }
        }
    }
}