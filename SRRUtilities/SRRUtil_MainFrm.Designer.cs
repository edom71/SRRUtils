namespace SRRUtil
{
    partial class SRRUtil_MainFrm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpItemVals = new System.Windows.Forms.GroupBox();
            this.grpEquipStatus = new System.Windows.Forms.GroupBox();
            this.dgEquipStatus = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSortingGroup = new System.Windows.Forms.TextBox();
            this.lblSortingGroup = new System.Windows.Forms.Label();
            this.chkTargetActor = new System.Windows.Forms.CheckBox();
            this.chkAffectsEnemy = new System.Windows.Forms.CheckBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudReload = new System.Windows.Forms.NumericUpDown();
            this.lblReloadCost = new System.Windows.Forms.Label();
            this.grpAbilityModes = new System.Windows.Forms.GroupBox();
            this.chklstAbilityModes = new System.Windows.Forms.CheckedListBox();
            this.grpDmg = new System.Windows.Forms.GroupBox();
            this.nudAPDmg = new System.Windows.Forms.NumericUpDown();
            this.lblAPDmg = new System.Windows.Forms.Label();
            this.nudHPDmg = new System.Windows.Forms.NumericUpDown();
            this.lblHPDmg = new System.Windows.Forms.Label();
            this.grpNoise = new System.Windows.Forms.GroupBox();
            this.nudNoiseLvl = new System.Windows.Forms.NumericUpDown();
            this.lblNoiseLvl = new System.Windows.Forms.Label();
            this.nudNoiseRds = new System.Windows.Forms.NumericUpDown();
            this.lblNoiseRds = new System.Windows.Forms.Label();
            this.grpRangeModTable = new System.Windows.Forms.GroupBox();
            this.dgRangeModTable = new System.Windows.Forms.DataGridView();
            this.colRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudAmmo = new System.Windows.Forms.NumericUpDown();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.cboCoreSpec = new System.Windows.Forms.ComboBox();
            this.lblCoreSpec = new System.Windows.Forms.Label();
            this.nudAP = new System.Windows.Forms.NumericUpDown();
            this.lblAPCost = new System.Windows.Forms.Label();
            this.txtPrereq = new System.Windows.Forms.TextBox();
            this.lblPrereq = new System.Windows.Forms.Label();
            this.cboCoreSkill = new System.Windows.Forms.ComboBox();
            this.lblCoreSkill = new System.Windows.Forms.Label();
            this.cboCoreAttribute = new System.Windows.Forms.ComboBox();
            this.lblCoreAttrib = new System.Windows.Forms.Label();
            this.cboAnimType = new System.Windows.Forms.ComboBox();
            this.lblAnimType = new System.Windows.Forms.Label();
            this.txtPrefab = new System.Windows.Forms.TextBox();
            this.lblEquipprefabname = new System.Windows.Forms.Label();
            this.grpUIRep = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.grpItemVals.SuspendLayout();
            this.grpEquipStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReload)).BeginInit();
            this.grpAbilityModes.SuspendLayout();
            this.grpDmg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAPDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPDmg)).BeginInit();
            this.grpNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoiseLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoiseRds)).BeginInit();
            this.grpRangeModTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRangeModTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAP)).BeginInit();
            this.grpUIRep.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(451, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblToolStripStatus
            // 
            this.lblToolStripStatus.Name = "lblToolStripStatus";
            this.lblToolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // grpItemVals
            // 
            this.grpItemVals.Controls.Add(this.grpEquipStatus);
            this.grpItemVals.Controls.Add(this.txtSortingGroup);
            this.grpItemVals.Controls.Add(this.lblSortingGroup);
            this.grpItemVals.Controls.Add(this.chkTargetActor);
            this.grpItemVals.Controls.Add(this.chkAffectsEnemy);
            this.grpItemVals.Controls.Add(this.nudPrice);
            this.grpItemVals.Controls.Add(this.lblPrice);
            this.grpItemVals.Controls.Add(this.nudReload);
            this.grpItemVals.Controls.Add(this.lblReloadCost);
            this.grpItemVals.Controls.Add(this.grpAbilityModes);
            this.grpItemVals.Controls.Add(this.grpDmg);
            this.grpItemVals.Controls.Add(this.grpNoise);
            this.grpItemVals.Controls.Add(this.grpRangeModTable);
            this.grpItemVals.Controls.Add(this.nudAmmo);
            this.grpItemVals.Controls.Add(this.lblAmmo);
            this.grpItemVals.Controls.Add(this.cboCoreSpec);
            this.grpItemVals.Controls.Add(this.lblCoreSpec);
            this.grpItemVals.Controls.Add(this.nudAP);
            this.grpItemVals.Controls.Add(this.lblAPCost);
            this.grpItemVals.Controls.Add(this.txtPrereq);
            this.grpItemVals.Controls.Add(this.lblPrereq);
            this.grpItemVals.Controls.Add(this.cboCoreSkill);
            this.grpItemVals.Controls.Add(this.lblCoreSkill);
            this.grpItemVals.Controls.Add(this.cboCoreAttribute);
            this.grpItemVals.Controls.Add(this.lblCoreAttrib);
            this.grpItemVals.Controls.Add(this.cboAnimType);
            this.grpItemVals.Controls.Add(this.lblAnimType);
            this.grpItemVals.Controls.Add(this.txtPrefab);
            this.grpItemVals.Controls.Add(this.lblEquipprefabname);
            this.grpItemVals.Controls.Add(this.grpUIRep);
            this.grpItemVals.Controls.Add(this.cboType);
            this.grpItemVals.Controls.Add(this.lblType);
            this.grpItemVals.Controls.Add(this.txtID);
            this.grpItemVals.Controls.Add(this.lblID);
            this.grpItemVals.Location = new System.Drawing.Point(12, 27);
            this.grpItemVals.Name = "grpItemVals";
            this.grpItemVals.Size = new System.Drawing.Size(427, 553);
            this.grpItemVals.TabIndex = 4;
            this.grpItemVals.TabStop = false;
            this.grpItemVals.Text = "Item Data";
            // 
            // grpEquipStatus
            // 
            this.grpEquipStatus.Controls.Add(this.dgEquipStatus);
            this.grpEquipStatus.Location = new System.Drawing.Point(13, 454);
            this.grpEquipStatus.Name = "grpEquipStatus";
            this.grpEquipStatus.Size = new System.Drawing.Size(401, 93);
            this.grpEquipStatus.TabIndex = 27;
            this.grpEquipStatus.TabStop = false;
            this.grpEquipStatus.Text = "Equipped Status Effects";
            // 
            // dgEquipStatus
            // 
            this.dgEquipStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.IntValue,
            this.Skill,
            this.Specialization});
            this.dgEquipStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEquipStatus.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgEquipStatus.Location = new System.Drawing.Point(3, 16);
            this.dgEquipStatus.Name = "dgEquipStatus";
            this.dgEquipStatus.Size = new System.Drawing.Size(395, 74);
            this.dgEquipStatus.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.FillWeight = 77F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Attribute";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.FillWeight = 77F;
            this.dataGridViewTextBoxColumn2.HeaderText = "FloatValue";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // IntValue
            // 
            this.IntValue.HeaderText = "Int Value";
            this.IntValue.Name = "IntValue";
            // 
            // Skill
            // 
            this.Skill.HeaderText = "Skill";
            this.Skill.Name = "Skill";
            // 
            // Specialization
            // 
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.Name = "Specialization";
            // 
            // txtSortingGroup
            // 
            this.txtSortingGroup.Location = new System.Drawing.Point(282, 402);
            this.txtSortingGroup.Name = "txtSortingGroup";
            this.txtSortingGroup.Size = new System.Drawing.Size(139, 20);
            this.txtSortingGroup.TabIndex = 44;
            // 
            // lblSortingGroup
            // 
            this.lblSortingGroup.AutoSize = true;
            this.lblSortingGroup.Location = new System.Drawing.Point(201, 405);
            this.lblSortingGroup.Name = "lblSortingGroup";
            this.lblSortingGroup.Size = new System.Drawing.Size(75, 13);
            this.lblSortingGroup.TabIndex = 43;
            this.lblSortingGroup.Text = "Sorting Group:";
            // 
            // chkTargetActor
            // 
            this.chkTargetActor.AutoSize = true;
            this.chkTargetActor.Location = new System.Drawing.Point(304, 379);
            this.chkTargetActor.Name = "chkTargetActor";
            this.chkTargetActor.Size = new System.Drawing.Size(107, 17);
            this.chkTargetActor.TabIndex = 42;
            this.chkTargetActor.Text = "Can Target Actor";
            this.chkTargetActor.UseVisualStyleBackColor = true;
            // 
            // chkAffectsEnemy
            // 
            this.chkAffectsEnemy.AutoSize = true;
            this.chkAffectsEnemy.Location = new System.Drawing.Point(204, 379);
            this.chkAffectsEnemy.Name = "chkAffectsEnemy";
            this.chkAffectsEnemy.Size = new System.Drawing.Size(94, 17);
            this.chkAffectsEnemy.TabIndex = 41;
            this.chkAffectsEnemy.Text = "Affects Enemy";
            this.chkAffectsEnemy.UseVisualStyleBackColor = true;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(241, 353);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(69, 20);
            this.nudPrice.TabIndex = 40;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(201, 355);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 39;
            this.lblPrice.Text = "Price:";
            // 
            // nudReload
            // 
            this.nudReload.Location = new System.Drawing.Point(375, 353);
            this.nudReload.Name = "nudReload";
            this.nudReload.Size = new System.Drawing.Size(39, 20);
            this.nudReload.TabIndex = 38;
            // 
            // lblReloadCost
            // 
            this.lblReloadCost.AutoSize = true;
            this.lblReloadCost.Location = new System.Drawing.Point(313, 355);
            this.lblReloadCost.Name = "lblReloadCost";
            this.lblReloadCost.Size = new System.Drawing.Size(61, 13);
            this.lblReloadCost.TabIndex = 37;
            this.lblReloadCost.Text = "Reload AP:";
            // 
            // grpAbilityModes
            // 
            this.grpAbilityModes.Controls.Add(this.chklstAbilityModes);
            this.grpAbilityModes.Location = new System.Drawing.Point(219, 262);
            this.grpAbilityModes.Name = "grpAbilityModes";
            this.grpAbilityModes.Size = new System.Drawing.Size(202, 74);
            this.grpAbilityModes.TabIndex = 36;
            this.grpAbilityModes.TabStop = false;
            this.grpAbilityModes.Text = "Ability Modes";
            // 
            // chklstAbilityModes
            // 
            this.chklstAbilityModes.FormattingEnabled = true;
            this.chklstAbilityModes.Location = new System.Drawing.Point(6, 19);
            this.chklstAbilityModes.Name = "chklstAbilityModes";
            this.chklstAbilityModes.Size = new System.Drawing.Size(189, 49);
            this.chklstAbilityModes.TabIndex = 35;
            // 
            // grpDmg
            // 
            this.grpDmg.Controls.Add(this.nudAPDmg);
            this.grpDmg.Controls.Add(this.lblAPDmg);
            this.grpDmg.Controls.Add(this.nudHPDmg);
            this.grpDmg.Controls.Add(this.lblHPDmg);
            this.grpDmg.Location = new System.Drawing.Point(10, 262);
            this.grpDmg.Name = "grpDmg";
            this.grpDmg.Size = new System.Drawing.Size(89, 74);
            this.grpDmg.TabIndex = 32;
            this.grpDmg.TabStop = false;
            this.grpDmg.Text = "Damage";
            // 
            // nudAPDmg
            // 
            this.nudAPDmg.Location = new System.Drawing.Point(41, 43);
            this.nudAPDmg.Name = "nudAPDmg";
            this.nudAPDmg.Size = new System.Drawing.Size(39, 20);
            this.nudAPDmg.TabIndex = 29;
            // 
            // lblAPDmg
            // 
            this.lblAPDmg.AutoSize = true;
            this.lblAPDmg.Location = new System.Drawing.Point(10, 45);
            this.lblAPDmg.Name = "lblAPDmg";
            this.lblAPDmg.Size = new System.Drawing.Size(24, 13);
            this.lblAPDmg.TabIndex = 28;
            this.lblAPDmg.Text = "AP:";
            // 
            // nudHPDmg
            // 
            this.nudHPDmg.Location = new System.Drawing.Point(41, 17);
            this.nudHPDmg.Name = "nudHPDmg";
            this.nudHPDmg.Size = new System.Drawing.Size(39, 20);
            this.nudHPDmg.TabIndex = 27;
            // 
            // lblHPDmg
            // 
            this.lblHPDmg.AutoSize = true;
            this.lblHPDmg.Location = new System.Drawing.Point(10, 19);
            this.lblHPDmg.Name = "lblHPDmg";
            this.lblHPDmg.Size = new System.Drawing.Size(25, 13);
            this.lblHPDmg.TabIndex = 26;
            this.lblHPDmg.Text = "HP:";
            // 
            // grpNoise
            // 
            this.grpNoise.Controls.Add(this.nudNoiseLvl);
            this.grpNoise.Controls.Add(this.lblNoiseLvl);
            this.grpNoise.Controls.Add(this.nudNoiseRds);
            this.grpNoise.Controls.Add(this.lblNoiseRds);
            this.grpNoise.Location = new System.Drawing.Point(105, 262);
            this.grpNoise.Name = "grpNoise";
            this.grpNoise.Size = new System.Drawing.Size(108, 74);
            this.grpNoise.TabIndex = 31;
            this.grpNoise.TabStop = false;
            this.grpNoise.Text = "Noise";
            // 
            // nudNoiseLvl
            // 
            this.nudNoiseLvl.Location = new System.Drawing.Point(60, 17);
            this.nudNoiseLvl.Name = "nudNoiseLvl";
            this.nudNoiseLvl.Size = new System.Drawing.Size(39, 20);
            this.nudNoiseLvl.TabIndex = 34;
            // 
            // lblNoiseLvl
            // 
            this.lblNoiseLvl.AutoSize = true;
            this.lblNoiseLvl.Location = new System.Drawing.Point(7, 19);
            this.lblNoiseLvl.Name = "lblNoiseLvl";
            this.lblNoiseLvl.Size = new System.Drawing.Size(36, 13);
            this.lblNoiseLvl.TabIndex = 33;
            this.lblNoiseLvl.Text = "Level:";
            // 
            // nudNoiseRds
            // 
            this.nudNoiseRds.Location = new System.Drawing.Point(60, 43);
            this.nudNoiseRds.Name = "nudNoiseRds";
            this.nudNoiseRds.Size = new System.Drawing.Size(39, 20);
            this.nudNoiseRds.TabIndex = 32;
            // 
            // lblNoiseRds
            // 
            this.lblNoiseRds.AutoSize = true;
            this.lblNoiseRds.Location = new System.Drawing.Point(7, 45);
            this.lblNoiseRds.Name = "lblNoiseRds";
            this.lblNoiseRds.Size = new System.Drawing.Size(47, 13);
            this.lblNoiseRds.TabIndex = 31;
            this.lblNoiseRds.Text = "Rounds:";
            // 
            // grpRangeModTable
            // 
            this.grpRangeModTable.Controls.Add(this.dgRangeModTable);
            this.grpRangeModTable.Location = new System.Drawing.Point(10, 342);
            this.grpRangeModTable.Name = "grpRangeModTable";
            this.grpRangeModTable.Size = new System.Drawing.Size(185, 106);
            this.grpRangeModTable.TabIndex = 26;
            this.grpRangeModTable.TabStop = false;
            this.grpRangeModTable.Text = "Range Mod Table";
            // 
            // dgRangeModTable
            // 
            this.dgRangeModTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRangeModTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRange,
            this.colMod});
            this.dgRangeModTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRangeModTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgRangeModTable.Location = new System.Drawing.Point(3, 16);
            this.dgRangeModTable.Name = "dgRangeModTable";
            this.dgRangeModTable.Size = new System.Drawing.Size(179, 87);
            this.dgRangeModTable.TabIndex = 0;
            // 
            // colRange
            // 
            this.colRange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRange.FillWeight = 77F;
            this.colRange.HeaderText = "Range";
            this.colRange.Name = "colRange";
            this.colRange.Width = 64;
            // 
            // colMod
            // 
            this.colMod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMod.FillWeight = 77F;
            this.colMod.HeaderText = "Mod";
            this.colMod.Name = "colMod";
            this.colMod.Width = 53;
            // 
            // nudAmmo
            // 
            this.nudAmmo.Location = new System.Drawing.Point(309, 205);
            this.nudAmmo.Name = "nudAmmo";
            this.nudAmmo.Size = new System.Drawing.Size(39, 20);
            this.nudAmmo.TabIndex = 21;
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(264, 208);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(39, 13);
            this.lblAmmo.TabIndex = 20;
            this.lblAmmo.Text = "Ammo:";
            // 
            // cboCoreSpec
            // 
            this.cboCoreSpec.FormattingEnabled = true;
            this.cboCoreSpec.Location = new System.Drawing.Point(113, 205);
            this.cboCoreSpec.Name = "cboCoreSpec";
            this.cboCoreSpec.Size = new System.Drawing.Size(145, 21);
            this.cboCoreSpec.TabIndex = 19;
            // 
            // lblCoreSpec
            // 
            this.lblCoreSpec.AutoSize = true;
            this.lblCoreSpec.Location = new System.Drawing.Point(7, 208);
            this.lblCoreSpec.Name = "lblCoreSpec";
            this.lblCoreSpec.Size = new System.Drawing.Size(100, 13);
            this.lblCoreSpec.TabIndex = 18;
            this.lblCoreSpec.Text = "Core Specialization:";
            // 
            // nudAP
            // 
            this.nudAP.Location = new System.Drawing.Point(382, 205);
            this.nudAP.Name = "nudAP";
            this.nudAP.Size = new System.Drawing.Size(39, 20);
            this.nudAP.TabIndex = 17;
            // 
            // lblAPCost
            // 
            this.lblAPCost.AutoSize = true;
            this.lblAPCost.Location = new System.Drawing.Point(352, 208);
            this.lblAPCost.Name = "lblAPCost";
            this.lblAPCost.Size = new System.Drawing.Size(24, 13);
            this.lblAPCost.TabIndex = 15;
            this.lblAPCost.Text = "AP:";
            // 
            // txtPrereq
            // 
            this.txtPrereq.Location = new System.Drawing.Point(59, 233);
            this.txtPrereq.Multiline = true;
            this.txtPrereq.Name = "txtPrereq";
            this.txtPrereq.Size = new System.Drawing.Size(362, 20);
            this.txtPrereq.TabIndex = 14;
            // 
            // lblPrereq
            // 
            this.lblPrereq.AutoSize = true;
            this.lblPrereq.Location = new System.Drawing.Point(7, 236);
            this.lblPrereq.Name = "lblPrereq";
            this.lblPrereq.Size = new System.Drawing.Size(46, 13);
            this.lblPrereq.TabIndex = 13;
            this.lblPrereq.Text = "Prereqs:";
            // 
            // cboCoreSkill
            // 
            this.cboCoreSkill.FormattingEnabled = true;
            this.cboCoreSkill.Location = new System.Drawing.Point(278, 178);
            this.cboCoreSkill.Name = "cboCoreSkill";
            this.cboCoreSkill.Size = new System.Drawing.Size(143, 21);
            this.cboCoreSkill.TabIndex = 12;
            // 
            // lblCoreSkill
            // 
            this.lblCoreSkill.AutoSize = true;
            this.lblCoreSkill.Location = new System.Drawing.Point(218, 181);
            this.lblCoreSkill.Name = "lblCoreSkill";
            this.lblCoreSkill.Size = new System.Drawing.Size(54, 13);
            this.lblCoreSkill.TabIndex = 11;
            this.lblCoreSkill.Text = "Core Skill:";
            // 
            // cboCoreAttribute
            // 
            this.cboCoreAttribute.FormattingEnabled = true;
            this.cboCoreAttribute.Location = new System.Drawing.Point(85, 178);
            this.cboCoreAttribute.Name = "cboCoreAttribute";
            this.cboCoreAttribute.Size = new System.Drawing.Size(127, 21);
            this.cboCoreAttribute.TabIndex = 10;
            // 
            // lblCoreAttrib
            // 
            this.lblCoreAttrib.AutoSize = true;
            this.lblCoreAttrib.Location = new System.Drawing.Point(7, 181);
            this.lblCoreAttrib.Name = "lblCoreAttrib";
            this.lblCoreAttrib.Size = new System.Drawing.Size(74, 13);
            this.lblCoreAttrib.TabIndex = 9;
            this.lblCoreAttrib.Text = "Core Attribute:";
            // 
            // cboAnimType
            // 
            this.cboAnimType.FormattingEnabled = true;
            this.cboAnimType.Location = new System.Drawing.Point(264, 152);
            this.cboAnimType.Name = "cboAnimType";
            this.cboAnimType.Size = new System.Drawing.Size(157, 21);
            this.cboAnimType.TabIndex = 8;
            // 
            // lblAnimType
            // 
            this.lblAnimType.AutoSize = true;
            this.lblAnimType.Location = new System.Drawing.Point(198, 155);
            this.lblAnimType.Name = "lblAnimType";
            this.lblAnimType.Size = new System.Drawing.Size(60, 13);
            this.lblAnimType.TabIndex = 7;
            this.lblAnimType.Text = "Anim Type:";
            // 
            // txtPrefab
            // 
            this.txtPrefab.Location = new System.Drawing.Point(85, 152);
            this.txtPrefab.Name = "txtPrefab";
            this.txtPrefab.Size = new System.Drawing.Size(107, 20);
            this.txtPrefab.TabIndex = 6;
            // 
            // lblEquipprefabname
            // 
            this.lblEquipprefabname.AutoSize = true;
            this.lblEquipprefabname.Location = new System.Drawing.Point(7, 155);
            this.lblEquipprefabname.Name = "lblEquipprefabname";
            this.lblEquipprefabname.Size = new System.Drawing.Size(72, 13);
            this.lblEquipprefabname.TabIndex = 5;
            this.lblEquipprefabname.Text = "Prefab Name:";
            // 
            // grpUIRep
            // 
            this.grpUIRep.Controls.Add(this.txtDescription);
            this.grpUIRep.Controls.Add(this.lblDescription);
            this.grpUIRep.Controls.Add(this.txtName);
            this.grpUIRep.Controls.Add(this.txtIcon);
            this.grpUIRep.Controls.Add(this.lblName);
            this.grpUIRep.Controls.Add(this.lblIcon);
            this.grpUIRep.Location = new System.Drawing.Point(10, 43);
            this.grpUIRep.Name = "grpUIRep";
            this.grpUIRep.Size = new System.Drawing.Size(411, 103);
            this.grpUIRep.TabIndex = 4;
            this.grpUIRep.TabStop = false;
            this.grpUIRep.Text = "UI Representation";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(43, 45);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(362, 49);
            this.txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Desc:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(245, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(43, 16);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(152, 20);
            this.txtIcon.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(201, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(6, 19);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(31, 13);
            this.lblIcon.TabIndex = 1;
            this.lblIcon.Text = "Icon:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(251, 16);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(170, 21);
            this.cboType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(211, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(34, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(7, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SRRUtil_MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 605);
            this.Controls.Add(this.grpItemVals);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SRRUtil_MainFrm";
            this.Text = "SRR Item Creation Utility";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpItemVals.ResumeLayout(false);
            this.grpItemVals.PerformLayout();
            this.grpEquipStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReload)).EndInit();
            this.grpAbilityModes.ResumeLayout(false);
            this.grpDmg.ResumeLayout(false);
            this.grpDmg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAPDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPDmg)).EndInit();
            this.grpNoise.ResumeLayout(false);
            this.grpNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoiseLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoiseRds)).EndInit();
            this.grpRangeModTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRangeModTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAP)).EndInit();
            this.grpUIRep.ResumeLayout(false);
            this.grpUIRep.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grpItemVals;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox grpUIRep;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.TextBox txtPrefab;
        private System.Windows.Forms.Label lblEquipprefabname;
        private System.Windows.Forms.ComboBox cboAnimType;
        private System.Windows.Forms.Label lblAnimType;
        private System.Windows.Forms.ComboBox cboCoreAttribute;
        private System.Windows.Forms.Label lblCoreAttrib;
        private System.Windows.Forms.ComboBox cboCoreSkill;
        private System.Windows.Forms.Label lblCoreSkill;
        private System.Windows.Forms.Label lblAPCost;
        private System.Windows.Forms.TextBox txtPrereq;
        private System.Windows.Forms.Label lblPrereq;
        private System.Windows.Forms.NumericUpDown nudAP;
        private System.Windows.Forms.NumericUpDown nudAmmo;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.ComboBox cboCoreSpec;
        private System.Windows.Forms.Label lblCoreSpec;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpNoise;
        private System.Windows.Forms.NumericUpDown nudNoiseLvl;
        private System.Windows.Forms.Label lblNoiseLvl;
        private System.Windows.Forms.NumericUpDown nudNoiseRds;
        private System.Windows.Forms.Label lblNoiseRds;
        private System.Windows.Forms.GroupBox grpRangeModTable;
        private System.Windows.Forms.DataGridView dgRangeModTable;
        private System.Windows.Forms.ToolStripStatusLabel lblToolStripStatus;
        private System.Windows.Forms.GroupBox grpDmg;
        private System.Windows.Forms.NumericUpDown nudAPDmg;
        private System.Windows.Forms.Label lblAPDmg;
        private System.Windows.Forms.NumericUpDown nudHPDmg;
        private System.Windows.Forms.Label lblHPDmg;
        private System.Windows.Forms.GroupBox grpAbilityModes;
        private System.Windows.Forms.CheckedListBox chklstAbilityModes;
        private System.Windows.Forms.NumericUpDown nudReload;
        private System.Windows.Forms.Label lblReloadCost;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox chkTargetActor;
        private System.Windows.Forms.CheckBox chkAffectsEnemy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMod;
        private System.Windows.Forms.TextBox txtSortingGroup;
        private System.Windows.Forms.Label lblSortingGroup;
        private System.Windows.Forms.GroupBox grpEquipStatus;
        private System.Windows.Forms.DataGridView dgEquipStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
    }
}

