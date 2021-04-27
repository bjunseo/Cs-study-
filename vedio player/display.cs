using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace vedio_player
{
    public partial class display : Form
    {
        WMPLib.WindowsMediaPlayer Player;

        private string file;
        private int Ver;
        private int Hol;
        private string line;
        public int Vertical
        {
            get { return this.Ver; }
            set { this.Ver = value; }
        }

        public string FIle
        {
            get { return this.file; }
            set { this.file = value; }
        }

        public int Holizontal
        {
            get { return this.Hol; }
            set { this.Hol = value; }
        }
        public display()
        {
            InitializeComponent();
        }

        private void display_Load(object sender, EventArgs e)
        {
            line = "@" + file;
            PlayFile(line); 
        }

        private void PlayFile(String url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.PlayStateChange +=
                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.play();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Close();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }

    }
}