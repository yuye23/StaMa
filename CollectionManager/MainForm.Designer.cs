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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.数据处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmideleteUnnecessaryImge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsddbStampQueryManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiStampClassManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStampUnitManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddStamp = new System.Windows.Forms.ToolStripButton();
            this.tsbEditStamp = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteAtamp = new System.Windows.Forms.ToolStripButton();
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
            this.collectionDataSet = new CollectionManager.Database.CollectionDataSet();
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
            this.rtMemo = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.view_stampinfoTableAdapter = new CollectionManager.Database.CollectionDataSetTableAdapters.view_stampinfoTableAdapter();
            this.tsmiBackData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestoreData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.cMSDataGridView.SuspendLayout();
            this.cMSTypeTreeNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.数据处理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1026, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.toolStripMenuItem1.Text = "菜单";
            // 
            // 数据处理ToolStripMenuItem
            // 
            this.数据处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmideleteUnnecessaryImge,
            this.tsmiBackData,
            this.tsmiRestoreData});
            this.数据处理ToolStripMenuItem.Name = "数据处理ToolStripMenuItem";
            this.数据处理ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.数据处理ToolStripMenuItem.Text = "数据处理";
            // 
            // tsmideleteUnnecessaryImge
            // 
            this.tsmideleteUnnecessaryImge.Name = "tsmideleteUnnecessaryImge";
            this.tsmideleteUnnecessaryImge.Size = new System.Drawing.Size(162, 24);
            this.tsmideleteUnnecessaryImge.Text = "清除多余图片";
            this.tsmideleteUnnecessaryImge.Click += new System.EventHandler(this.tsmideleteUnnecessaryImge_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbStampQueryManage,
            this.toolStripSeparator1,
            this.tsbAddStamp,
            this.tsbEditStamp,
            this.tsbDeleteAtamp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
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
            // tsbDeleteAtamp
            // 
            this.tsbDeleteAtamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteAtamp.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteAtamp.Image")));
            this.tsbDeleteAtamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteAtamp.Name = "tsbDeleteAtamp";
            this.tsbDeleteAtamp.Size = new System.Drawing.Size(76, 22);
            this.tsbDeleteAtamp.Text = "删除邮票";
            this.tsbDeleteAtamp.Click += new System.EventHandler(this.tsbDeleteAtamp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 679);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1018, 649);
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
            this.splitContainer1.Size = new System.Drawing.Size(1010, 641);
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
            this.treeView1.Size = new System.Drawing.Size(236, 637);
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
            this.splitContainer2.Size = new System.Drawing.Size(768, 641);
            this.splitContainer2.SplitterDistance = 195;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.dataGridView1.Size = new System.Drawing.Size(764, 191);
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
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.FillWeight = 7F;
            this.codeDataGridViewTextBoxColumn.HeaderText = "志号";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 65;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 65;
            // 
            // parentidDataGridViewTextBoxColumn
            // 
            this.parentidDataGridViewTextBoxColumn.DataPropertyName = "parentid";
            this.parentidDataGridViewTextBoxColumn.HeaderText = "parentid";
            this.parentidDataGridViewTextBoxColumn.Name = "parentidDataGridViewTextBoxColumn";
            this.parentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentidDataGridViewTextBoxColumn.Visible = false;
            this.parentidDataGridViewTextBoxColumn.Width = 97;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "orderid";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "orderid";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderidDataGridViewTextBoxColumn.Visible = false;
            this.orderidDataGridViewTextBoxColumn.Width = 89;
            // 
            // publishdateDataGridViewTextBoxColumn
            // 
            this.publishdateDataGridViewTextBoxColumn.DataPropertyName = "publishdate";
            this.publishdateDataGridViewTextBoxColumn.HeaderText = "出版日期";
            this.publishdateDataGridViewTextBoxColumn.Name = "publishdateDataGridViewTextBoxColumn";
            this.publishdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.publishdateDataGridViewTextBoxColumn.Width = 97;
            // 
            // unitnameDataGridViewTextBoxColumn
            // 
            this.unitnameDataGridViewTextBoxColumn.DataPropertyName = "unitname";
            this.unitnameDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitnameDataGridViewTextBoxColumn.Name = "unitnameDataGridViewTextBoxColumn";
            this.unitnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitnameDataGridViewTextBoxColumn.Width = 65;
            // 
            // priceoriDataGridViewTextBoxColumn
            // 
            this.priceoriDataGridViewTextBoxColumn.DataPropertyName = "price_ori";
            this.priceoriDataGridViewTextBoxColumn.HeaderText = "面值";
            this.priceoriDataGridViewTextBoxColumn.Name = "priceoriDataGridViewTextBoxColumn";
            this.priceoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceoriDataGridViewTextBoxColumn.Width = 65;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "typename";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "自建分类";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            this.typenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typenameDataGridViewTextBoxColumn.Width = 97;
            // 
            // classnameDataGridViewTextBoxColumn
            // 
            this.classnameDataGridViewTextBoxColumn.DataPropertyName = "classname";
            this.classnameDataGridViewTextBoxColumn.HeaderText = "类型";
            this.classnameDataGridViewTextBoxColumn.Name = "classnameDataGridViewTextBoxColumn";
            this.classnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.classnameDataGridViewTextBoxColumn.Width = 65;
            // 
            // picpathDataGridViewTextBoxColumn
            // 
            this.picpathDataGridViewTextBoxColumn.DataPropertyName = "picpath";
            this.picpathDataGridViewTextBoxColumn.HeaderText = "picpath";
            this.picpathDataGridViewTextBoxColumn.Name = "picpathDataGridViewTextBoxColumn";
            this.picpathDataGridViewTextBoxColumn.ReadOnly = true;
            this.picpathDataGridViewTextBoxColumn.Visible = false;
            this.picpathDataGridViewTextBoxColumn.Width = 89;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoDataGridViewTextBoxColumn.Visible = false;
            this.memoDataGridViewTextBoxColumn.Width = 65;
            // 
            // unitidDataGridViewTextBoxColumn
            // 
            this.unitidDataGridViewTextBoxColumn.DataPropertyName = "unitid";
            this.unitidDataGridViewTextBoxColumn.HeaderText = "unitid";
            this.unitidDataGridViewTextBoxColumn.Name = "unitidDataGridViewTextBoxColumn";
            this.unitidDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitidDataGridViewTextBoxColumn.Visible = false;
            this.unitidDataGridViewTextBoxColumn.Width = 81;
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "classid";
            this.classidDataGridViewTextBoxColumn.HeaderText = "classid";
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            this.classidDataGridViewTextBoxColumn.ReadOnly = true;
            this.classidDataGridViewTextBoxColumn.Visible = false;
            this.classidDataGridViewTextBoxColumn.Width = 89;
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "typeid";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "typeid";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            this.typeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeidDataGridViewTextBoxColumn.Visible = false;
            this.typeidDataGridViewTextBoxColumn.Width = 81;
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
            this.groupBox1.Size = new System.Drawing.Size(764, 439);
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
            this.splitContainer3.Size = new System.Drawing.Size(758, 414);
            this.splitContainer3.SplitterDistance = 318;
            this.splitContainer3.SplitterWidth = 2;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer4.Panel2.Controls.Add(this.rtMemo);
            this.splitContainer4.Size = new System.Drawing.Size(318, 414);
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
            // rtMemo
            // 
            this.rtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtMemo.Location = new System.Drawing.Point(0, 0);
            this.rtMemo.Name = "rtMemo";
            this.rtMemo.ReadOnly = true;
            this.rtMemo.Size = new System.Drawing.Size(318, 182);
            this.rtMemo.TabIndex = 0;
            this.rtMemo.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 414);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1018, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "钱币收藏";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cMSDataGridView
            // 
            this.cMSDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditStamp,
            this.tsmiDeleteStamp});
            this.cMSDataGridView.Name = "cMSDataGridView";
            this.cMSDataGridView.Size = new System.Drawing.Size(125, 48);
            // 
            // tsmiEditStamp
            // 
            this.tsmiEditStamp.Name = "tsmiEditStamp";
            this.tsmiEditStamp.Size = new System.Drawing.Size(124, 22);
            this.tsmiEditStamp.Text = "编辑邮票";
            this.tsmiEditStamp.Click += new System.EventHandler(this.tsmiEditStamp_Click);
            // 
            // tsmiDeleteStamp
            // 
            this.tsmiDeleteStamp.Name = "tsmiDeleteStamp";
            this.tsmiDeleteStamp.Size = new System.Drawing.Size(124, 22);
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
            this.cMSTypeTreeNode.Size = new System.Drawing.Size(125, 136);
            this.cMSTypeTreeNode.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmiAddStamp
            // 
            this.tsmiAddStamp.Name = "tsmiAddStamp";
            this.tsmiAddStamp.Size = new System.Drawing.Size(124, 22);
            this.tsmiAddStamp.Text = "新增邮票";
            this.tsmiAddStamp.Click += new System.EventHandler(this.addStampMS_Click);
            // 
            // tsmiAddChild
            // 
            this.tsmiAddChild.Name = "tsmiAddChild";
            this.tsmiAddChild.Size = new System.Drawing.Size(124, 22);
            this.tsmiAddChild.Text = "增加子类";
            this.tsmiAddChild.Click += new System.EventHandler(this.addChild_Click);
            // 
            // tsmiEditNode
            // 
            this.tsmiEditNode.Name = "tsmiEditNode";
            this.tsmiEditNode.Size = new System.Drawing.Size(124, 22);
            this.tsmiEditNode.Text = "编辑子类";
            this.tsmiEditNode.Click += new System.EventHandler(this.tsmiEditNode_Click);
            // 
            // tsmiDeleteNode
            // 
            this.tsmiDeleteNode.Name = "tsmiDeleteNode";
            this.tsmiDeleteNode.Size = new System.Drawing.Size(124, 22);
            this.tsmiDeleteNode.Text = "删除选中";
            this.tsmiDeleteNode.Click += new System.EventHandler(this.deleteNode_Click);
            // 
            // tsmiUpNode
            // 
            this.tsmiUpNode.Name = "tsmiUpNode";
            this.tsmiUpNode.Size = new System.Drawing.Size(124, 22);
            this.tsmiUpNode.Text = "向上移动";
            this.tsmiUpNode.Click += new System.EventHandler(this.tsmiUpNode_Click);
            // 
            // tsmiDownNode
            // 
            this.tsmiDownNode.Name = "tsmiDownNode";
            this.tsmiDownNode.Size = new System.Drawing.Size(124, 22);
            this.tsmiDownNode.Text = "向下移动";
            this.tsmiDownNode.Click += new System.EventHandler(this.tsmiDownNode_Click);
            // 
            // view_stampinfoTableAdapter
            // 
            this.view_stampinfoTableAdapter.ClearBeforeFill = true;
            // 
            // tsmiBackData
            // 
            this.tsmiBackData.Name = "tsmiBackData";
            this.tsmiBackData.Size = new System.Drawing.Size(162, 24);
            this.tsmiBackData.Text = "备份数据";
            this.tsmiBackData.Click += new System.EventHandler(this.tsmiBackData_Click);
            // 
            // tsmiRestoreData
            // 
            this.tsmiRestoreData.Name = "tsmiRestoreData";
            this.tsmiRestoreData.Size = new System.Drawing.Size(162, 24);
            this.tsmiRestoreData.Text = "恢复数据";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 734);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收藏管理";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
            this.cMSDataGridView.ResumeLayout(false);
            this.cMSTypeTreeNode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private Database.CollectionDataSet collectionDataSet;
        private System.Windows.Forms.BindingSource viewstampinfoBindingSource;
        private Database.CollectionDataSetTableAdapters.view_stampinfoTableAdapter view_stampinfoTableAdapter;
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
        private System.Windows.Forms.RichTextBox rtMemo;
        private System.Windows.Forms.ToolStripButton tsbAddStamp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStamp;
        private System.Windows.Forms.ToolStripButton tsbEditStamp;
        private System.Windows.Forms.ToolStripButton tsbDeleteAtamp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbStampQueryManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStampClassManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStampUnitManage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip cMSDataGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditStamp;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStamp;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpNode;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownNode;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiEditNode;
        private System.Windows.Forms.ToolStripMenuItem 数据处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmideleteUnnecessaryImge;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackData;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestoreData;
    }
}