using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CollectionManager.DATA.Database;
using CollectionManager.DATA.Database.CollectionDataSetTableAdapters;
using System.IO;

namespace CollectionManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.treeView1.DrawNode += new DrawTreeNodeEventHandler(treeView1_DrawNode);
            this.treeView2.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.treeView2.DrawNode += new DrawTreeNodeEventHandler(treeView1_DrawNode);

            tsddbStampQueryManage.Visible = true;
            tsbAddStamp.Visible = true;
            tsbEditStamp.Visible = true;
            tsbDeleteStamp.Visible = true;
            toolStripSeparator1.Visible = true;

            tsddbCoinQueryManage.Visible = false;
            tsbAddCoin.Visible = false;
            tsbEditCoin.Visible = false;
            tsbDeleteCoin.Visible = false;
            toolStripSeparator2.Visible = false;
        }


        //在绘制节点事件中，按自已想的绘制
        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true; //我这里用默认颜色即可，只需要在TreeView失去焦点时选中节点仍然突显
            return;

            //if ((e.State & TreeNodeStates.Selected) != 0)
            //{
            //    //演示为绿底白字
            //    e.Graphics.FillRectangle(Brushes.DarkBlue, e.Node.Bounds);

            //    Font nodeFont = e.Node.NodeFont;
            //    if (nodeFont == null) nodeFont = ((TreeView)sender).Font;
            //    e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.White, Rectangle.Inflate(e.Bounds, 2, 0));
            //}
            //else
            //{
            //    e.DrawDefault = true;
            //}

            //if ((e.State & TreeNodeStates.Focused) != 0)
            //{
            //    using (Pen focusPen = new Pen(Color.Black))
            //    {
            //        focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //        Rectangle focusBounds = e.Node.Bounds;
            //        focusBounds.Size = new Size(focusBounds.Width - 1,
            //        focusBounds.Height - 1);
            //        e.Graphics.DrawRectangle(focusPen, focusBounds);
            //    }
            //}

        }


        // view_stampinfoTableAdapter vstainfoAdp = new view_stampinfoTableAdapter();
        //List<string> imgArray = new List<string>();
        //List<PictureBox> listPicBox = new List<PictureBox>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“collectionDataSet.view_coininfo”中。您可以根据需要移动或删除它。
            this.view_coininfoTableAdapter.FillByTypeID(this.collectionDataSet.view_coininfo, 1);

            // TODO: 这行代码将数据加载到表“collectionDataSet.view_stampinfo”中。您可以根据需要移动或删除它。
            this.view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, 1);
            // TODO: 这行代码将数据加载到表“collectionDataSet.view_stampinfo”中。您可以根据需要移动或删除它。
            //this.vstainfoAdp.Fill(this.dataSet1.view_stampinfo);



            TreeView1_Init();
            TreeView2_Init();

        }
        //初始化stamp的Treeview1        
        string rootNodeName1 = "";
        stamptypeTableAdapter sta = new stamptypeTableAdapter();
        CollectionDataSet dataSet1 = new CollectionDataSet();
        private void TreeView1_Init()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            loadTreeView1();
            rootNodeName1 = this.treeView1.Nodes[0].Name;
            loadTreeViewByClass1();
            loadTreeViewByUnit1();
            treeView1.EndUpdate();
            treeView1.TopNode.Expand();
            treeView1.SelectedNode = treeView1.TopNode;
        }
        
        private void loadTreeView1()
        {
            this.sta.Fill(dataSet1.stamptype);
            DataTable table = dataSet1.stamptype;
            DataRow[] row = table.Select("parentid=0");
            foreach (DataRow r in row)
            {
                TreeNode node = treeView1.Nodes.Add(r["id"].ToString(), r["typename"].ToString());
                node.ContextMenuStrip = cMSTypeTreeNode;
                recursionShow1(node, r["id"].ToString());
            }
        }
        private void recursionShow1(TreeNode nodes, string id)
        {
            DataTable table = dataSet1.stamptype;
            DataRow[] row = table.Select("parentid=" + id);
            if (row != null)
            {
                foreach (DataRow r in row)
                {
                    TreeNode node = nodes.Nodes.Insert(Convert.ToInt32(r["orderid"].ToString()), r["id"].ToString(), r["typename"].ToString());
                    node.ContextMenuStrip = cMSTypeTreeNode;
                    recursionShow1(node, r["id"].ToString());
                }
            }
        }
        //treeview1加类型和单位
        stampclassTableAdapter staClaTA = new stampclassTableAdapter();
        private void loadTreeViewByClass1()
        {
            this.staClaTA.Fill(dataSet1.stampclass);
            DataTable table = dataSet1.stampclass;
            DataRow[] row = table.Select();
            TreeNode classNode = new TreeNode("按类型查询");
            classNode.Name = "-1";
            foreach (DataRow r in row)
            {
                classNode.Nodes.Add(r["id"].ToString(), r["classname"].ToString());
                // nodes[ = treeView1.Nodes.Add(r["id"].ToString(), r["classname"].ToString());
                //node.ContextMenuStrip = contextMenuStrip1;
            }
            //TreeNode classNode = new TreeNode("按类型查询", nodes);

            treeView1.Nodes.Add(classNode);

        }

        stampunitTableAdapter staUnitTA = new stampunitTableAdapter();
        private void loadTreeViewByUnit1()
        {
            this.staUnitTA.Fill(dataSet1.stampunit);
            DataTable table = dataSet1.stampunit;
            DataRow[] row = table.Select();
            TreeNode classNode = new TreeNode("按单位查询");
            classNode.Name = "-2";
            foreach (DataRow r in row)
            {
                classNode.Nodes.Add(r["id"].ToString(), r["unitname"].ToString());
                // nodes[ = treeView1.Nodes.Add(r["id"].ToString(), r["classname"].ToString());
                //node.ContextMenuStrip = contextMenuStrip1;
            }
            //TreeNode classNode = new TreeNode("按类型查询", nodes);

            treeView1.Nodes.Add(classNode);

        }

        /// <summary>
        /// treeView1的动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeView1.SelectedNode.Parent != null)
            {
                if (this.treeView1.SelectedNode.Parent.Name != "-1" || this.treeView1.SelectedNode.Parent.Name != "-2")
                {

                    try
                    {
                        this.view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.treeView1.SelectedNode.Name, typeof(int))))));
                        ClearStampInfoPanel();
                        if (dataGridView1.Rows.Count != 0)
                        {
                            dataGridView1.Rows[0].Selected = true;
                            FillStampInfoPanel();
                        }

                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                if (this.treeView1.SelectedNode.Parent.Name == "-1")
                {
                    try
                    {
                        this.view_stampinfoTableAdapter.FillByClassID(this.collectionDataSet.view_stampinfo, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.treeView1.SelectedNode.Name, typeof(int))))));
                        ClearStampInfoPanel();
                        if (dataGridView1.Rows.Count != 0)
                        {
                            dataGridView1.Rows[0].Selected = true;
                            FillStampInfoPanel();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                if (this.treeView1.SelectedNode.Parent.Name == "-2")
                {
                    try
                    {
                        this.view_stampinfoTableAdapter.FillByUnitID(this.collectionDataSet.view_stampinfo, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.treeView1.SelectedNode.Name, typeof(int))))));
                        ClearStampInfoPanel();
                        if (dataGridView1.Rows.Count != 0)
                        {
                            dataGridView1.Rows[0].Selected = true;
                            FillStampInfoPanel();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }


            }
            else
            {
                try
                {
                    this.view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, 1);
                    ClearStampInfoPanel();

                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode node = treeView1.GetNodeAt(e.X, e.Y);
                if (node != null)//右键未选中节点，不改变当前选中的节点。VS2005如此。 
                {
                    this.treeView1.SelectedNode = node;
                }

            }
        }



        ///////////////////////////////////////////////////////////////////////
        //初始化coin的Treeview2        
        string rootNodeName2 = "";
        cointypeTableAdapter cia = new cointypeTableAdapter();
        CollectionDataSet dataSet2 = new CollectionDataSet();
        private void TreeView2_Init()
        {
            treeView2.BeginUpdate();
            treeView2.Nodes.Clear();
            loadTreeView2();
            rootNodeName2 = this.treeView2.Nodes[0].Name;
            loadTreeViewByClass2();
            loadTreeViewByUnit2();
            treeView2.EndUpdate();
            treeView2.Nodes[0].Expand();
            treeView2.SelectedNode = treeView2.TopNode;
        }

        private void loadTreeView2()
        {
            this.cia.Fill(dataSet2.cointype);
            DataTable table = dataSet2.cointype;
            DataRow[] row = table.Select("parentid=0");
            foreach (DataRow r in row)
            {
                TreeNode node = treeView2.Nodes.Add(r["id"].ToString(), r["typename"].ToString());
                node.ContextMenuStrip = cMCTypeTreeNode;
                recursionShow2(node, r["id"].ToString());
            }
        }
        private void recursionShow2(TreeNode nodes, string id)
        {
            DataTable table = dataSet2.cointype;
            DataRow[] row = table.Select("parentid=" + id);
            if (row != null)
            {
                foreach (DataRow r in row)
                {
                    TreeNode node = nodes.Nodes.Insert(Convert.ToInt32(r["orderid"].ToString()), r["id"].ToString(), r["typename"].ToString());
                    node.ContextMenuStrip = cMCTypeTreeNode;
                    recursionShow2(node, r["id"].ToString());
                }
            }
        }
        //treeview2加类型和单位
        coinclassTableAdapter ciaClaTA = new coinclassTableAdapter();
        private void loadTreeViewByClass2()
        {
            this.ciaClaTA.Fill(dataSet2.coinclass);
            DataTable table = dataSet2.coinclass;
            DataRow[] row = table.Select();
            TreeNode classNode = new TreeNode("按类型查询");
            classNode.Name = "-1";
            foreach (DataRow r in row)
            {
                classNode.Nodes.Add(r["id"].ToString(), r["classname"].ToString());
                // nodes[ = treeView1.Nodes.Add(r["id"].ToString(), r["classname"].ToString());
                //node.ContextMenuStrip = contextMenuStrip1;
            }
            //TreeNode classNode = new TreeNode("按类型查询", nodes);

            treeView2.Nodes.Add(classNode);

        }

        coinunitTableAdapter ciaUnitTA = new coinunitTableAdapter();
        private void loadTreeViewByUnit2()
        {
            this.ciaUnitTA.Fill(dataSet2.coinunit);
            DataTable table = dataSet2.coinunit;
            DataRow[] row = table.Select();
            TreeNode classNode = new TreeNode("按单位查询");
            classNode.Name = "-2";
            foreach (DataRow r in row)
            {
                classNode.Nodes.Add(r["id"].ToString(), r["unitname"].ToString());
                // nodes[ = treeView1.Nodes.Add(r["id"].ToString(), r["classname"].ToString());
                //node.ContextMenuStrip = contextMenuStrip1;
            }
            //TreeNode classNode = new TreeNode("按类型查询", nodes);

            treeView2.Nodes.Add(classNode);

        }

        
        /// <summary>
        /// treeView2的动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeView2.SelectedNode.Parent != null)
            {
                if (this.treeView2.SelectedNode.Parent.Name != "-1" || this.treeView2.SelectedNode.Parent.Name != "-2")
                {

                    try
                    {
                        this.view_coininfoTableAdapter.FillByTypeID(this.collectionDataSet.view_coininfo, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.treeView2.SelectedNode.Name, typeof(int))))));
                        ClearCoinInfoPanel();
                        if (dataGridView2.Rows.Count != 0)
                        {
                            dataGridView2.Rows[0].Selected = true;
                            FillCoinInfoPanel();
                        }

                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                if (this.treeView2.SelectedNode.Parent.Name == "-1")
                {
                    try
                    {
                        this.view_coininfoTableAdapter.FillByClassID(this.collectionDataSet.view_coininfo, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.treeView2.SelectedNode.Name, typeof(int))))));
                        ClearCoinInfoPanel();
                        if (dataGridView2.Rows.Count != 0)
                        {
                            dataGridView2.Rows[0].Selected = true;
                            FillCoinInfoPanel();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                if (this.treeView2.SelectedNode.Parent.Name == "-2")
                {
                    try
                    {
                        this.view_coininfoTableAdapter.FillByUnitID(this.collectionDataSet.view_coininfo, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.treeView2.SelectedNode.Name, typeof(int))))));
                        ClearCoinInfoPanel();
                        if (dataGridView2.Rows.Count != 0)
                        {
                            dataGridView2.Rows[0].Selected = true;
                            FillCoinInfoPanel();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }


            }
            else
            {
                try
                {
                    this.view_coininfoTableAdapter.FillByTypeID(this.collectionDataSet.view_coininfo, 1);
                    ClearCoinInfoPanel();

                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        private void treeView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode node = treeView2.GetNodeAt(e.X, e.Y);
                if (node != null)//右键未选中节点，不改变当前选中的节点。VS2005如此。 
                {
                    this.treeView2.SelectedNode = node;
                }

            }
        }
        
        /// <summary>
        /// stamp的上下文菜单菜单contextMenuStrip1及菜单动作
        /// </summary>

        private void cMSTypeTreeNode_Opening(object sender, CancelEventArgs e)
        {
            if (this.treeView1.SelectedNode.Parent == null)
            {
                this.cMSTypeTreeNode.Items["tsmiAddStamp"].Enabled = false;
                this.cMSTypeTreeNode.Items["tsmiDeleteNode"].Enabled = false;
                this.cMSTypeTreeNode.Items["tsmiUpNode"].Enabled = false;
                this.cMSTypeTreeNode.Items["tsmiDownNode"].Enabled = false;
            }
            else
            {
                this.cMSTypeTreeNode.Items["tsmiAddStamp"].Enabled = true;
                this.cMSTypeTreeNode.Items["tsmiDeleteNode"].Enabled = true;
                this.cMSTypeTreeNode.Items["tsmiUpNode"].Enabled = true;
                this.cMSTypeTreeNode.Items["tsmiDownNode"].Enabled = true;
            }
        }

        private void addStampMS_Click(object sender, EventArgs e)
        {
            tsbAddStamp_Click(sender, e);
        }

        private void addChild_Click(object sender, EventArgs e)
        {
            //首先判断是否选定组件中的位置
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AddNodeForm addNodeform = new AddNodeForm();
                if (addNodeform.ShowDialog() == DialogResult.OK)
                {
                    string txt = addNodeform.addNodeTxt;
                    //创建一个节点对象，并初始化

                    int parentid = Convert.ToInt32(treeView1.SelectedNode.Name);
                    int? orderid = cia.ScalarQueryByParentID(parentid);
                    if (orderid == null)
                    {
                        orderid = 0;
                    }
                    int idd = sta.InsertByName(txt, parentid, orderid);
                    sta.GetData();
                    sta.Fill(dataSet1.stamptype);
                    DataTable table = dataSet1.stamptype;
                    //////////////
                    DataRow[] row = table.Select("parentid=" + parentid.ToString() + " and typename='" + txt + "' and orderid=" + orderid);
                    /////////
                    string id = "";
                    if (row != null)
                    {
                        foreach (DataRow r in row)
                        {
                            id = r["ID"].ToString();
                        }
                    }

                    TreeNode node = treeView1.SelectedNode.Nodes.Add(id, txt);
                    node.ContextMenuStrip = cMSTypeTreeNode;
                    treeView1.SelectedNode.Expand();
                    treeView1.SelectedNode = node;

                    UpdateStampTypeOrderID();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.SelectedNode.Expand();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.ExpandAll();
                }

                addNodeform.Dispose();
            }

        }

        private stampinfoTableAdapter stampinfoTableAdapter = new stampinfoTableAdapter();
        private void deleteNode_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (MessageBox.Show("是否确定要删除选中的节点？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = treeView1.SelectedNode.Name.ToString();
                    if (stampinfoTableAdapter.ScalarQueryByTypeID(Convert.ToInt32(id)) == 0)
                    {
                        DataRow[] row = dataSet1.stamptype.Select("id=" + id);
                        if (row != null)
                        {

                            DataRow[] rowChildren = dataSet1.stamptype.Select("parentid=" + id);
                            if (rowChildren.Length != 0)
                            {
                                MessageBox.Show("请先删除此节点中的子节点！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                sta.DeleteByID(Convert.ToInt32(id));
                                this.sta.Fill(dataSet1.stamptype);
                                treeView1.SelectedNode.Remove();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("请先删除所有属于此分类的邮票信息再进行删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("请先选择要删除的节点！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            


        private void tsmiUpNode_Click(object sender, EventArgs e)
        {
            TreeNode selectedNodeParent = this.treeView1.SelectedNode.Parent;
            int index = this.treeView1.SelectedNode.Index;
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNodeParent != null)
            {
                if (selectedNodeParent.Name != "0")
                {
                    if (selectedNode.Index == 0)
                    {
                        MessageBox.Show("该节点已在最上方！");
                    }
                    else
                    {

                        TreeNode newNode = new TreeNode();
                        newNode = selectedNodeParent.Nodes[index];
                        selectedNodeParent.Nodes.RemoveAt(index);
                        selectedNodeParent.Nodes.Insert(index - 1, newNode);
                        treeView1.SelectedNode.Expand();
                        treeView1.SelectedNode = selectedNode;


                        //////将orderid写入数据库
                        UpdateStampTypeOrderID();

                    }
                }
            }
        }

        private void tsmiDownNode_Click(object sender, EventArgs e)
        {
            TreeNode selectedNodeParent = this.treeView1.SelectedNode.Parent;
            int index = this.treeView1.SelectedNode.Index;
            TreeNode selectedNode = this.treeView1.SelectedNode;
            if (selectedNodeParent != null)
            {
                if (selectedNodeParent.Name != "0")
                {
                    if (selectedNode.Index == selectedNodeParent.Nodes.Count - 1)
                    {
                        MessageBox.Show("该节点已在最下方！");
                    }
                    else
                    {

                        TreeNode newNode = new TreeNode();
                        newNode = selectedNodeParent.Nodes[index];
                        selectedNodeParent.Nodes.RemoveAt(index);
                        selectedNodeParent.Nodes.Insert(index + 1, newNode);

                        treeView1.SelectedNode.Expand();
                        treeView1.SelectedNode = selectedNode;
                        UpdateStampTypeOrderID();

                    }
                }
            }
        }


        //////将orderid写入数据库
        private void UpdateStampTypeOrderID()
        {
            foreach (TreeNode node in this.treeView1.Nodes)
            {
                try
                {

                    if (node.Name == rootNodeName1)
                    {
                        sta.UpdateByID(node.Text, 0, node.Index, Convert.ToInt32(node.Name));
                        recursionUpdate(node);
                    }


                }
                catch
                {

                }

            }


        }
        private void recursionUpdate(TreeNode nodes)
        {

            foreach (TreeNode node in nodes.Nodes)
            {
                try
                {
                    sta.UpdateByID(node.Text, Convert.ToInt32(nodes.Name), node.Index, Convert.ToInt32(node.Name));
                    recursionUpdate(node);
                }
                catch
                {

                }

            }
        }

        private void tsmiEditNode_Click(object sender, EventArgs e)
        {
            //首先判断是否选定组件中的位置
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AddNodeForm addNodeform = new AddNodeForm();
                addNodeform.Text = "请输入新的节点名称";
                if (addNodeform.ShowDialog() == DialogResult.OK)
                {

                    string txt = addNodeform.addNodeTxt;
                    //创建一个节点对象，并初始化

                    int parentid = Convert.ToInt32(treeView1.SelectedNode.Parent.Name);

                    sta.UpdateByID(txt, parentid, treeView1.SelectedNode.Index, Convert.ToInt32(treeView1.SelectedNode.Name));
                    sta.GetData();
                    sta.Fill(dataSet1.stamptype);

                    treeView1.SelectedNode.Text = txt;

                    //TreeNode node = treeView1.SelectedNode;
                    //TreeView_Init();
                    //treeView1.SelectedNode.Expand();
                    //treeView1.SelectedNode = node;

                    //UpdateStampTypeOrderID();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.SelectedNode.Expand();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.ExpandAll();
                }

                addNodeform.Dispose();
            }
        }



        /// <summary>
        /// coin的上下文菜单菜单contextMenuStrip2及菜单动作
        /// </summary>

        private void cMCTypeTreeNode_Opening(object sender, CancelEventArgs e)
        {
            if (this.treeView2.SelectedNode.Parent == null)
            {
                this.cMCTypeTreeNode.Items["tcmiAddCoin"].Enabled = false;
                this.cMCTypeTreeNode.Items["tcmiDeleteNode"].Enabled = false;
                this.cMCTypeTreeNode.Items["tcmiUpNode"].Enabled = false;
                this.cMCTypeTreeNode.Items["tcmiDownNode"].Enabled = false;
            }
            else
            {
                this.cMCTypeTreeNode.Items["tcmiAddCoin"].Enabled = true;
                this.cMCTypeTreeNode.Items["tcmiDeleteNode"].Enabled = true;
                this.cMCTypeTreeNode.Items["tcmiUpNode"].Enabled = true;
                this.cMCTypeTreeNode.Items["tcmiDownNode"].Enabled = true;
            }
        }



        private void tcmiAddCoin_Click(object sender, EventArgs e)
        {
            tsbAddCoin_Click(sender,e);
        }

        private void tcmiAddChild_Click(object sender, EventArgs e)
        {
            //首先判断是否选定组件中的位置
            if (treeView2.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AddNodeForm addNodeform = new AddNodeForm();
                if (addNodeform.ShowDialog() == DialogResult.OK)
                {
                    string txt = addNodeform.addNodeTxt;
                    //创建一个节点对象，并初始化

                    int parentid = Convert.ToInt32(treeView2.SelectedNode.Name);
                    int? orderid=cia.ScalarQueryByParentID(parentid);
                    if (orderid == null)
                    {
                        orderid = 0;
                    }
                    int idd=cia.InsertByName(txt, parentid,orderid);
                    cia.GetData();
                    cia.Fill(dataSet2.cointype);
                    DataTable table = dataSet2.cointype;
                    //////////////
                    DataRow[] row = table.Select("parentid=" + parentid.ToString() + " and typename='" + txt + "' and orderid=" + orderid);
                    /////////
                    string id = "";
                    if (row != null)
                    {
                        foreach (DataRow r in row)
                        {
                            id = r["ID"].ToString();
                        }
                    }

                    TreeNode node = treeView2.SelectedNode.Nodes.Add(id, txt);
                    node.ContextMenuStrip = cMCTypeTreeNode;
                    treeView2.SelectedNode.Expand();
                    treeView2.SelectedNode = node;

                    UpdateCoinTypeOrderID();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.SelectedNode.Expand();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.ExpandAll();
                }

                addNodeform.Dispose();
            }
        }

        private void tcmiEditNode_Click(object sender, EventArgs e)
        {
            //首先判断是否选定组件中的位置
            if (treeView2.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AddNodeForm addNodeform = new AddNodeForm();
                addNodeform.Text = "请输入新的节点名称";
                if (addNodeform.ShowDialog() == DialogResult.OK)
                {

                    string txt = addNodeform.addNodeTxt;
                    //创建一个节点对象，并初始化

                    int parentid = Convert.ToInt32(treeView2.SelectedNode.Parent.Name);

                    cia.UpdateByID(txt, parentid, treeView2.SelectedNode.Index, Convert.ToInt32(treeView2.SelectedNode.Name));
                    cia.GetData();
                    cia.Fill(dataSet2.cointype);

                    treeView2.SelectedNode.Text = txt;

                    //TreeNode node = treeView1.SelectedNode;
                    //TreeView_Init();
                    //treeView1.SelectedNode.Expand();
                    //treeView1.SelectedNode = node;

                    //UpdateStampTypeOrderID();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.SelectedNode.Expand();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.ExpandAll();
                }

                addNodeform.Dispose();
            }
        }
        private coininfoTableAdapter coininfoTableAdapter = new coininfoTableAdapter();
        private void tcmiDeleteNode_Click(object sender, EventArgs e)
        {
            if (treeView2.SelectedNode != null)
            {
                if (MessageBox.Show("是否确定要删除选中的节点？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = treeView2.SelectedNode.Name.ToString();
                    if (coininfoTableAdapter.ScalarQueryByTypeID(Convert.ToInt32(id)) == 0)
                    {
                        DataRow[] row = dataSet2.cointype.Select("id=" + id);
                        if (row != null)
                        {

                            DataRow[] rowChildren = dataSet2.cointype.Select("parentid=" + id);
                            if (rowChildren.Length != 0)
                            {
                                MessageBox.Show("请先删除此节点中的子节点！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                cia.DeleteByID(Convert.ToInt32(id));
                                cia.Fill(dataSet2.cointype);
                                treeView2.SelectedNode.Remove();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("请先删除所有属于此分类的邮票信息再进行删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选中要删除的节点！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tcmiUpNode_Click(object sender, EventArgs e)
        {
            TreeNode selectedNodeParent = this.treeView2.SelectedNode.Parent;
            int index = this.treeView2.SelectedNode.Index;
            TreeNode selectedNode = this.treeView2.SelectedNode;
            if (selectedNodeParent != null)
            {
                if (selectedNodeParent.Name != "0")
                {
                    if (selectedNode.Index == 0)
                    {
                        MessageBox.Show("该节点已在最上方！");
                    }
                    else
                    {

                        TreeNode newNode = new TreeNode();
                        newNode = selectedNodeParent.Nodes[index];
                        selectedNodeParent.Nodes.RemoveAt(index);
                        selectedNodeParent.Nodes.Insert(index - 1, newNode);
                        treeView2.SelectedNode.Expand();
                        treeView2.SelectedNode = selectedNode;


                        //////将orderid写入数据库
                        UpdateCoinTypeOrderID();

                    }
                }
            }
        }

        private void tcmiDownNode_Click(object sender, EventArgs e)
        {
            TreeNode selectedNodeParent = this.treeView2.SelectedNode.Parent;
            int index = this.treeView2.SelectedNode.Index;
            TreeNode selectedNode = this.treeView2.SelectedNode;
            if (selectedNodeParent != null)
            {
                if (selectedNodeParent.Name != "0")
                {
                    if (selectedNode.Index == selectedNodeParent.Nodes.Count - 1)
                    {
                        MessageBox.Show("该节点已在最下方！");
                    }
                    else
                    {

                        TreeNode newNode = new TreeNode();
                        newNode = selectedNodeParent.Nodes[index];
                        selectedNodeParent.Nodes.RemoveAt(index);
                        selectedNodeParent.Nodes.Insert(index + 1, newNode);

                        treeView2.SelectedNode.Expand();
                        treeView2.SelectedNode = selectedNode;
                        UpdateCoinTypeOrderID();

                    }
                }
            }
        }

        //////将cointype的orderid写入数据库
        private void UpdateCoinTypeOrderID()
        {
            foreach (TreeNode node in this.treeView2.Nodes)
            {
                try
                {

                    if (node.Name == rootNodeName2)
                    {
                        cia.UpdateByID(node.Text, 0, node.Index, Convert.ToInt32(node.Name));
                        recursionUpdate1(node);
                    }


                }
                catch
                {

                }

            }


        }
        private void recursionUpdate1(TreeNode nodes)
        {

            foreach (TreeNode node in nodes.Nodes)
            {
                try
                {
                    cia.UpdateByID(node.Text, Convert.ToInt32(nodes.Name), node.Index, Convert.ToInt32(node.Name));
                    recursionUpdate1(node);
                }
                catch
                {

                }

            }
        }


        /// <summary>
        /// dataGridView1的动作
        /// </summary>
        int selectedRowIndex = -1;
        int selectedCellIndex = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedRowIndex != e.RowIndex || selectedCellIndex != e.ColumnIndex)
            {
                FillStampInfoPanel();
                selectedCellIndex = e.ColumnIndex;
                selectedRowIndex = e.RowIndex;
            }
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridView1.CurrentRow.Selected = false;
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));
                cMSDataGridView.Show(MousePosition.X, MousePosition.Y);
            }
        }
        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            ClearStampInfoPanel();
        }


        private void tsmiEditStamp_Click(object sender, EventArgs e)
        {
            tsbEditStamp_Click(sender, e);
        }

        private void tsmiDeleteStamp_Click(object sender, EventArgs e)
        {
            tsbDeleteStamp_Click(sender, e);
        }
        

        /// <summary>
        /// dataGridView2的动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedRowIndex != e.RowIndex || selectedCellIndex != e.ColumnIndex)
            {
                FillCoinInfoPanel();
                selectedCellIndex = e.ColumnIndex;
                selectedRowIndex = e.RowIndex;
            }
        }
        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridView2.CurrentRow.Selected = false;
                dataGridView2.Rows[e.RowIndex].Selected = true;
                dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));
                cMCDataGridView.Show(MousePosition.X, MousePosition.Y);
            }
        }
        private void dataGridView2_Sorted(object sender, EventArgs e)
        {
            ClearCoinInfoPanel();
        }

        private void tcmiEditCoin_Click(object sender, EventArgs e)
        {
            tsbEditCoin_Click(sender, e);
        }

        private void tcmiDeleteCoin_Click(object sender, EventArgs e)
        {
            tsbDeleteCoin_Click(sender, e);
        }












        /// <summary>
        /// 操作Stamp详细信息面板
        /// </summary>


        private void ClearStampInfoPanel()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
            selectedCellIndex = -1;
            selectedRowIndex = -1;
            this.tbSCode.Text = "";
            this.tbSClass.Text = "";
            this.tbSName.Text = "";
            this.tbSPrice.Text = "";
            this.tbSPubDate.Text = "";
            this.tbSType.Text = "";
            this.tbSUnit.Text = "";
            this.rtSMemo.Text = "";
            this.flowLayoutPanel1.Controls.Clear();
        }


        private void FillStampInfoPanel()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                this.tbSCode.Text = row.Cells["codeDataGridViewTextBoxColumn"].Value.ToString();
                this.tbSClass.Text = row.Cells["classnameDataGridViewTextBoxColumn"].Value.ToString();
                this.tbSName.Text = row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                this.tbSPrice.Text = row.Cells["priceoriDataGridViewTextBoxColumn"].Value.ToString();
                this.tbSPubDate.Text = Convert.ToDateTime(row.Cells["publishdateDataGridViewTextBoxColumn"].Value).ToShortDateString();
                this.tbSType.Text = row.Cells["typenameDataGridViewTextBoxColumn"].Value.ToString();
                this.tbSUnit.Text = row.Cells["unitnameDataGridViewTextBoxColumn"].Value.ToString();
                this.rtSMemo.Text = row.Cells["memoDataGridViewTextBoxColumn"].Value.ToString();
                string picPath = row.Cells["picpathDataGridViewTextBoxColumn"].Value.ToString();

                List<string> imgPath = new List<string>();
                String imgdr = System.Windows.Forms.Application.StartupPath + "\\DATA\\StampPicture\\";
                while (picPath.IndexOf(",") != -1)
                {
                    imgPath.Add(imgdr + picPath.Substring(0, picPath.IndexOf(",")));
                    picPath = picPath.Substring(picPath.IndexOf(",") + 1);


                }

                this.flowLayoutPanel1.Controls.Clear();
                foreach (string img in imgPath)
                {
                    try
                    {
                        Panel panel = new Panel();
                        panel.Size = new System.Drawing.Size(200, 185);
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        Bitmap newbitmap = (Bitmap)Image.FromFile(img);
                        PictureBox picBox = new PictureBox();
                        picBox.Image = newbitmap;
                        picBox.SizeMode = PictureBoxSizeMode.Zoom;
                        picBox.Width = 200;
                        picBox.Height = 150;
                        picBox.Location = new Point(0, 0);
                        //panel.Name = Path.GetFileNameWithoutExtension(img);


                        Button btnViewImg = new Button();
                        btnViewImg.Name = "btnViewImg";
                        btnViewImg.Text = "查看大图";
                        btnViewImg.TextAlign = ContentAlignment.MiddleCenter;
                        btnViewImg.Width = 80;
                        btnViewImg.Height = 25;
                        btnViewImg.Location = new Point(60, 155);
                        btnViewImg.Tag = newbitmap;
                        btnViewImg.Click += new System.EventHandler(this.btnViewImg_Click);

                        panel.Controls.Add(picBox);
                        panel.Controls.Add(btnViewImg);

                        this.flowLayoutPanel1.Controls.Add(panel);
                        //imgArray.Add(img);
                    }
                    catch
                    {
                        MessageBox.Show("未找到图片，请重新添加!");
                    }

                }
            }
        }
        /// <summary>
        /// 操作Coin详细信息面板
        /// </summary>
        private void ClearCoinInfoPanel()
        {
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[0].Selected = false;
            }
            selectedCellIndex = -1;
            selectedRowIndex = -1;
            this.tbCPublisher.Text = "";
            this.tbCClass.Text = "";
            this.tbCName.Text = "";
            this.tbCPrice.Text = "";
            this.tbCPubDate.Text = "";
            this.tbCType.Text = "";
            this.tbCUnit.Text = "";
            this.rtCMemo.Text = "";
            this.flowLayoutPanel2.Controls.Clear();
        }
        private void FillCoinInfoPanel()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];

                this.tbCPublisher.Text = row.Cells["publisherCoinDataGridViewTextBoxColumn"].Value.ToString();
                this.tbCClass.Text = row.Cells["classnameCoinDataGridViewTextBoxColumn"].Value.ToString();
                this.tbCName.Text = row.Cells["nameCoinDataGridViewTextBoxColumn"].Value.ToString();
                this.tbCPrice.Text = row.Cells["price_oriCoinDataGridViewTextBoxColumn"].Value.ToString();
                this.tbCPubDate.Text = Convert.ToDateTime(row.Cells["publishdateCoinDataGridViewTextBoxColumn"].Value).ToShortDateString();
                this.tbCType.Text = row.Cells["typenameCoinDataGridViewTextBoxColumn"].Value.ToString();
                this.tbCUnit.Text = row.Cells["unitnameCoinDataGridViewTextBoxColumn"].Value.ToString();
                this.rtCMemo.Text = row.Cells["memoCoinDataGridViewTextBoxColumn"].Value.ToString();
                string picPath = row.Cells["picpathCoinDataGridViewTextBoxColumn"].Value.ToString();

                List<string> imgPath = new List<string>();
                String imgdr = System.Windows.Forms.Application.StartupPath + "\\DATA\\StampPicture\\";
                while (picPath.IndexOf(",") != -1)
                {
                    imgPath.Add(imgdr + picPath.Substring(0, picPath.IndexOf(",")));
                    picPath = picPath.Substring(picPath.IndexOf(",") + 1);


                }

                this.flowLayoutPanel2.Controls.Clear();
                foreach (string img in imgPath)
                {
                    try
                    {
                        Panel panel = new Panel();
                        panel.Size = new System.Drawing.Size(200, 185);
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        Bitmap newbitmap = (Bitmap)Image.FromFile(img);
                        PictureBox picBox = new PictureBox();
                        picBox.Image = newbitmap;
                        picBox.SizeMode = PictureBoxSizeMode.Zoom;
                        picBox.Width = 200;
                        picBox.Height = 150;
                        picBox.Location = new Point(0, 0);
                        //panel.Name = Path.GetFileNameWithoutExtension(img);


                        Button btnViewImg = new Button();
                        btnViewImg.Name = "btnViewImg";
                        btnViewImg.Text = "查看大图";
                        btnViewImg.TextAlign = ContentAlignment.MiddleCenter;
                        btnViewImg.Width = 80;
                        btnViewImg.Height = 25;
                        btnViewImg.Location = new Point(60, 155);
                        btnViewImg.Tag = newbitmap;
                        btnViewImg.Click += new System.EventHandler(this.btnViewImg_Click);

                        panel.Controls.Add(picBox);
                        panel.Controls.Add(btnViewImg);

                        this.flowLayoutPanel2.Controls.Add(panel);
                        //imgArray.Add(img);
                    }
                    catch
                    {
                        MessageBox.Show("未找到图片，请重新添加!");
                    }

                }
            }
        }


        /// <summary>
        /// 工具栏中的增加、编辑、删除邮票。分类管理
        /// </summary>


        private void tsbAddStamp_Click(object sender, EventArgs e)
        {
            AddStampForm addStampForm = new AddStampForm();
            addStampForm.Tag = this.treeView1.SelectedNode.Name;
            TreeNode selectedTreeNode = this.treeView1.SelectedNode;

            if (addStampForm.ShowDialog() == DialogResult.OK)
            {


                string Typeid = addStampForm.Tag.ToString();
                for (int i = 0; i < this.treeView1.Nodes.Count; i++)
                {
                    if (this.treeView1.Nodes[i].Name == Typeid)
                    {
                        this.treeView1.SelectedNode = this.treeView1.Nodes[i];
                    }
                    if (this.treeView1.Nodes[i].Name != "-1" && this.treeView1.Nodes[i].Name != "-2")
                    {
                        SelectTreeNodeByID(this.treeView1.Nodes[i], Typeid);
                    }
                }


                view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, Convert.ToInt32(addStampForm.Tag.ToString()));
                //this.treeView1.SelectedNode = this.treeView1.Nodes[addStampForm.Tag.ToString()];
                ClearStampInfoPanel();
                //treeView1_AfterSelect(sender, new TreeViewEventArgs(this.treeView1.SelectedNode, new TreeViewAction()));
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                FillStampInfoPanel();
            }
            addStampForm.Dispose();
        }

        private void SelectTreeNodeByID(TreeNode node, string Typeid)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].Name == Typeid)
                {
                    this.treeView1.SelectedNode = node.Nodes[i];
                    break;
                }
            }

        }







        private void tsbEditStamp_Click(object sender, EventArgs e)
        {
            AddStampForm addStampForm = new AddStampForm();
            TreeNode selectedTreeNode = this.treeView1.SelectedNode;
            //this.dataGridView1.se;
            addStampForm.Text = "编辑邮票";
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int selectedrow = dataGridView1.SelectedRows[0].Index;
                addStampForm.Tag = dataGridView1.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;
                if (addStampForm.ShowDialog() == DialogResult.OK)
                {
                    ////////
                    view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, Convert.ToInt32(selectedTreeNode.Name));
                    this.treeView1.SelectedNode = selectedTreeNode;


                    ClearStampInfoPanel();
                    dataGridView1.Rows[selectedrow].Selected = true;
                    FillStampInfoPanel();



                }
            }
            else
            {
                MessageBox.Show("请先选择要编辑的邮票！");
            }
            addStampForm.Dispose();
        }



        private void tsbDeleteStamp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("是否确定要删除选中的邮票？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        stampinfoTableAdapter stainfoAdp = new stampinfoTableAdapter();
                        TreeNode selectedTreeNode = this.treeView1.SelectedNode;
                        stainfoAdp.DeleteByID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value));
                        view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, Convert.ToInt32(selectedTreeNode.Name));
                        
                        ClearStampInfoPanel();



                    }
                    catch
                    {
                        MessageBox.Show("未成功删除！");
                    }
                }

            }
            else
            {
                MessageBox.Show("请先选择要删除的邮票！");
            }

        }




        private void tsmiClassManage_Click(object sender, EventArgs e)
        {
            ClassManageForm stampClassManageFrom = new ClassManageForm();
            stampClassManageFrom.Text = "邮票类型管理";
            if (stampClassManageFrom.ShowDialog() == DialogResult.Cancel)
            {
                TreeView1_Init();
            }
        }

        private void tsmiUnitManage_Click(object sender, EventArgs e)
        {
            ClassManageForm stampUnitManageFrom = new ClassManageForm();
            stampUnitManageFrom.Text = "邮票单位管理";
            if (stampUnitManageFrom.ShowDialog() == DialogResult.Cancel)
            {
                TreeView1_Init();
            }
        }


        /// <summary>
        /// 工具栏中的增加、编辑、删除钱币。分类管理
        /// </summary>


        private void tsbAddCoin_Click(object sender, EventArgs e)
        {

        }

        private void tsbEditCoin_Click(object sender, EventArgs e)
        {

        }

        private void tsbDeleteCoin_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("是否确定要删除选中的钱币？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        coininfoTableAdapter coininfoAdp = new coininfoTableAdapter();
                        TreeNode selectedTreeNode = this.treeView2.SelectedNode;
                        coininfoAdp.DeleteByID(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value));
                        view_coininfoTableAdapter.FillByTypeID(this.collectionDataSet.view_coininfo, Convert.ToInt32(selectedTreeNode.Name));
                        //this.treeView2.SelectedNode = selectedTreeNode;

                        ClearCoinInfoPanel();
                    }
                    catch
                    {
                        MessageBox.Show("未成功删除！");
                    }
                }

            }
            else
            {
                MessageBox.Show("请先选择要删除的邮票！");
            }
        }

        private void tsmiCoinClassManage_Click(object sender, EventArgs e)
        {
            ClassManageForm coinClassManageFrom = new ClassManageForm();
            coinClassManageFrom.Text = "钱币类型管理";
            if (coinClassManageFrom.ShowDialog() == DialogResult.Cancel)
            {
                TreeView2_Init();
            }
        }

        private void tsmiCoinUnitManage_Click(object sender, EventArgs e)
        {
            ClassManageForm coinUnitManageFrom = new ClassManageForm();
            coinUnitManageFrom.Text = "邮票单位管理";
            if (coinUnitManageFrom.ShowDialog() == DialogResult.Cancel)
            {
                TreeView2_Init();
            }
        }













        private void btnViewImg_Click(object sender, EventArgs e)
        {
            try
            {
                EditImageForm editImgForm = new EditImageForm();
                editImgForm.Tag = ((Button)sender).Tag;
                editImgForm.Text = "查看大图";
                if (editImgForm.ShowDialog() == DialogResult.OK)
                {
                    //((PictureBox)((Button)sender).Parent.Controls[0]).Image = (Image)editImgForm.Tag;
                }
                editImgForm.Dispose();
            }
            catch
            {
            }

        }










        private void deleteUnnecessaryImge()
        {
            //返回picture下所有文件列表
            DirectoryInfo TheFolder = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "\\DATA\\StampPicture\\");
            FileInfo[] files = TheFolder.GetFiles();
            List<string> allFiles = new List<string>();
            foreach (FileInfo file in files)
            {
                allFiles.Add(file.FullName);
            }
            //获取数据库中的文件列表
            this.view_stampinfoTableAdapter.Fill(this.dataSet1.view_stampinfo);
            DataTable table = dataSet1.view_stampinfo;
            DataRow[] row = table.Select();
            List<string> imgPath = new List<string>();

            if (row != null)
            {
                foreach (DataRow r in row)
                {
                    string picPath = r["picpath"].ToString();

                    String imgdr = System.Windows.Forms.Application.StartupPath + "\\DATA\\StampPicture\\";

                    while (picPath.IndexOf(",") != -1)
                    {
                        imgPath.Add(imgdr + picPath.Substring(0, picPath.IndexOf(",")));
                        picPath = picPath.Substring(picPath.IndexOf(",") + 1);
                    }

                }
            }

            //比对两个列表，从所有文件列表中去掉数据库中有的文件

            foreach (string img in imgPath)
            {
                allFiles.Remove(img);
            }

            //删除picture下allFiles中剩余的文件
            foreach (string file in allFiles)
            {
                try
                {
                    if (File.Exists(file))
                    {
                        //如果存在则删除
                        File.Delete(file);
                    }
                }
                catch
                {
                }
            }

        }












        private void tsmideleteUnnecessaryImge_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("清除多余图片应在打开程序未进行其他操作时进行！是否继续", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteUnnecessaryImge();
                MessageBox.Show("清除完毕！");
            }
        }

        private void tsmiBackData_Click(object sender, EventArgs e)
        {
            try
            {

                BackImg();

                //BackDB();
                MessageBox.Show("备份成功!，请妥善保管备份文件。");
            }
            catch
            {
                MessageBox.Show("备份不成功!，请重启程序重新备份。");
            }
        }

        private static void BackImg()
        {
            string copyPath = System.Windows.Forms.Application.StartupPath + "\\DATA\\";
            string zipFilePath = System.Windows.Forms.Application.StartupPath + "\\DataBack\\";

            if (!File.Exists(copyPath))
            {
                Directory.CreateDirectory(copyPath);
            }

            if (!File.Exists(zipFilePath))
            {
                Directory.CreateDirectory(zipFilePath);
            }

            zipFilePath = zipFilePath + @"\back" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".zip";


            ZipFloClass Zc = new ZipFloClass();
            Zc.ZipFile(copyPath, zipFilePath);
        }

        /**
         *
         * 数据库备份
         */
        private void BackDB()
        {




                SaveFileDialog savefile = new SaveFileDialog();//提示用户选择保存文件
                savefile.InitialDirectory =System.Windows.Forms.Application.StartupPath + "\\back\\";//打开文件的初始目录
                savefile.Filter = "数据库文件(*.mdb)|";

                savefile.FileName = "数据备份" +
                    System.DateTime.Now.ToString("yyyyMMddHHmmss");//格式转换如此简单

                savefile.DefaultExt = ".mdb";//设置或获取文件后缀
                DialogResult dr = savefile.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    String filePath = savefile.FileName.ToString();//数据备份,BackDB为备份保存的位置 
                    try
                    {
                        string path = System.Windows.Forms.Application.StartupPath + "\\Database\\Collection.mdb";
                        File.Copy(path, filePath, true);

                    }
                    catch
                    {

                    }
                }
                else
                {

                }

            

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == this.tabPage1)
            {
                tsddbStampQueryManage.Visible = true;
                tsbAddStamp.Visible = true;
                tsbEditStamp.Visible = true;
                tsbDeleteStamp.Visible = true;
                toolStripSeparator1.Visible = true;

                tsddbCoinQueryManage.Visible = false;
                tsbAddCoin.Visible = false;
                tsbEditCoin.Visible = false;
                tsbDeleteCoin.Visible = false;
                toolStripSeparator2.Visible = false;
            }
            if (tabControl1.SelectedTab == this.tabPage2)
            {
                tsddbStampQueryManage.Visible = false;
                tsbAddStamp.Visible = false;
                tsbEditStamp.Visible = false;
                tsbDeleteStamp.Visible = false;
                toolStripSeparator1.Visible = false;

                tsddbCoinQueryManage.Visible = true;
                tsbAddCoin.Visible = true;
                tsbEditCoin.Visible = true;
                tsbDeleteCoin.Visible = true;
                toolStripSeparator2.Visible = true;
            }
        }








    }
}
