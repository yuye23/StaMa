using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace RestoreData
{
    public partial class RestoreForm : Form
    {
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\DataBack\\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "收藏管理备份文件(*.cmz)|*.cmz";



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                    textBox1.Text = openFileDialog1.FileName;

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请先选择正确的备份文件");
            }
            else
            {

                string fileName = textBox1.Text;
                fileName = Path.GetFileName(fileName);


                System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"back_\d\d\d\d-\d\d-\d\d-\d\d\d\d\d\d.cmz");
                System.Text.RegularExpressions.Match m = r.Match(fileName);
                if (m.Success)
                {

                    MessageBox.Show("为避免错误操作，恢复数据前将先进行当前数据备份！");

                    CollectionManager.ProcessBarForm proBarForm = new CollectionManager.ProcessBarForm();
                    proBarForm.task = "BackAllData";

                    if (proBarForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("备份成功!，请妥善保管备份文件。备份路径：" + proBarForm.savePath);
                    }

                    if (DialogResult.OK == MessageBox.Show("是否真的恢复数据？此操作将使您的全部数据恢复到所选备份文件时的数据！", "警告", MessageBoxButtons.OKCancel))
                    {
                        CollectionManager.ProcessBarForm proBarForm1 = new CollectionManager.ProcessBarForm();
                        proBarForm1.task = "RestoreAllData";
                        proBarForm1.restoreFilePath = textBox1.Text;
                        if (proBarForm1.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("恢复成功!，数据恢复到：" + proBarForm1.restoreDate);
                            this.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("备份文件有误，请选择文件名形如“back_XXXX-XX-XX-XXXXXX.cmz”的备份文件！");
                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


    }
}
