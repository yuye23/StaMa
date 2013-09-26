using CollectionManager.DATA.Database;
namespace CollectionManager
{
    partial class MainForm
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
            //deleteUnnecessaryImge();
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsddbStampQueryManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiStampClassManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStampUnitManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddStamp = new System.Windows.Forms.ToolStripButton();
            this.tsbEditStamp = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteStamp = new System.Windows.Forms.ToolStripButton();
            this.tsddbCoinQueryManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCoinClassManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCoinUnitManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddCoin = new System.Windows.Forms.ToolStripButton();
            this.tsbEditCoin = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteCoin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbChangeMode = new System.Windows.Forms.ToolStripButton();
            this.tssbDataManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiDelUnuseedImg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackAllData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picpathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewstampinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet = new CollectionManager.DATA.Database.CollectionDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSClass = new System.Windows.Forms.TextBox();
            this.tbSType = new System.Windows.Forms.TextBox();
            this.tbSPrice = new System.Windows.Forms.TextBox();
            this.tbSUnit = new System.Windows.Forms.TextBox();
            this.tbSPubDate = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtSMemo = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentidCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishdateCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitnameCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_oriCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picpathCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitidCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidCoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewcoininfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCType = new System.Windows.Forms.TextBox();
            this.tbCClass = new System.Windows.Forms.TextBox();
            this.tbCPrice = new System.Windows.Forms.TextBox();
            this.tbCUnit = new System.Windows.Forms.TextBox();
            this.tbCPubDate = new System.Windows.Forms.TextBox();
            this.tbCPublisher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rtCMemo = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cMSDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditStamp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteStamp = new System.Windows.Forms.ToolStripMenuItem();
            this.cMSTypeTreeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddStamp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDownNode = new System.Windows.Forms.ToolStripMenuItem();
            this.view_stampinfoTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.view_stampinfoTableAdapter();
            this.view_coininfoTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.view_coininfoTableAdapter();
            this.cMCTypeTreeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcmiAddCoin = new System.Windows.Forms.ToolStripMenuItem();
            this.tcmiAddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.tcmiEditNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tcmiDeleteNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tcmiUpNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tcmiDownNode = new System.Windows.Forms.ToolStripMenuItem();
            this.cMCDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcmiEditCoin = new System.Windows.Forms.ToolStripMenuItem();
            this.tcmiDeleteCoin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewstampinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcoininfoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.cMSDataGridView.SuspendLayout();
            this.cMSTypeTreeNode.SuspendLayout();
            this.cMCTypeTreeNode.SuspendLayout();
            this.cMCDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbStampQueryManage,
            this.toolStripSeparator1,
            this.tsbAddStamp,
            this.tsbEditStamp,
            this.tsbDeleteStamp,
            this.tsddbCoinQueryManage,
            this.toolStripSeparator2,
            this.tsbAddCoin,
            this.tsbEditCoin,
            this.tsbDeleteCoin,
            this.toolStripSeparator3,
            this.tsbChangeMode,
            this.tssbDataManage,
            this.tsddbHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1026, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsddbStampQueryManage
            // 
            this.tsddbStampQueryManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbStampQueryManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStampClassManage,
            this.tsmiStampUnitManage});
            this.tsddbStampQueryManage.Image = ((System.Drawing.Image)(resources.GetObject("tsddbStampQueryManage.Image")));
            this.tsddbStampQueryManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbStampQueryManage.Name = "tsddbStampQueryManage";
            this.tsddbStampQueryManage.Size = new System.Drawing.Size(85, 22);
            this.tsddbStampQueryManage.Text = "查询管理";
            // 
            // tsmiStampClassManage
            // 
            this.tsmiStampClassManage.Name = "tsmiStampClassManage";
            this.tsmiStampClassManage.Size = new System.Drawing.Size(140, 22);
            this.tsmiStampClassManage.Text = "分类管理";
            this.tsmiStampClassManage.Click += new System.EventHandler(this.tsmiClassManage_Click);
            // 
            // tsmiStampUnitManage
            // 
            this.tsmiStampUnitManage.Name = "tsmiStampUnitManage";
            this.tsmiStampUnitManage.Size = new System.Drawing.Size(140, 22);
            this.tsmiStampUnitManage.Text = "单位管理";
            this.tsmiStampUnitManage.Click += new System.EventHandler(this.tsmiUnitManage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddStamp
            // 
            this.tsbAddStamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddStamp.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddStamp.Image")));
            this.tsbAddStamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddStamp.Name = "tsbAddStamp";
            this.tsbAddStamp.Size = new System.Drawing.Size(76, 22);
            this.tsbAddStamp.Text = "新增邮票";
            this.tsbAddStamp.Click += new System.EventHandler(this.tsbAddStamp_Click);
            // 
            // tsbEditStamp
            // 
            this.tsbEditStamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditStamp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbEditStamp.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditStamp.Image")));
            this.tsbEditStamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditStamp.Name = "tsbEditStamp";
            this.tsbEditStamp.Size = new System.Drawing.Size(76, 22);
            this.tsbEditStamp.Text = "编辑邮票";
            this.tsbEditStamp.Click += new System.EventHandler(this.tsbEditStamp_Click);
            // 
            // tsbDeleteStamp
            // 
            this.tsbDeleteStamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteStamp.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteStamp.Image")));
            this.tsbDeleteStamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteStamp.Name = "tsbDeleteStamp";
            this.tsbDeleteStamp.Size = new System.Drawing.Size(76, 22);
            this.tsbDeleteStamp.Text = "删除邮票";
            this.tsbDeleteStamp.Click += new System.EventHandler(this.tsbDeleteStamp_Click);
            // 
            // tsddbCoinQueryManage
            // 
            this.tsddbCoinQueryManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbCoinQueryManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCoinClassManage,
            this.tsmiCoinUnitManage});
            this.tsddbCoinQueryManage.Image = ((System.Drawing.Image)(resources.GetObject("tsddbCoinQueryManage.Image")));
            this.tsddbCoinQueryManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbCoinQueryManage.Name = "tsddbCoinQueryManage";
            this.tsddbCoinQueryManage.Size = new System.Drawing.Size(85, 22);
            this.tsddbCoinQueryManage.Text = "查询管理";
            // 
            // tsmiCoinClassManage
            // 
            this.tsmiCoinClassManage.Name = "tsmiCoinClassManage";
            this.tsmiCoinClassManage.Size = new System.Drawing.Size(140, 22);
            this.tsmiCoinClassManage.Text = "分类管理";
            this.tsmiCoinClassManage.Click += new System.EventHandler(this.tsmiCoinClassManage_Click);
            // 
            // tsmiCoinUnitManage
            // 
            this.tsmiCoinUnitManage.Name = "tsmiCoinUnitManage";
            this.tsmiCoinUnitManage.Size = new System.Drawing.Size(140, 22);
            this.tsmiCoinUnitManage.Text = "单位管理";
            this.tsmiCoinUnitManage.Click += new System.EventHandler(this.tsmiCoinUnitManage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddCoin
            // 
            this.tsbAddCoin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddCoin.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddCoin.Image")));
            this.tsbAddCoin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddCoin.Name = "tsbAddCoin";
            this.tsbAddCoin.Size = new System.Drawing.Size(76, 22);
            this.tsbAddCoin.Text = "新增钱币";
            this.tsbAddCoin.Click += new System.EventHandler(this.tsbAddCoin_Click);
            // 
            // tsbEditCoin
            // 
            this.tsbEditCoin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditCoin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbEditCoin.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditCoin.Image")));
            this.tsbEditCoin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditCoin.Name = "tsbEditCoin";
            this.tsbEditCoin.Size = new System.Drawing.Size(76, 22);
            this.tsbEditCoin.Text = "编辑钱币";
            this.tsbEditCoin.Click += new System.EventHandler(this.tsbEditCoin_Click);
            // 
            // tsbDeleteCoin
            // 
            this.tsbDeleteCoin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteCoin.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteCoin.Image")));
            this.tsbDeleteCoin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteCoin.Name = "tsbDeleteCoin";
            this.tsbDeleteCoin.Size = new System.Drawing.Size(76, 22);
            this.tsbDeleteCoin.Text = "删除钱币";
            this.tsbDeleteCoin.Click += new System.EventHandler(this.tsbDeleteCoin_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbChangeMode
            // 
            this.tsbChangeMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeMode.Image")));
            this.tsbChangeMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeMode.Name = "tsbChangeMode";
            this.tsbChangeMode.Size = new System.Drawing.Size(76, 22);
            this.tsbChangeMode.Text = "欣赏模式";
            this.tsbChangeMode.Click += new System.EventHandler(this.tsbChangeMode_Click);
            // 
            // tssbDataManage
            // 
            this.tssbDataManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssbDataManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelUnuseedImg,
            this.tsmiBackAllData});
            this.tssbDataManage.Image = ((System.Drawing.Image)(resources.GetObject("tssbDataManage.Image")));
            this.tssbDataManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbDataManage.Name = "tssbDataManage";
            this.tssbDataManage.Size = new System.Drawing.Size(85, 22);
            this.tssbDataManage.Text = "数据处理";
            this.tssbDataManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssbDataManage.ToolTipText = "数据处理";
            // 
            // tsmiDelUnuseedImg
            // 
            this.tsmiDelUnuseedImg.Name = "tsmiDelUnuseedImg";
            this.tsmiDelUnuseedImg.Size = new System.Drawing.Size(172, 22);
            this.tsmiDelUnuseedImg.Text = "清除多余图片";
            this.tsmiDelUnuseedImg.Click += new System.EventHandler(this.tsmiDelUnuseedImg_Click);
            // 
            // tsmiBackAllData
            // 
            this.tsmiBackAllData.Name = "tsmiBackAllData";
            this.tsmiBackAllData.Size = new System.Drawing.Size(172, 22);
            this.tsmiBackAllData.Text = "备份数据";
            this.tsmiBackAllData.Click += new System.EventHandler(this.tsmiBackAllData_Click);
            // 
            // tsddbHelp
            // 
            this.tsddbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsddbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.tsmiAbout});
            this.tsddbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsddbHelp.Image")));
            this.tsddbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbHelp.Name = "tsddbHelp";
            this.tsddbHelp.Size = new System.Drawing.Size(53, 22);
            this.tsddbHelp.Text = "帮助";
            this.tsddbHelp.ToolTipText = "帮助";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(140, 22);
            this.tsmiHelp.Text = "查看帮助";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(140, 22);
            this.tsmiAbout.Text = "关于..";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 709);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1018, 680);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "邮票收藏";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 672);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.ItemHeight = 22;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(236, 668);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(768, 672);
            this.splitContainer2.SplitterDistance = 201;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.parentidDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.publishdateDataGridViewTextBoxColumn,
            this.unitnameDataGridViewTextBoxColumn,
            this.priceoriDataGridViewTextBoxColumn,
            this.typenameDataGridViewTextBoxColumn,
            this.classnameDataGridViewTextBoxColumn,
            this.picpathDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.unitidDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewstampinfoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.FillWeight = 10F;
            this.codeDataGridViewTextBoxColumn.HeaderText = "志号";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 27F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentidDataGridViewTextBoxColumn
            // 
            this.parentidDataGridViewTextBoxColumn.DataPropertyName = "parentid";
            this.parentidDataGridViewTextBoxColumn.HeaderText = "parentid";
            this.parentidDataGridViewTextBoxColumn.Name = "parentidDataGridViewTextBoxColumn";
            this.parentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "orderid";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "orderid";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderidDataGridViewTextBoxColumn.Visible = false;
            // 
            // publishdateDataGridViewTextBoxColumn
            // 
            this.publishdateDataGridViewTextBoxColumn.DataPropertyName = "publishdate";
            this.publishdateDataGridViewTextBoxColumn.FillWeight = 15F;
            this.publishdateDataGridViewTextBoxColumn.HeaderText = "出版日期";
            this.publishdateDataGridViewTextBoxColumn.Name = "publishdateDataGridViewTextBoxColumn";
            this.publishdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitnameDataGridViewTextBoxColumn
            // 
            this.unitnameDataGridViewTextBoxColumn.DataPropertyName = "unitname";
            this.unitnameDataGridViewTextBoxColumn.FillWeight = 10F;
            this.unitnameDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitnameDataGridViewTextBoxColumn.Name = "unitnameDataGridViewTextBoxColumn";
            this.unitnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceoriDataGridViewTextBoxColumn
            // 
            this.priceoriDataGridViewTextBoxColumn.DataPropertyName = "price_ori";
            this.priceoriDataGridViewTextBoxColumn.FillWeight = 10F;
            this.priceoriDataGridViewTextBoxColumn.HeaderText = "面值";
            this.priceoriDataGridViewTextBoxColumn.Name = "priceoriDataGridViewTextBoxColumn";
            this.priceoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "typename";
            this.typenameDataGridViewTextBoxColumn.FillWeight = 15F;
            this.typenameDataGridViewTextBoxColumn.HeaderText = "自建分类";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            this.typenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classnameDataGridViewTextBoxColumn
            // 
            this.classnameDataGridViewTextBoxColumn.DataPropertyName = "classname";
            this.classnameDataGridViewTextBoxColumn.FillWeight = 15F;
            this.classnameDataGridViewTextBoxColumn.HeaderText = "类型";
            this.classnameDataGridViewTextBoxColumn.Name = "classnameDataGridViewTextBoxColumn";
            this.classnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picpathDataGridViewTextBoxColumn
            // 
            this.picpathDataGridViewTextBoxColumn.DataPropertyName = "picpath";
            this.picpathDataGridViewTextBoxColumn.HeaderText = "picpath";
            this.picpathDataGridViewTextBoxColumn.Name = "picpathDataGridViewTextBoxColumn";
            this.picpathDataGridViewTextBoxColumn.ReadOnly = true;
            this.picpathDataGridViewTextBoxColumn.Visible = false;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitidDataGridViewTextBoxColumn
            // 
            this.unitidDataGridViewTextBoxColumn.DataPropertyName = "unitid";
            this.unitidDataGridViewTextBoxColumn.HeaderText = "unitid";
            this.unitidDataGridViewTextBoxColumn.Name = "unitidDataGridViewTextBoxColumn";
            this.unitidDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitidDataGridViewTextBoxColumn.Visible = false;
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "classid";
            this.classidDataGridViewTextBoxColumn.HeaderText = "classid";
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            this.classidDataGridViewTextBoxColumn.ReadOnly = true;
            this.classidDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "typeid";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "typeid";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            this.typeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewstampinfoBindingSource
            // 
            this.viewstampinfoBindingSource.DataMember = "view_stampinfo";
            this.viewstampinfoBindingSource.DataSource = this.collectionDataSet;
            // 
            // collectionDataSet
            // 
            this.collectionDataSet.DataSetName = "CollectionDataSet";
            this.collectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.splitContainer3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 22);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer3.Size = new System.Drawing.Size(758, 439);
            this.splitContainer3.SplitterDistance = 318;
            this.splitContainer3.SplitterWidth = 2;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label8);
            this.splitContainer4.Panel1.Controls.Add(this.tbSClass);
            this.splitContainer4.Panel1.Controls.Add(this.tbSType);
            this.splitContainer4.Panel1.Controls.Add(this.tbSPrice);
            this.splitContainer4.Panel1.Controls.Add(this.tbSUnit);
            this.splitContainer4.Panel1.Controls.Add(this.tbSPubDate);
            this.splitContainer4.Panel1.Controls.Add(this.tbSName);
            this.splitContainer4.Panel1.Controls.Add(this.label7);
            this.splitContainer4.Panel1.Controls.Add(this.label6);
            this.splitContainer4.Panel1.Controls.Add(this.label5);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.Controls.Add(this.tbSCode);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.rtSMemo);
            this.splitContainer4.Size = new System.Drawing.Size(318, 439);
            this.splitContainer4.SplitterDistance = 228;
            this.splitContainer4.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "备    注：";
            // 
            // tbSClass
            // 
            this.tbSClass.Location = new System.Drawing.Point(82, 177);
            this.tbSClass.Name = "tbSClass";
            this.tbSClass.ReadOnly = true;
            this.tbSClass.Size = new System.Drawing.Size(235, 26);
            this.tbSClass.TabIndex = 13;
            // 
            // tbSType
            // 
            this.tbSType.Location = new System.Drawing.Point(82, 148);
            this.tbSType.Name = "tbSType";
            this.tbSType.ReadOnly = true;
            this.tbSType.Size = new System.Drawing.Size(235, 26);
            this.tbSType.TabIndex = 12;
            // 
            // tbSPrice
            // 
            this.tbSPrice.Location = new System.Drawing.Point(82, 119);
            this.tbSPrice.Name = "tbSPrice";
            this.tbSPrice.ReadOnly = true;
            this.tbSPrice.Size = new System.Drawing.Size(235, 26);
            this.tbSPrice.TabIndex = 11;
            // 
            // tbSUnit
            // 
            this.tbSUnit.Location = new System.Drawing.Point(82, 90);
            this.tbSUnit.Name = "tbSUnit";
            this.tbSUnit.ReadOnly = true;
            this.tbSUnit.Size = new System.Drawing.Size(235, 26);
            this.tbSUnit.TabIndex = 10;
            // 
            // tbSPubDate
            // 
            this.tbSPubDate.Location = new System.Drawing.Point(82, 61);
            this.tbSPubDate.Name = "tbSPubDate";
            this.tbSPubDate.ReadOnly = true;
            this.tbSPubDate.Size = new System.Drawing.Size(235, 26);
            this.tbSPubDate.TabIndex = 9;
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(82, 32);
            this.tbSName.Name = "tbSName";
            this.tbSName.ReadOnly = true;
            this.tbSName.Size = new System.Drawing.Size(235, 26);
            this.tbSName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "类    型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "自建分类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "面    值：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "单    位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "出版日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "名    称：";
            // 
            // tbSCode
            // 
            this.tbSCode.Location = new System.Drawing.Point(82, 3);
            this.tbSCode.Name = "tbSCode";
            this.tbSCode.ReadOnly = true;
            this.tbSCode.Size = new System.Drawing.Size(235, 26);
            this.tbSCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "志    号：";
            // 
            // rtSMemo
            // 
            this.rtSMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtSMemo.Location = new System.Drawing.Point(0, 0);
            this.rtSMemo.Name = "rtSMemo";
            this.rtSMemo.ReadOnly = true;
            this.rtSMemo.Size = new System.Drawing.Size(318, 207);
            this.rtSMemo.TabIndex = 0;
            this.rtSMemo.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 439);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1018, 680);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "钱币收藏";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(4, 4);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.treeView2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(1010, 672);
            this.splitContainer5.SplitterDistance = 240;
            this.splitContainer5.SplitterWidth = 2;
            this.splitContainer5.TabIndex = 1;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.Window;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.FullRowSelect = true;
            this.treeView2.HideSelection = false;
            this.treeView2.ItemHeight = 22;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Margin = new System.Windows.Forms.Padding(4);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(236, 668);
            this.treeView2.TabIndex = 0;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            this.treeView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView2_MouseDown);
            // 
            // splitContainer6
            // 
            this.splitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer6.Size = new System.Drawing.Size(764, 668);
            this.splitContainer6.SplitterDistance = 193;
            this.splitContainer6.SplitterWidth = 3;
            this.splitContainer6.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCoinDataGridViewTextBoxColumn,
            this.nameCoinDataGridViewTextBoxColumn,
            this.publisherCoinDataGridViewTextBoxColumn,
            this.parentidCoinDataGridViewTextBoxColumn,
            this.orderidCoinDataGridViewTextBoxColumn,
            this.publishdateCoinDataGridViewTextBoxColumn,
            this.unitnameCoinDataGridViewTextBoxColumn,
            this.price_oriCoinDataGridViewTextBoxColumn,
            this.typenameCoinDataGridViewTextBoxColumn,
            this.classnameCoinDataGridViewTextBoxColumn,
            this.picpathCoinDataGridViewTextBoxColumn,
            this.memoCoinDataGridViewTextBoxColumn,
            this.unitidCoinDataGridViewTextBoxColumn,
            this.classidCoinDataGridViewTextBoxColumn,
            this.typeidCoinDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.viewcoininfoBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(760, 189);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDown);
            this.dataGridView2.Sorted += new System.EventHandler(this.dataGridView2_Sorted);
            // 
            // idCoinDataGridViewTextBoxColumn
            // 
            this.idCoinDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idCoinDataGridViewTextBoxColumn.HeaderText = "id";
            this.idCoinDataGridViewTextBoxColumn.Name = "idCoinDataGridViewTextBoxColumn";
            this.idCoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameCoinDataGridViewTextBoxColumn
            // 
            this.nameCoinDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameCoinDataGridViewTextBoxColumn.FillWeight = 20F;
            this.nameCoinDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameCoinDataGridViewTextBoxColumn.Name = "nameCoinDataGridViewTextBoxColumn";
            this.nameCoinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherCoinDataGridViewTextBoxColumn
            // 
            this.publisherCoinDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherCoinDataGridViewTextBoxColumn.FillWeight = 20F;
            this.publisherCoinDataGridViewTextBoxColumn.HeaderText = "发行单位";
            this.publisherCoinDataGridViewTextBoxColumn.Name = "publisherCoinDataGridViewTextBoxColumn";
            this.publisherCoinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentidCoinDataGridViewTextBoxColumn
            // 
            this.parentidCoinDataGridViewTextBoxColumn.DataPropertyName = "parentid";
            this.parentidCoinDataGridViewTextBoxColumn.HeaderText = "parentid";
            this.parentidCoinDataGridViewTextBoxColumn.Name = "parentidCoinDataGridViewTextBoxColumn";
            this.parentidCoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentidCoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderidCoinDataGridViewTextBoxColumn
            // 
            this.orderidCoinDataGridViewTextBoxColumn.DataPropertyName = "orderid";
            this.orderidCoinDataGridViewTextBoxColumn.HeaderText = "orderid";
            this.orderidCoinDataGridViewTextBoxColumn.Name = "orderidCoinDataGridViewTextBoxColumn";
            this.orderidCoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderidCoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // publishdateCoinDataGridViewTextBoxColumn
            // 
            this.publishdateCoinDataGridViewTextBoxColumn.DataPropertyName = "publishdate";
            this.publishdateCoinDataGridViewTextBoxColumn.FillWeight = 13F;
            this.publishdateCoinDataGridViewTextBoxColumn.HeaderText = "发行日期";
            this.publishdateCoinDataGridViewTextBoxColumn.Name = "publishdateCoinDataGridViewTextBoxColumn";
            this.publishdateCoinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitnameCoinDataGridViewTextBoxColumn
            // 
            this.unitnameCoinDataGridViewTextBoxColumn.DataPropertyName = "unitname";
            this.unitnameCoinDataGridViewTextBoxColumn.FillWeight = 10F;
            this.unitnameCoinDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitnameCoinDataGridViewTextBoxColumn.Name = "unitnameCoinDataGridViewTextBoxColumn";
            this.unitnameCoinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // price_oriCoinDataGridViewTextBoxColumn
            // 
            this.price_oriCoinDataGridViewTextBoxColumn.DataPropertyName = "price_ori";
            this.price_oriCoinDataGridViewTextBoxColumn.FillWeight = 10F;
            this.price_oriCoinDataGridViewTextBoxColumn.HeaderText = "面值";
            this.price_oriCoinDataGridViewTextBoxColumn.Name = "price_oriCoinDataGridViewTextBoxColumn";
            this.price_oriCoinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typenameCoinDataGridViewTextBoxColumn
            // 
            this.typenameCoinDataGridViewTextBoxColumn.DataPropertyName = "typename";
            this.typenameCoinDataGridViewTextBoxColumn.FillWeight = 15F;
            this.typenameCoinDataGridViewTextBoxColumn.HeaderText = "自建分类";
            this.typenameCoinDataGridViewTextBoxColumn.Name = "typenameCoinDataGridViewTextBoxColumn";
            this.typenameCoinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classnameCoinDataGridViewTextBoxColumn
            // 
            this.classnameCoinDataGridViewTextBoxColumn.DataPropertyName = "classname";
            this.classnameCoinDataGridViewTextBoxColumn.FillWeight = 12F;
            this.classnameCoinDataGridViewTextBoxColumn.HeaderText = "类型";
            this.classnameCoinDataGridViewTextBoxColumn.Name = "classnameCoinDataGridViewTextBoxColumn";
            this.classnameCoinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picpathCoinDataGridViewTextBoxColumn
            // 
            this.picpathCoinDataGridViewTextBoxColumn.DataPropertyName = "picpath";
            this.picpathCoinDataGridViewTextBoxColumn.HeaderText = "picpath";
            this.picpathCoinDataGridViewTextBoxColumn.Name = "picpathCoinDataGridViewTextBoxColumn";
            this.picpathCoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.picpathCoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // memoCoinDataGridViewTextBoxColumn
            // 
            this.memoCoinDataGridViewTextBoxColumn.DataPropertyName = "memo";
            this.memoCoinDataGridViewTextBoxColumn.HeaderText = "memo";
            this.memoCoinDataGridViewTextBoxColumn.Name = "memoCoinDataGridViewTextBoxColumn";
            this.memoCoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoCoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitidCoinDataGridViewTextBoxColumn
            // 
            this.unitidCoinDataGridViewTextBoxColumn.DataPropertyName = "unitid";
            this.unitidCoinDataGridViewTextBoxColumn.HeaderText = "unitid";
            this.unitidCoinDataGridViewTextBoxColumn.Name = "unitidCoinDataGridViewTextBoxColumn";
            this.unitidCoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitidCoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // classidCoinDataGridViewTextBoxColumn
            // 
            this.classidCoinDataGridViewTextBoxColumn.DataPropertyName = "classid";
            this.classidCoinDataGridViewTextBoxColumn.HeaderText = "classid";
            this.classidCoinDataGridViewTextBoxColumn.Name = "classidCoinDataGridViewTextBoxColumn";
            this.classidCoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.classidCoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeidCoinDataGridViewTextBoxColumn
            // 
            this.typeidCoinDataGridViewTextBoxColumn.DataPropertyName = "typeid";
            this.typeidCoinDataGridViewTextBoxColumn.HeaderText = "typeid";
            this.typeidCoinDataGridViewTextBoxColumn.Name = "typeidCoinDataGridViewTextBoxColumn";
            this.typeidCoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeidCoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewcoininfoBindingSource
            // 
            this.viewcoininfoBindingSource.DataMember = "view_coininfo";
            this.viewcoininfoBindingSource.DataSource = this.collectionDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.splitContainer7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 468);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细信息";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.Location = new System.Drawing.Point(3, 17);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer7.Size = new System.Drawing.Size(754, 448);
            this.splitContainer7.SplitterDistance = 313;
            this.splitContainer7.SplitterWidth = 2;
            this.splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.label9);
            this.splitContainer8.Panel1.Controls.Add(this.tbCType);
            this.splitContainer8.Panel1.Controls.Add(this.tbCClass);
            this.splitContainer8.Panel1.Controls.Add(this.tbCPrice);
            this.splitContainer8.Panel1.Controls.Add(this.tbCUnit);
            this.splitContainer8.Panel1.Controls.Add(this.tbCPubDate);
            this.splitContainer8.Panel1.Controls.Add(this.tbCPublisher);
            this.splitContainer8.Panel1.Controls.Add(this.label10);
            this.splitContainer8.Panel1.Controls.Add(this.label11);
            this.splitContainer8.Panel1.Controls.Add(this.label12);
            this.splitContainer8.Panel1.Controls.Add(this.label13);
            this.splitContainer8.Panel1.Controls.Add(this.label14);
            this.splitContainer8.Panel1.Controls.Add(this.label15);
            this.splitContainer8.Panel1.Controls.Add(this.tbCName);
            this.splitContainer8.Panel1.Controls.Add(this.label16);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.rtCMemo);
            this.splitContainer8.Size = new System.Drawing.Size(313, 448);
            this.splitContainer8.SplitterDistance = 228;
            this.splitContainer8.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "备    注：";
            // 
            // tbCType
            // 
            this.tbCType.Location = new System.Drawing.Point(82, 177);
            this.tbCType.Name = "tbCType";
            this.tbCType.ReadOnly = true;
            this.tbCType.Size = new System.Drawing.Size(235, 26);
            this.tbCType.TabIndex = 13;
            // 
            // tbCClass
            // 
            this.tbCClass.Location = new System.Drawing.Point(82, 148);
            this.tbCClass.Name = "tbCClass";
            this.tbCClass.ReadOnly = true;
            this.tbCClass.Size = new System.Drawing.Size(235, 26);
            this.tbCClass.TabIndex = 12;
            // 
            // tbCPrice
            // 
            this.tbCPrice.Location = new System.Drawing.Point(82, 119);
            this.tbCPrice.Name = "tbCPrice";
            this.tbCPrice.ReadOnly = true;
            this.tbCPrice.Size = new System.Drawing.Size(235, 26);
            this.tbCPrice.TabIndex = 11;
            // 
            // tbCUnit
            // 
            this.tbCUnit.Location = new System.Drawing.Point(82, 90);
            this.tbCUnit.Name = "tbCUnit";
            this.tbCUnit.ReadOnly = true;
            this.tbCUnit.Size = new System.Drawing.Size(235, 26);
            this.tbCUnit.TabIndex = 10;
            // 
            // tbCPubDate
            // 
            this.tbCPubDate.Location = new System.Drawing.Point(82, 61);
            this.tbCPubDate.Name = "tbCPubDate";
            this.tbCPubDate.ReadOnly = true;
            this.tbCPubDate.Size = new System.Drawing.Size(235, 26);
            this.tbCPubDate.TabIndex = 9;
            // 
            // tbCPublisher
            // 
            this.tbCPublisher.Location = new System.Drawing.Point(82, 32);
            this.tbCPublisher.Name = "tbCPublisher";
            this.tbCPublisher.ReadOnly = true;
            this.tbCPublisher.Size = new System.Drawing.Size(235, 26);
            this.tbCPublisher.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "类    型：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "自建分类：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "面    值：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "单    位：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "发行日期：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "发行单位：";
            // 
            // tbCName
            // 
            this.tbCName.Location = new System.Drawing.Point(82, 3);
            this.tbCName.Name = "tbCName";
            this.tbCName.ReadOnly = true;
            this.tbCName.Size = new System.Drawing.Size(235, 26);
            this.tbCName.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "名    称：";
            // 
            // rtCMemo
            // 
            this.rtCMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtCMemo.Location = new System.Drawing.Point(0, 0);
            this.rtCMemo.Name = "rtCMemo";
            this.rtCMemo.ReadOnly = true;
            this.rtCMemo.Size = new System.Drawing.Size(313, 216);
            this.rtCMemo.TabIndex = 0;
            this.rtCMemo.Text = "";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(439, 448);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // cMSDataGridView
            // 
            this.cMSDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditStamp,
            this.tsmiDeleteStamp});
            this.cMSDataGridView.Name = "cMSDataGridView";
            this.cMSDataGridView.Size = new System.Drawing.Size(119, 48);
            // 
            // tsmiEditStamp
            // 
            this.tsmiEditStamp.Name = "tsmiEditStamp";
            this.tsmiEditStamp.Size = new System.Drawing.Size(118, 22);
            this.tsmiEditStamp.Text = "编辑邮票";
            this.tsmiEditStamp.Click += new System.EventHandler(this.tsmiEditStamp_Click);
            // 
            // tsmiDeleteStamp
            // 
            this.tsmiDeleteStamp.Name = "tsmiDeleteStamp";
            this.tsmiDeleteStamp.Size = new System.Drawing.Size(118, 22);
            this.tsmiDeleteStamp.Text = "删除邮票";
            this.tsmiDeleteStamp.Click += new System.EventHandler(this.tsmiDeleteStamp_Click);
            // 
            // cMSTypeTreeNode
            // 
            this.cMSTypeTreeNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStamp,
            this.tsmiAddChild,
            this.tsmiEditNode,
            this.tsmiDeleteNode,
            this.tsmiUpNode,
            this.tsmiDownNode});
            this.cMSTypeTreeNode.Name = "contextMenuStrip1";
            this.cMSTypeTreeNode.Size = new System.Drawing.Size(119, 136);
            this.cMSTypeTreeNode.Opening += new System.ComponentModel.CancelEventHandler(this.cMSTypeTreeNode_Opening);
            // 
            // tsmiAddStamp
            // 
            this.tsmiAddStamp.Name = "tsmiAddStamp";
            this.tsmiAddStamp.Size = new System.Drawing.Size(118, 22);
            this.tsmiAddStamp.Text = "新增邮票";
            this.tsmiAddStamp.Click += new System.EventHandler(this.addStampMS_Click);
            // 
            // tsmiAddChild
            // 
            this.tsmiAddChild.Name = "tsmiAddChild";
            this.tsmiAddChild.Size = new System.Drawing.Size(118, 22);
            this.tsmiAddChild.Text = "增加子类";
            this.tsmiAddChild.Click += new System.EventHandler(this.addChild_Click);
            // 
            // tsmiEditNode
            // 
            this.tsmiEditNode.Name = "tsmiEditNode";
            this.tsmiEditNode.Size = new System.Drawing.Size(118, 22);
            this.tsmiEditNode.Text = "编辑选中";
            this.tsmiEditNode.Click += new System.EventHandler(this.tsmiEditNode_Click);
            // 
            // tsmiDeleteNode
            // 
            this.tsmiDeleteNode.Name = "tsmiDeleteNode";
            this.tsmiDeleteNode.Size = new System.Drawing.Size(118, 22);
            this.tsmiDeleteNode.Text = "删除选中";
            this.tsmiDeleteNode.Click += new System.EventHandler(this.deleteNode_Click);
            // 
            // tsmiUpNode
            // 
            this.tsmiUpNode.Name = "tsmiUpNode";
            this.tsmiUpNode.Size = new System.Drawing.Size(118, 22);
            this.tsmiUpNode.Text = "向上移动";
            this.tsmiUpNode.Click += new System.EventHandler(this.tsmiUpNode_Click);
            // 
            // tsmiDownNode
            // 
            this.tsmiDownNode.Name = "tsmiDownNode";
            this.tsmiDownNode.Size = new System.Drawing.Size(118, 22);
            this.tsmiDownNode.Text = "向下移动";
            this.tsmiDownNode.Click += new System.EventHandler(this.tsmiDownNode_Click);
            // 
            // view_stampinfoTableAdapter
            // 
            this.view_stampinfoTableAdapter.ClearBeforeFill = true;
            // 
            // view_coininfoTableAdapter
            // 
            this.view_coininfoTableAdapter.ClearBeforeFill = true;
            // 
            // cMCTypeTreeNode
            // 
            this.cMCTypeTreeNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcmiAddCoin,
            this.tcmiAddChild,
            this.tcmiEditNode,
            this.tcmiDeleteNode,
            this.tcmiUpNode,
            this.tcmiDownNode});
            this.cMCTypeTreeNode.Name = "contextMenuStrip1";
            this.cMCTypeTreeNode.Size = new System.Drawing.Size(119, 136);
            // 
            // tcmiAddCoin
            // 
            this.tcmiAddCoin.Name = "tcmiAddCoin";
            this.tcmiAddCoin.Size = new System.Drawing.Size(118, 22);
            this.tcmiAddCoin.Text = "新增钱币";
            this.tcmiAddCoin.Click += new System.EventHandler(this.tcmiAddCoin_Click);
            // 
            // tcmiAddChild
            // 
            this.tcmiAddChild.Name = "tcmiAddChild";
            this.tcmiAddChild.Size = new System.Drawing.Size(118, 22);
            this.tcmiAddChild.Text = "增加子类";
            this.tcmiAddChild.Click += new System.EventHandler(this.tcmiAddChild_Click);
            // 
            // tcmiEditNode
            // 
            this.tcmiEditNode.Name = "tcmiEditNode";
            this.tcmiEditNode.Size = new System.Drawing.Size(118, 22);
            this.tcmiEditNode.Text = "编辑选中";
            this.tcmiEditNode.Click += new System.EventHandler(this.tcmiEditNode_Click);
            // 
            // tcmiDeleteNode
            // 
            this.tcmiDeleteNode.Name = "tcmiDeleteNode";
            this.tcmiDeleteNode.Size = new System.Drawing.Size(118, 22);
            this.tcmiDeleteNode.Text = "删除选中";
            this.tcmiDeleteNode.Click += new System.EventHandler(this.tcmiDeleteNode_Click);
            // 
            // tcmiUpNode
            // 
            this.tcmiUpNode.Name = "tcmiUpNode";
            this.tcmiUpNode.Size = new System.Drawing.Size(118, 22);
            this.tcmiUpNode.Text = "向上移动";
            this.tcmiUpNode.Click += new System.EventHandler(this.tcmiUpNode_Click);
            // 
            // tcmiDownNode
            // 
            this.tcmiDownNode.Name = "tcmiDownNode";
            this.tcmiDownNode.Size = new System.Drawing.Size(118, 22);
            this.tcmiDownNode.Text = "向下移动";
            this.tcmiDownNode.Click += new System.EventHandler(this.tcmiDownNode_Click);
            // 
            // cMCDataGridView
            // 
            this.cMCDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcmiEditCoin,
            this.tcmiDeleteCoin});
            this.cMCDataGridView.Name = "cMSDataGridView";
            this.cMCDataGridView.Size = new System.Drawing.Size(119, 48);
            // 
            // tcmiEditCoin
            // 
            this.tcmiEditCoin.Name = "tcmiEditCoin";
            this.tcmiEditCoin.Size = new System.Drawing.Size(118, 22);
            this.tcmiEditCoin.Text = "编辑钱币";
            this.tcmiEditCoin.Click += new System.EventHandler(this.tcmiEditCoin_Click);
            // 
            // tcmiDeleteCoin
            // 
            this.tcmiDeleteCoin.Name = "tcmiDeleteCoin";
            this.tcmiDeleteCoin.Size = new System.Drawing.Size(118, 22);
            this.tcmiDeleteCoin.Text = "删除钱币";
            this.tcmiDeleteCoin.Click += new System.EventHandler(this.tcmiDeleteCoin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 734);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收藏管理";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewstampinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcoininfoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.cMSDataGridView.ResumeLayout(false);
            this.cMSTypeTreeNode.ResumeLayout(false);
            this.cMCTypeTreeNode.ResumeLayout(false);
            this.cMCDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip cMSTypeTreeNode;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddChild;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteNode;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource viewstampinfoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox tbSClass;
        private System.Windows.Forms.TextBox tbSType;
        private System.Windows.Forms.TextBox tbSPrice;
        private System.Windows.Forms.TextBox tbSUnit;
        private System.Windows.Forms.TextBox tbSPubDate;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.RichTextBox rtSMemo;
        private System.Windows.Forms.ToolStripButton tsbAddStamp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStamp;
        private System.Windows.Forms.ToolStripButton tsbEditStamp;
        private System.Windows.Forms.ToolStripButton tsbDeleteStamp;
        private System.Windows.Forms.ToolStripDropDownButton tsddbStampQueryManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStampClassManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStampUnitManage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip cMSDataGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditStamp;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStamp;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpNode;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownNode;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditNode;
        private CollectionManager.DATA.Database.CollectionDataSet collectionDataSet;
        private CollectionManager.DATA.Database.CollectionDataSetTableAdapters.view_stampinfoTableAdapter view_stampinfoTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCType;
        private System.Windows.Forms.TextBox tbCClass;
        private System.Windows.Forms.TextBox tbCPrice;
        private System.Windows.Forms.TextBox tbCUnit;
        private System.Windows.Forms.TextBox tbCPubDate;
        private System.Windows.Forms.TextBox tbCPublisher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rtCMemo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.BindingSource viewcoininfoBindingSource;
        private DATA.Database.CollectionDataSetTableAdapters.view_coininfoTableAdapter view_coininfoTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cMCTypeTreeNode;
        private System.Windows.Forms.ToolStripMenuItem tcmiAddCoin;
        private System.Windows.Forms.ToolStripMenuItem tcmiAddChild;
        private System.Windows.Forms.ToolStripMenuItem tcmiEditNode;
        private System.Windows.Forms.ToolStripMenuItem tcmiDeleteNode;
        private System.Windows.Forms.ToolStripMenuItem tcmiUpNode;
        private System.Windows.Forms.ToolStripMenuItem tcmiDownNode;
        private System.Windows.Forms.ContextMenuStrip cMCDataGridView;
        private System.Windows.Forms.ToolStripMenuItem tcmiEditCoin;
        private System.Windows.Forms.ToolStripMenuItem tcmiDeleteCoin;
        private System.Windows.Forms.ToolStripDropDownButton tsddbCoinQueryManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCoinClassManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCoinUnitManage;
        private System.Windows.Forms.ToolStripButton tsbAddCoin;
        private System.Windows.Forms.ToolStripButton tsbEditCoin;
        private System.Windows.Forms.ToolStripButton tsbDeleteCoin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picpathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentidCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishdateCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnameCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_oriCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picpathCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitidCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidCoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tssbDataManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelUnuseedImg;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackAllData;
        private System.Windows.Forms.ToolStripDropDownButton tsddbHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripButton tsbChangeMode;
    }
}