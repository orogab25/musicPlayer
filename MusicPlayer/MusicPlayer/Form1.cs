using CSCore;
using CSCore.Codecs;
using CSCore.Codecs.WAV;
using CSCore.SoundIn;
using CSCore.SoundOut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{ 
    public partial class f_player : Form
    {
        //Form
        public f_player()
        {
            InitializeComponent();
        }

        //Init
        f_playlist playlist = new f_playlist();
        f_options options = new f_options();

        public IWaveSource audio;
        public ISoundOut device;

        public string path, pathPlaylist;
        public int paused, length, db;
        public string[] tracks = new string[10000];
        public string[] files;
        string be;

        //Prepare
        private void f_player_Load(object sender, EventArgs e)
        {
            //Device load
            if (options.cB_Device.SelectedIndex==0)
                device = new DirectSoundOut();
            else
                device = new WasapiOut();

            //Skin color load
            if (options.cB_Skin.SelectedIndex == 0)
                this.BackColor =Color.White;
            else if (options.cB_Skin.SelectedIndex == 1)
                this.BackColor = Color.Yellow;
            else if (options.cB_Skin.SelectedIndex == 2)
                this.BackColor = Color.Red;
            else if (options.cB_Skin.SelectedIndex == 3)
                this.BackColor = Color.Blue;

            paused = 0;
            length = 0;
            db = 0;

            pictureB_image.Load("FreestyleLogo.png");
        }

        //File_Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files (*.mp3, *.flac, *.wav)|*.mp3;*.flac;*.wav";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Adding audio to list
                playlist.list.Rows.Add();
                path = dialog.FileName;
                tracks[db] = path;
                playlist.list.Rows[db].Cells[0].Value = db + 1;
                playlist.list.Rows[db].Cells[1].Value = Path.GetFileNameWithoutExtension(path);
                playlist.list.Rows[db].Cells[0].Selected = true;
                db++;

                playing();
            }
        }

        //File_Preferences
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            options.Visible = true;
        }

        //File_About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FreeStyle Music Player\nVersion 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //File_Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device.Dispose();

            Application.Exit();
        }

        //Playlist_Open
        private void openPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Playlist Files (*.pls)|*.pls";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Opening
                playlist.list.Rows.Clear();
                playlist.list.Refresh();
                db = 0;
                pathPlaylist = dialog.FileName;
                StreamReader reader = new StreamReader(pathPlaylist);

                while (reader.Peek() > -1)
                {
                    be = reader.ReadLine();

                    if (be.StartsWith("File"))
                    {
                        tracks[db] = be;
                        playlist.list.Rows.Add();
                        playlist.list.Rows[db].Cells[0].Value = db + 1;
                        db++;
                    }
                    if (be.StartsWith("Title"))
                    {
                        string[] title=be.Split('=');
                        playlist.list.Rows[db - 1].Cells[1].Value = title[1];
                    }
                }
                reader.Close();
            }
        }

        //Playlist_Save
        private void savePlaylist_Click(object sender, EventArgs e)
        {
            if (db>0)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Playlist Files (*.pls)|*.pls";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //Saving
                    pathPlaylist = dialog.FileName;
                    StreamWriter writer = new StreamWriter(pathPlaylist);

                    writer.WriteLine("[playlist]");

                    for (int i = 0; i < db; i++)
                    {
                        writer.WriteLine("\nFile" + (i + 1) + "=" + tracks[i]);
                        writer.WriteLine("Title" + (i + 1) + "=" + playlist.list.Rows[i].Cells[1].Value);
                    }
                    writer.WriteLine("\nNumberOfEntries=" + db);
                    writer.WriteLine("Version=2");
                    writer.Close();
                }
            }
            else
            {
                MessageBox.Show("The playlist is empty!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Playlist_AddFile
        private void addFilePlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files (*.mp3, *.flac, *.wav)|*.mp3;*.flac;*.wav";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Adding audio to list
                playlist.list.Rows.Add();
                path = dialog.FileName;
                tracks[db] = path;
                playlist.list.Rows[db].Cells[0].Value = db + 1;
                playlist.list.Rows[db].Cells[1].Value = Path.GetFileNameWithoutExtension(path);
                playlist.list.Rows[db].Cells[0].Selected = true;
                db++;
            }
        }

        //Playlist_AddFolder
        private void addFolderPlaylist_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                files= Directory.GetFiles(dialog.SelectedPath, "*.flac", SearchOption.AllDirectories);
            }

            for(int i=0; i<files.Length;i++)
            {
                playlist.list.Rows.Add();
                tracks[db] = files[i];
                playlist.list.Rows[db].Cells[0].Value = db + 1;
                playlist.list.Rows[db].Cells[1].Value = Path.GetFileNameWithoutExtension(files[i]);
                playlist.list.Rows[db].Cells[0].Selected = true;
                db++;
            }
        }

        //Play
        private void button_play_Click(object sender, EventArgs e)
        {
            playing();
        }

        //Stop
        private void button_stop_Click(object sender, EventArgs e)
        {
            if (db>0)
            {
                device.Stop();
                audio = CodecFactory.Instance.GetCodec(path);
                device.Initialize(audio);
            }
        }

        //Pause
        private void button_pause_Click(object sender, EventArgs e)
        {
            if (db>0)
            {
                device.Pause();
                paused = 1;
            }
        }

        //Prev track
        private void button_prev_Click(object sender, EventArgs e)
        {
            if (db > 0)
            {
                if (playlist.list.Rows[0].Cells[0].Selected == true)
                {
                    playing();
                }
                else
                {
                    int current=playlist.list.CurrentRow.Index;
                    playlist.list.Rows[current-1].Cells[0].Selected = true;
                    playing();
                }
            }
        }

        //Next track
        private void button_next_Click(object sender, EventArgs e)
        {
            if (db > 0)
            {
                if (playlist.list.Rows[db-1].Cells[0].Selected == true)
                {
                    playing();
                }
                else
                {
                    int current = playlist.list.CurrentRow.Index;
                    playlist.list.Rows[current+1].Cells[0].Selected = true;
                    playing();
                }
            }
        }

        //Playlist visibility
        private void check_playlist_CheckStateChanged(object sender, EventArgs e)
        {
            if (check_playlist.Checked)
                playlist.Visible = true;
            else
                playlist.Visible = false;
        }

        //Volume changing
        private void track_volume_ValueChanged(object sender, EventArgs e)
        {
            if (db > 0)
            {
                device.Volume = (float)track_volume.Value / 10;
            }
        }

        //Playing function
        public void playing()
        {
            if (db > 0)
            {
                //Init
                device.Stop();
                int index = (int)playlist.list.CurrentRow.Cells[0].Value - 1;
                path = tracks[index];

                if (paused == 0)
                {
                    audio = CodecFactory.Instance.GetCodec(path);
                }
                device.Initialize(audio);
                device.Volume = (float)track_volume.Value / 10;
                device.Play();
                paused = 0;

                //Getting audio information
                label_name.Text = Path.GetFileNameWithoutExtension(path);
                label_extension.Text = Path.GetExtension(path);
                label_progress.Text = "00:00";
                label_length.Text = "";
                length = (int)audio.GetLength().TotalSeconds;

                if (length / 60 < 10)
                    label_length.Text += "0" + length / 60 + ":";
                else
                    label_length.Text += length / 60 + ":";

                if (length % 60 < 10)
                    label_length.Text += "0" + length % 60;
                else
                    label_length.Text += length % 60;

                timer.Start();
            }
        }

        //Progress changing
        private void progressBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (db > 0)
            {
                double MousePosition = e.X;
                double ratio = MousePosition / progressBar.Width;
                double progressBarValue = ratio * progressBar.Maximum;
                this.progressBar.Value = (int)progressBarValue;

                TimeSpan position = new TimeSpan(0, 0, (int)progressBarValue);
                audio.SetPosition(position);
            }
        }

        //Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            //Start
            progressBar.Maximum = length;
            progressBar.Value = (int)audio.GetPosition().TotalSeconds;

            //Label
            label_progress.Text = "";

            if (progressBar.Value / 60 < 10)
                label_progress.Text += "0" + progressBar.Value / 60 + ":";
            else
                label_progress.Text += progressBar.Value / 60 + ":";

            if (progressBar.Value % 60 < 10)
                label_progress.Text += "0" + progressBar.Value % 60;
            else
                label_progress.Text += progressBar.Value % 60;

            //End
            if (progressBar.Value == length)
                timer.Stop();
        }
    }
}
