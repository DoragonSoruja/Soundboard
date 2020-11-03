using System;
using WMPLib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string audioFilePath;
        string audioName;

        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Video Files (*.mp3, *.mp4, *.wmv)|*.mp3; *.mp4; *.wmv";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath.Text = ofd.FileName;
                    audioName = ofd.SafeFileName;
                    audioFilePath = ofd.FileName;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            IWMPMedia mediainfo = wmp.newMedia(audioFilePath);
            int minutes = (int)mediainfo.duration / 60;
            int seconds = (int)mediainfo.duration % 60;

            string time;

            if (seconds < 10)
            {
                time = minutes.ToString() + ":0" + seconds.ToString();
            }
            else
            {
                time = minutes.ToString() + ":" + seconds.ToString();
            }

            audioList.Items.Add(new ListViewItem(new String[] {audioName, time}));
        }
    }
}
