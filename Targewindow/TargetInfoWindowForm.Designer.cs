namespace Targewindow
{
    partial class TargetInfoWindowForm
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
            this.TargetNameLabel = new System.Windows.Forms.Label();
            this.TargetHPLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TargetNameLabel
            // 
            this.TargetNameLabel.AutoSize = true;
            this.TargetNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TargetNameLabel.Location = new System.Drawing.Point(14, 9);
            this.TargetNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TargetNameLabel.Name = "TargetNameLabel";
            this.TargetNameLabel.Size = new System.Drawing.Size(105, 20);
            this.TargetNameLabel.TabIndex = 0;
            this.TargetNameLabel.Text = "ターゲットネーム";
            // 
            // TargetHPLabel
            // 
            this.TargetHPLabel.AutoSize = true;
            this.TargetHPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TargetHPLabel.Location = new System.Drawing.Point(14, 35);
            this.TargetHPLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TargetHPLabel.Name = "TargetHPLabel";
            this.TargetHPLabel.Size = new System.Drawing.Size(116, 20);
            this.TargetHPLabel.TabIndex = 1;
            this.TargetHPLabel.Text = "65535/65535";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DistanceLabel.Location = new System.Drawing.Point(14, 66);
            this.DistanceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(109, 20);
            this.DistanceLabel.TabIndex = 3;
            this.DistanceLabel.Text = "dist.1234.56";
            // 
            // TargetInfoWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(218, 95);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.TargetHPLabel);
            this.Controls.Add(this.TargetNameLabel);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TargetInfoWindowForm";
            this.Text = "TargetInfo";
            this.Load += new System.EventHandler(this.TargetInfoWindowForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RankingForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.RankingForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.RankingForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RankingForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TargetNameLabel;
        private System.Windows.Forms.Label TargetHPLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DistanceLabel;
    }
}

