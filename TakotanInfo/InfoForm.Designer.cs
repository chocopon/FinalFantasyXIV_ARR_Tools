namespace Infoman
{
    partial class InfoForm
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
            this.PhaseLabel = new System.Windows.Forms.Label();
            this.NextActionLabel = new System.Windows.Forms.Label();
            this.NextNextActionLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhaseLabel
            // 
            this.PhaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhaseLabel.AutoSize = true;
            this.PhaseLabel.BackColor = System.Drawing.Color.Black;
            this.PhaseLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PhaseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PhaseLabel.Location = new System.Drawing.Point(161, 9);
            this.PhaseLabel.Name = "PhaseLabel";
            this.PhaseLabel.Size = new System.Drawing.Size(70, 20);
            this.PhaseLabel.TabIndex = 0;
            this.PhaseLabel.Text = "phase 1";
            // 
            // NextActionLabel
            // 
            this.NextActionLabel.AutoSize = true;
            this.NextActionLabel.BackColor = System.Drawing.Color.Black;
            this.NextActionLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NextActionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NextActionLabel.Location = new System.Drawing.Point(12, 40);
            this.NextActionLabel.Name = "NextActionLabel";
            this.NextActionLabel.Size = new System.Drawing.Size(110, 20);
            this.NextActionLabel.TabIndex = 1;
            this.NextActionLabel.Text = "→ ランドスライド";
            // 
            // NextNextActionLabel
            // 
            this.NextNextActionLabel.AutoSize = true;
            this.NextNextActionLabel.BackColor = System.Drawing.Color.Black;
            this.NextNextActionLabel.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NextNextActionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NextNextActionLabel.Location = new System.Drawing.Point(19, 67);
            this.NextNextActionLabel.Name = "NextNextActionLabel";
            this.NextNextActionLabel.Size = new System.Drawing.Size(64, 17);
            this.NextNextActionLabel.TabIndex = 2;
            this.NextNextActionLabel.Text = "→→ 激震";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(156, 40);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "激震";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(188, 69);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(43, 15);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "停止中";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(243, 104);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NextNextActionLabel);
            this.Controls.Add(this.NextActionLabel);
            this.Controls.Add(this.PhaseLabel);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.InfoForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseEnter += new System.EventHandler(this.InfoForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.InfoForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhaseLabel;
        private System.Windows.Forms.Label NextActionLabel;
        private System.Windows.Forms.Label NextNextActionLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
    }
}