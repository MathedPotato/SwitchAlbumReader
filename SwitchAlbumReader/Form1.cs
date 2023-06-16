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
    public partial class Form1 : Form
    {
        public enum AlbumFileType
        {
            JPG,
            MP4
        };

        public class GameIdData
        {
            public string id;
            public string name;

            public GameIdData(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
        }

        public class AlbumFileData
        {
            public string timestamp;
            public string gameID;
            public AlbumFileType fileType;

            public AlbumFileData(string timestamp, string gameID, AlbumFileType fileType)
            {
                this.timestamp = timestamp;
                this.gameID = gameID;
                this.fileType = fileType;
            }

            public AlbumFileData(string timestamp, string gameID, string fileType)
            {
                this.timestamp = timestamp;
                this.gameID = gameID;
                if (fileType.ToLower() == "jpg")
                {
                    this.fileType = AlbumFileType.JPG;
                }
                else
                {
                    this.fileType = AlbumFileType.MP4;
                }
            }

            public override string ToString()
            {
                //return "Time: " + this.timestamp + ", Game: " + this.gameID + ", File Type: " + this.fileType.ToString();
                return ((Form1)Form1.ActiveForm).GetAlbumFileDesc(this);
            }
        }

        const string CONFIG_FILE_NAME = "config.txt";
        const string DISPLAY_FILE_NAME = "display.txt";

        string rootFolderPath;
        string[] subDirs;
        AlbumFileData[] albumFiles;
        List<GameIdData> gameList = new List<GameIdData>();
        List<string> unknownGameIds = new List<string>();
        int maxResults = 10;
        //AlbumFileData[] filesToDisplay;
        List<string> filteredGameIds = new List<string>();

        FormImageViewer imageViewer = new FormImageViewer();
        VideoPlayerHost videoPlayer = new VideoPlayerHost();

        public bool usingListBoxAlbum = false;
        FlowLayoutPanel flowLayoutAlbum;

        public Form1()
        {
            InitializeComponent();

            if (!usingListBoxAlbum)
            {
                listBox1.Visible = false;
                Control parentControl = listBox1.Parent;
                parentControl.Controls.Remove(listBox1);

                flowLayoutAlbum = new FlowLayoutPanel();
                flowLayoutAlbum.Dock = DockStyle.Fill;
                flowLayoutAlbum.AutoScroll = true;
                flowLayoutAlbum.HorizontalScroll.Visible = false;
                //flowLayoutAlbum.Scale(new SizeF(2, 2));
                //flowLayoutAlbum.Margin = new Padding(0);
                //flowLayoutAlbum.Padding = new Padding(0);
                flowLayoutAlbum.Resize += FlowLayoutAlbum_Resize;
                parentControl.Controls.Add(flowLayoutAlbum);
            }
        }

        private void FlowLayoutAlbum_Resize(object sender, EventArgs e)
        {
            ResizeFlowElements();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadAlbum(folderBrowserDialog1.SelectedPath);
            }
        }

        public void LoadAlbum(string rootFolder)
        {
            rootFolderPath = rootFolder;
            //subDirs = System.IO.Directory.GetDirectories(rootFolderPath, "*.*", System.IO.SearchOption.AllDirectories);
            subDirs = System.IO.Directory.GetFiles(rootFolderPath, "*.*", System.IO.SearchOption.AllDirectories);
            albumFiles = new AlbumFileData[subDirs.Length];
            for (int i = 0; i < subDirs.Length; i++)
            {
                string[] subDirArr = subDirs[i].Split('\\');
                char[] delimiters = { '.', '-' };
                string[] fileNameArr = subDirArr[subDirArr.Length - 1].Split(delimiters);
                albumFiles[i] = (new AlbumFileData(fileNameArr[0], fileNameArr[1], fileNameArr[2]));
                if (!gameList.Exists(x => x.id == fileNameArr[1]) && !unknownGameIds.Exists(x => x == fileNameArr[1]))
                {
                    unknownGameIds.Add(fileNameArr[1]);
                }
            }
            RefreshAlbumDisplay();
            if (unknownGameIds.Count >= 1)
            {
                string msgTxt;
                msgTxt = "New Game Ids: \n";
                for (int i = 0; i < unknownGameIds.Count; i++)
                {
                    msgTxt += unknownGameIds[i] + "\n";
                }
                //MessageBox.Show(msgTxt);
                //RefreshCfgDisplay();
            }

            RefreshCfgDisplay();
        }

        public void RefreshAlbumDisplay()
        {
            if (usingListBoxAlbum)
            {
                listBox1.Items.Clear();

                for (int i = 0; i < albumFiles.Length; i++)
                {
                    int actualIndex;
                    if (cmbSort.SelectedIndex == 1)
                    {
                        actualIndex = i;
                    }
                    else
                    {
                        actualIndex = (albumFiles.Length - 1) - i;
                    }
                    //listBox1.Items.Add(GetAlbumFileDesc(albumFiles[i]));
                    if (listBox1.Items.Count >= maxResults)
                    {
                        break;
                    }
                    // Apply file type filter
                    if(cmbFileTypeFilter.SelectedIndex == 1 && albumFiles[actualIndex].fileType == AlbumFileType.MP4)
                    {
                        continue;
                    }
                    if (cmbFileTypeFilter.SelectedIndex == 2 && albumFiles[actualIndex].fileType == AlbumFileType.JPG)
                    {
                        continue;
                    }
                    if (filteredGameIds.Count == 0)
                    {
                        listBox1.Items.Add(albumFiles[actualIndex]);
                    }
                    else
                    {
                        // Apply game filter
                        if (filteredGameIds.Exists(x => x == albumFiles[actualIndex].gameID))
                        {
                            listBox1.Items.Add(albumFiles[actualIndex]);
                        }
                    }
                }
            }
            else
            {
                // Use image board view (flow layout) instead
                flowLayoutAlbum.Controls.Clear();

                for (int i = 0; i < albumFiles.Length; i++)
                {
                    int actualIndex;
                    if(cmbSort.SelectedIndex == 1)
                    {
                        actualIndex = i;
                    }
                    else
                    {
                        actualIndex = (albumFiles.Length - 1) - i;
                    }
                    if (flowLayoutAlbum.Controls.Count >= maxResults)
                    {
                        break;
                    }
                    // Apply file type filter
                    if (cmbFileTypeFilter.SelectedIndex == 1 && albumFiles[actualIndex].fileType == AlbumFileType.MP4)
                    {
                        continue;
                    }
                    if (cmbFileTypeFilter.SelectedIndex == 2 && albumFiles[actualIndex].fileType == AlbumFileType.JPG)
                    {
                        continue;
                    }
                    if (filteredGameIds.Count == 0)
                    {
                        AddFileToFlow(albumFiles[actualIndex]);
                    }
                    else
                    {
                        // Apply game filter
                        if (filteredGameIds.Exists(x => x == albumFiles[actualIndex].gameID))
                        {
                            AddFileToFlow(albumFiles[actualIndex]);
                        }
                    }
                }

                //flowLayoutAlbum.Scale(new SizeF(2, 2));
                //MessageBox.Show(flowLayoutAlbum.Margin.ToString());
                ResizeFlowElements();
            }
        }

        public void AddFileToFlow(AlbumFileData albumFileData)
        {
            int defaultMargin = 3;
            //double targetWidth = (flowLayoutAlbum.ClientSize.Width/(double)txtMaxRowImg.Value) - (defaultMargin * 2);
            //double targetHeight = targetWidth * 9.0 / 16.0;

            if (albumFileData.fileType == AlbumFileType.JPG)
            {
                PictureBox albumImage = new PictureBox();
                albumImage.ImageLocation = GetAlbumFilePath(albumFileData);
                albumImage.SizeMode = PictureBoxSizeMode.Zoom;
                //albumImage.ClientSize = new Size((int)targetWidth, (int)targetHeight);
                albumImage.Margin = new Padding(defaultMargin);
                albumImage.Click += AlbumImage_Click;
                //albumImage.Controls.Add(new ListBox());
                albumImage.Load();

                flowLayoutAlbum.Controls.Add(albumImage);
            }
            else
            {
                ListBox videoLabel = new ListBox();
                videoLabel.Items.Add(albumFileData);
                videoLabel.DoubleClick += VideoLabel_DoubleClick;
                //videoLabel.ClientSize = new Size((int)targetWidth, (int)targetHeight);
                videoLabel.Margin = new Padding(defaultMargin);

                flowLayoutAlbum.Controls.Add(videoLabel);
                /*try
                {
                    PictureBox videoImg = new PictureBox();
                    videoImg.Image = System.Drawing.Image.FromFile(GetAlbumFilePath(albumFileData));
                    videoImg.SizeMode = PictureBoxSizeMode.Zoom;
                    videoImg.Margin = new Padding(defaultMargin);

                    flowLayoutAlbum.Controls.Add(videoImg);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }*/
            }
        }

        private void AlbumImage_Click(object sender, EventArgs e)
        {
            AlbumFileData albumFileData = albumFiles.First(x => GetAlbumFilePath(x) == ((PictureBox)sender).ImageLocation);
            ViewFile(albumFileData);
        }

        private void VideoLabel_DoubleClick(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedItem == null)
            {
                return;
            }

            AlbumFileData albumFileData = (AlbumFileData)((ListBox)sender).SelectedItem;
            ViewFile(albumFileData);
        }

        public void ResizeFlowElements()
        {
            int defaultMargin = 3;
            double targetWidth = (flowLayoutAlbum.ClientSize.Width / (double)txtMaxRowImg.Value) - (defaultMargin * 2);
            if(targetWidth < (double)txtMinImgWidth.Value)
            {
                targetWidth = (double)txtMinImgWidth.Value;
            }
            double targetHeight = targetWidth * 9.0 / 16.0;

            foreach(Control control in flowLayoutAlbum.Controls)
            {
                control.Size = new Size((int)targetWidth, (int)targetHeight);
            }
        }

        public void RefreshCfgDisplay()
        {
            lstCfg.Items.Clear();
            foreach(GameIdData data in gameList)
            {
                lstCfg.Items.Add(data.name + " (" + data.id + ")");
            }
            foreach(string s in unknownGameIds)
            {
                lstCfg.Items.Add(s);
            }
            RefreshAlbumDisplay();
            RefreshFilterDisplay();
        }

        public void LoadCfg()
        {
            if(System.IO.File.Exists(CONFIG_FILE_NAME))
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(CONFIG_FILE_NAME);

                rootFolderPath = streamReader.ReadLine();

                gameList.Clear();
                unknownGameIds.Clear();

                while(!streamReader.EndOfStream)
                {
                    string[] gameIdData = streamReader.ReadLine().Split(';');
                    // Game Id format: id:name
                    gameList.Add(new GameIdData(gameIdData[0], gameIdData[1]));
                }

                streamReader.Close();

                LoadAlbum(rootFolderPath);
            }
        }

        public void SaveCfg()
        {
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(CONFIG_FILE_NAME, false);

            streamWriter.Write(rootFolderPath);

            foreach(GameIdData gameData in gameList)
            {
                streamWriter.WriteLine();
                streamWriter.Write(gameData.id + ";" + gameData.name);
            }

            streamWriter.Close();

            MessageBox.Show("Config file updated\n(" + System.IO.Directory.GetCurrentDirectory() + "\\" + CONFIG_FILE_NAME);
        }

        //Label[] gameFilterLabels;
        CheckBox[] gameFilterCheckBoxes;

        public void RefreshFilterDisplay()
        {
            tblGameFilter.Controls.Clear();
            //filteredGameIds.Clear();
            tblGameFilter.RowCount = gameList.Count + unknownGameIds.Count;
            //gameFilterLabels = new Label[tblGameFilter.RowCount];
            gameFilterCheckBoxes = new CheckBox[tblGameFilter.RowCount];
            foreach(RowStyle style in tblGameFilter.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 30;
            }
            for(int i = 0; i < gameList.Count; i++)
            {
                //gameFilterLabels[i] = new Label();
                //gameFilterLabels[i].Text = gameList[i].name;
                //tblGameFilter.SetRow(gameFilterLabels[i], i);
                gameFilterCheckBoxes[i] = new CheckBox();
                gameFilterCheckBoxes[i].Text = gameList[i].name;
                gameFilterCheckBoxes[i].Dock = DockStyle.Fill;
                gameFilterCheckBoxes[i].CheckedChanged += FilterBoxChange;
                tblGameFilter.Controls.Add(gameFilterCheckBoxes[i], 1, i);
                //tblGameFilter.Controls.Add(gameFilterLabels[i], 0, i);
            }
            for (int i = 0; i < unknownGameIds.Count; i++)
            {
                int index = i + gameList.Count;
                //gameFilterLabels[index] = new Label();
                //gameFilterLabels[index].Text = unknownGameIds[i];
                //tblGameFilter.SetRow(gameFilterLabels[i], i);
                gameFilterCheckBoxes[index] = new CheckBox();
                gameFilterCheckBoxes[index].Text = unknownGameIds[i];
                gameFilterCheckBoxes[index].Dock = DockStyle.Fill;
                gameFilterCheckBoxes[index].CheckedChanged += FilterBoxChange;
                tblGameFilter.Controls.Add(gameFilterCheckBoxes[index], 1, index);
                //tblGameFilter.Controls.Add(gameFilterLabels[index], 0, index);
            }
            tblGameFilter.RowCount += 1;
        }

        public string GetAlbumFilePath(AlbumFileData albumFile)
        {
            string relPath = "";
            relPath = albumFile.timestamp.Substring(0, 4) + "\\";
            relPath += albumFile.timestamp.Substring(4, 2) + "\\";
            relPath += albumFile.timestamp.Substring(6, 2) + "\\";
            relPath += albumFile.timestamp + "-" + albumFile.gameID + "." + albumFile.fileType.ToString();

            return rootFolderPath + "\\" + relPath;
        }

        public string GetAlbumFileDesc(AlbumFileData albumFile)
        {
            string gameStr = "";
            if(gameList.Exists(x => x.id == albumFile.gameID))
            {
                gameStr = gameList.Find(x => x.id == albumFile.gameID).name;
            }
            else
            {
                gameStr = albumFile.gameID;
            }
            return "Game: " + gameStr + ", Time: " + ConvertTimestamp(albumFile.timestamp) + ", File Type: " + albumFile.fileType.ToString();
        }

        public string ConvertTimestamp(string timestamp)
        {
            string year, month, day, hour, minute;
            year = timestamp.Substring(0, 4);
            month = timestamp.Substring(4, 2);
            day = timestamp.Substring(6, 2);
            hour = timestamp.Substring(8, 2);
            minute = timestamp.Substring(10, 2);

            return day + "/" + month + "/" + year + " " + hour + ":" + minute;
        }

        private void lstCfg_DoubleClick(object sender, EventArgs e)
        {
            UpdateGameName updateGameName;
            string selectedGameId = (string)lstCfg.SelectedItem;
            //MessageBox.Show(selectedGameId);
            string[] selectedIdArr = selectedGameId.Split('(');
            if (selectedIdArr.Length > 1)
            {
                for (int i = 0; i < selectedIdArr.Length; i++)
                {
                    selectedIdArr[i] = selectedIdArr[i].Substring(0, selectedIdArr[i].Length - 1);
                }
                updateGameName = new UpdateGameName(selectedIdArr[1], selectedIdArr[0]);
                
            }
            else
            {
                updateGameName = new UpdateGameName(selectedIdArr[0]);
            }
            //MessageBox.Show(selectedIdArr.Length.ToString() + "\n" + selectedIdArr[0]);

            if(updateGameName.ShowDialog(this) == DialogResult.OK)
            {
                string newGameName = updateGameName.gameName;
                //MessageBox.Show(newGameName);
                if (selectedIdArr.Length > 1)
                {
                    gameList.Find(x => x.id == selectedIdArr[1]).name = newGameName;
                }
                else
                {
                    gameList.Add(new GameIdData(selectedGameId, newGameName));
                    unknownGameIds.Remove(selectedGameId);
                    //string gameLstStr = "";
                    /*foreach(GameIdData data in gameList)
                    {
                        gameLstStr += data.name + "\n";
                    }
                    MessageBox.Show(gameLstStr);*/
                }
            }
            updateGameName.Dispose();
            RefreshCfgDisplay();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void FilterBoxChange(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        public void ApplyFilter()
        {
            filteredGameIds.Clear();
            maxResults = (int)txtMaxItems.Value;
            for (int i = 0; i < gameFilterCheckBoxes.Length; i++)
            {
                if (gameFilterCheckBoxes[i].Checked)
                {
                    if (i < gameList.Count)
                    {
                        filteredGameIds.Add(gameList[i].id);
                    }
                    else
                    {
                        filteredGameIds.Add(unknownGameIds[i - gameList.Count]);
                    }
                }
            }
            RefreshAlbumDisplay();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null)
            {
                return;
            }

            AlbumFileData albumFileData = (AlbumFileData)listBox1.SelectedItem;
            ViewFile(albumFileData);
            //MessageBox.Show(GetAlbumFilePath(albumFileData));
        }

        public void ViewFile(AlbumFileData albumFileData)
        {
            if (albumFileData.fileType == AlbumFileType.JPG)
            {
                //System.Diagnostics.Process newProcess = new System.Diagnostics.Process();
                //newProcess.StartInfo.FileName = GetAlbumFilePath(albumFileData);
                //newProcess.Start();

                pictureBox1.ImageLocation = GetAlbumFilePath(albumFileData);
                pictureBox1.Load();
                //imageViewer.UpdateWebUrl(GetAlbumFilePath(albumFileData));
                //imageViewer.Width = 1260;
                //imageViewer.Height = 720;
                /*if (!imageViewer.Visible)
                {
                    imageViewer.Show(this);
                }*/
                //imageViewer.UpdateWebUrl(GetAlbumFilePath(albumFileData));
                //imageViewer.Width = 1260 + ;
                //imageViewer.Height = 720 + 47;
                //imageViewer.ClientSize = new Size(1280, 720);
                /*if (!imageViewer.Visible)
                {
                    imageViewer.Show(this);
                }*/
            }
            else
            {
                //System.Windows.
                //System.Diagnostics.Process.Start(GetAlbumFilePath(albumFileData));
                //imageViewer.UpdateWebUrl(GetAlbumFilePath(albumFileData));
                //imageViewer.Width = 1260 + ;
                //imageViewer.Height = 720 + 47;
                //imageViewer.ClientSize = new Size(1280, 720);
                /*if (!imageViewer.Visible)
                {
                    imageViewer.Show(this);
                }*/
                if (!videoPlayer.Visible)
                {
                    videoPlayer.Show(this);
                }
                videoPlayer.UpdateVideoSrc(GetAlbumFilePath(albumFileData));
            }
        }

        private void btnChangeConfig_Click(object sender, EventArgs e)
        {
            SaveCfg();
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            LoadDisplaySettings();
            LoadCfg();
        }

        private void cmbFileTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtMaxRowImg_ValueChanged(object sender, EventArgs e)
        {
            ResizeFlowElements();
        }

        private void txtMinImgWidth_ValueChanged(object sender, EventArgs e)
        {
            ResizeFlowElements();
        }

        public void SaveDisplaySettings()
        {
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(DISPLAY_FILE_NAME, false);

            streamWriter.Write(txtMaxRowImg.Value.ToString() + "," + txtMinImgWidth.Value.ToString() + "," + txtMaxItems.Value.ToString());
            streamWriter.Close();

            MessageBox.Show("Display settings updated\n(" + System.IO.Directory.GetCurrentDirectory() + "\\" + DISPLAY_FILE_NAME);
        }

        public void LoadDisplaySettings()
        {
            if (System.IO.File.Exists(DISPLAY_FILE_NAME))
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(DISPLAY_FILE_NAME);

                string[] fileData = streamReader.ReadLine().Split(',');

                txtMaxRowImg.Value = int.Parse(fileData[0]);
                txtMinImgWidth.Value = int.Parse(fileData[1]);
                txtMaxItems.Value = int.Parse(fileData[2]);

                streamReader.Close();
            }
        }

        private void btnSaveDisplay_Click(object sender, EventArgs e)
        {
            SaveDisplaySettings();
        }

        private void txtMaxItems_ValueChanged(object sender, EventArgs e)
        {
            maxResults = (int)txtMaxItems.Value;
        }
    }
}
