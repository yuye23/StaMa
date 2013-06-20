using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CollectionManager.Database;
using CollectionManager.Database.CollectionDataSetTableAdapters;

namespace CollectionManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        stamptypeTableAdapter sta = new stamptypeTableAdapter();
        CollectionDataSet dataSet1 = new CollectionDataSet();
        view_stampinfoTableAdapter vstainfoAdp = new view_stampinfoTableAdapter();
        List<string> imgArray = new List<string>();
        List<PictureBox> listPicBox = new List<PictureBox>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“collectionDataSet.view_stampinfo”中。您可以根据需要移动或删除它。
            this.view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo,0);
            // TODO: 这行代码将数据加载到表“collectionDataSet.view_stampinfo”中。您可以根据需要移动或删除它。
            //this.vstainfoAdp.Fill(this.dataSet1.view_stampinfo);


            
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            loadTreeView();

            treeView1.EndUpdate();
            treeView1.TopNode.Expand();

        }
        private void loadTreeView()
        {
            this.sta.Fill(dataSet1.stamptype);
            DataTable table = dataSet1.stamptype;
            DataRow[] row = table.Select("parentid=0");
            foreach (DataRow r in row)
            {
                TreeNode node = treeView1.Nodes.Add(r["id"].ToString(), r["typename"].ToString());
                node.ContextMenuStrip = contextMenuStrip1;
                recursionShow(node, r["id"].ToString());
            }
        }
        private void recursionShow(TreeNode nodes, string id)
        {
            DataTable table = dataSet1.stamptype;
            DataRow[] row = table.Select("parentid=" + id);
            if (row != null)
            {
                foreach (DataRow r in row)
                {
                    TreeNode node = nodes.Nodes.Add(r["ID"].ToString(), r["typename"].ToString());
                    node.ContextMenuStrip = contextMenuStrip1;
                    recursionShow(node, r["ID"].ToString());
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                this.view_stampinfoTableAdapter.FillByTypeID(this.collectionDataSet.view_stampinfo, new System.Nullable<int>(((int)(System.Convert.ChangeType(this.treeView1.SelectedNode.Name, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

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

                    int parentid=Convert.ToInt32(treeView1.SelectedNode.Name);

                    sta.InsertByName(txt, parentid, 0);
                    sta.GetData();
                    sta.Fill(dataSet1.stamptype);
                    DataTable table = dataSet1.stamptype;
                    //////////////
                    DataRow[] row = table.Select("parentid=" + parentid.ToString());
                    /////////
                    string id="";
                    if (row != null)
                    {
                        foreach (DataRow r in row)
                        {
                            id=r["ID"].ToString();
                        }
                    } 

                    TreeNode node = treeView1.SelectedNode.Nodes.Add(id, txt);
                    node.ContextMenuStrip = contextMenuStrip1;
                    treeView1.SelectedNode.Expand();
                    treeView1.SelectedNode = node;
                    //treeView1.SelectedNode = tmp;
                    //treeView1.SelectedNode.Expand();
                    //treeView1.SelectedNode = tmp;
                    //treeView1.ExpandAll();
                }

                
            }
        }

        private void deleteNode_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string id = treeView1.SelectedNode.Name.ToString();
                DataRow[] row = dataSet1.stamptype.Select("id=" + id);
                if (row != null)
                {

                    DataRow[] rowChildren = dataSet1.stamptype.Select("parentid=" + id);
                    if (rowChildren.Length != 0)
                    {
                        MessageBox.Show("请先删除此节点中的子节点！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sta.DeleteByID(Convert.ToInt32(id));
                        this.sta.Fill(dataSet1.stamptype);
                        treeView1.SelectedNode.Remove();
                    }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            this.tbSCode.Text = row.Cells["codeDataGridViewTextBoxColumn"].Value.ToString();
            this.tbSClass.Text = row.Cells["classnameDataGridViewTextBoxColumn"].Value.ToString();
            this.tbSName.Text = row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            this.tbSPrice.Text = row.Cells["priceoriDataGridViewTextBoxColumn"].Value.ToString();
            this.tbSPubDate.Text = Convert.ToDateTime(row.Cells["publishdateDataGridViewTextBoxColumn"].Value).ToShortDateString();
            this.tbSType.Text = row.Cells["typenameDataGridViewTextBoxColumn"].Value.ToString();
            this.tbSUnit.Text = row.Cells["unitnameDataGridViewTextBoxColumn"].Value.ToString();
            this.rtMemo.Text = row.Cells["memoDataGridViewTextBoxColumn"].Value.ToString();
            string picPath = row.Cells["picpathDataGridViewTextBoxColumn"].Value.ToString();

            List<string> imgPath = new List<string>();
            String imgdr = System.Windows.Forms.Application.StartupPath + "\\picture\\";
            while (picPath.IndexOf(",") != -1)
            {
                imgPath.Add(imgdr+picPath.Substring(0, picPath.IndexOf(",")));
                picPath = picPath.Substring(picPath.IndexOf(",")+1);
            
            
            }




           // string[] imgPath = fileDialog.FileNames;


            //string directory = Path.GetDirectoryName(imgPath);
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
                    imgArray.Add(img);
                }
                catch
                {
                    MessageBox.Show("未找到图片，请重新添加!");
                }



                //File.Copy(img,img+DateTime.Today.
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
            }
            catch
            {
            }
        }




        



        private void addStampMS_Click(object sender, EventArgs e)
        {

        }

        private void tsbAddStamp_Click(object sender, EventArgs e)
        {
            AddStampForm addStampForm=new AddStampForm();
            if (addStampForm.ShowDialog() == DialogResult.OK)
            {
                
                //this.treeView1.SelectedNode = this.treeView1.Nodes[((ComboBox)addStampForm.Controls["cbType"]).SelectedValue.ToString()];
            }
        }

        private void tsbEditStamp_Click(object sender, EventArgs e)
        {
            AddStampForm addStampForm = new AddStampForm();

            if (dataGridView1.SelectedRows.Count != 0)
            {
                addStampForm.Tag = dataGridView1.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;
                if (addStampForm.ShowDialog() == DialogResult.OK)
                {

                    view_stampinfoTableAdapter.Fill(this.collectionDataSet.view_stampinfo);
                }
            }
            else
            {
                MessageBox.Show("请先选择要编辑的邮票！");
            }
        }


    }
}
