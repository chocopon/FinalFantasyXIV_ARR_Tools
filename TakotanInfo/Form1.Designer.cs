namespace Infoman
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TestButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SoundStopButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SounbVolumeBar = new System.Windows.Forms.TrackBar();
            this.PlayButton6 = new System.Windows.Forms.Button();
            this.PlayButton5 = new System.Windows.Forms.Button();
            this.PlayButton4 = new System.Windows.Forms.Button();
            this.PlayButton3 = new System.Windows.Forms.Button();
            this.PlayButton2 = new System.Windows.Forms.Button();
            this.PlayButton1 = new System.Windows.Forms.Button();
            this.SoundMountain = new System.Windows.Forms.ComboBox();
            this.SoundJailBox = new System.Windows.Forms.ComboBox();
            this.SoundBombBox = new System.Windows.Forms.ComboBox();
            this.SoundOmomiBox = new System.Windows.Forms.ComboBox();
            this.SoundGekishinBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SoundLandslideBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SounbVolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(250, 15);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(62, 21);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "開始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "停止";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(237, 444);
            this.TestButton.Margin = new System.Windows.Forms.Padding(2);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(69, 27);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(6, 477);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Rest";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.SoundStopButton);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.SounbVolumeBar);
            this.groupBox1.Controls.Add(this.PlayButton6);
            this.groupBox1.Controls.Add(this.PlayButton5);
            this.groupBox1.Controls.Add(this.PlayButton4);
            this.groupBox1.Controls.Add(this.PlayButton3);
            this.groupBox1.Controls.Add(this.PlayButton2);
            this.groupBox1.Controls.Add(this.PlayButton1);
            this.groupBox1.Controls.Add(this.SoundMountain);
            this.groupBox1.Controls.Add(this.SoundJailBox);
            this.groupBox1.Controls.Add(this.SoundBombBox);
            this.groupBox1.Controls.Add(this.SoundOmomiBox);
            this.groupBox1.Controls.Add(this.SoundGekishinBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SoundLandslideBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 258);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "アラーム音設定";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "音源は実行フォルダ内の\"sounds\"に入れてください";
            // 
            // SoundStopButton
            // 
            this.SoundStopButton.Location = new System.Drawing.Point(232, 210);
            this.SoundStopButton.Name = "SoundStopButton";
            this.SoundStopButton.Size = new System.Drawing.Size(45, 23);
            this.SoundStopButton.TabIndex = 20;
            this.SoundStopButton.Text = "停止";
            this.SoundStopButton.UseVisualStyleBackColor = true;
            this.SoundStopButton.Click += new System.EventHandler(this.SoundStopButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "音量";
            // 
            // SounbVolumeBar
            // 
            this.SounbVolumeBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Infoman.Properties.Settings.Default, "SoundVolume", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SounbVolumeBar.Location = new System.Drawing.Point(108, 210);
            this.SounbVolumeBar.Name = "SounbVolumeBar";
            this.SounbVolumeBar.Size = new System.Drawing.Size(118, 45);
            this.SounbVolumeBar.TabIndex = 18;
            this.SounbVolumeBar.Value = global::Infoman.Properties.Settings.Default.SoundVolume;
            this.SounbVolumeBar.Scroll += new System.EventHandler(this.SounbVolumeBar_Scroll);
            // 
            // PlayButton6
            // 
            this.PlayButton6.Location = new System.Drawing.Point(232, 181);
            this.PlayButton6.Name = "PlayButton6";
            this.PlayButton6.Size = new System.Drawing.Size(45, 23);
            this.PlayButton6.TabIndex = 17;
            this.PlayButton6.Text = "再生";
            this.PlayButton6.UseVisualStyleBackColor = true;
            this.PlayButton6.Click += new System.EventHandler(this.PlayButton6_Click);
            // 
            // PlayButton5
            // 
            this.PlayButton5.Location = new System.Drawing.Point(232, 154);
            this.PlayButton5.Name = "PlayButton5";
            this.PlayButton5.Size = new System.Drawing.Size(45, 23);
            this.PlayButton5.TabIndex = 16;
            this.PlayButton5.Text = "再生";
            this.PlayButton5.UseVisualStyleBackColor = true;
            this.PlayButton5.Click += new System.EventHandler(this.PlayButton5_Click);
            // 
            // PlayButton4
            // 
            this.PlayButton4.Location = new System.Drawing.Point(232, 130);
            this.PlayButton4.Name = "PlayButton4";
            this.PlayButton4.Size = new System.Drawing.Size(45, 23);
            this.PlayButton4.TabIndex = 15;
            this.PlayButton4.Text = "再生";
            this.PlayButton4.UseVisualStyleBackColor = true;
            this.PlayButton4.Click += new System.EventHandler(this.PlayButton4_Click);
            // 
            // PlayButton3
            // 
            this.PlayButton3.Location = new System.Drawing.Point(232, 104);
            this.PlayButton3.Name = "PlayButton3";
            this.PlayButton3.Size = new System.Drawing.Size(45, 23);
            this.PlayButton3.TabIndex = 14;
            this.PlayButton3.Text = "再生";
            this.PlayButton3.UseVisualStyleBackColor = true;
            this.PlayButton3.Click += new System.EventHandler(this.PlayButton3_Click);
            // 
            // PlayButton2
            // 
            this.PlayButton2.Location = new System.Drawing.Point(232, 75);
            this.PlayButton2.Name = "PlayButton2";
            this.PlayButton2.Size = new System.Drawing.Size(45, 23);
            this.PlayButton2.TabIndex = 13;
            this.PlayButton2.Text = "再生";
            this.PlayButton2.UseVisualStyleBackColor = true;
            this.PlayButton2.Click += new System.EventHandler(this.PlayButton2_Click);
            // 
            // PlayButton1
            // 
            this.PlayButton1.Location = new System.Drawing.Point(232, 46);
            this.PlayButton1.Name = "PlayButton1";
            this.PlayButton1.Size = new System.Drawing.Size(45, 23);
            this.PlayButton1.TabIndex = 12;
            this.PlayButton1.Text = "再生";
            this.PlayButton1.UseVisualStyleBackColor = true;
            this.PlayButton1.Click += new System.EventHandler(this.PlayButton1_Click);
            // 
            // SoundMountain
            // 
            this.SoundMountain.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Infoman.Properties.Settings.Default, "MountainSoundFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SoundMountain.FormattingEnabled = true;
            this.SoundMountain.Location = new System.Drawing.Point(108, 181);
            this.SoundMountain.Name = "SoundMountain";
            this.SoundMountain.Size = new System.Drawing.Size(118, 23);
            this.SoundMountain.TabIndex = 11;
            this.SoundMountain.Text = global::Infoman.Properties.Settings.Default.MountainSoundFile;
            this.SoundMountain.SelectedIndexChanged += new System.EventHandler(this.SoundBox_SelectedIndexChanged);
            // 
            // SoundJailBox
            // 
            this.SoundJailBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Infoman.Properties.Settings.Default, "JailSoundFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SoundJailBox.FormattingEnabled = true;
            this.SoundJailBox.Location = new System.Drawing.Point(108, 154);
            this.SoundJailBox.Name = "SoundJailBox";
            this.SoundJailBox.Size = new System.Drawing.Size(118, 23);
            this.SoundJailBox.TabIndex = 10;
            this.SoundJailBox.Text = global::Infoman.Properties.Settings.Default.JailSoundFile;
            this.SoundJailBox.SelectedIndexChanged += new System.EventHandler(this.SoundBox_SelectedIndexChanged);
            // 
            // SoundBombBox
            // 
            this.SoundBombBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Infoman.Properties.Settings.Default, "BombSoundFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SoundBombBox.FormattingEnabled = true;
            this.SoundBombBox.Location = new System.Drawing.Point(108, 127);
            this.SoundBombBox.Name = "SoundBombBox";
            this.SoundBombBox.Size = new System.Drawing.Size(118, 23);
            this.SoundBombBox.TabIndex = 9;
            this.SoundBombBox.Text = global::Infoman.Properties.Settings.Default.BombSoundFile;
            this.SoundBombBox.SelectedIndexChanged += new System.EventHandler(this.SoundBox_SelectedIndexChanged);
            // 
            // SoundOmomiBox
            // 
            this.SoundOmomiBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Infoman.Properties.Settings.Default, "OmomiSoundFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SoundOmomiBox.FormattingEnabled = true;
            this.SoundOmomiBox.Location = new System.Drawing.Point(108, 102);
            this.SoundOmomiBox.Name = "SoundOmomiBox";
            this.SoundOmomiBox.Size = new System.Drawing.Size(118, 23);
            this.SoundOmomiBox.TabIndex = 8;
            this.SoundOmomiBox.Text = global::Infoman.Properties.Settings.Default.OmomiSoundFile;
            this.SoundOmomiBox.SelectedIndexChanged += new System.EventHandler(this.SoundBox_SelectedIndexChanged);
            // 
            // SoundGekishinBox
            // 
            this.SoundGekishinBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Infoman.Properties.Settings.Default, "GekishinSoundFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SoundGekishinBox.FormattingEnabled = true;
            this.SoundGekishinBox.Location = new System.Drawing.Point(108, 73);
            this.SoundGekishinBox.Name = "SoundGekishinBox";
            this.SoundGekishinBox.Size = new System.Drawing.Size(118, 23);
            this.SoundGekishinBox.TabIndex = 7;
            this.SoundGekishinBox.Text = global::Infoman.Properties.Settings.Default.GekishinSoundFile;
            this.SoundGekishinBox.SelectedIndexChanged += new System.EventHandler(this.SoundBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "マウンテンバスター";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "グラナイト・ジェイル";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "ボムボルダー";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "大地の重み";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "激震";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "ランドスライド";
            // 
            // SoundLandslideBox
            // 
            this.SoundLandslideBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Infoman.Properties.Settings.Default, "LandslideSoundFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SoundLandslideBox.FormattingEnabled = true;
            this.SoundLandslideBox.Location = new System.Drawing.Point(108, 46);
            this.SoundLandslideBox.Name = "SoundLandslideBox";
            this.SoundLandslideBox.Size = new System.Drawing.Size(118, 23);
            this.SoundLandslideBox.TabIndex = 0;
            this.SoundLandslideBox.Text = global::Infoman.Properties.Settings.Default.LandslideSoundFile;
            this.SoundLandslideBox.SelectedIndexChanged += new System.EventHandler(this.SoundBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 311);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(315, 68);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(74, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "みちゃった？　これはデバッグ用よ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 384);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "たこたんいんふぉ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SounbVolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SoundLandslideBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar SounbVolumeBar;
        private System.Windows.Forms.Button PlayButton6;
        private System.Windows.Forms.Button PlayButton5;
        private System.Windows.Forms.Button PlayButton4;
        private System.Windows.Forms.Button PlayButton3;
        private System.Windows.Forms.Button PlayButton2;
        private System.Windows.Forms.Button PlayButton1;
        private System.Windows.Forms.ComboBox SoundMountain;
        private System.Windows.Forms.ComboBox SoundJailBox;
        private System.Windows.Forms.ComboBox SoundBombBox;
        private System.Windows.Forms.ComboBox SoundOmomiBox;
        private System.Windows.Forms.ComboBox SoundGekishinBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SoundStopButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;

    }
}

