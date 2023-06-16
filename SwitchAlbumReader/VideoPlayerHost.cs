using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace SwitchAlbumReader
{
    public partial class VideoPlayerHost : Form
    {
        ElementHost host;
        VideoPlayerWpf.UserControl1 uc1;

        public VideoPlayerHost()
        {
            InitializeComponent();
        }

        private void VideoPlayerHost_Load(object sender, EventArgs e)
        {
            host = new ElementHost();
            host.Dock = DockStyle.Fill;

            uc1 = new VideoPlayerWpf.UserControl1();
            host.Child = uc1;

            this.Controls.Add(host);
            this.ClientSize = new Size(1280, 760);
        }

        public void UpdateVideoSrc(string newSrc)
        {
            uc1.ChangeSource(newSrc);
            //C:\Switch-screenshots\Album\2017\10\21\2017102119341100-F1C11A22FAEE3B82F21B330E1B786A39.mp4
        }

        private void VideoPlayerHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString() == "UserClosing")
            {
                e.Cancel = true;
                uc1.StopMedia();
                this.Hide();
            }
        }
    }
}
