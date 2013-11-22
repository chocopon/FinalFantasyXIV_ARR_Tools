namespace FF14FastReport
{
    partial class RankingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingForm));
            this.fF14FastReportDataSet = new FF14FastReport.FF14FastReportDataSet();
            this.dPSReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dPSReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DotValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxDPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.データリセットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.幅自動調整ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高さ自動調整ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.フィットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.マウス透過ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pT表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemy表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LogTextLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fF14FastReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dPSReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dPSReportDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fF14FastReportDataSet
            // 
            this.fF14FastReportDataSet.DataSetName = "FF14FastReportDataSet";
            this.fF14FastReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dPSReportBindingSource
            // 
            this.dPSReportBindingSource.DataMember = "DPSReport";
            this.dPSReportBindingSource.DataSource = this.fF14FastReportDataSet;
            // 
            // dPSReportDataGridView
            // 
            this.dPSReportDataGridView.AllowUserToAddRows = false;
            this.dPSReportDataGridView.AllowUserToDeleteRows = false;
            this.dPSReportDataGridView.AllowUserToResizeColumns = false;
            this.dPSReportDataGridView.AllowUserToResizeRows = false;
            this.dPSReportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dPSReportDataGridView.AutoGenerateColumns = false;
            this.dPSReportDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.dPSReportDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dPSReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dPSReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dPSReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.DDValue,
            this.DotValue,
            this.dataGridViewTextBoxColumn7,
            this.MaxDPS,
            this.dataGridViewTextBoxColumn4});
            this.dPSReportDataGridView.DataSource = this.dPSReportBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dPSReportDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.dPSReportDataGridView.Enabled = false;
            this.dPSReportDataGridView.EnableHeadersVisualStyles = false;
            this.dPSReportDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dPSReportDataGridView.Location = new System.Drawing.Point(5, 5);
            this.dPSReportDataGridView.Name = "dPSReportDataGridView";
            this.dPSReportDataGridView.ReadOnly = true;
            this.dPSReportDataGridView.RowHeadersVisible = false;
            this.dPSReportDataGridView.RowTemplate.Height = 21;
            this.dPSReportDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dPSReportDataGridView.Size = new System.Drawing.Size(310, 193);
            this.dPSReportDataGridView.TabIndex = 1;
            this.dPSReportDataGridView.DefaultCellStyleChanged += new System.EventHandler(this.dPSReportDataGridView_DefaultCellStyleChanged);
            this.dPSReportDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dPSReportDataGridView_RowsAdded);
            this.dPSReportDataGridView.Resize += new System.EventHandler(this.dPSReportDataGridView_Resize);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 48;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TotalDmg";
            dataGridViewCellStyle3.Format = "0";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 43;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DPS";
            dataGridViewCellStyle4.Format = "0.00";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn9.HeaderText = "DPS";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 37;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AtkHit";
            dataGridViewCellStyle5.Format = "0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "Hit";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 29;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HitRate";
            dataGridViewCellStyle6.Format = "0.00";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "%";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 25;
            // 
            // DDValue
            // 
            this.DDValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DDValue.DataPropertyName = "DDValue";
            this.DDValue.HeaderText = "DD";
            this.DDValue.MinimumWidth = 20;
            this.DDValue.Name = "DDValue";
            this.DDValue.ReadOnly = true;
            this.DDValue.Width = 49;
            // 
            // DotValue
            // 
            this.DotValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DotValue.DataPropertyName = "DotValue";
            this.DotValue.HeaderText = "DoT";
            this.DotValue.MinimumWidth = 20;
            this.DotValue.Name = "DotValue";
            this.DotValue.ReadOnly = true;
            this.DotValue.Width = 55;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaxDmg";
            dataGridViewCellStyle7.Format = "0";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn7.HeaderText = "MaxDmg";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // MaxDPS
            // 
            this.MaxDPS.DataPropertyName = "MaxDPS";
            dataGridViewCellStyle8.Format = "0.00";
            this.MaxDPS.DefaultCellStyle = dataGridViewCellStyle8;
            this.MaxDPS.HeaderText = "MaxDPS";
            this.MaxDPS.MinimumWidth = 20;
            this.MaxDPS.Name = "MaxDPS";
            this.MaxDPS.ReadOnly = true;
            this.MaxDPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AtkTotal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Atk";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(302, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            this.button1.MouseEnter += new System.EventHandler(this.RankingForm_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.RankingForm_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データリセットToolStripMenuItem,
            this.toolStripSeparator3,
            this.幅自動調整ToolStripMenuItem,
            this.高さ自動調整ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.フィットToolStripMenuItem,
            this.マウス透過ToolStripMenuItem,
            this.toolStripSeparator2,
            this.pT表示ToolStripMenuItem,
            this.enemy表示ToolStripMenuItem,
            this.toolStripSeparator1,
            this.閉じるToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(269, 242);
            // 
            // データリセットToolStripMenuItem
            // 
            this.データリセットToolStripMenuItem.Name = "データリセットToolStripMenuItem";
            this.データリセットToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.データリセットToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.データリセットToolStripMenuItem.Text = "データリセット";
            this.データリセットToolStripMenuItem.Click += new System.EventHandler(this.データリセットToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(265, 6);
            // 
            // 幅自動調整ToolStripMenuItem
            // 
            this.幅自動調整ToolStripMenuItem.Checked = true;
            this.幅自動調整ToolStripMenuItem.CheckOnClick = true;
            this.幅自動調整ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.幅自動調整ToolStripMenuItem.Name = "幅自動調整ToolStripMenuItem";
            this.幅自動調整ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.幅自動調整ToolStripMenuItem.Text = "幅自動調整";
            this.幅自動調整ToolStripMenuItem.ToolTipText = "表示内容にあわせてフォームの幅を自動調整します";
            this.幅自動調整ToolStripMenuItem.Click += new System.EventHandler(this.幅自動調整ToolStripMenuItem_Click);
            // 
            // 高さ自動調整ToolStripMenuItem
            // 
            this.高さ自動調整ToolStripMenuItem.Checked = true;
            this.高さ自動調整ToolStripMenuItem.CheckOnClick = true;
            this.高さ自動調整ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.高さ自動調整ToolStripMenuItem.Name = "高さ自動調整ToolStripMenuItem";
            this.高さ自動調整ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.高さ自動調整ToolStripMenuItem.Text = "高さ自動調整";
            this.高さ自動調整ToolStripMenuItem.ToolTipText = "内容にあわせてフォームの高さを自動調整します";
            this.高さ自動調整ToolStripMenuItem.Click += new System.EventHandler(this.高さ自動調整ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(268, 22);
            this.toolStripMenuItem1.Text = "ログ表示";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // フィットToolStripMenuItem
            // 
            this.フィットToolStripMenuItem.Name = "フィットToolStripMenuItem";
            this.フィットToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.フィットToolStripMenuItem.Text = "表示データにサイズをフィットする";
            this.フィットToolStripMenuItem.ToolTipText = "現在のデータにあわせてフォームサイズを調整します。";
            this.フィットToolStripMenuItem.Click += new System.EventHandler(this.フィットToolStripMenuItem_Click);
            // 
            // マウス透過ToolStripMenuItem
            // 
            this.マウス透過ToolStripMenuItem.Name = "マウス透過ToolStripMenuItem";
            this.マウス透過ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.マウス透過ToolStripMenuItem.Text = "マウス透過";
            this.マウス透過ToolStripMenuItem.ToolTipText = "マウスを透過させます。戻すにはメインフォームで透過のチェックを外して下さい。";
            this.マウス透過ToolStripMenuItem.Click += new System.EventHandler(this.マウス透過ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(265, 6);
            // 
            // pT表示ToolStripMenuItem
            // 
            this.pT表示ToolStripMenuItem.Checked = true;
            this.pT表示ToolStripMenuItem.CheckOnClick = true;
            this.pT表示ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pT表示ToolStripMenuItem.Name = "pT表示ToolStripMenuItem";
            this.pT表示ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.pT表示ToolStripMenuItem.Text = "PTメンバー表示";
            this.pT表示ToolStripMenuItem.Click += new System.EventHandler(this.pT表示ToolStripMenuItem_Click);
            // 
            // enemy表示ToolStripMenuItem
            // 
            this.enemy表示ToolStripMenuItem.Checked = true;
            this.enemy表示ToolStripMenuItem.CheckOnClick = true;
            this.enemy表示ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enemy表示ToolStripMenuItem.Name = "enemy表示ToolStripMenuItem";
            this.enemy表示ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.enemy表示ToolStripMenuItem.Text = "Enemy表示";
            this.enemy表示ToolStripMenuItem.Click += new System.EventHandler(this.enemy表示ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.閉じるToolStripMenuItem.Text = "閉じる(&X)";
            this.閉じるToolStripMenuItem.Click += new System.EventHandler(this.閉じるToolStripMenuItem_Click);
            // 
            // LogTextLabel
            // 
            this.LogTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextLabel.BackColor = System.Drawing.Color.Black;
            this.LogTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTextLabel.Enabled = false;
            this.LogTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogTextLabel.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.LogTextLabel.ForeColor = System.Drawing.Color.Cyan;
            this.LogTextLabel.Location = new System.Drawing.Point(5, 182);
            this.LogTextLabel.Name = "LogTextLabel";
            this.LogTextLabel.Size = new System.Drawing.Size(310, 14);
            this.LogTextLabel.TabIndex = 3;
            this.LogTextLabel.Text = "...";
            this.LogTextLabel.Click += new System.EventHandler(this.LogTextLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AtkTotal";
            dataGridViewCellStyle10.Format = "0.00";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn8.HeaderText = "Total";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DPS";
            dataGridViewCellStyle11.Format = "0.00";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn10.HeaderText = "DPS";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MaxDPS";
            dataGridViewCellStyle12.Format = "0.00";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn11.HeaderText = "MaxDPS";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogTextLabel);
            this.Controls.Add(this.dPSReportDataGridView);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RankingForm";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Text = "DPS表示";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RankingForm_Load);
            this.Shown += new System.EventHandler(this.RankingForm_Shown);
            this.LocationChanged += new System.EventHandler(this.RankingForm_LocationChanged);
            this.DoubleClick += new System.EventHandler(this.RankingForm_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RankingForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.RankingForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.RankingForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RankingForm_MouseMove);
            this.Resize += new System.EventHandler(this.RankingForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fF14FastReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dPSReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dPSReportDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FF14FastReportDataSet fF14FastReportDataSet;
        private System.Windows.Forms.BindingSource dPSReportBindingSource;
        private System.Windows.Forms.DataGridView dPSReportDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 幅自動調整ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高さ自動調整ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem マウス透過ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フィットToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
        private System.Windows.Forms.Label LogTextLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem データリセットToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripMenuItem pT表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemy表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DotValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxDPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}