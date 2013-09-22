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
    public partial class ClassManageForm : Form
    {
        public ClassManageForm()
        {
            InitializeComponent();
        }
        private DATA.Database.CollectionDataSetTableAdapters.stampclassTableAdapter stampclassTableAdapter;
        private DATA.Database.CollectionDataSetTableAdapters.stampunitTableAdapter stampunitTableAdapter;
        private DATA.Database.CollectionDataSetTableAdapters.coinclassTableAdapter coinclassTableAdapter;
        private DATA.Database.CollectionDataSetTableAdapters.coinunitTableAdapter coinunitTableAdapter;

        private void StampClassManage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“collectionDataSet.stampclass”中。您可以根据需要移动或删除它。
            if (this.Text == "邮票类型管理")
            {
                this.stampclassTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.stampclassTableAdapter();
                this.listBoxBindingSource.DataMember = "stampclass";
                this.listBox1.ValueMember = "id";
                this.listBox1.DisplayMember = "classname";
                
                this.stampclassTableAdapter.Fill(this.collectionDataSet.stampclass);
            }

            if (this.Text == "邮票单位管理")
            {
                this.stampunitTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.stampunitTableAdapter();
                this.listBoxBindingSource.DataMember = "stampunit";
                this.listBox1.ValueMember = "id";
                this.listBox1.DisplayMember = "unitname";
                this.stampunitTableAdapter.Fill(this.collectionDataSet.stampunit);
            }
            if (this.Text == "钱币类型管理")
            {
                this.coinclassTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.coinclassTableAdapter();
                this.listBoxBindingSource.DataMember = "coinclass";
                this.listBox1.ValueMember = "id";
                this.listBox1.DisplayMember = "classname";

                this.coinclassTableAdapter.Fill(this.collectionDataSet.coinclass);
            }

            if (this.Text == "钱币单位管理")
            {
                this.coinunitTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.coinunitTableAdapter();
                this.listBoxBindingSource.DataMember = "coinunit";
                this.listBox1.ValueMember = "id";
                this.listBox1.DisplayMember = "unitname";
                this.coinunitTableAdapter.Fill(this.collectionDataSet.coinunit);
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.Text == "邮票类型管理")
            {
                AddQueryItemNameForm addStampClassForm = new AddQueryItemNameForm();
                addStampClassForm.Text = "请输入邮票类型名称";
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
                addStampUnitForm.Text = "请输入邮票单位名称";
                if (addStampUnitForm.ShowDialog() == DialogResult.OK)
                {
                    string txt = addStampUnitForm.addTxt;
                    this.stampunitTableAdapter.Insert(txt);
                    this.stampunitTableAdapter.Fill(this.collectionDataSet.stampunit);
                }
            }
            if (this.Text == "钱币类型管理")
            {
                AddQueryItemNameForm addCoinClassForm = new AddQueryItemNameForm();
                addCoinClassForm.Text = "请输入钱币类型名称";
                if (addCoinClassForm.ShowDialog() == DialogResult.OK)
                {
                    string txt = addCoinClassForm.addTxt;
                    this.coinclassTableAdapter.Insert(txt);
                    this.coinclassTableAdapter.Fill(this.collectionDataSet.coinclass);
                }
            }

            if (this.Text == "钱币单位管理")
            {
                AddQueryItemNameForm addCoinUnitForm = new AddQueryItemNameForm();
                addCoinUnitForm.Text = "请输入钱币单位名称";
                if (addCoinUnitForm.ShowDialog() == DialogResult.OK)
                {
                    string txt = addCoinUnitForm.addTxt;
                    this.coinunitTableAdapter.Insert(txt);
                    this.coinunitTableAdapter.Fill(this.collectionDataSet.coinunit);
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
                if (this.Text == "钱币类型管理")
                {
                    AddQueryItemNameForm addCoinClassForm = new AddQueryItemNameForm();
                    addCoinClassForm.Text = "请输入新的名称";
                    if (addCoinClassForm.ShowDialog() == DialogResult.OK)
                    {
                        string txt = addCoinClassForm.addTxt;
                        this.coinclassTableAdapter.Update(txt, Convert.ToInt32(listBox1.SelectedValue.ToString()), listBox1.Text);
                        this.coinclassTableAdapter.Fill(this.collectionDataSet.coinclass);
                    }
                }
                if (this.Text == "钱币单位管理")
                {
                    AddQueryItemNameForm addCoinUnitForm = new AddQueryItemNameForm();
                    addCoinUnitForm.Text = "请输入新的名称";
                    if (addCoinUnitForm.ShowDialog() == DialogResult.OK)
                    {
                        string txt = addCoinUnitForm.addTxt;
                        this.coinunitTableAdapter.Update(txt, Convert.ToInt32(listBox1.SelectedValue.ToString()), listBox1.Text);
                        this.coinunitTableAdapter.Fill(this.collectionDataSet.coinunit);
                    }
                }


            }
            else
            {
                MessageBox.Show("请选择要编辑的项！");
            }
        }

        private DATA.Database.CollectionDataSetTableAdapters.stampinfoTableAdapter stampinfoAdapter = new DATA.Database.CollectionDataSetTableAdapters.stampinfoTableAdapter();
        private DATA.Database.CollectionDataSetTableAdapters.coininfoTableAdapter coininfoAdapter = new DATA.Database.CollectionDataSetTableAdapters.coininfoTableAdapter();
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                if (this.Text == "邮票类型管理")
                {
                    if (stampinfoAdapter.ScalarQueryByClassID(Convert.ToInt32(this.listBox1.SelectedValue)) == 0)
                    {
                        this.stampclassTableAdapter.Delete(Convert.ToInt32(listBox1.SelectedValue), listBox1.Text);
                        this.stampclassTableAdapter.Fill(this.collectionDataSet.stampclass);

                    }
                    else
                    {
                        MessageBox.Show("请先删除所有属于此类型的邮票信息再进行删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                if (this.Text == "邮票单位管理")
                {
                    if (stampinfoAdapter.ScalarQueryByUnitID(Convert.ToInt32(this.listBox1.SelectedValue)) == 0)
                    {
                        this.stampunitTableAdapter.Delete(Convert.ToInt32(listBox1.SelectedValue), listBox1.Text);
                        this.stampunitTableAdapter.Fill(this.collectionDataSet.stampunit);
                    }
                    else
                    {
                        MessageBox.Show("请先删除所有属于此单位的邮票信息再进行删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (this.Text == "钱币类型管理")
                {
                    if (coininfoAdapter.ScalarQueryByClassID(Convert.ToInt32(this.listBox1.SelectedValue)) == 0)
                    {
                        this.coinclassTableAdapter.Delete(Convert.ToInt32(listBox1.SelectedValue), listBox1.Text);
                        this.coinclassTableAdapter.Fill(this.collectionDataSet.coinclass);

                    }
                    else
                    {
                        MessageBox.Show("请先删除所有属于此类型的钱币信息再进行删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                if (this.Text == "钱币单位管理")
                {
                    if (coininfoAdapter.ScalarQueryByUnitID(Convert.ToInt32(this.listBox1.SelectedValue)) == 0)
                    {
                        this.coinunitTableAdapter.Delete(Convert.ToInt32(listBox1.SelectedValue), listBox1.Text);
                        this.coinunitTableAdapter.Fill(this.collectionDataSet.coinunit);
                    }
                    else
                    {
                        MessageBox.Show("请先删除所有属于此单位的钱币信息再进行删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }



            }
            else
            {
                MessageBox.Show("请选择要编辑的项！");
            }
        }
    }
}
