namespace FF14FastReport
{
    partial class FastReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LastTimeLabel = new System.Windows.Forms.Label();
            this.TotalDmgLabel = new System.Windows.Forms.Label();
            this.HitLabel = new System.Windows.Forms.Label();
            this.DpsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fF14FastReportDataSet = new FF14FastReport.FF14FastReportDataSet();
            this.reportlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fF14FastReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportlogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.LastTimeLabel);
            this.flowLayoutPanel2.Controls.Add(this.TotalDmgLabel);
            this.flowLayoutPanel2.Controls.Add(this.HitLabel);
            this.flowLayoutPanel2.Controls.Add(this.DpsLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 8);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(367, 13);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // LastTimeLabel
            // 
            this.LastTimeLabel.AutoSize = true;
            this.LastTimeLabel.ForeColor = System.Drawing.Color.White;
            this.LastTimeLabel.Location = new System.Drawing.Point(3, 0);
            this.LastTimeLabel.Name = "LastTimeLabel";
            this.LastTimeLabel.Size = new System.Drawing.Size(45, 12);
            this.LastTimeLabel.TabIndex = 0;
            this.LastTimeLabel.Text = "00:00:00";
            // 
            // TotalDmgLabel
            // 
            this.TotalDmgLabel.AutoSize = true;
            this.TotalDmgLabel.ForeColor = System.Drawing.Color.White;
            this.TotalDmgLabel.Location = new System.Drawing.Point(54, 0);
            this.TotalDmgLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.TotalDmgLabel.Name = "TotalDmgLabel";
            this.TotalDmgLabel.Size = new System.Drawing.Size(38, 12);
            this.TotalDmgLabel.TabIndex = 1;
            this.TotalDmgLabel.Text = "total 0";
            // 
            // HitLabel
            // 
            this.HitLabel.AutoSize = true;
            this.HitLabel.ForeColor = System.Drawing.Color.White;
            this.HitLabel.Location = new System.Drawing.Point(98, 0);
            this.HitLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.HitLabel.Name = "HitLabel";
            this.HitLabel.Size = new System.Drawing.Size(64, 12);
            this.HitLabel.TabIndex = 2;
            this.HitLabel.Text = "hit 0/0 0.0%";
            // 
            // DpsLabel
            // 
            this.DpsLabel.AutoSize = true;
            this.DpsLabel.ForeColor = System.Drawing.Color.White;
            this.DpsLabel.Location = new System.Drawing.Point(168, 0);
            this.DpsLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.DpsLabel.Name = "DpsLabel";
            this.DpsLabel.Size = new System.Drawing.Size(33, 12);
            this.DpsLabel.TabIndex = 3;
            this.DpsLabel.Text = "dps 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportlogBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(5, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(400, 175);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.flowLayoutPanel1_MouseEnter);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.flowLayoutPanel1_MouseLeave);
            // 
            // fF14FastReportDataSet
            // 
            this.fF14FastReportDataSet.DataSetName = "FF14FastReportDataSet";
            this.fF14FastReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportlogBindingSource
            // 
            this.reportlogBindingSource.DataMember = "Reportlog";
            this.reportlogBindingSource.DataSource = this.fF14FastReportDataSet;
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            this.reportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(385, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "×";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FastReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(410, 210);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(200, 25);
            this.Name = "FastReportForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LayerdMouseTransForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LayerdMouseTransForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.flowLayoutPanel1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.flowLayoutPanel1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LayerdMouseTransForm_MouseMove);
            this.Resize += new System.EventHandler(this.LayerdMouseTransForm_Resize);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fF14FastReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportlogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LastTimeLabel;
        private System.Windows.Forms.Label TotalDmgLabel;
        private System.Windows.Forms.Label HitLabel;
        private System.Windows.Forms.Label DpsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource reportlogBindingSource;
        private FF14FastReportDataSet fF14FastReportDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CloseButton;



    }
}