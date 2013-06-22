using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollectionManager
{
    public partial class StampQueryManageForm : Form
    {
        public StampQueryManageForm()
        {
            InitializeComponent();
        }
        private Database.CollectionDataSetTableAdapters.stampclassTableAdapter stampclassTableAdapter;
        private Database.CollectionDataSetTableAdapters.stampunitTableAdapter stampunitTableAdapter;
        private void StampClassManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“collectionDataSet.stampclass”中。您可以根据需要移动或删除它。
            if (this.Text == "邮票类型管理")
            {
                this.stampclassTableAdapter = new CollectionManager.Database.CollectionDataSetTableAdapters.stampclassTableAdapter();
                this.listBoxBindingSource.DataMember = "stampclass";
                this.listBox1.ValueMember = "id";
                this.listBox1.DisplayMember = "classname";
                
                this.stampclassTableAdapter.Fill(this.collectionDataSet.stampclass);
            }

            if (this.Text == "邮票单位管理")
            {
                this.stampunitTableAdapter = new CollectionManager.Database.CollectionDataSetTableAdapters.stampunitTableAdapter();
                this.listBoxBindingSource.DataMember = "stampunit";
                this.listBox1.ValueMember = "id";
                this.listBox1.DisplayMember = "unitname";
                this.stampunitTableAdapter.Fill(this.collectionDataSet.stampunit);
            }


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.Text == "邮票类型管理")
            {
                AddQueryItemNameForm addStampClassForm = new AddQueryItemNameForm();
                if (addStampClassForm.ShowDialog() == DialogResult.OK)
                {
                    string txt = addStampClassForm.addTxt;
                    this.stampclassTableAdapter.Insert(txt);
                    this.stampclassTableAdapter.Fill(this.collectionDataSet.stampclass);
                }
            }

            if (this.Text == "邮票单位管理")
            {
                AddQueryItemNameForm addStampUnitForm = new AddQueryItemNameForm();
                if (addStampUnitForm.ShowDialog() == DialogResult.OK)
                {
                    string txt = addStampUnitForm.addTxt;
                    this.stampunitTableAdapter.Insert(txt);
                    this.stampunitTableAdapter.Fill(this.collectionDataSet.stampunit);
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                if (this.Text == "邮票类型管理")
                {
                    AddQueryItemNameForm addStampClassForm = new AddQueryItemNameForm();
                    addStampClassForm.Text = "请输入新的名称";
                    if (addStampClassForm.ShowDialog() == DialogResult.OK)
                    {
                        string txt = addStampClassForm.addTxt;
                        this.stampclassTableAdapter.Update(txt, Convert.ToInt32(listBox1.SelectedValue.ToString()), listBox1.Text);
                        this.stampclassTableAdapter.Fill(this.collectionDataSet.stampclass);
                    }
                }
                if (this.Text == "邮票单位管理")
                {
                    AddQueryItemNameForm addStampUnitForm = new AddQueryItemNameForm();
                    addStampUnitForm.Text = "请输入新的名称";
                    if (addStampUnitForm.ShowDialog() == DialogResult.OK)
                    {
                        string txt = addStampUnitForm.addTxt;
                        this.stampunitTableAdapter.Update(txt, Convert.ToInt32(listBox1.SelectedValue.ToString()), listBox1.Text);
                        this.stampunitTableAdapter.Fill(this.collectionDataSet.stampunit);
                    }
                }



            }
            else
            {
                MessageBox.Show("请选择要编辑的项！");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                if (this.Text == "邮票类型管理")
                {

                    this.stampclassTableAdapter.Delete(Convert.ToInt32(listBox1.SelectedValue), listBox1.Text);
                    this.stampclassTableAdapter.Fill(this.collectionDataSet.stampclass);
                }
                if (this.Text == "邮票单位管理")
                {
                    this.stampunitTableAdapter.Delete(Convert.ToInt32(listBox1.SelectedValue), listBox1.Text);
                    this.stampunitTableAdapter.Fill(this.collectionDataSet.stampunit);
                }

            }
            else
            {
                MessageBox.Show("请选择要编辑的项！");
            }
        }
    }
}
