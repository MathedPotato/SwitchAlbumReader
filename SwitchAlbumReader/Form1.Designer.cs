namespace SwitchAlbumReader
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstCfg = new System.Windows.Forms.ListBox();
            this.btnChangeCfg = new System.Windows.Forms.Button();
            this.btnLoadCfg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tblFilterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.tblGameFilter = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxItems = new System.Windows.Forms.NumericUpDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtMaxRowImg = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFileTypeFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinImgWidth = new System.Windows.Forms.NumericUpDown();
            this.btnSaveDisplay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tblFilterLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxRowImg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinImgWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(705, 359);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstCfg);
            this.tabPage1.Controls.Add(this.btnChangeCfg);
            this.tabPage1.Controls.Add(this.btnLoadCfg);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstCfg
            // 
            this.lstCfg.FormattingEnabled = true;
            this.lstCfg.HorizontalScrollbar = true;
            this.lstCfg.ItemHeight = 16;
            this.lstCfg.Location = new System.Drawing.Point(8, 76);
            this.lstCfg.Name = "lstCfg";
            this.lstCfg.Size = new System.Drawing.Size(229, 196);
            this.lstCfg.TabIndex = 1;
            this.lstCfg.DoubleClick += new System.EventHandler(this.lstCfg_DoubleClick);
            // 
            // btnChangeCfg
            // 
            this.btnChangeCfg.Location = new System.Drawing.Point(8, 293);
            this.btnChangeCfg.Name = "btnChangeCfg";
            this.btnChangeCfg.Size = new System.Drawing.Size(229, 29);
            this.btnChangeCfg.TabIndex = 0;
            this.btnChangeCfg.Text = "Change Config";
            this.btnChangeCfg.UseVisualStyleBackColor = true;
            this.btnChangeCfg.Click += new System.EventHandler(this.btnChangeConfig_Click);
            // 
            // btnLoadCfg
            // 
            this.btnLoadCfg.Location = new System.Drawing.Point(8, 41);
            this.btnLoadCfg.Name = "btnLoadCfg";
            this.btnLoadCfg.Size = new System.Drawing.Size(229, 29);
            this.btnLoadCfg.TabIndex = 0;
            this.btnLoadCfg.Text = "Load Config";
            this.btnLoadCfg.UseVisualStyleBackColor = true;
            this.btnLoadCfg.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change Root Folder...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tblFilterLayout);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblFilterLayout
            // 
            this.tblFilterLayout.ColumnCount = 1;
            this.tblFilterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilterLayout.Controls.Add(this.btnApplyFilter, 0, 4);
            this.tblFilterLayout.Controls.Add(this.tblGameFilter, 0, 3);
            this.tblFilterLayout.Controls.Add(this.label2, 0, 2);
            this.tblFilterLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblFilterLayout.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tblFilterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilterLayout.Location = new System.Drawing.Point(3, 3);
            this.tblFilterLayout.Name = "tblFilterLayout";
            this.tblFilterLayout.RowCount = 5;
            this.tblFilterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblFilterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblFilterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblFilterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblFilterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblFilterLayout.Size = new System.Drawing.Size(346, 324);
            this.tblFilterLayout.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max items:";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(3, 287);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(229, 34);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // tblGameFilter
            // 
            this.tblGameFilter.AutoScroll = true;
            this.tblGameFilter.ColumnCount = 1;
            this.tblGameFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblGameFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGameFilter.Location = new System.Drawing.Point(3, 73);
            this.tblGameFilter.Name = "tblGameFilter";
            this.tblGameFilter.RowCount = 3;
            this.tblGameFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblGameFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblGameFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGameFilter.Size = new System.Drawing.Size(340, 208);
            this.tblGameFilter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Games:";
            // 
            // txtMaxItems
            // 
            this.txtMaxItems.Location = new System.Drawing.Point(11, 123);
            this.txtMaxItems.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtMaxItems.Name = "txtMaxItems";
            this.txtMaxItems.Size = new System.Drawing.Size(120, 22);
            this.txtMaxItems.TabIndex = 1;
            this.txtMaxItems.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtMaxItems.ValueChanged += new System.EventHandler(this.txtMaxItems_ValueChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Size = new System.Drawing.Size(341, 359);
            this.splitContainer2.SplitterDistance = 170;
            this.splitContainer2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 170);
            this.listBox1.TabIndex = 2;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select \"Album\" folder";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtMaxItems);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnSaveDisplay);
            this.tabPage3.Controls.Add(this.txtMinImgWidth);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtMaxRowImg);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(352, 330);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Settings 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtMaxRowImg
            // 
            this.txtMaxRowImg.Location = new System.Drawing.Point(11, 35);
            this.txtMaxRowImg.Name = "txtMaxRowImg";
            this.txtMaxRowImg.Size = new System.Drawing.Size(120, 22);
            this.txtMaxRowImg.TabIndex = 0;
            this.txtMaxRowImg.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtMaxRowImg.ValueChanged += new System.EventHandler(this.txtMaxRowImg_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maximum Images per row:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 20);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cmbFileTypeFilter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbSort, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 30);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "File Type:";
            // 
            // cmbFileTypeFilter
            // 
            this.cmbFileTypeFilter.FormattingEnabled = true;
            this.cmbFileTypeFilter.Items.AddRange(new object[] {
            "All",
            "Images",
            "Videos"});
            this.cmbFileTypeFilter.Location = new System.Drawing.Point(176, 3);
            this.cmbFileTypeFilter.Name = "cmbFileTypeFilter";
            this.cmbFileTypeFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbFileTypeFilter.TabIndex = 2;
            this.cmbFileTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFileTypeFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Minimum image width (px):";
            // 
            // txtMinImgWidth
            // 
            this.txtMinImgWidth.Location = new System.Drawing.Point(11, 80);
            this.txtMinImgWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtMinImgWidth.Name = "txtMinImgWidth";
            this.txtMinImgWidth.Size = new System.Drawing.Size(120, 22);
            this.txtMinImgWidth.TabIndex = 3;
            this.txtMinImgWidth.ValueChanged += new System.EventHandler(this.txtMinImgWidth_ValueChanged);
            // 
            // btnSaveDisplay
            // 
            this.btnSaveDisplay.Location = new System.Drawing.Point(8, 151);
            this.btnSaveDisplay.Name = "btnSaveDisplay";
            this.btnSaveDisplay.Size = new System.Drawing.Size(229, 29);
            this.btnSaveDisplay.TabIndex = 4;
            this.btnSaveDisplay.Text = "Save Settings";
            this.btnSaveDisplay.UseVisualStyleBackColor = true;
            this.btnSaveDisplay.Click += new System.EventHandler(this.btnSaveDisplay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sort:";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Newest First",
            "Oldest First"});
            this.cmbSort.Location = new System.Drawing.Point(3, 3);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(121, 24);
            this.cmbSort.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 359);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tblFilterLayout.ResumeLayout(false);
            this.tblFilterLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxItems)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxRowImg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMinImgWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstCfg;
        private System.Windows.Forms.Button btnChangeCfg;
        private System.Windows.Forms.Button btnLoadCfg;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown txtMaxItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblGameFilter;
        private System.Windows.Forms.TableLayoutPanel tblFilterLayout;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtMaxRowImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbFileTypeFilter;
        private System.Windows.Forms.NumericUpDown txtMinImgWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSort;
    }
}

