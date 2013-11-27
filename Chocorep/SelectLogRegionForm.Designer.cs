namespace FF14FastReport
{
    partial class SelectLogRegionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLogRegionForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ffxivLogDataSet1 = new FFXIV_Tools.FFXIVLogDataSet();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.IDStartEndBox = new System.Windows.Forms.CheckBox();
            this.SystemEventBox = new System.Windows.Forms.CheckBox();
            this.GameEventBox = new System.Windows.Forms.CheckBox();
            this.BattleLogBox = new System.Windows.Forms.CheckBox();
            this.AllLogBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isDamageDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isCureDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isHPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isMPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isTPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isHateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isBlockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isParryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDodgeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isCriticalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isBuffOnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDebuffOnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isBuffRemoveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDebuffRemoveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isInterruptedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDoneDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isKODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isContentStartDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isContentEndDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLevelSyncStartDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLevelSyncEndDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debuffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syncLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn13 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn14 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn15 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn16 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn17 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn18 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn19 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn20 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn21 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn22 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SystemEventBox2 = new System.Windows.Forms.CheckBox();
            this.IDStartEndBox2 = new System.Windows.Forms.CheckBox();
            this.GameEventBox2 = new System.Windows.Forms.CheckBox();
            this.BattleLogBox2 = new System.Windows.Forms.CheckBox();
            this.AllLogBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffxivLogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Anaylzed";
            this.bindingSource1.DataSource = this.ffxivLogDataSet1;
            // 
            // ffxivLogDataSet1
            // 
            this.ffxivLogDataSet1.DataSetName = "FFXIVLogDataSet";
            this.ffxivLogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Anaylzed";
            this.bindingSource2.DataSource = this.ffxivLogDataSet1;
            // 
            // IDStartEndBox
            // 
            this.IDStartEndBox.AutoSize = true;
            this.IDStartEndBox.Location = new System.Drawing.Point(6, 22);
            this.IDStartEndBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDStartEndBox.Name = "IDStartEndBox";
            this.IDStartEndBox.Size = new System.Drawing.Size(89, 16);
            this.IDStartEndBox.TabIndex = 2;
            this.IDStartEndBox.Text = "ID開始・終了";
            this.IDStartEndBox.UseVisualStyleBackColor = true;
            this.IDStartEndBox.CheckedChanged += new System.EventHandler(this.IDStartEndBox_CheckedChanged);
            // 
            // SystemEventBox
            // 
            this.SystemEventBox.AutoSize = true;
            this.SystemEventBox.Location = new System.Drawing.Point(117, 22);
            this.SystemEventBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SystemEventBox.Name = "SystemEventBox";
            this.SystemEventBox.Size = new System.Drawing.Size(98, 16);
            this.SystemEventBox.TabIndex = 3;
            this.SystemEventBox.Text = "システムイベント";
            this.SystemEventBox.UseVisualStyleBackColor = true;
            this.SystemEventBox.CheckedChanged += new System.EventHandler(this.IDStartEndBox_CheckedChanged);
            // 
            // GameEventBox
            // 
            this.GameEventBox.AutoSize = true;
            this.GameEventBox.Location = new System.Drawing.Point(238, 22);
            this.GameEventBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameEventBox.Name = "GameEventBox";
            this.GameEventBox.Size = new System.Drawing.Size(90, 16);
            this.GameEventBox.TabIndex = 4;
            this.GameEventBox.Text = "ゲームイベント";
            this.GameEventBox.UseVisualStyleBackColor = true;
            this.GameEventBox.CheckedChanged += new System.EventHandler(this.IDStartEndBox_CheckedChanged);
            // 
            // BattleLogBox
            // 
            this.BattleLogBox.AutoSize = true;
            this.BattleLogBox.Location = new System.Drawing.Point(7, 50);
            this.BattleLogBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BattleLogBox.Name = "BattleLogBox";
            this.BattleLogBox.Size = new System.Drawing.Size(66, 16);
            this.BattleLogBox.TabIndex = 5;
            this.BattleLogBox.Text = "戦闘ログ";
            this.BattleLogBox.UseVisualStyleBackColor = true;
            this.BattleLogBox.CheckedChanged += new System.EventHandler(this.IDStartEndBox_CheckedChanged);
            // 
            // AllLogBox
            // 
            this.AllLogBox.AutoSize = true;
            this.AllLogBox.Location = new System.Drawing.Point(238, 50);
            this.AllLogBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllLogBox.Name = "AllLogBox";
            this.AllLogBox.Size = new System.Drawing.Size(48, 16);
            this.AllLogBox.TabIndex = 6;
            this.AllLogBox.Text = "全部";
            this.AllLogBox.UseVisualStyleBackColor = true;
            this.AllLogBox.CheckedChanged += new System.EventHandler(this.IDStartEndBox_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isDamageDataGridViewCheckBoxColumn,
            this.isCureDataGridViewCheckBoxColumn,
            this.isHPDataGridViewCheckBoxColumn,
            this.isMPDataGridViewCheckBoxColumn,
            this.isTPDataGridViewCheckBoxColumn,
            this.isHateDataGridViewCheckBoxColumn,
            this.isBlockDataGridViewCheckBoxColumn,
            this.isParryDataGridViewCheckBoxColumn,
            this.isDodgeDataGridViewCheckBoxColumn,
            this.isCriticalDataGridViewCheckBoxColumn,
            this.isBuffOnDataGridViewCheckBoxColumn,
            this.isDebuffOnDataGridViewCheckBoxColumn,
            this.isBuffRemoveDataGridViewCheckBoxColumn,
            this.isDebuffRemoveDataGridViewCheckBoxColumn,
            this.isInterruptedDataGridViewCheckBoxColumn,
            this.isDoneDataGridViewCheckBoxColumn,
            this.isStartedDataGridViewCheckBoxColumn,
            this.isKODataGridViewCheckBoxColumn,
            this.isContentStartDataGridViewCheckBoxColumn,
            this.isContentEndDataGridViewCheckBoxColumn,
            this.isLevelSyncStartDataGridViewCheckBoxColumn,
            this.isLevelSyncEndDataGridViewCheckBoxColumn,
            this.iDDataGridViewTextBoxColumn1,
            this.totalSecondsDataGridViewTextBoxColumn,
            this.serverTimeDataGridViewTextBoxColumn,
            this.localTimeDataGridViewTextBoxColumn,
            this.logTypeDataGridViewTextBoxColumn,
            this.actionTypeDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.actionNameDataGridViewTextBoxColumn,
            this.buffNameDataGridViewTextBoxColumn,
            this.debuffNameDataGridViewTextBoxColumn,
            this.numericDataGridViewTextBoxColumn,
            this.bonusRateDataGridViewTextBoxColumn,
            this.contentNameDataGridViewTextBoxColumn,
            this.syncLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(432, 494);
            this.dataGridView1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dataGridView1, "解析範囲の始めを選択します。");
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // isDamageDataGridViewCheckBoxColumn
            // 
            this.isDamageDataGridViewCheckBoxColumn.DataPropertyName = "IsDamage";
            this.isDamageDataGridViewCheckBoxColumn.HeaderText = "IsDamage";
            this.isDamageDataGridViewCheckBoxColumn.Name = "isDamageDataGridViewCheckBoxColumn";
            this.isDamageDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDamageDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isCureDataGridViewCheckBoxColumn
            // 
            this.isCureDataGridViewCheckBoxColumn.DataPropertyName = "IsCure";
            this.isCureDataGridViewCheckBoxColumn.HeaderText = "IsCure";
            this.isCureDataGridViewCheckBoxColumn.Name = "isCureDataGridViewCheckBoxColumn";
            this.isCureDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCureDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isHPDataGridViewCheckBoxColumn
            // 
            this.isHPDataGridViewCheckBoxColumn.DataPropertyName = "IsHP";
            this.isHPDataGridViewCheckBoxColumn.HeaderText = "IsHP";
            this.isHPDataGridViewCheckBoxColumn.Name = "isHPDataGridViewCheckBoxColumn";
            this.isHPDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isHPDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isMPDataGridViewCheckBoxColumn
            // 
            this.isMPDataGridViewCheckBoxColumn.DataPropertyName = "IsMP";
            this.isMPDataGridViewCheckBoxColumn.HeaderText = "IsMP";
            this.isMPDataGridViewCheckBoxColumn.Name = "isMPDataGridViewCheckBoxColumn";
            this.isMPDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isMPDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isTPDataGridViewCheckBoxColumn
            // 
            this.isTPDataGridViewCheckBoxColumn.DataPropertyName = "IsTP";
            this.isTPDataGridViewCheckBoxColumn.HeaderText = "IsTP";
            this.isTPDataGridViewCheckBoxColumn.Name = "isTPDataGridViewCheckBoxColumn";
            this.isTPDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isTPDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isHateDataGridViewCheckBoxColumn
            // 
            this.isHateDataGridViewCheckBoxColumn.DataPropertyName = "IsHate";
            this.isHateDataGridViewCheckBoxColumn.HeaderText = "IsHate";
            this.isHateDataGridViewCheckBoxColumn.Name = "isHateDataGridViewCheckBoxColumn";
            this.isHateDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isHateDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isBlockDataGridViewCheckBoxColumn
            // 
            this.isBlockDataGridViewCheckBoxColumn.DataPropertyName = "IsBlock";
            this.isBlockDataGridViewCheckBoxColumn.HeaderText = "IsBlock";
            this.isBlockDataGridViewCheckBoxColumn.Name = "isBlockDataGridViewCheckBoxColumn";
            this.isBlockDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBlockDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isParryDataGridViewCheckBoxColumn
            // 
            this.isParryDataGridViewCheckBoxColumn.DataPropertyName = "IsParry";
            this.isParryDataGridViewCheckBoxColumn.HeaderText = "IsParry";
            this.isParryDataGridViewCheckBoxColumn.Name = "isParryDataGridViewCheckBoxColumn";
            this.isParryDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isParryDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isDodgeDataGridViewCheckBoxColumn
            // 
            this.isDodgeDataGridViewCheckBoxColumn.DataPropertyName = "IsDodge";
            this.isDodgeDataGridViewCheckBoxColumn.HeaderText = "IsDodge";
            this.isDodgeDataGridViewCheckBoxColumn.Name = "isDodgeDataGridViewCheckBoxColumn";
            this.isDodgeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDodgeDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isCriticalDataGridViewCheckBoxColumn
            // 
            this.isCriticalDataGridViewCheckBoxColumn.DataPropertyName = "IsCritical";
            this.isCriticalDataGridViewCheckBoxColumn.HeaderText = "IsCritical";
            this.isCriticalDataGridViewCheckBoxColumn.Name = "isCriticalDataGridViewCheckBoxColumn";
            this.isCriticalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCriticalDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isBuffOnDataGridViewCheckBoxColumn
            // 
            this.isBuffOnDataGridViewCheckBoxColumn.DataPropertyName = "IsBuffOn";
            this.isBuffOnDataGridViewCheckBoxColumn.HeaderText = "IsBuffOn";
            this.isBuffOnDataGridViewCheckBoxColumn.Name = "isBuffOnDataGridViewCheckBoxColumn";
            this.isBuffOnDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBuffOnDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isDebuffOnDataGridViewCheckBoxColumn
            // 
            this.isDebuffOnDataGridViewCheckBoxColumn.DataPropertyName = "IsDebuffOn";
            this.isDebuffOnDataGridViewCheckBoxColumn.HeaderText = "IsDebuffOn";
            this.isDebuffOnDataGridViewCheckBoxColumn.Name = "isDebuffOnDataGridViewCheckBoxColumn";
            this.isDebuffOnDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDebuffOnDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isBuffRemoveDataGridViewCheckBoxColumn
            // 
            this.isBuffRemoveDataGridViewCheckBoxColumn.DataPropertyName = "IsBuffRemove";
            this.isBuffRemoveDataGridViewCheckBoxColumn.HeaderText = "IsBuffRemove";
            this.isBuffRemoveDataGridViewCheckBoxColumn.Name = "isBuffRemoveDataGridViewCheckBoxColumn";
            this.isBuffRemoveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBuffRemoveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isDebuffRemoveDataGridViewCheckBoxColumn
            // 
            this.isDebuffRemoveDataGridViewCheckBoxColumn.DataPropertyName = "IsDebuffRemove";
            this.isDebuffRemoveDataGridViewCheckBoxColumn.HeaderText = "IsDebuffRemove";
            this.isDebuffRemoveDataGridViewCheckBoxColumn.Name = "isDebuffRemoveDataGridViewCheckBoxColumn";
            this.isDebuffRemoveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDebuffRemoveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isInterruptedDataGridViewCheckBoxColumn
            // 
            this.isInterruptedDataGridViewCheckBoxColumn.DataPropertyName = "IsInterrupted";
            this.isInterruptedDataGridViewCheckBoxColumn.HeaderText = "IsInterrupted";
            this.isInterruptedDataGridViewCheckBoxColumn.Name = "isInterruptedDataGridViewCheckBoxColumn";
            this.isInterruptedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isInterruptedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isDoneDataGridViewCheckBoxColumn
            // 
            this.isDoneDataGridViewCheckBoxColumn.DataPropertyName = "IsDone";
            this.isDoneDataGridViewCheckBoxColumn.HeaderText = "IsDone";
            this.isDoneDataGridViewCheckBoxColumn.Name = "isDoneDataGridViewCheckBoxColumn";
            this.isDoneDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDoneDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isStartedDataGridViewCheckBoxColumn
            // 
            this.isStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            this.isStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            this.isStartedDataGridViewCheckBoxColumn.Name = "isStartedDataGridViewCheckBoxColumn";
            this.isStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isStartedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isKODataGridViewCheckBoxColumn
            // 
            this.isKODataGridViewCheckBoxColumn.DataPropertyName = "IsKO";
            this.isKODataGridViewCheckBoxColumn.HeaderText = "IsKO";
            this.isKODataGridViewCheckBoxColumn.Name = "isKODataGridViewCheckBoxColumn";
            this.isKODataGridViewCheckBoxColumn.ReadOnly = true;
            this.isKODataGridViewCheckBoxColumn.Visible = false;
            // 
            // isContentStartDataGridViewCheckBoxColumn
            // 
            this.isContentStartDataGridViewCheckBoxColumn.DataPropertyName = "IsContentStart";
            this.isContentStartDataGridViewCheckBoxColumn.HeaderText = "IsContentStart";
            this.isContentStartDataGridViewCheckBoxColumn.Name = "isContentStartDataGridViewCheckBoxColumn";
            this.isContentStartDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isContentStartDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isContentEndDataGridViewCheckBoxColumn
            // 
            this.isContentEndDataGridViewCheckBoxColumn.DataPropertyName = "IsContentEnd";
            this.isContentEndDataGridViewCheckBoxColumn.HeaderText = "IsContentEnd";
            this.isContentEndDataGridViewCheckBoxColumn.Name = "isContentEndDataGridViewCheckBoxColumn";
            this.isContentEndDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isContentEndDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isLevelSyncStartDataGridViewCheckBoxColumn
            // 
            this.isLevelSyncStartDataGridViewCheckBoxColumn.DataPropertyName = "IsLevelSyncStart";
            this.isLevelSyncStartDataGridViewCheckBoxColumn.HeaderText = "IsLevelSyncStart";
            this.isLevelSyncStartDataGridViewCheckBoxColumn.Name = "isLevelSyncStartDataGridViewCheckBoxColumn";
            this.isLevelSyncStartDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isLevelSyncStartDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isLevelSyncEndDataGridViewCheckBoxColumn
            // 
            this.isLevelSyncEndDataGridViewCheckBoxColumn.DataPropertyName = "IsLevelSyncEnd";
            this.isLevelSyncEndDataGridViewCheckBoxColumn.HeaderText = "IsLevelSyncEnd";
            this.isLevelSyncEndDataGridViewCheckBoxColumn.Name = "isLevelSyncEndDataGridViewCheckBoxColumn";
            this.isLevelSyncEndDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isLevelSyncEndDataGridViewCheckBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDDataGridViewTextBoxColumn1.Width = 27;
            // 
            // totalSecondsDataGridViewTextBoxColumn
            // 
            this.totalSecondsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeconds";
            this.totalSecondsDataGridViewTextBoxColumn.HeaderText = "TotalSeconds";
            this.totalSecondsDataGridViewTextBoxColumn.Name = "totalSecondsDataGridViewTextBoxColumn";
            this.totalSecondsDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSecondsDataGridViewTextBoxColumn.Visible = false;
            // 
            // serverTimeDataGridViewTextBoxColumn
            // 
            this.serverTimeDataGridViewTextBoxColumn.DataPropertyName = "ServerTime";
            this.serverTimeDataGridViewTextBoxColumn.HeaderText = "ServerTime";
            this.serverTimeDataGridViewTextBoxColumn.Name = "serverTimeDataGridViewTextBoxColumn";
            this.serverTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.serverTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // localTimeDataGridViewTextBoxColumn
            // 
            this.localTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.localTimeDataGridViewTextBoxColumn.DataPropertyName = "LocalTime";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "HH:mm:ss";
            this.localTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.localTimeDataGridViewTextBoxColumn.HeaderText = "LocalTime";
            this.localTimeDataGridViewTextBoxColumn.Name = "localTimeDataGridViewTextBoxColumn";
            this.localTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.localTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.localTimeDataGridViewTextBoxColumn.Width = 73;
            // 
            // logTypeDataGridViewTextBoxColumn
            // 
            this.logTypeDataGridViewTextBoxColumn.DataPropertyName = "LogType";
            this.logTypeDataGridViewTextBoxColumn.HeaderText = "LogType";
            this.logTypeDataGridViewTextBoxColumn.Name = "logTypeDataGridViewTextBoxColumn";
            this.logTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.logTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // actionTypeDataGridViewTextBoxColumn
            // 
            this.actionTypeDataGridViewTextBoxColumn.DataPropertyName = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.HeaderText = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.Name = "actionTypeDataGridViewTextBoxColumn";
            this.actionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bodyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bodyDataGridViewTextBoxColumn.HeaderText = "ログ";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            this.fromDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromDataGridViewTextBoxColumn.Visible = false;
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            this.toDataGridViewTextBoxColumn.ReadOnly = true;
            this.toDataGridViewTextBoxColumn.Visible = false;
            // 
            // actionNameDataGridViewTextBoxColumn
            // 
            this.actionNameDataGridViewTextBoxColumn.DataPropertyName = "ActionName";
            this.actionNameDataGridViewTextBoxColumn.HeaderText = "ActionName";
            this.actionNameDataGridViewTextBoxColumn.Name = "actionNameDataGridViewTextBoxColumn";
            this.actionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // buffNameDataGridViewTextBoxColumn
            // 
            this.buffNameDataGridViewTextBoxColumn.DataPropertyName = "BuffName";
            this.buffNameDataGridViewTextBoxColumn.HeaderText = "BuffName";
            this.buffNameDataGridViewTextBoxColumn.Name = "buffNameDataGridViewTextBoxColumn";
            this.buffNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.buffNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // debuffNameDataGridViewTextBoxColumn
            // 
            this.debuffNameDataGridViewTextBoxColumn.DataPropertyName = "DebuffName";
            this.debuffNameDataGridViewTextBoxColumn.HeaderText = "DebuffName";
            this.debuffNameDataGridViewTextBoxColumn.Name = "debuffNameDataGridViewTextBoxColumn";
            this.debuffNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.debuffNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // numericDataGridViewTextBoxColumn
            // 
            this.numericDataGridViewTextBoxColumn.DataPropertyName = "Numeric";
            this.numericDataGridViewTextBoxColumn.HeaderText = "Numeric";
            this.numericDataGridViewTextBoxColumn.Name = "numericDataGridViewTextBoxColumn";
            this.numericDataGridViewTextBoxColumn.ReadOnly = true;
            this.numericDataGridViewTextBoxColumn.Visible = false;
            // 
            // bonusRateDataGridViewTextBoxColumn
            // 
            this.bonusRateDataGridViewTextBoxColumn.DataPropertyName = "BonusRate";
            this.bonusRateDataGridViewTextBoxColumn.HeaderText = "BonusRate";
            this.bonusRateDataGridViewTextBoxColumn.Name = "bonusRateDataGridViewTextBoxColumn";
            this.bonusRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusRateDataGridViewTextBoxColumn.Visible = false;
            // 
            // contentNameDataGridViewTextBoxColumn
            // 
            this.contentNameDataGridViewTextBoxColumn.DataPropertyName = "ContentName";
            this.contentNameDataGridViewTextBoxColumn.HeaderText = "ContentName";
            this.contentNameDataGridViewTextBoxColumn.Name = "contentNameDataGridViewTextBoxColumn";
            this.contentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // syncLevelDataGridViewTextBoxColumn
            // 
            this.syncLevelDataGridViewTextBoxColumn.DataPropertyName = "SyncLevel";
            this.syncLevelDataGridViewTextBoxColumn.HeaderText = "SyncLevel";
            this.syncLevelDataGridViewTextBoxColumn.Name = "syncLevelDataGridViewTextBoxColumn";
            this.syncLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.syncLevelDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewCheckBoxColumn7,
            this.dataGridViewCheckBoxColumn8,
            this.dataGridViewCheckBoxColumn9,
            this.dataGridViewCheckBoxColumn10,
            this.dataGridViewCheckBoxColumn11,
            this.dataGridViewCheckBoxColumn12,
            this.dataGridViewCheckBoxColumn13,
            this.dataGridViewCheckBoxColumn14,
            this.dataGridViewCheckBoxColumn15,
            this.dataGridViewCheckBoxColumn16,
            this.dataGridViewCheckBoxColumn17,
            this.dataGridViewCheckBoxColumn18,
            this.dataGridViewCheckBoxColumn19,
            this.dataGridViewCheckBoxColumn20,
            this.dataGridViewCheckBoxColumn21,
            this.dataGridViewCheckBoxColumn22,
            this.iDDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(443, 161);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(432, 494);
            this.dataGridView2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dataGridView2, "解析範囲の終わりを選択します。");
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsDamage";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsDamage";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsCure";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsCure";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "IsHP";
            this.dataGridViewCheckBoxColumn3.HeaderText = "IsHP";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "IsMP";
            this.dataGridViewCheckBoxColumn4.HeaderText = "IsMP";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "IsTP";
            this.dataGridViewCheckBoxColumn5.HeaderText = "IsTP";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            this.dataGridViewCheckBoxColumn5.Visible = false;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "IsHate";
            this.dataGridViewCheckBoxColumn6.HeaderText = "IsHate";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.ReadOnly = true;
            this.dataGridViewCheckBoxColumn6.Visible = false;
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.DataPropertyName = "IsBlock";
            this.dataGridViewCheckBoxColumn7.HeaderText = "IsBlock";
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            this.dataGridViewCheckBoxColumn7.ReadOnly = true;
            this.dataGridViewCheckBoxColumn7.Visible = false;
            // 
            // dataGridViewCheckBoxColumn8
            // 
            this.dataGridViewCheckBoxColumn8.DataPropertyName = "IsParry";
            this.dataGridViewCheckBoxColumn8.HeaderText = "IsParry";
            this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
            this.dataGridViewCheckBoxColumn8.ReadOnly = true;
            this.dataGridViewCheckBoxColumn8.Visible = false;
            // 
            // dataGridViewCheckBoxColumn9
            // 
            this.dataGridViewCheckBoxColumn9.DataPropertyName = "IsDodge";
            this.dataGridViewCheckBoxColumn9.HeaderText = "IsDodge";
            this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
            this.dataGridViewCheckBoxColumn9.ReadOnly = true;
            this.dataGridViewCheckBoxColumn9.Visible = false;
            // 
            // dataGridViewCheckBoxColumn10
            // 
            this.dataGridViewCheckBoxColumn10.DataPropertyName = "IsCritical";
            this.dataGridViewCheckBoxColumn10.HeaderText = "IsCritical";
            this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
            this.dataGridViewCheckBoxColumn10.ReadOnly = true;
            this.dataGridViewCheckBoxColumn10.Visible = false;
            // 
            // dataGridViewCheckBoxColumn11
            // 
            this.dataGridViewCheckBoxColumn11.DataPropertyName = "IsBuffOn";
            this.dataGridViewCheckBoxColumn11.HeaderText = "IsBuffOn";
            this.dataGridViewCheckBoxColumn11.Name = "dataGridViewCheckBoxColumn11";
            this.dataGridViewCheckBoxColumn11.ReadOnly = true;
            this.dataGridViewCheckBoxColumn11.Visible = false;
            // 
            // dataGridViewCheckBoxColumn12
            // 
            this.dataGridViewCheckBoxColumn12.DataPropertyName = "IsDebuffOn";
            this.dataGridViewCheckBoxColumn12.HeaderText = "IsDebuffOn";
            this.dataGridViewCheckBoxColumn12.Name = "dataGridViewCheckBoxColumn12";
            this.dataGridViewCheckBoxColumn12.ReadOnly = true;
            this.dataGridViewCheckBoxColumn12.Visible = false;
            // 
            // dataGridViewCheckBoxColumn13
            // 
            this.dataGridViewCheckBoxColumn13.DataPropertyName = "IsBuffRemove";
            this.dataGridViewCheckBoxColumn13.HeaderText = "IsBuffRemove";
            this.dataGridViewCheckBoxColumn13.Name = "dataGridViewCheckBoxColumn13";
            this.dataGridViewCheckBoxColumn13.ReadOnly = true;
            this.dataGridViewCheckBoxColumn13.Visible = false;
            // 
            // dataGridViewCheckBoxColumn14
            // 
            this.dataGridViewCheckBoxColumn14.DataPropertyName = "IsDebuffRemove";
            this.dataGridViewCheckBoxColumn14.HeaderText = "IsDebuffRemove";
            this.dataGridViewCheckBoxColumn14.Name = "dataGridViewCheckBoxColumn14";
            this.dataGridViewCheckBoxColumn14.ReadOnly = true;
            this.dataGridViewCheckBoxColumn14.Visible = false;
            // 
            // dataGridViewCheckBoxColumn15
            // 
            this.dataGridViewCheckBoxColumn15.DataPropertyName = "IsInterrupted";
            this.dataGridViewCheckBoxColumn15.HeaderText = "IsInterrupted";
            this.dataGridViewCheckBoxColumn15.Name = "dataGridViewCheckBoxColumn15";
            this.dataGridViewCheckBoxColumn15.ReadOnly = true;
            this.dataGridViewCheckBoxColumn15.Visible = false;
            // 
            // dataGridViewCheckBoxColumn16
            // 
            this.dataGridViewCheckBoxColumn16.DataPropertyName = "IsDone";
            this.dataGridViewCheckBoxColumn16.HeaderText = "IsDone";
            this.dataGridViewCheckBoxColumn16.Name = "dataGridViewCheckBoxColumn16";
            this.dataGridViewCheckBoxColumn16.ReadOnly = true;
            this.dataGridViewCheckBoxColumn16.Visible = false;
            // 
            // dataGridViewCheckBoxColumn17
            // 
            this.dataGridViewCheckBoxColumn17.DataPropertyName = "IsStarted";
            this.dataGridViewCheckBoxColumn17.HeaderText = "IsStarted";
            this.dataGridViewCheckBoxColumn17.Name = "dataGridViewCheckBoxColumn17";
            this.dataGridViewCheckBoxColumn17.ReadOnly = true;
            this.dataGridViewCheckBoxColumn17.Visible = false;
            // 
            // dataGridViewCheckBoxColumn18
            // 
            this.dataGridViewCheckBoxColumn18.DataPropertyName = "IsKO";
            this.dataGridViewCheckBoxColumn18.HeaderText = "IsKO";
            this.dataGridViewCheckBoxColumn18.Name = "dataGridViewCheckBoxColumn18";
            this.dataGridViewCheckBoxColumn18.ReadOnly = true;
            this.dataGridViewCheckBoxColumn18.Visible = false;
            // 
            // dataGridViewCheckBoxColumn19
            // 
            this.dataGridViewCheckBoxColumn19.DataPropertyName = "IsContentStart";
            this.dataGridViewCheckBoxColumn19.HeaderText = "IsContentStart";
            this.dataGridViewCheckBoxColumn19.Name = "dataGridViewCheckBoxColumn19";
            this.dataGridViewCheckBoxColumn19.ReadOnly = true;
            this.dataGridViewCheckBoxColumn19.Visible = false;
            // 
            // dataGridViewCheckBoxColumn20
            // 
            this.dataGridViewCheckBoxColumn20.DataPropertyName = "IsContentEnd";
            this.dataGridViewCheckBoxColumn20.HeaderText = "IsContentEnd";
            this.dataGridViewCheckBoxColumn20.Name = "dataGridViewCheckBoxColumn20";
            this.dataGridViewCheckBoxColumn20.ReadOnly = true;
            this.dataGridViewCheckBoxColumn20.Visible = false;
            // 
            // dataGridViewCheckBoxColumn21
            // 
            this.dataGridViewCheckBoxColumn21.DataPropertyName = "IsLevelSyncStart";
            this.dataGridViewCheckBoxColumn21.HeaderText = "IsLevelSyncStart";
            this.dataGridViewCheckBoxColumn21.Name = "dataGridViewCheckBoxColumn21";
            this.dataGridViewCheckBoxColumn21.ReadOnly = true;
            this.dataGridViewCheckBoxColumn21.Visible = false;
            // 
            // dataGridViewCheckBoxColumn22
            // 
            this.dataGridViewCheckBoxColumn22.DataPropertyName = "IsLevelSyncEnd";
            this.dataGridViewCheckBoxColumn22.HeaderText = "IsLevelSyncEnd";
            this.dataGridViewCheckBoxColumn22.Name = "dataGridViewCheckBoxColumn22";
            this.dataGridViewCheckBoxColumn22.ReadOnly = true;
            this.dataGridViewCheckBoxColumn22.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDDataGridViewTextBoxColumn2.Width = 27;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "TotalSeconds";
            this.dataGridViewTextBoxColumn46.HeaderText = "TotalSeconds";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Visible = false;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "ServerTime";
            this.dataGridViewTextBoxColumn47.HeaderText = "ServerTime";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Visible = false;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn48.DataPropertyName = "LocalTime";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "HH:mm:ss";
            this.dataGridViewTextBoxColumn48.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn48.HeaderText = "LocalTime";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn48.Width = 73;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "LogType";
            this.dataGridViewTextBoxColumn49.HeaderText = "LogType";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Visible = false;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "ActionType";
            this.dataGridViewTextBoxColumn50.HeaderText = "ActionType";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            this.dataGridViewTextBoxColumn50.Visible = false;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Body";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataGridViewTextBoxColumn51.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn51.HeaderText = "ログ";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "From";
            this.dataGridViewTextBoxColumn52.HeaderText = "From";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            this.dataGridViewTextBoxColumn52.Visible = false;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "To";
            this.dataGridViewTextBoxColumn53.HeaderText = "To";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            this.dataGridViewTextBoxColumn53.Visible = false;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "ActionName";
            this.dataGridViewTextBoxColumn54.HeaderText = "ActionName";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Visible = false;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "BuffName";
            this.dataGridViewTextBoxColumn55.HeaderText = "BuffName";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Visible = false;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "DebuffName";
            this.dataGridViewTextBoxColumn56.HeaderText = "DebuffName";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            this.dataGridViewTextBoxColumn56.Visible = false;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Numeric";
            this.dataGridViewTextBoxColumn57.HeaderText = "Numeric";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            this.dataGridViewTextBoxColumn57.Visible = false;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "BonusRate";
            this.dataGridViewTextBoxColumn58.HeaderText = "BonusRate";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            this.dataGridViewTextBoxColumn58.Visible = false;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "ContentName";
            this.dataGridViewTextBoxColumn59.HeaderText = "ContentName";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            this.dataGridViewTextBoxColumn59.Visible = false;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "SyncLevel";
            this.dataGridViewTextBoxColumn60.HeaderText = "SyncLevel";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(76, 130);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(515, 130);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "1970/01/01 00:00:00 - 2099/12/31 23:59:59";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SystemEventBox);
            this.groupBox1.Controls.Add(this.IDStartEndBox);
            this.groupBox1.Controls.Add(this.GameEventBox);
            this.groupBox1.Controls.Add(this.BattleLogBox);
            this.groupBox1.Controls.Add(this.AllLogBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(432, 79);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "フィルター";
            this.toolTip1.SetToolTip(this.groupBox1, "フィルタを選択します。");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SystemEventBox2);
            this.groupBox2.Controls.Add(this.IDStartEndBox2);
            this.groupBox2.Controls.Add(this.GameEventBox2);
            this.groupBox2.Controls.Add(this.BattleLogBox2);
            this.groupBox2.Controls.Add(this.AllLogBox2);
            this.groupBox2.Location = new System.Drawing.Point(443, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(432, 79);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "フィルター";
            this.toolTip1.SetToolTip(this.groupBox2, "フィルタを選択します。");
            // 
            // SystemEventBox2
            // 
            this.SystemEventBox2.AutoSize = true;
            this.SystemEventBox2.Location = new System.Drawing.Point(117, 22);
            this.SystemEventBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SystemEventBox2.Name = "SystemEventBox2";
            this.SystemEventBox2.Size = new System.Drawing.Size(98, 16);
            this.SystemEventBox2.TabIndex = 3;
            this.SystemEventBox2.Text = "システムイベント";
            this.SystemEventBox2.UseVisualStyleBackColor = true;
            this.SystemEventBox2.CheckedChanged += new System.EventHandler(this.IDStartEndBox2_CheckedChanged);
            // 
            // IDStartEndBox2
            // 
            this.IDStartEndBox2.AutoSize = true;
            this.IDStartEndBox2.Location = new System.Drawing.Point(6, 22);
            this.IDStartEndBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDStartEndBox2.Name = "IDStartEndBox2";
            this.IDStartEndBox2.Size = new System.Drawing.Size(89, 16);
            this.IDStartEndBox2.TabIndex = 2;
            this.IDStartEndBox2.Text = "ID開始・終了";
            this.IDStartEndBox2.UseVisualStyleBackColor = true;
            this.IDStartEndBox2.CheckedChanged += new System.EventHandler(this.IDStartEndBox2_CheckedChanged);
            // 
            // GameEventBox2
            // 
            this.GameEventBox2.AutoSize = true;
            this.GameEventBox2.Location = new System.Drawing.Point(238, 22);
            this.GameEventBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameEventBox2.Name = "GameEventBox2";
            this.GameEventBox2.Size = new System.Drawing.Size(90, 16);
            this.GameEventBox2.TabIndex = 4;
            this.GameEventBox2.Text = "ゲームイベント";
            this.GameEventBox2.UseVisualStyleBackColor = true;
            this.GameEventBox2.CheckedChanged += new System.EventHandler(this.IDStartEndBox2_CheckedChanged);
            // 
            // BattleLogBox2
            // 
            this.BattleLogBox2.AutoSize = true;
            this.BattleLogBox2.Location = new System.Drawing.Point(7, 50);
            this.BattleLogBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BattleLogBox2.Name = "BattleLogBox2";
            this.BattleLogBox2.Size = new System.Drawing.Size(66, 16);
            this.BattleLogBox2.TabIndex = 5;
            this.BattleLogBox2.Text = "戦闘ログ";
            this.BattleLogBox2.UseVisualStyleBackColor = true;
            this.BattleLogBox2.CheckedChanged += new System.EventHandler(this.IDStartEndBox2_CheckedChanged);
            // 
            // AllLogBox2
            // 
            this.AllLogBox2.AutoSize = true;
            this.AllLogBox2.Location = new System.Drawing.Point(238, 50);
            this.AllLogBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllLogBox2.Name = "AllLogBox2";
            this.AllLogBox2.Size = new System.Drawing.Size(48, 16);
            this.AllLogBox2.TabIndex = 6;
            this.AllLogBox2.Text = "全部";
            this.AllLogBox2.UseVisualStyleBackColor = true;
            this.AllLogBox2.CheckedChanged += new System.EventHandler(this.IDStartEndBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "開始ログID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "終了ログID";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(637, 129);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(99, 25);
            this.OKButton.TabIndex = 16;
            this.OKButton.Text = "Rep更新(&U)";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "ログの範囲";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LocalTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "LocalTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Body";
            this.dataGridViewTextBoxColumn3.HeaderText = "Body";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "HH:mm:ss";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LocalTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "LocalTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Body";
            this.dataGridViewTextBoxColumn6.HeaderText = "Body";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Body";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn7.HeaderText = "Body";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "From";
            this.dataGridViewTextBoxColumn8.HeaderText = "From";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "To";
            this.dataGridViewTextBoxColumn9.HeaderText = "To";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ActionName";
            this.dataGridViewTextBoxColumn10.HeaderText = "ActionName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "BuffName";
            this.dataGridViewTextBoxColumn11.HeaderText = "BuffName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DebuffName";
            this.dataGridViewTextBoxColumn12.HeaderText = "DebuffName";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Numeric";
            this.dataGridViewTextBoxColumn13.HeaderText = "Numeric";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "BonusRate";
            this.dataGridViewTextBoxColumn14.HeaderText = "BonusRate";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ContentName";
            this.dataGridViewTextBoxColumn15.HeaderText = "ContentName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "SyncLevel";
            this.dataGridViewTextBoxColumn16.HeaderText = "SyncLevel";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Enum_WHO";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn17.HeaderText = "Enum_WHO";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Enum_TO";
            this.dataGridViewTextBoxColumn18.HeaderText = "Enum_TO";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Enum_TARGET_STATUS";
            this.dataGridViewTextBoxColumn19.HeaderText = "Enum_TARGET_STATUS";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Enum_LOG_TYPE";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "HH:mm:ss";
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn20.HeaderText = "Enum_LOG_TYPE";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Enum_UNKNOWN_FLG";
            this.dataGridViewTextBoxColumn21.HeaderText = "Enum_UNKNOWN_FLG";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Enum_BATTLETYPE";
            this.dataGridViewTextBoxColumn22.HeaderText = "Enum_BATTLETYPE";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "ID";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn23.HeaderText = "ID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "TotalSeconds";
            this.dataGridViewTextBoxColumn24.HeaderText = "TotalSeconds";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ServerTime";
            this.dataGridViewTextBoxColumn25.HeaderText = "ServerTime";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "LocalTime";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.Format = "HH:mm:ss";
            this.dataGridViewTextBoxColumn26.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn26.HeaderText = "LocalTime";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "LogType";
            this.dataGridViewTextBoxColumn27.HeaderText = "LogType";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Visible = false;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "ActionType";
            this.dataGridViewTextBoxColumn28.HeaderText = "ActionType";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Visible = false;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Body";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn29.HeaderText = "Body";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "From";
            this.dataGridViewTextBoxColumn30.HeaderText = "From";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "To";
            this.dataGridViewTextBoxColumn31.HeaderText = "To";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Visible = false;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "ActionName";
            this.dataGridViewTextBoxColumn32.HeaderText = "ActionName";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "BuffName";
            this.dataGridViewTextBoxColumn33.HeaderText = "BuffName";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "DebuffName";
            this.dataGridViewTextBoxColumn34.HeaderText = "DebuffName";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Numeric";
            this.dataGridViewTextBoxColumn35.HeaderText = "Numeric";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "BonusRate";
            this.dataGridViewTextBoxColumn36.HeaderText = "BonusRate";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Visible = false;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "ContentName";
            this.dataGridViewTextBoxColumn37.HeaderText = "ContentName";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Visible = false;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "SyncLevel";
            this.dataGridViewTextBoxColumn38.HeaderText = "SyncLevel";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Visible = false;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Enum_WHO";
            this.dataGridViewTextBoxColumn39.HeaderText = "Enum_WHO";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Visible = false;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Enum_TO";
            this.dataGridViewTextBoxColumn40.HeaderText = "Enum_TO";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Visible = false;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Enum_TARGET_STATUS";
            this.dataGridViewTextBoxColumn41.HeaderText = "Enum_TARGET_STATUS";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Visible = false;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Enum_LOG_TYPE";
            this.dataGridViewTextBoxColumn42.HeaderText = "Enum_LOG_TYPE";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Visible = false;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Enum_UNKNOWN_FLG";
            this.dataGridViewTextBoxColumn43.HeaderText = "Enum_UNKNOWN_FLG";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Visible = false;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Enum_BATTLETYPE";
            this.dataGridViewTextBoxColumn44.HeaderText = "Enum_BATTLETYPE";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Visible = false;
            // 
            // SelectLogRegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 658);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectLogRegionForm";
            this.Text = "解析範囲の選択";
            this.toolTip1.SetToolTip(this, "解析範囲を指定して更新を押すか、");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectLogRegionForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectLogRegionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffxivLogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private FFXIV_Tools.FFXIVLogDataSet ffxivLogDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.CheckBox IDStartEndBox;
        private System.Windows.Forms.CheckBox SystemEventBox;
        private System.Windows.Forms.CheckBox GameEventBox;
        private System.Windows.Forms.CheckBox BattleLogBox;
        private System.Windows.Forms.CheckBox AllLogBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumWHODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumTARGETSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumLOGTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumUNKNOWNFLGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumBATTLETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox SystemEventBox2;
        private System.Windows.Forms.CheckBox IDStartEndBox2;
        private System.Windows.Forms.CheckBox GameEventBox2;
        private System.Windows.Forms.CheckBox BattleLogBox2;
        private System.Windows.Forms.CheckBox AllLogBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDamageDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCureDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isHPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isTPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isHateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBlockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isParryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDodgeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCriticalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBuffOnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDebuffOnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBuffRemoveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDebuffRemoveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isInterruptedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDoneDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isStartedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isKODataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isContentStartDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isContentEndDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLevelSyncStartDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLevelSyncEndDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debuffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numericDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn syncLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn20;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn21;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
    }
}