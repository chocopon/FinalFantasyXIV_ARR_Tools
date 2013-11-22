namespace FF14FastReport
{
    partial class OpenGameLogFolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenGameLogFolderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fF14FastReportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fF14FastReportDataSet = new FF14FastReport.FF14FastReportDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLoggedinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPlayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OtherFolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fF14FastReportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fF14FastReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ユーザーフォルダ一覧：";
            // 
            // fF14FastReportDataSetBindingSource
            // 
            this.fF14FastReportDataSetBindingSource.DataMember = "CharactorFolder";
            this.fF14FastReportDataSetBindingSource.DataSource = this.fF14FastReportDataSet;
            // 
            // fF14FastReportDataSet
            // 
            this.fF14FastReportDataSet.DataSetName = "FF14FastReportDataSet";
            this.fF14FastReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverNameDataGridViewTextBoxColumn,
            this.charNameDataGridViewTextBoxColumn,
            this.folderNameDataGridViewTextBoxColumn,
            this.lastLoggedinDataGridViewTextBoxColumn,
            this.lastPlayDataGridViewTextBoxColumn,
            this.fullPathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fF14FastReportDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(473, 115);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // serverNameDataGridViewTextBoxColumn
            // 
            this.serverNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.serverNameDataGridViewTextBoxColumn.DataPropertyName = "ServerName";
            this.serverNameDataGridViewTextBoxColumn.HeaderText = "Server";
            this.serverNameDataGridViewTextBoxColumn.Name = "serverNameDataGridViewTextBoxColumn";
            this.serverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.serverNameDataGridViewTextBoxColumn.Width = 71;
            // 
            // charNameDataGridViewTextBoxColumn
            // 
            this.charNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.charNameDataGridViewTextBoxColumn.DataPropertyName = "CharName";
            this.charNameDataGridViewTextBoxColumn.HeaderText = "Char";
            this.charNameDataGridViewTextBoxColumn.Name = "charNameDataGridViewTextBoxColumn";
            this.charNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.charNameDataGridViewTextBoxColumn.Width = 59;
            // 
            // folderNameDataGridViewTextBoxColumn
            // 
            this.folderNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.folderNameDataGridViewTextBoxColumn.DataPropertyName = "FolderName";
            this.folderNameDataGridViewTextBoxColumn.HeaderText = "Folder";
            this.folderNameDataGridViewTextBoxColumn.Name = "folderNameDataGridViewTextBoxColumn";
            this.folderNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.folderNameDataGridViewTextBoxColumn.Width = 68;
            // 
            // lastLoggedinDataGridViewTextBoxColumn
            // 
            this.lastLoggedinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastLoggedinDataGridViewTextBoxColumn.DataPropertyName = "LastLoggedin";
            this.lastLoggedinDataGridViewTextBoxColumn.HeaderText = "LastLogin";
            this.lastLoggedinDataGridViewTextBoxColumn.Name = "lastLoggedinDataGridViewTextBoxColumn";
            this.lastLoggedinDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastLoggedinDataGridViewTextBoxColumn.Width = 88;
            // 
            // lastPlayDataGridViewTextBoxColumn
            // 
            this.lastPlayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastPlayDataGridViewTextBoxColumn.DataPropertyName = "LastPlay";
            this.lastPlayDataGridViewTextBoxColumn.HeaderText = "LastPlay";
            this.lastPlayDataGridViewTextBoxColumn.Name = "lastPlayDataGridViewTextBoxColumn";
            this.lastPlayDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastPlayDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullPathDataGridViewTextBoxColumn
            // 
            this.fullPathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullPathDataGridViewTextBoxColumn.DataPropertyName = "FullPath";
            this.fullPathDataGridViewTextBoxColumn.HeaderText = "FullPath";
            this.fullPathDataGridViewTextBoxColumn.Name = "fullPathDataGridViewTextBoxColumn";
            this.fullPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(152, 222);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(87, 29);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(247, 222);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 29);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OtherFolderButton
            // 
            this.OtherFolderButton.Location = new System.Drawing.Point(422, 191);
            this.OtherFolderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OtherFolderButton.Name = "OtherFolderButton";
            this.OtherFolderButton.Size = new System.Drawing.Size(48, 23);
            this.OtherFolderButton.TabIndex = 6;
            this.OtherFolderButton.Text = "...";
            this.OtherFolderButton.UseVisualStyleBackColor = true;
            this.OtherFolderButton.Click += new System.EventHandler(this.OtherFolderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ユーザーフォルダの一覧もしくは、その他のログフォルダからログフォルダを選択してください。";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(74, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "選択フォルダ";
            // 
            // OpenGameLogFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OtherFolderButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OpenGameLogFolderForm";
            this.Text = "ログファイルのあるフォルダを選択してください";
            this.Load += new System.EventHandler(this.OpenGameLogFolderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fF14FastReportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fF14FastReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fF14FastReportDataSetBindingSource;
        private FF14FastReportDataSet fF14FastReportDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastLoggedinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPlayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OtherFolderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}