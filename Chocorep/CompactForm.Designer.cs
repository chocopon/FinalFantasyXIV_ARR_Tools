namespace FF14FastReport
{
    partial class CompactForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompactForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AutoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GameLogButton = new System.Windows.Forms.Button();
            this.OpenAnalyzeWindowButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StopStartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResetClose_Box = new System.Windows.Forms.CheckBox();
            this.ResetLevelSync_Box = new System.Windows.Forms.CheckBox();
            this.ResetJobClassChanged_Box = new System.Windows.Forms.CheckBox();
            this.ResetID_Box = new System.Windows.Forms.CheckBox();
            this.ESCButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ViewDPSWindowButton = new System.Windows.Forms.Button();
            this.TransMouseBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReadmeBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.ProductNameVersionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LogCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.LogReadIntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.SearchLogInfoBGWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 309);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AutoSaveCheckBox);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "操作";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AutoSaveCheckBox
            // 
            this.AutoSaveCheckBox.AutoSize = true;
            this.AutoSaveCheckBox.Checked = global::FF14FastReport.Properties.Settings.Default.AutoSaveLog;
            this.AutoSaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSaveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FF14FastReport.Properties.Settings.Default, "AutoSaveLog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AutoSaveCheckBox.Location = new System.Drawing.Point(13, 186);
            this.AutoSaveCheckBox.Name = "AutoSaveCheckBox";
            this.AutoSaveCheckBox.Size = new System.Drawing.Size(102, 19);
            this.AutoSaveCheckBox.TabIndex = 6;
            this.AutoSaveCheckBox.Text = "ログの自動保存";
            this.toolTip1.SetToolTip(this.AutoSaveCheckBox, "ログデータを保存します。");
            this.AutoSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GameLogButton);
            this.groupBox2.Controls.Add(this.OpenAnalyzeWindowButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 62);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "その他のWindow";
            // 
            // GameLogButton
            // 
            this.GameLogButton.Location = new System.Drawing.Point(131, 22);
            this.GameLogButton.Name = "GameLogButton";
            this.GameLogButton.Size = new System.Drawing.Size(100, 30);
            this.GameLogButton.TabIndex = 1;
            this.GameLogButton.Text = "ゲームログ表示";
            this.GameLogButton.UseVisualStyleBackColor = true;
            this.GameLogButton.Click += new System.EventHandler(this.GameLogButton_Click);
            // 
            // OpenAnalyzeWindowButton
            // 
            this.OpenAnalyzeWindowButton.Location = new System.Drawing.Point(6, 23);
            this.OpenAnalyzeWindowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenAnalyzeWindowButton.Name = "OpenAnalyzeWindowButton";
            this.OpenAnalyzeWindowButton.Size = new System.Drawing.Size(119, 29);
            this.OpenAnalyzeWindowButton.TabIndex = 0;
            this.OpenAnalyzeWindowButton.Text = "解析(Rep)表示";
            this.toolTip1.SetToolTip(this.OpenAnalyzeWindowButton, "ログ解析（Rep）のウィンドウを表示します。");
            this.OpenAnalyzeWindowButton.UseVisualStyleBackColor = true;
            this.OpenAnalyzeWindowButton.Click += new System.EventHandler(this.OpenAnalyzeWindowButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopStartButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.ESCButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.ViewDPSWindowButton);
            this.groupBox1.Controls.Add(this.TransMouseBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DPS";
            // 
            // StopStartButton
            // 
            this.StopStartButton.Location = new System.Drawing.Point(317, 17);
            this.StopStartButton.Name = "StopStartButton";
            this.StopStartButton.Size = new System.Drawing.Size(75, 29);
            this.StopStartButton.TabIndex = 7;
            this.StopStartButton.Text = "停止する";
            this.toolTip1.SetToolTip(this.StopStartButton, "ゲームを起動しない場合は、停止させてください。");
            this.StopStartButton.UseVisualStyleBackColor = false;
            this.StopStartButton.Click += new System.EventHandler(this.StopStartButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "DPSリセット";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResetClose_Box);
            this.groupBox4.Controls.Add(this.ResetLevelSync_Box);
            this.groupBox4.Controls.Add(this.ResetJobClassChanged_Box);
            this.groupBox4.Controls.Add(this.ResetID_Box);
            this.groupBox4.Location = new System.Drawing.Point(6, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 49);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "リセットのタイミング";
            // 
            // ResetClose_Box
            // 
            this.ResetClose_Box.AutoSize = true;
            this.ResetClose_Box.Checked = global::FF14FastReport.Properties.Settings.Default.ResetWhenJail;
            this.ResetClose_Box.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FF14FastReport.Properties.Settings.Default, "ResetWhenJail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResetClose_Box.Location = new System.Drawing.Point(75, 22);
            this.ResetClose_Box.Name = "ResetClose_Box";
            this.ResetClose_Box.Size = new System.Drawing.Size(72, 16);
            this.ResetClose_Box.TabIndex = 5;
            this.ResetClose_Box.Text = "封鎖開始";
            this.ResetClose_Box.UseVisualStyleBackColor = true;
            // 
            // ResetLevelSync_Box
            // 
            this.ResetLevelSync_Box.AutoSize = true;
            this.ResetLevelSync_Box.Checked = global::FF14FastReport.Properties.Settings.Default.ResetWhenLevelSync;
            this.ResetLevelSync_Box.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FF14FastReport.Properties.Settings.Default, "ResetWhenLevelSync", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResetLevelSync_Box.Location = new System.Drawing.Point(155, 22);
            this.ResetLevelSync_Box.Name = "ResetLevelSync_Box";
            this.ResetLevelSync_Box.Size = new System.Drawing.Size(104, 16);
            this.ResetLevelSync_Box.TabIndex = 4;
            this.ResetLevelSync_Box.Text = "レベルシンク開始";
            this.ResetLevelSync_Box.UseVisualStyleBackColor = true;
            // 
            // ResetJobClassChanged_Box
            // 
            this.ResetJobClassChanged_Box.AutoSize = true;
            this.ResetJobClassChanged_Box.Checked = global::FF14FastReport.Properties.Settings.Default.ResetWhenJobClassChanged;
            this.ResetJobClassChanged_Box.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FF14FastReport.Properties.Settings.Default, "ResetWhenJobClassChanged", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResetJobClassChanged_Box.Location = new System.Drawing.Point(267, 22);
            this.ResetJobClassChanged_Box.Name = "ResetJobClassChanged_Box";
            this.ResetJobClassChanged_Box.Size = new System.Drawing.Size(98, 16);
            this.ResetJobClassChanged_Box.TabIndex = 1;
            this.ResetJobClassChanged_Box.Text = "ジョブクラス変更";
            this.ResetJobClassChanged_Box.UseVisualStyleBackColor = true;
            // 
            // ResetID_Box
            // 
            this.ResetID_Box.AutoSize = true;
            this.ResetID_Box.Checked = global::FF14FastReport.Properties.Settings.Default.ResetWhenIDStart;
            this.ResetID_Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResetID_Box.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FF14FastReport.Properties.Settings.Default, "ResetWhenIDStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResetID_Box.Location = new System.Drawing.Point(5, 22);
            this.ResetID_Box.Name = "ResetID_Box";
            this.ResetID_Box.Size = new System.Drawing.Size(59, 16);
            this.ResetID_Box.TabIndex = 0;
            this.ResetID_Box.Text = "ID開始";
            this.ResetID_Box.UseVisualStyleBackColor = true;
            // 
            // ESCButton
            // 
            this.ESCButton.Location = new System.Drawing.Point(317, 76);
            this.ESCButton.Name = "ESCButton";
            this.ESCButton.Size = new System.Drawing.Size(75, 29);
            this.ESCButton.TabIndex = 4;
            this.ESCButton.Text = "左上に移動";
            this.toolTip1.SetToolTip(this.ESCButton, "DPSウィンドウを画面左上に表示します。");
            this.ESCButton.UseVisualStyleBackColor = true;
            this.ESCButton.Click += new System.EventHandler(this.ESCButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "フォントサイズ：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::FF14FastReport.Properties.Settings.Default, "RankingFormFontSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(93, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 23);
            this.numericUpDown1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.numericUpDown1, "DPS表示のフォントサイズを指定します。");
            this.numericUpDown1.Value = global::FF14FastReport.Properties.Settings.Default.RankingFormFontSize;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ViewDPSWindowButton
            // 
            this.ViewDPSWindowButton.Location = new System.Drawing.Point(9, 17);
            this.ViewDPSWindowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewDPSWindowButton.Name = "ViewDPSWindowButton";
            this.ViewDPSWindowButton.Size = new System.Drawing.Size(87, 29);
            this.ViewDPSWindowButton.TabIndex = 0;
            this.ViewDPSWindowButton.Text = "DPS表示";
            this.toolTip1.SetToolTip(this.ViewDPSWindowButton, "リアルタイムでDPSを表示するウィンドウを表示します。");
            this.ViewDPSWindowButton.UseVisualStyleBackColor = true;
            this.ViewDPSWindowButton.Click += new System.EventHandler(this.ViewDPSWindowButton_Click);
            // 
            // TransMouseBox
            // 
            this.TransMouseBox.AutoSize = true;
            this.TransMouseBox.Location = new System.Drawing.Point(6, 86);
            this.TransMouseBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransMouseBox.Name = "TransMouseBox";
            this.TransMouseBox.Size = new System.Drawing.Size(257, 16);
            this.TransMouseBox.TabIndex = 1;
            this.TransMouseBox.Text = "マウス透過（チェックするとマウス操作を無視します）";
            this.toolTip1.SetToolTip(this.TransMouseBox, "マウス操作を透過しますので、DPSをゲーム画面上に配置しても邪魔になりません。");
            this.TransMouseBox.UseVisualStyleBackColor = true;
            this.TransMouseBox.CheckedChanged += new System.EventHandler(this.TransMouseBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReadmeBox);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "情報";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReadmeBox
            // 
            this.ReadmeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadmeBox.Location = new System.Drawing.Point(6, 78);
            this.ReadmeBox.Multiline = true;
            this.ReadmeBox.Name = "ReadmeBox";
            this.ReadmeBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReadmeBox.Size = new System.Drawing.Size(392, 197);
            this.ReadmeBox.TabIndex = 1;
            this.ReadmeBox.Text = resources.GetString("ReadmeBox.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CopyrightLabel);
            this.groupBox3.Controls.Add(this.ProductNameVersionLabel);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 66);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(102, 39);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(41, 15);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "label2";
            // 
            // ProductNameVersionLabel
            // 
            this.ProductNameVersionLabel.AutoSize = true;
            this.ProductNameVersionLabel.Location = new System.Drawing.Point(102, 22);
            this.ProductNameVersionLabel.Name = "ProductNameVersionLabel";
            this.ProductNameVersionLabel.Size = new System.Drawing.Size(41, 15);
            this.ProductNameVersionLabel.TabIndex = 1;
            this.ProductNameVersionLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.LogCountLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(423, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(393, 18);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "...";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogCountLabel
            // 
            this.LogCountLabel.Name = "LogCountLabel";
            this.LogCountLabel.Size = new System.Drawing.Size(15, 18);
            this.LogCountLabel.Text = "0";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 17);
            this.toolStripProgressBar1.Visible = false;
            // 
            // LogReadIntervalTimer
            // 
            this.LogReadIntervalTimer.Interval = 1000;
            this.LogReadIntervalTimer.Tick += new System.EventHandler(this.LogReadIntervalTimer_Tick);
            // 
            // SearchLogInfoBGWorker
            // 
            this.SearchLogInfoBGWorker.WorkerReportsProgress = true;
            this.SearchLogInfoBGWorker.WorkerSupportsCancellation = true;
            this.SearchLogInfoBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchLogInfoBGWorker_DoWork);
            this.SearchLogInfoBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SearchLogInfoBGWorker_ProgressChanged);
            this.SearchLogInfoBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchLogInfoBGWorker_RunWorkerCompleted);
            // 
            // CompactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 336);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompactForm";
            this.Text = "FFXIV ARR Chocorep αバージョン";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompactForm_FormClosing);
            this.Load += new System.EventHandler(this.CompactForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OpenAnalyzeWindowButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ViewDPSWindowButton;
        private System.Windows.Forms.CheckBox TransMouseBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Label ProductNameVersionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ReadmeBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button ESCButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer LogReadIntervalTimer;
        private System.Windows.Forms.Button GameLogButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ResetClose_Box;
        private System.Windows.Forms.CheckBox ResetLevelSync_Box;
        private System.Windows.Forms.CheckBox ResetJobClassChanged_Box;
        private System.Windows.Forms.CheckBox ResetID_Box;
        private System.Windows.Forms.CheckBox AutoSaveCheckBox;
        private System.Windows.Forms.Button StopStartButton;
        private System.ComponentModel.BackgroundWorker SearchLogInfoBGWorker;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel LogCountLabel;
    }
}