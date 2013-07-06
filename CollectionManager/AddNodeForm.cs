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
    public partial class AddNodeForm : Form
    {
        public AddNodeForm()
        {
            InitializeComponent();
        }
        public string addNodeTxt="";

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                addNodeTxt = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请输入节点名称！");
            }
        }

    }
}
