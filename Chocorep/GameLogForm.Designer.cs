namespace FF14FastReport
{
    partial class GameLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLogForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ユーザーフォルダからインポートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.閉じるXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ffxivLogDataSet1 = new FFXIV_Tools.FFXIVLogDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.contentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isContentStartDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isContentEndDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.syncLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLevelSyncStartDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLevelSyncEndDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isOverrideDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.effectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEffectOnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isEffectRemovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDotDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dotIryokuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dotSecsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enemyGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dotSpaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dotEndSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dotValueSecsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dotDamageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLAGWHODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLAGTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLAGFIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLAGINFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLAGUNKNOWNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLAGNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSVファイルを作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffxivLogDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.データDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くOToolStripMenuItem,
            this.ユーザーフォルダからインポートToolStripMenuItem,
            this.toolStripSeparator2,
            this.cSVファイルを作成ToolStripMenuItem,
            this.toolStripSeparator1,
            this.閉じるXToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.開くOToolStripMenuItem.Text = "開く(&O)";
            this.開くOToolStripMenuItem.Click += new System.EventHandler(this.開くOToolStripMenuItem_Click);
            // 
            // ユーザーフォルダからインポートToolStripMenuItem
            // 
            this.ユーザーフォルダからインポートToolStripMenuItem.Name = "ユーザーフォルダからインポートToolStripMenuItem";
            this.ユーザーフォルダからインポートToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.ユーザーフォルダからインポートToolStripMenuItem.Text = "ユーザーフォルダからインポート";
            this.ユーザーフォルダからインポートToolStripMenuItem.Click += new System.EventHandler(this.ファイルからインポートToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // 閉じるXToolStripMenuItem
            // 
            this.閉じるXToolStripMenuItem.Name = "閉じるXToolStripMenuItem";
            this.閉じるXToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.閉じるXToolStripMenuItem.Text = "閉じる(&X)";
            this.閉じるXToolStripMenuItem.Click += new System.EventHandler(this.閉じるXToolStripMenuItem_Click);
            // 
            // データDToolStripMenuItem
            // 
            this.データDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新UToolStripMenuItem});
            this.データDToolStripMenuItem.Name = "データDToolStripMenuItem";
            this.データDToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.データDToolStripMenuItem.Text = "データ(&D)";
            // 
            // 更新UToolStripMenuItem
            // 
            this.更新UToolStripMenuItem.Name = "更新UToolStripMenuItem";
            this.更新UToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.更新UToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.更新UToolStripMenuItem.Text = "ゲームログ表示(&U)";
            this.更新UToolStripMenuItem.Click += new System.EventHandler(this.更新UToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
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
            this.contentNameDataGridViewTextBoxColumn,
            this.isContentStartDataGridViewCheckBoxColumn,
            this.isContentEndDataGridViewCheckBoxColumn,
            this.syncLevelDataGridViewTextBoxColumn,
            this.isLevelSyncStartDataGridViewCheckBoxColumn,
            this.isLevelSyncEndDataGridViewCheckBoxColumn,
            this.isOverrideDataGridViewCheckBoxColumn,
            this.effectNameDataGridViewTextBoxColumn,
            this.isEffectOnDataGridViewCheckBoxColumn,
            this.isEffectRemovedDataGridViewCheckBoxColumn,
            this.isDotDataGridViewCheckBoxColumn,
            this.dotIryokuDataGridViewTextBoxColumn,
            this.dotSecsDataGridViewTextBoxColumn,
            this.toTypeDataGridViewTextBoxColumn,
            this.enemyGroupIDDataGridViewTextBoxColumn,
            this.dotSpaceDataGridViewTextBoxColumn,
            this.dotEndSecondsDataGridViewTextBoxColumn,
            this.dotValueSecsDataGridViewTextBoxColumn,
            this.damageBaseDataGridViewTextBoxColumn,
            this.dotDamageDataGridViewTextBoxColumn,
            this.fLAGWHODataGridViewTextBoxColumn,
            this.fLAGTODataGridViewTextBoxColumn,
            this.fLAGFIGHTDataGridViewTextBoxColumn,
            this.fLAGINFODataGridViewTextBoxColumn,
            this.fLAGUNKNOWNDataGridViewTextBoxColumn,
            this.fLAGNUMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(709, 393);
            this.dataGridView1.TabIndex = 1;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSecondsDataGridViewTextBoxColumn
            // 
            this.totalSecondsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeconds";
            this.totalSecondsDataGridViewTextBoxColumn.HeaderText = "TotalSeconds";
            this.totalSecondsDataGridViewTextBoxColumn.Name = "totalSecondsDataGridViewTextBoxColumn";
            this.totalSecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serverTimeDataGridViewTextBoxColumn
            // 
            this.serverTimeDataGridViewTextBoxColumn.DataPropertyName = "ServerTime";
            this.serverTimeDataGridViewTextBoxColumn.HeaderText = "ServerTime";
            this.serverTimeDataGridViewTextBoxColumn.Name = "serverTimeDataGridViewTextBoxColumn";
            this.serverTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localTimeDataGridViewTextBoxColumn
            // 
            this.localTimeDataGridViewTextBoxColumn.DataPropertyName = "LocalTime";
            this.localTimeDataGridViewTextBoxColumn.HeaderText = "LocalTime";
            this.localTimeDataGridViewTextBoxColumn.Name = "localTimeDataGridViewTextBoxColumn";
            this.localTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logTypeDataGridViewTextBoxColumn
            // 
            this.logTypeDataGridViewTextBoxColumn.DataPropertyName = "LogType";
            this.logTypeDataGridViewTextBoxColumn.HeaderText = "LogType";
            this.logTypeDataGridViewTextBoxColumn.Name = "logTypeDataGridViewTextBoxColumn";
            this.logTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionTypeDataGridViewTextBoxColumn
            // 
            this.actionTypeDataGridViewTextBoxColumn.DataPropertyName = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.HeaderText = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.Name = "actionTypeDataGridViewTextBoxColumn";
            this.actionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            this.fromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            this.toDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionNameDataGridViewTextBoxColumn
            // 
            this.actionNameDataGridViewTextBoxColumn.DataPropertyName = "ActionName";
            this.actionNameDataGridViewTextBoxColumn.HeaderText = "ActionName";
            this.actionNameDataGridViewTextBoxColumn.Name = "actionNameDataGridViewTextBoxColumn";
            this.actionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buffNameDataGridViewTextBoxColumn
            // 
            this.buffNameDataGridViewTextBoxColumn.DataPropertyName = "BuffName";
            this.buffNameDataGridViewTextBoxColumn.HeaderText = "BuffName";
            this.buffNameDataGridViewTextBoxColumn.Name = "buffNameDataGridViewTextBoxColumn";
            this.buffNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debuffNameDataGridViewTextBoxColumn
            // 
            this.debuffNameDataGridViewTextBoxColumn.DataPropertyName = "DebuffName";
            this.debuffNameDataGridViewTextBoxColumn.HeaderText = "DebuffName";
            this.debuffNameDataGridViewTextBoxColumn.Name = "debuffNameDataGridViewTextBoxColumn";
            this.debuffNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numericDataGridViewTextBoxColumn
            // 
            this.numericDataGridViewTextBoxColumn.DataPropertyName = "Numeric";
            this.numericDataGridViewTextBoxColumn.HeaderText = "Numeric";
            this.numericDataGridViewTextBoxColumn.Name = "numericDataGridViewTextBoxColumn";
            this.numericDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonusRateDataGridViewTextBoxColumn
            // 
            this.bonusRateDataGridViewTextBoxColumn.DataPropertyName = "BonusRate";
            this.bonusRateDataGridViewTextBoxColumn.HeaderText = "BonusRate";
            this.bonusRateDataGridViewTextBoxColumn.Name = "bonusRateDataGridViewTextBoxColumn";
            this.bonusRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDamageDataGridViewCheckBoxColumn
            // 
            this.isDamageDataGridViewCheckBoxColumn.DataPropertyName = "IsDamage";
            this.isDamageDataGridViewCheckBoxColumn.HeaderText = "IsDamage";
            this.isDamageDataGridViewCheckBoxColumn.Name = "isDamageDataGridViewCheckBoxColumn";
            this.isDamageDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isCureDataGridViewCheckBoxColumn
            // 
            this.isCureDataGridViewCheckBoxColumn.DataPropertyName = "IsCure";
            this.isCureDataGridViewCheckBoxColumn.HeaderText = "IsCure";
            this.isCureDataGridViewCheckBoxColumn.Name = "isCureDataGridViewCheckBoxColumn";
            this.isCureDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isHPDataGridViewCheckBoxColumn
            // 
            this.isHPDataGridViewCheckBoxColumn.DataPropertyName = "IsHP";
            this.isHPDataGridViewCheckBoxColumn.HeaderText = "IsHP";
            this.isHPDataGridViewCheckBoxColumn.Name = "isHPDataGridViewCheckBoxColumn";
            this.isHPDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isMPDataGridViewCheckBoxColumn
            // 
            this.isMPDataGridViewCheckBoxColumn.DataPropertyName = "IsMP";
            this.isMPDataGridViewCheckBoxColumn.HeaderText = "IsMP";
            this.isMPDataGridViewCheckBoxColumn.Name = "isMPDataGridViewCheckBoxColumn";
            this.isMPDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isTPDataGridViewCheckBoxColumn
            // 
            this.isTPDataGridViewCheckBoxColumn.DataPropertyName = "IsTP";
            this.isTPDataGridViewCheckBoxColumn.HeaderText = "IsTP";
            this.isTPDataGridViewCheckBoxColumn.Name = "isTPDataGridViewCheckBoxColumn";
            this.isTPDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isHateDataGridViewCheckBoxColumn
            // 
            this.isHateDataGridViewCheckBoxColumn.DataPropertyName = "IsHate";
            this.isHateDataGridViewCheckBoxColumn.HeaderText = "IsHate";
            this.isHateDataGridViewCheckBoxColumn.Name = "isHateDataGridViewCheckBoxColumn";
            this.isHateDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isBlockDataGridViewCheckBoxColumn
            // 
            this.isBlockDataGridViewCheckBoxColumn.DataPropertyName = "IsBlock";
            this.isBlockDataGridViewCheckBoxColumn.HeaderText = "IsBlock";
            this.isBlockDataGridViewCheckBoxColumn.Name = "isBlockDataGridViewCheckBoxColumn";
            this.isBlockDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isParryDataGridViewCheckBoxColumn
            // 
            this.isParryDataGridViewCheckBoxColumn.DataPropertyName = "IsParry";
            this.isParryDataGridViewCheckBoxColumn.HeaderText = "IsParry";
            this.isParryDataGridViewCheckBoxColumn.Name = "isParryDataGridViewCheckBoxColumn";
            this.isParryDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isDodgeDataGridViewCheckBoxColumn
            // 
            this.isDodgeDataGridViewCheckBoxColumn.DataPropertyName = "IsDodge";
            this.isDodgeDataGridViewCheckBoxColumn.HeaderText = "IsDodge";
            this.isDodgeDataGridViewCheckBoxColumn.Name = "isDodgeDataGridViewCheckBoxColumn";
            this.isDodgeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isCriticalDataGridViewCheckBoxColumn
            // 
            this.isCriticalDataGridViewCheckBoxColumn.DataPropertyName = "IsCritical";
            this.isCriticalDataGridViewCheckBoxColumn.HeaderText = "IsCritical";
            this.isCriticalDataGridViewCheckBoxColumn.Name = "isCriticalDataGridViewCheckBoxColumn";
            this.isCriticalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isBuffOnDataGridViewCheckBoxColumn
            // 
            this.isBuffOnDataGridViewCheckBoxColumn.DataPropertyName = "IsBuffOn";
            this.isBuffOnDataGridViewCheckBoxColumn.HeaderText = "IsBuffOn";
            this.isBuffOnDataGridViewCheckBoxColumn.Name = "isBuffOnDataGridViewCheckBoxColumn";
            this.isBuffOnDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isDebuffOnDataGridViewCheckBoxColumn
            // 
            this.isDebuffOnDataGridViewCheckBoxColumn.DataPropertyName = "IsDebuffOn";
            this.isDebuffOnDataGridViewCheckBoxColumn.HeaderText = "IsDebuffOn";
            this.isDebuffOnDataGridViewCheckBoxColumn.Name = "isDebuffOnDataGridViewCheckBoxColumn";
            this.isDebuffOnDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isBuffRemoveDataGridViewCheckBoxColumn
            // 
            this.isBuffRemoveDataGridViewCheckBoxColumn.DataPropertyName = "IsBuffRemove";
            this.isBuffRemoveDataGridViewCheckBoxColumn.HeaderText = "IsBuffRemove";
            this.isBuffRemoveDataGridViewCheckBoxColumn.Name = "isBuffRemoveDataGridViewCheckBoxColumn";
            this.isBuffRemoveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isDebuffRemoveDataGridViewCheckBoxColumn
            // 
            this.isDebuffRemoveDataGridViewCheckBoxColumn.DataPropertyName = "IsDebuffRemove";
            this.isDebuffRemoveDataGridViewCheckBoxColumn.HeaderText = "IsDebuffRemove";
            this.isDebuffRemoveDataGridViewCheckBoxColumn.Name = "isDebuffRemoveDataGridViewCheckBoxColumn";
            this.isDebuffRemoveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isInterruptedDataGridViewCheckBoxColumn
            // 
            this.isInterruptedDataGridViewCheckBoxColumn.DataPropertyName = "IsInterrupted";
            this.isInterruptedDataGridViewCheckBoxColumn.HeaderText = "IsInterrupted";
            this.isInterruptedDataGridViewCheckBoxColumn.Name = "isInterruptedDataGridViewCheckBoxColumn";
            this.isInterruptedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isDoneDataGridViewCheckBoxColumn
            // 
            this.isDoneDataGridViewCheckBoxColumn.DataPropertyName = "IsDone";
            this.isDoneDataGridViewCheckBoxColumn.HeaderText = "IsDone";
            this.isDoneDataGridViewCheckBoxColumn.Name = "isDoneDataGridViewCheckBoxColumn";
            this.isDoneDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isStartedDataGridViewCheckBoxColumn
            // 
            this.isStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            this.isStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            this.isStartedDataGridViewCheckBoxColumn.Name = "isStartedDataGridViewCheckBoxColumn";
            this.isStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isKODataGridViewCheckBoxColumn
            // 
            this.isKODataGridViewCheckBoxColumn.DataPropertyName = "IsKO";
            this.isKODataGridViewCheckBoxColumn.HeaderText = "IsKO";
            this.isKODataGridViewCheckBoxColumn.Name = "isKODataGridViewCheckBoxColumn";
            this.isKODataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // contentNameDataGridViewTextBoxColumn
            // 
            this.contentNameDataGridViewTextBoxColumn.DataPropertyName = "ContentName";
            this.contentNameDataGridViewTextBoxColumn.HeaderText = "ContentName";
            this.contentNameDataGridViewTextBoxColumn.Name = "contentNameDataGridViewTextBoxColumn";
            this.contentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isContentStartDataGridViewCheckBoxColumn
            // 
            this.isContentStartDataGridViewCheckBoxColumn.DataPropertyName = "IsContentStart";
            this.isContentStartDataGridViewCheckBoxColumn.HeaderText = "IsContentStart";
            this.isContentStartDataGridViewCheckBoxColumn.Name = "isContentStartDataGridViewCheckBoxColumn";
            this.isContentStartDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isContentEndDataGridViewCheckBoxColumn
            // 
            this.isContentEndDataGridViewCheckBoxColumn.DataPropertyName = "IsContentEnd";
            this.isContentEndDataGridViewCheckBoxColumn.HeaderText = "IsContentEnd";
            this.isContentEndDataGridViewCheckBoxColumn.Name = "isContentEndDataGridViewCheckBoxColumn";
            this.isContentEndDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // syncLevelDataGridViewTextBoxColumn
            // 
            this.syncLevelDataGridViewTextBoxColumn.DataPropertyName = "SyncLevel";
            this.syncLevelDataGridViewTextBoxColumn.HeaderText = "SyncLevel";
            this.syncLevelDataGridViewTextBoxColumn.Name = "syncLevelDataGridViewTextBoxColumn";
            this.syncLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isLevelSyncStartDataGridViewCheckBoxColumn
            // 
            this.isLevelSyncStartDataGridViewCheckBoxColumn.DataPropertyName = "IsLevelSyncStart";
            this.isLevelSyncStartDataGridViewCheckBoxColumn.HeaderText = "IsLevelSyncStart";
            this.isLevelSyncStartDataGridViewCheckBoxColumn.Name = "isLevelSyncStartDataGridViewCheckBoxColumn";
            this.isLevelSyncStartDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isLevelSyncEndDataGridViewCheckBoxColumn
            // 
            this.isLevelSyncEndDataGridViewCheckBoxColumn.DataPropertyName = "IsLevelSyncEnd";
            this.isLevelSyncEndDataGridViewCheckBoxColumn.HeaderText = "IsLevelSyncEnd";
            this.isLevelSyncEndDataGridViewCheckBoxColumn.Name = "isLevelSyncEndDataGridViewCheckBoxColumn";
            this.isLevelSyncEndDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isOverrideDataGridViewCheckBoxColumn
            // 
            this.isOverrideDataGridViewCheckBoxColumn.DataPropertyName = "IsOverride";
            this.isOverrideDataGridViewCheckBoxColumn.HeaderText = "IsOverride";
            this.isOverrideDataGridViewCheckBoxColumn.Name = "isOverrideDataGridViewCheckBoxColumn";
            this.isOverrideDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // effectNameDataGridViewTextBoxColumn
            // 
            this.effectNameDataGridViewTextBoxColumn.DataPropertyName = "EffectName";
            this.effectNameDataGridViewTextBoxColumn.HeaderText = "EffectName";
            this.effectNameDataGridViewTextBoxColumn.Name = "effectNameDataGridViewTextBoxColumn";
            this.effectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isEffectOnDataGridViewCheckBoxColumn
            // 
            this.isEffectOnDataGridViewCheckBoxColumn.DataPropertyName = "IsEffectOn";
            this.isEffectOnDataGridViewCheckBoxColumn.HeaderText = "IsEffectOn";
            this.isEffectOnDataGridViewCheckBoxColumn.Name = "isEffectOnDataGridViewCheckBoxColumn";
            this.isEffectOnDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isEffectRemovedDataGridViewCheckBoxColumn
            // 
            this.isEffectRemovedDataGridViewCheckBoxColumn.DataPropertyName = "IsEffectRemoved";
            this.isEffectRemovedDataGridViewCheckBoxColumn.HeaderText = "IsEffectRemoved";
            this.isEffectRemovedDataGridViewCheckBoxColumn.Name = "isEffectRemovedDataGridViewCheckBoxColumn";
            this.isEffectRemovedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isDotDataGridViewCheckBoxColumn
            // 
            this.isDotDataGridViewCheckBoxColumn.DataPropertyName = "IsDot";
            this.isDotDataGridViewCheckBoxColumn.HeaderText = "IsDot";
            this.isDotDataGridViewCheckBoxColumn.Name = "isDotDataGridViewCheckBoxColumn";
            this.isDotDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dotIryokuDataGridViewTextBoxColumn
            // 
            this.dotIryokuDataGridViewTextBoxColumn.DataPropertyName = "Dot_Iryoku";
            this.dotIryokuDataGridViewTextBoxColumn.HeaderText = "Dot_Iryoku";
            this.dotIryokuDataGridViewTextBoxColumn.Name = "dotIryokuDataGridViewTextBoxColumn";
            this.dotIryokuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dotSecsDataGridViewTextBoxColumn
            // 
            this.dotSecsDataGridViewTextBoxColumn.DataPropertyName = "DotSecs";
            this.dotSecsDataGridViewTextBoxColumn.HeaderText = "DotSecs";
            this.dotSecsDataGridViewTextBoxColumn.Name = "dotSecsDataGridViewTextBoxColumn";
            this.dotSecsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toTypeDataGridViewTextBoxColumn
            // 
            this.toTypeDataGridViewTextBoxColumn.DataPropertyName = "ToType";
            this.toTypeDataGridViewTextBoxColumn.HeaderText = "ToType";
            this.toTypeDataGridViewTextBoxColumn.Name = "toTypeDataGridViewTextBoxColumn";
            this.toTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enemyGroupIDDataGridViewTextBoxColumn
            // 
            this.enemyGroupIDDataGridViewTextBoxColumn.DataPropertyName = "EnemyGroupID";
            this.enemyGroupIDDataGridViewTextBoxColumn.HeaderText = "EnemyGroupID";
            this.enemyGroupIDDataGridViewTextBoxColumn.Name = "enemyGroupIDDataGridViewTextBoxColumn";
            this.enemyGroupIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dotSpaceDataGridViewTextBoxColumn
            // 
            this.dotSpaceDataGridViewTextBoxColumn.DataPropertyName = "DotSpace";
            this.dotSpaceDataGridViewTextBoxColumn.HeaderText = "DotSpace";
            this.dotSpaceDataGridViewTextBoxColumn.Name = "dotSpaceDataGridViewTextBoxColumn";
            this.dotSpaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dotEndSecondsDataGridViewTextBoxColumn
            // 
            this.dotEndSecondsDataGridViewTextBoxColumn.DataPropertyName = "DotEndSeconds";
            this.dotEndSecondsDataGridViewTextBoxColumn.HeaderText = "DotEndSeconds";
            this.dotEndSecondsDataGridViewTextBoxColumn.Name = "dotEndSecondsDataGridViewTextBoxColumn";
            this.dotEndSecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dotValueSecsDataGridViewTextBoxColumn
            // 
            this.dotValueSecsDataGridViewTextBoxColumn.DataPropertyName = "DotValueSecs";
            this.dotValueSecsDataGridViewTextBoxColumn.HeaderText = "DotValueSecs";
            this.dotValueSecsDataGridViewTextBoxColumn.Name = "dotValueSecsDataGridViewTextBoxColumn";
            this.dotValueSecsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // damageBaseDataGridViewTextBoxColumn
            // 
            this.damageBaseDataGridViewTextBoxColumn.DataPropertyName = "DamageBase";
            this.damageBaseDataGridViewTextBoxColumn.HeaderText = "DamageBase";
            this.damageBaseDataGridViewTextBoxColumn.Name = "damageBaseDataGridViewTextBoxColumn";
            this.damageBaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dotDamageDataGridViewTextBoxColumn
            // 
            this.dotDamageDataGridViewTextBoxColumn.DataPropertyName = "DotDamage";
            this.dotDamageDataGridViewTextBoxColumn.HeaderText = "DotDamage";
            this.dotDamageDataGridViewTextBoxColumn.Name = "dotDamageDataGridViewTextBoxColumn";
            this.dotDamageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLAGWHODataGridViewTextBoxColumn
            // 
            this.fLAGWHODataGridViewTextBoxColumn.DataPropertyName = "FLAG_WHO";
            this.fLAGWHODataGridViewTextBoxColumn.HeaderText = "FLAG_WHO";
            this.fLAGWHODataGridViewTextBoxColumn.Name = "fLAGWHODataGridViewTextBoxColumn";
            this.fLAGWHODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLAGTODataGridViewTextBoxColumn
            // 
            this.fLAGTODataGridViewTextBoxColumn.DataPropertyName = "FLAG_TO";
            this.fLAGTODataGridViewTextBoxColumn.HeaderText = "FLAG_TO";
            this.fLAGTODataGridViewTextBoxColumn.Name = "fLAGTODataGridViewTextBoxColumn";
            this.fLAGTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLAGFIGHTDataGridViewTextBoxColumn
            // 
            this.fLAGFIGHTDataGridViewTextBoxColumn.DataPropertyName = "FLAG_FIGHT";
            this.fLAGFIGHTDataGridViewTextBoxColumn.HeaderText = "FLAG_FIGHT";
            this.fLAGFIGHTDataGridViewTextBoxColumn.Name = "fLAGFIGHTDataGridViewTextBoxColumn";
            this.fLAGFIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLAGINFODataGridViewTextBoxColumn
            // 
            this.fLAGINFODataGridViewTextBoxColumn.DataPropertyName = "FLAG_INFO";
            this.fLAGINFODataGridViewTextBoxColumn.HeaderText = "FLAG_INFO";
            this.fLAGINFODataGridViewTextBoxColumn.Name = "fLAGINFODataGridViewTextBoxColumn";
            this.fLAGINFODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLAGUNKNOWNDataGridViewTextBoxColumn
            // 
            this.fLAGUNKNOWNDataGridViewTextBoxColumn.DataPropertyName = "FLAG_UNKNOWN";
            this.fLAGUNKNOWNDataGridViewTextBoxColumn.HeaderText = "FLAG_UNKNOWN";
            this.fLAGUNKNOWNDataGridViewTextBoxColumn.Name = "fLAGUNKNOWNDataGridViewTextBoxColumn";
            this.fLAGUNKNOWNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLAGNUMDataGridViewTextBoxColumn
            // 
            this.fLAGNUMDataGridViewTextBoxColumn.DataPropertyName = "FLAG_NUM";
            this.fLAGNUMDataGridViewTextBoxColumn.HeaderText = "FLAG_NUM";
            this.fLAGNUMDataGridViewTextBoxColumn.Name = "fLAGNUMDataGridViewTextBoxColumn";
            this.fLAGNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cSVファイルを作成ToolStripMenuItem
            // 
            this.cSVファイルを作成ToolStripMenuItem.Name = "cSVファイルを作成ToolStripMenuItem";
            this.cSVファイルを作成ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cSVファイルを作成ToolStripMenuItem.Text = "CSVファイルを作成";
            this.cSVファイルを作成ToolStripMenuItem.Click += new System.EventHandler(this.cSVファイルを作成ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
            // 
            // GameLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(462, 300);
            this.Name = "GameLogForm";
            this.Text = "ゲームログ(おまけ程度）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameLogForm_FormClosing);
            this.Load += new System.EventHandler(this.GameLogForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffxivLogDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 閉じるXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新UToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FFXIV_Tools.FFXIVLogDataSet ffxivLogDataSet1;
        private System.Windows.Forms.ToolStripMenuItem ユーザーフォルダからインポートToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cSVファイルを作成ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn contentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isContentStartDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isContentEndDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn syncLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLevelSyncStartDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLevelSyncEndDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOverrideDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEffectOnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEffectRemovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDotDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dotIryokuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dotSecsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enemyGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dotSpaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dotEndSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dotValueSecsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dotDamageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLAGWHODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLAGTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLAGFIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLAGINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLAGUNKNOWNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLAGNUMDataGridViewTextBoxColumn;
    }
}