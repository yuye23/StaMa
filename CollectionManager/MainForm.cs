﻿using System;
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
using System.Threading;

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
                            dataGridView1_CellClick(sender,new DataGridViewCellEventArgs(0,0));
                            //FillStampInfoPanel();
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
                            dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
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
                            dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
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
            treeView2.SelectedNode = treeView2.Nodes[0];
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
                            dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
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
                            dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
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
                            dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
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
            tsbAddCoin_Click(sender, e);
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
                    int? orderid = cia.ScalarQueryByParentID(parentid);
                    if (orderid == null)
                    {
                        orderid = 0;
                    }
                    int idd = cia.InsertByName(txt, parentid, orderid);
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
        int SselectedRowIndex = -1;
        int SselectedCellIndex = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SselectedRowIndex != e.RowIndex)
            {
                FillStampInfoPanel();

            }
            SselectedCellIndex = e.ColumnIndex;
            SselectedRowIndex = e.RowIndex;
            if (SselectedRowIndex == 0)
            {
                btnSFirst.Enabled = false;
                btnSPrevious.Enabled = false;
            }
            else
            {
                btnSFirst.Enabled = true;
                btnSPrevious.Enabled = true;
            }

            if (SselectedRowIndex == dataGridView1.Rows.Count - 1)
            {
                btnSNext.Enabled = false;
                btnSEnd.Enabled = false;
            }
            else
            {
                btnSNext.Enabled = true;
                btnSEnd.Enabled = true;
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
        int CselectedRowIndex = -1;
        int CselectedCellIndex = -1;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CselectedRowIndex != e.RowIndex)
            {
                FillCoinInfoPanel();

            }
            CselectedCellIndex = e.ColumnIndex;
            CselectedRowIndex = e.RowIndex;
            if (CselectedRowIndex == 0)
            {
                btnCFirst.Enabled = false;
                btnCPrevious.Enabled = false;
            }
            else
            {
                btnCFirst.Enabled = true;
                btnCPrevious.Enabled = true;
            }

            if (CselectedRowIndex == dataGridView2.Rows.Count - 1)
            {
                btnCNext.Enabled = false;
                btnCEnd.Enabled = false;
            }
            else
            {
                btnCNext.Enabled = true;
                btnCEnd.Enabled = true;
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
            SselectedCellIndex = -1;
            SselectedRowIndex = -1;
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
                        panel.Size = new System.Drawing.Size(imgPanelWidth, imgPanelHeight);
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        Bitmap newbitmap = (Bitmap)Image.FromFile(img);
                        PictureBox picBox = new PictureBox();
                        picBox.Image = newbitmap;
                        picBox.SizeMode = PictureBoxSizeMode.Zoom;
                        picBox.Width = imgWidth;
                        picBox.Height = imgHeight;
                        picBox.Location = new Point(0, 0);
                        //panel.Name = Path.GetFileNameWithoutExtension(img);


                        Button btnViewImg = new Button();
                        btnViewImg.Name = "btnViewImg";
                        btnViewImg.Text = "查看大图";
                        btnViewImg.TextAlign = ContentAlignment.MiddleCenter;
                        btnViewImg.Width = 80;
                        btnViewImg.Height = 25;
                        btnViewImg.Location = new Point(btnX, btnY);
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
            CselectedCellIndex = -1;
            CselectedRowIndex = -1;
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




        int imgPanelWidth = 200;
        int imgPanelHeight = 185;
        int imgWidth = 200;
        int imgHeight = 150;
        int btnX = 60;
        int btnY = 155;
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
                String imgdr = System.Windows.Forms.Application.StartupPath + "\\DATA\\CoinPicture\\";
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
                        panel.Size = new System.Drawing.Size(imgPanelWidth, imgPanelHeight);
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        Bitmap newbitmap = (Bitmap)Image.FromFile(img);
                        PictureBox picBox = new PictureBox();
                        picBox.Image = newbitmap;
                        picBox.SizeMode = PictureBoxSizeMode.Zoom;
                        picBox.Width = imgWidth;
                        picBox.Height = imgHeight;
                        picBox.Location = new Point(0, 0);
                        //panel.Name = Path.GetFileNameWithoutExtension(img);


                        Button btnViewImg = new Button();
                        btnViewImg.Name = "btnViewImg";
                        btnViewImg.Text = "查看大图";
                        btnViewImg.TextAlign = ContentAlignment.MiddleCenter;
                        btnViewImg.Width = 80;
                        btnViewImg.Height = 25;
                        btnViewImg.Location = new Point(btnX, btnY);
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
                        SelectTree1NodeByID(this.treeView1.Nodes[i], Typeid);
                    }
                }


                view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, Convert.ToInt32(addStampForm.Tag.ToString()));
                //this.treeView1.SelectedNode = this.treeView1.Nodes[addStampForm.Tag.ToString()];
                ClearStampInfoPanel();
                //treeView1_AfterSelect(sender, new TreeViewEventArgs(this.treeView1.SelectedNode, new TreeViewAction()));
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, dataGridView1.Rows.Count - 1));
            }
            addStampForm.Dispose();
        }

        private void SelectTree1NodeByID(TreeNode node, string Typeid)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].Name == Typeid)
                {
                    this.treeView1.SelectedNode = node.Nodes[i];

                    break;
                }

                SelectTree1NodeByID(node.Nodes[i], Typeid);
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
                    dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, selectedrow));



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
                        int selectedrow = dataGridView1.SelectedRows[0].Index;

                        stampinfoTableAdapter stainfoAdp = new stampinfoTableAdapter();
                        TreeNode selectedTreeNode = this.treeView1.SelectedNode;
                        stainfoAdp.DeleteByID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value));
                        view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, Convert.ToInt32(selectedTreeNode.Name));

                        ClearStampInfoPanel();
                        selectedrow--;
                        
                        if (selectedrow >= 0)
                        {
                            dataGridView1.Rows[selectedrow].Selected = true;
                            dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, selectedrow));
                        }

                        if (selectedrow == -1&&dataGridView1.Rows.Count!=0)
                        {
                            selectedrow++;
                            dataGridView1.Rows[selectedrow].Selected = true;
                            dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, selectedrow));
                        }

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
            AddCoinForm addCoinForm = new AddCoinForm();
            addCoinForm.Tag = this.treeView2.SelectedNode.Name;
            TreeNode selectedTreeNode = this.treeView2.SelectedNode;

            if (addCoinForm.ShowDialog() == DialogResult.OK)
            {


                string Typeid = addCoinForm.Tag.ToString();
                for (int i = 0; i < this.treeView2.Nodes.Count; i++)
                {
                    if (this.treeView2.Nodes[i].Name == Typeid)
                    {
                        this.treeView2.SelectedNode = this.treeView2.Nodes[i];
                    }
                    if (this.treeView2.Nodes[i].Name != "-1" && this.treeView1.Nodes[i].Name != "-2")
                    {
                        SelectTree2NodeByID(this.treeView2.Nodes[i], Typeid);
                    }
                }


                view_coininfoTableAdapter.FillByTypeID(this.collectionDataSet.view_coininfo, Convert.ToInt32(addCoinForm.Tag.ToString()));
                //this.treeView1.SelectedNode = this.treeView1.Nodes[addStampForm.Tag.ToString()];
                ClearCoinInfoPanel();
                //treeView1_AfterSelect(sender, new TreeViewEventArgs(this.treeView1.SelectedNode, new TreeViewAction()));
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Selected = true;
                dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, dataGridView2.Rows.Count - 1));
            }
            addCoinForm.Dispose();
        }
        private void SelectTree2NodeByID(TreeNode node, string Typeid)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].Name == Typeid)
                {
                    this.treeView2.SelectedNode = node.Nodes[i];
                    break;
                }
                SelectTree2NodeByID(node.Nodes[i], Typeid);
            }

        }
        private void tsbEditCoin_Click(object sender, EventArgs e)
        {
            AddCoinForm addCoinForm = new AddCoinForm();
            TreeNode selectedTreeNode = this.treeView2.SelectedNode;
            //this.dataGridView1.se;
            addCoinForm.Text = "编辑钱币";
            if (dataGridView2.SelectedRows.Count != 0)
            {
                int selectedrow = dataGridView2.SelectedRows[0].Index;
                addCoinForm.Tag = dataGridView2.SelectedRows[0].Cells["idCoinDataGridViewTextBoxColumn"].Value;
                if (addCoinForm.ShowDialog() == DialogResult.OK)
                {
                    ////////
                    view_coininfoTableAdapter.FillByTypeID(this.collectionDataSet.view_coininfo, Convert.ToInt32(selectedTreeNode.Name));
                    this.treeView2.SelectedNode = selectedTreeNode;


                    ClearCoinInfoPanel();
                    dataGridView2.Rows[selectedrow].Selected = true;
                    dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, selectedrow));

                }
            }
            else
            {
                MessageBox.Show("请先选择要编辑的钱币！");
            }
            addCoinForm.Dispose();
        }

        private void tsbDeleteCoin_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("是否确定要删除选中的钱币？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {

                        int selectedrow = dataGridView2.SelectedRows[0].Index;
                        coininfoTableAdapter coininfoAdp = new coininfoTableAdapter();
                        TreeNode selectedTreeNode = this.treeView2.SelectedNode;
                        coininfoAdp.DeleteByID(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["idCoinDataGridViewTextBoxColumn"].Value));
                        view_coininfoTableAdapter.FillByTypeID(this.collectionDataSet.view_coininfo, Convert.ToInt32(selectedTreeNode.Name));
                        //this.treeView2.SelectedNode = selectedTreeNode;

                        ClearCoinInfoPanel();

                        selectedrow--;

                        if (selectedrow >= 0)
                        {
                            dataGridView2.Rows[selectedrow].Selected = true;
                            dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, selectedrow));
                        }

                        if (selectedrow == -1 && dataGridView2.Rows.Count != 0)
                        {
                            selectedrow++;
                            dataGridView2.Rows[selectedrow].Selected = true;
                            dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, selectedrow));
                        }
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


        private void tsmiDelUnuseedImg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("清除多余图片应在打开程序未进行其他操作时进行！是否继续", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteUnnecessaryImge();
                MessageBox.Show("清除完毕！");
            }
        }

        private void tsmiBackAllData_Click(object sender, EventArgs e)
        {

            ProcessBarForm proBarForm = new ProcessBarForm();
            proBarForm.task = "BackAllData";
            if (proBarForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("备份成功!，请妥善保管备份文件。备份路径：" + proBarForm.savePath);
            }

        }





        private void deleteUnnecessaryImge()
        {
            this.view_stampinfoTableAdapter.Fill(this.dataSet1.view_stampinfo);
            DataTable table1 = dataSet1.view_stampinfo;
            deleteUnnecessaryImge("\\DATA\\StampPicture\\", table1);

            this.view_coininfoTableAdapter.Fill(this.dataSet1.view_coininfo);
            DataTable table2 = dataSet1.view_stampinfo;
            deleteUnnecessaryImge("\\DATA\\CoinPicture\\", table2);

        }



        private void deleteUnnecessaryImge(string dir, DataTable table)
        {
            //返回picture下所有文件列表
            DirectoryInfo TheFolder = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + dir);
            FileInfo[] files = TheFolder.GetFiles();
            List<string> allFiles = new List<string>();
            foreach (FileInfo file in files)
            {
                allFiles.Add(file.FullName);
            }
            //获取数据库中的文件列表

            DataRow[] row = table.Select();
            List<string> imgPath = new List<string>();

            if (row != null)
            {
                foreach (DataRow r in row)
                {
                    string picPath = r["picpath"].ToString();

                    String imgdr = System.Windows.Forms.Application.StartupPath + dir;

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

        private void tsmiHelp_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {

        }
        
        private void tsbChangeMode_Click(object sender, EventArgs e)
        {


            if (tsbChangeMode.Text == "欣赏模式")
            {

                SModeChange();
                CModeChange();
                tsbChangeMode.Text = "管理模式";
            }
            else
            {

                if (tsbChangeMode.Text == "管理模式")
                {

                    SRestoreChange();
                    CRestoreChange();
                    tsbChangeMode.Text = "欣赏模式";

                }
            }


        }

        private void SRestoreChange()
        {
            this.splitContainer3.Panel2.Controls.Remove(btnSFirst);
            this.splitContainer3.Panel2.Controls.Remove(btnSPrevious);
            this.splitContainer3.Panel2.Controls.Remove(btnSNext);
            this.splitContainer3.Panel2.Controls.Remove(btnSEnd);

            setSLandT();


            imgPanelWidth = 200;
            imgPanelHeight = 185;
            imgWidth = 200;
            imgHeight = 150;
            btnX = 60;
            btnY = 155;


            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitContainer3.SplitterDistance = 318;

            this.splitContainer2.Panel1.Controls.Remove(this.flowLayoutPanel1);
            this.splitContainer2.SplitterDistance = 200;

            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel1);

            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer4.Size = new System.Drawing.Size(318, 439);
            this.splitContainer4.SplitterDistance = 228;
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            if (this.dataGridView1.Rows.Count != 0)
            {
                this.dataGridView1.Rows[SselectedRowIndex].Selected = true;
            }
            this.dataGridView1.Dock = DockStyle.Fill;
            this.splitContainer1.Panel1.Controls.Remove(this.splitContainer9);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);


            FillStampInfoPanel();
        }

        private void SModeChange()
        {
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer9);
            this.splitContainer9.Panel1.Controls.Add(this.treeView1);
            this.splitContainer9.Panel1.AutoScroll = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Panel2.Controls.Add(this.dataGridView1);
            if (this.dataGridView1.Rows.Count != 0)
            {
                this.dataGridView1.Rows[SselectedRowIndex].Selected = true;
            }
            this.dataGridView1.Dock = DockStyle.None;
            this.splitContainer9.Panel2.AutoScroll = true;
            this.splitContainer9.SplitterDistance = 480;
            this.splitContainer9.SplitterWidth = 3;

            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.SplitterDistance = 500;

            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitContainer4.SplitterDistance = 185;

            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer3.SplitterDistance = 110;

            imgPanelWidth = 640;
            imgPanelHeight = 488;
            imgWidth = 640;
            imgHeight = 480;
            btnX = 160;
            btnY = 305;

            setSLandT();

            FillStampInfoPanel();

            if (dataGridView1.SelectedRows.Count == 0)
            {
                btnSNext.Enabled = false;
                btnSEnd.Enabled = false;
                btnSPrevious.Enabled = false;
                btnSFirst.Enabled = false;
            }

            this.splitContainer3.Panel2.Controls.Add(btnSFirst);
            this.splitContainer3.Panel2.Controls.Add(btnSPrevious);
            this.splitContainer3.Panel2.Controls.Add(btnSNext);
            this.splitContainer3.Panel2.Controls.Add(btnSEnd);
        }


        private void CModeChange()
        {
            this.splitContainer5.Panel1.Controls.Add(this.splitContainer10);
            this.splitContainer10.Panel1.Controls.Add(this.treeView2);
            this.splitContainer10.Panel1.AutoScroll = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.Panel2.Controls.Add(this.dataGridView2);
            if (this.dataGridView2.Rows.Count != 0)
            {
                this.dataGridView2.Rows[CselectedRowIndex].Selected = true;
            }
            this.dataGridView2.Dock = DockStyle.None;
            this.splitContainer10.Panel2.AutoScroll = true;
            this.splitContainer10.SplitterDistance = 480;
            this.splitContainer10.SplitterWidth = 3;

            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer7.SplitterDistance = 110;

            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitContainer8.SplitterDistance = 440;
            this.splitContainer6.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer6.SplitterDistance = 500;


            imgPanelWidth = 640;
            imgPanelHeight = 488;
            imgWidth = 640;
            imgHeight = 480;
            btnX = 160;
            btnY = 305;

            setCLandT();

            FillCoinInfoPanel();

            if (dataGridView2.SelectedRows.Count == 0)
            {
                btnCNext.Enabled = false;
                btnCEnd.Enabled = false;
                btnCPrevious.Enabled = false;
                btnCFirst.Enabled = false;
            }

            this.splitContainer7.Panel2.Controls.Add(btnCFirst);
            this.splitContainer7.Panel2.Controls.Add(btnCPrevious);
            this.splitContainer7.Panel2.Controls.Add(btnCNext);
            this.splitContainer7.Panel2.Controls.Add(btnCEnd);
        }
        private void CRestoreChange()
        {
            this.splitContainer7.Panel2.Controls.Remove(btnCFirst);
            this.splitContainer7.Panel2.Controls.Remove(btnCPrevious);
            this.splitContainer7.Panel2.Controls.Remove(btnCNext);
            this.splitContainer7.Panel2.Controls.Remove(btnCEnd);

            setCLandT();


            imgPanelWidth = 200;
            imgPanelHeight = 185;
            imgWidth = 200;
            imgHeight = 150;
            btnX = 60;
            btnY = 155;


            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitContainer7.SplitterDistance = 318;

            this.splitContainer6.Panel1.Controls.Remove(this.flowLayoutPanel2);
            this.splitContainer6.SplitterDistance = 200;

            this.splitContainer7.Panel2.Controls.Add(this.flowLayoutPanel2);

            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer8.Size = new System.Drawing.Size(318, 439);
            this.splitContainer8.SplitterDistance = 228;
            this.splitContainer6.Panel1.Controls.Add(this.dataGridView2);
            if (this.dataGridView2.Rows.Count != 0)
            {
                this.dataGridView2.Rows[CselectedRowIndex].Selected = true;
            }
            this.dataGridView2.Dock = DockStyle.Fill;
            this.splitContainer5.Panel1.Controls.Remove(this.splitContainer10);
            this.splitContainer5.Panel1.Controls.Add(this.treeView2);


            FillCoinInfoPanel();
        }
        private void setSLandT()
        {

            if (tsbChangeMode.Text == "欣赏模式")
            {

                // label8
                // 
                this.label8.Location = new System.Drawing.Point(222, 93);
                this.label8.Size = new System.Drawing.Size(88, 16);

                // 
                // tbSClass
                // 
                this.tbSClass.Location = new System.Drawing.Point(298, 61);
                this.tbSClass.Size = new System.Drawing.Size(140, 26);
                // 
                // tbSType
                // 
                this.tbSType.Location = new System.Drawing.Point(298, 32);
                this.tbSType.Size = new System.Drawing.Size(140, 26);
                // 
                // tbSPrice
                // 
                this.tbSPrice.Location = new System.Drawing.Point(298, 3);
                this.tbSPrice.Size = new System.Drawing.Size(140, 26);
                // 
                // tbSUnit
                // 
                this.tbSUnit.Location = new System.Drawing.Point(78, 90);
                this.tbSUnit.Size = new System.Drawing.Size(140, 26);
                // 
                // tbSPubDate
                // 
                this.tbSPubDate.Location = new System.Drawing.Point(78, 61);
                this.tbSPubDate.Size = new System.Drawing.Size(140, 26);
                // 
                // tbSName
                // 
                this.tbSName.Location = new System.Drawing.Point(78, 32);
                this.tbSName.Size = new System.Drawing.Size(140, 26);
                // 
                // label7
                // 
                this.label7.Location = new System.Drawing.Point(222, 64);
                this.label7.Size = new System.Drawing.Size(88, 16);
                // 
                // label6
                // 
                this.label6.Location = new System.Drawing.Point(222, 35);
                this.label6.Size = new System.Drawing.Size(88, 16);
                // 
                // label5
                // 
                this.label5.Location = new System.Drawing.Point(222, 6);
                this.label5.Size = new System.Drawing.Size(88, 16);
                // 
                // label4
                // 
                this.label4.Location = new System.Drawing.Point(2, 93);
                this.label4.Size = new System.Drawing.Size(88, 16);

                // 
                // label3
                // 

                this.label3.Location = new System.Drawing.Point(2, 64);
                this.label3.Size = new System.Drawing.Size(88, 16);

                // 
                // label2
                // 
                this.label2.Location = new System.Drawing.Point(2, 35);
                this.label2.Size = new System.Drawing.Size(88, 16);
                // 
                // tbSCode
                // 
                this.tbSCode.Location = new System.Drawing.Point(78, 3);
                this.tbSCode.Size = new System.Drawing.Size(140, 26);
                // 
                // label1
                // 
                this.label1.Location = new System.Drawing.Point(2, 6);
                this.label1.Size = new System.Drawing.Size(88, 16);
                // 
                // rtSMemo
                // 
                this.rtSMemo.Location = new System.Drawing.Point(0, 0);
                this.rtSMemo.Size = new System.Drawing.Size(318, 207);
            }
            else{
                if (tsbChangeMode.Text == "管理模式")
                {

                    // label8
                    // 
                    this.label8.Location = new System.Drawing.Point(6, 208);
                    this.label8.Size = new System.Drawing.Size(88, 16);

                    // 
                    // tbSClass
                    // 
                    this.tbSClass.Location = new System.Drawing.Point(82, 177);
                    this.tbSClass.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbSType
                    // 
                    this.tbSType.Location = new System.Drawing.Point(82, 148);
                    this.tbSType.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbSPrice
                    // 
                    this.tbSPrice.Location = new System.Drawing.Point(82, 119);
                    this.tbSPrice.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbSUnit
                    // 
                    this.tbSUnit.Location = new System.Drawing.Point(82, 90);
                    this.tbSUnit.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbSPubDate
                    // 
                    this.tbSPubDate.Location = new System.Drawing.Point(82, 61);
                    this.tbSPubDate.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbSName
                    // 
                    this.tbSName.Location = new System.Drawing.Point(82, 32);
                    this.tbSName.Size = new System.Drawing.Size(235, 26);
                    // 
                    // label7
                    // 
                    this.label7.Location = new System.Drawing.Point(6, 180);
                    this.label7.Size = new System.Drawing.Size(88, 16);
                    // 
                    // label6
                    // 
                    this.label6.Location = new System.Drawing.Point(5, 151);
                    this.label6.Size = new System.Drawing.Size(88, 16);
                    // 
                    // label5
                    // 
                    this.label5.Location = new System.Drawing.Point(6, 122);
                    this.label5.Size = new System.Drawing.Size(88, 16);
                    // 
                    // label4
                    // 
                    this.label4.Location = new System.Drawing.Point(6, 93);
                    this.label4.Size = new System.Drawing.Size(88, 16);
                    // 
                    // label3
                    // 
                    this.label3.Location = new System.Drawing.Point(5, 64);
                    this.label3.Size = new System.Drawing.Size(88, 16);
                    // 
                    // label2
                    // 
                    this.label2.Location = new System.Drawing.Point(5, 35);
                    this.label2.Size = new System.Drawing.Size(88, 16);
                    // 
                    // tbSCode
                    // 
                    this.tbSCode.Location = new System.Drawing.Point(82, 3);
                    this.tbSCode.Size = new System.Drawing.Size(235, 26);
                    // 
                    // label1
                    // 
                    this.label1.Location = new System.Drawing.Point(6, 6);
                    this.label1.Size = new System.Drawing.Size(88, 16);
                    // 
                    // rtSMemo
                    // 
                    this.rtSMemo.Location = new System.Drawing.Point(0, 0);
                    this.rtSMemo.Size = new System.Drawing.Size(318, 207);
                }
            }
        }

        private void setCLandT()
        {


            if (tsbChangeMode.Text == "欣赏模式")
            {


                // 
                // tbCType
                // 
                this.tbCType.Location = new System.Drawing.Point(298, 32);
                this.tbCType.Size = new System.Drawing.Size(140, 26);
                // 
                // tbCClass
                // 
                this.tbCClass.Location = new System.Drawing.Point(298, 61);
                this.tbCClass.Size = new System.Drawing.Size(140, 26);
                // 
                // tbCPrice
                // 
                this.tbCPrice.Location = new System.Drawing.Point(298, 3);
                this.tbCPrice.Size = new System.Drawing.Size(140, 26);
                // 
                // tbCUnit
                // 
                this.tbCUnit.Size = new System.Drawing.Size(140, 26);
                // 
                // tbCPubDate
                // 
                this.tbCPubDate.Size = new System.Drawing.Size(140, 26);
                // 
                // tbCPublisher
                // 
                this.tbCPublisher.Size = new System.Drawing.Size(140, 26);
                // 
                // label9
                // 
                this.label9.Location = new System.Drawing.Point(222, 93);
                // 
                // label10
                // 
                this.label10.Location = new System.Drawing.Point(222, 64);
                // 
                // label11
                // 
                this.label11.Location = new System.Drawing.Point(222, 35);
                // 
                // label12
                // 
                this.label12.Location = new System.Drawing.Point(222, 7);
                // 
                // tbCName
                // 
                this.tbCName.Size = new System.Drawing.Size(140, 26);
            }
            else
            {
                if (tsbChangeMode.Text == "管理模式")
                {

                    // 
                    // label9
                    // 
                    this.label9.Location = new System.Drawing.Point(6, 208);
                    // 
                    // tbCType
                    // 
                    this.tbCType.Location = new System.Drawing.Point(82, 177);
                    this.tbCType.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbCClass
                    // 
                    this.tbCClass.Location = new System.Drawing.Point(82, 148);
                    this.tbCClass.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbCPrice
                    // 
                    this.tbCPrice.Location = new System.Drawing.Point(82, 119);
                    this.tbCPrice.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbCUnit
                    // 
                    this.tbCUnit.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbCPubDate
                    // 
                    this.tbCPubDate.Size = new System.Drawing.Size(235, 26);
                    // 
                    // tbCPublisher
                    // 
                    this.tbCPublisher.Size = new System.Drawing.Size(235, 26);
                    // 
                    // label10
                    // 
                    this.label10.Location = new System.Drawing.Point(6, 180);
                    // 
                    // label11
                    // 
                    this.label11.Location = new System.Drawing.Point(5, 151);
                    // 
                    // label12
                    // 
                    this.label12.Location = new System.Drawing.Point(6, 122);
                    // 
                    // tbCName
                    // 
                    this.tbCName.Size = new System.Drawing.Size(235, 26);
                }
            }

        }

        private void btnSNext_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                i++;
                dataGridView1.Rows[i].Selected = true;
                dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0,i));


            }

        }

        private void btnSPrevious_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                i--;
                dataGridView1.Rows[i].Selected = true;
                dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, i));


            }
        }

        private void btnSFirst_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                
                dataGridView1.Rows[0].Selected = true;
                dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, 0));


            }
        }

        private void btnSEnd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count-1].Selected = true;
                
                dataGridView1_CellClick(sender, new DataGridViewCellEventArgs(0, dataGridView1.Rows.Count - 1));

            }
        }


        private void btnCNext_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                int i = dataGridView2.SelectedRows[0].Index;
                i++;
                dataGridView2.Rows[i].Selected = true;
                dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, i));


            }

        }

        private void btnCPrevious_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                int i = dataGridView2.SelectedRows[0].Index;
                i--;
                dataGridView2.Rows[i].Selected = true;
                dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, i));


            }
        }

        private void btnCFirst_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {

                dataGridView2.Rows[0].Selected = true;
                dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, 0));


            }
        }

        private void btnCEnd_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Selected = true;

                dataGridView2_CellClick(sender, new DataGridViewCellEventArgs(0, dataGridView2.Rows.Count - 1));

            }
        }
    }
}