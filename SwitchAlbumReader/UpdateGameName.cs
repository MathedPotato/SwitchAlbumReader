using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchAlbumReader
{
    public partial class UpdateGameName : Form
    {
        string gameId = "";
        public string gameName = "";

        public UpdateGameName()
        {
            InitializeComponent();
        }

        public UpdateGameName(string gameId)
        {
            this.gameId = gameId;
            InitializeComponent();
            lblGameId.Text = gameId;
        }

        public UpdateGameName(string gameId, string gameName)
        {
            this.gameId = gameId;
            this.gameName = gameName;
            InitializeComponent();
            lblGameId.Text = gameId;
            txtGameName.Text = gameName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            gameName = txtGameName.Text;
        }
    }
}
