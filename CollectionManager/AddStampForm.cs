using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CollectionManager.Database.CollectionDataSetTableAdapters;
using System.IO;

namespace CollectionManager
{
    public partial class AddStampForm : Form
    {
        List<string> imgArray = new List<string>();
        List<Bitmap> listImage = new List<Bitmap>();

        stampinfoTableAdapter stampinfoTA = new stampinfoTableAdapter();
       
        //view_stampinfoTableAdapter view_stampinfoTA = new view_stampinfoTableAdapter();

        public AddStampForm()
        {
            InitializeComponent();
        }


        private void AddStampForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“collectionDataSet.stampclass”中。您可以根据需要移动或删除它。
            this.stampclassTableAdapter.Fill(this.collectionDataSet.stampclass);
            // TODO: 这行代码将数据加载到表“collectionDataSet.stamptype”中。您可以根据需要移动或删除它。
            this.stamptypeTableAdapter.Fill(this.collectionDataSet.stamptype);
            // TODO: 这行代码将数据加载到表“collectionDataSet.stampunit”中。您可以根据需要移动或删除它。
            this.stampunitTableAdapter.Fill(this.collectionDataSet.stampunit);
            if (this.Tag != null)
            {
                this.Text = "编辑邮票";
                this.btnAccept.Text = "保存编辑";
                CollectionManager.Database.CollectionDataSet.stampinfoDataTable stampinfo = stampinfoTA.GetDataByID(Convert.ToInt32(this.Tag));
                if (stampinfo != null)
                {
                    this.tbSCode.Text = stampinfo.Rows[0]["code"].ToString();
                    this.tbSName.Text = stampinfo.Rows[0]["name"].ToString();
                    this.tbSPubDate.Text = stampinfo.Rows[0]["publishdate"].ToString();
                    this.tbSPrice.Text = stampinfo.Rows[0]["price_ori"].ToString();
                    this.cbUnit.SelectedValue = stampinfo.Rows[0]["unitid"].ToString();
                    this.cbType.SelectedValue = stampinfo.Rows[0]["typeid"].ToString();
                    this.cbClass.SelectedValue = stampinfo.Rows[0]["classid"].ToString();
                    string picPath = stampinfo.Rows[0]["picpath"].ToString();
                    String imgdr = System.Windows.Forms.Application.StartupPath + "\\picture\\";
                    while (picPath.IndexOf(",") != -1)
                    {
                        imgArray.Add(imgdr + picPath.Substring(0, picPath.IndexOf(",")));
                        picPath = picPath.Substring(picPath.IndexOf(",") + 1);


                    }

                    this.flowLayoutPanel1.Controls.Clear();
                    int i = 0;
                    foreach (string img in imgArray)
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
                        picBox.Tag = i;

                        Button btnEditImg = new Button();
                        Button btnDelImg = new Button();
                        btnEditImg.Name = "btnEditImg";
                        btnEditImg.Text = "编辑图片";
                        btnEditImg.TextAlign = ContentAlignment.MiddleCenter;
                        btnEditImg.Width = 80;
                        btnEditImg.Height = 25;
                        btnEditImg.Location = new Point(10, 155);
                        btnEditImg.Tag = newbitmap;
                        btnEditImg.Click += new System.EventHandler(this.btnEditImg_Click);

                        btnDelImg.Name = "btnDelImg";
                        btnDelImg.Text = "放弃插入";
                        btnEditImg.TextAlign = ContentAlignment.MiddleCenter;
                        btnDelImg.Width = 80;
                        btnDelImg.Height = 25;
                        btnDelImg.Location = new Point(110, 155);
                        btnDelImg.Tag = img;
                        btnDelImg.Click += new System.EventHandler(this.btnDelImg_Click);

                        panel.Controls.Add(picBox);
                        panel.Controls.Add(btnEditImg);
                        panel.Controls.Add(btnDelImg);



                        this.flowLayoutPanel1.Controls.Add(panel);
                        //imgArray.Add(img);
                        listImage.Add(newbitmap);
                        i++;
                    }


                }
                else
                {
                    MessageBox.Show("请先选择要编辑的邮票！");
                }
            }

        }

        private void tbSPubDate_Validating(object sender, CancelEventArgs e)
        {
            if (this.tbSPubDate.Text != null)
            {
                try
                {
                    DateTime.Parse(this.tbSPubDate.Text);
                }
                catch
                {
                    MessageBox.Show("输入有误请按“1970/1/1”的格式输入日期！");
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            if (this.tbSName.Text == "")
            {
                MessageBox.Show("名称不能为空!");
                return;
            }
            if (this.tbSPubDate.Text == "")
            {
                MessageBox.Show("出版时间不能为空!");
                return;
            }
            if (cbType.SelectedIndex == 0)
            {
                MessageBox.Show("请选择自建分类！");
                return;
            }


            //stampinfoTableAdapter stampinfoTA = new stampinfoTableAdapter();
            string picpath = "";
            try
            {
                //List<string> picnames = new List<string>();
                String targetPathDr = System.Windows.Forms.Application.StartupPath + "\\picture\\";
                if (!System.IO.Directory.Exists(targetPathDr))
                    {
                        // 目录不存在，建立目录 
                        System.IO.Directory.CreateDirectory(targetPathDr);
                    }
                foreach (Bitmap img in listImage)
                {
                    string targetimgPath = targetPathDr + DateTime.Now.ToString("yyyyMMddHHmmssffff") +".jpg";
                    
                    try
                    {
                        int imgHeight = 1200;
                        int imgWidth = (int)(img.Width / (((float)img.Height / 1200)));
                        Bitmap newImg = ImageManager.ResizeImage(img, imgWidth, imgHeight, 0);
                        ImageManager.SaveQuality(newImg, targetimgPath);


                        //File.Copy(img, targetimg);
                        //picnames.Add(Path.GetFileName(targetimgPath));
                        picpath += Path.GetFileName(targetimgPath) + ",";
                    }
                    catch
                    {
                        MessageBox.Show("图片插入不成功，请检查文件名，重新插入！");
                        return;
                    }
                        
                }
                if (btnAccept.Text == "确定新增")
                {
                    stampinfoTA.Insert(tbSCode.Text, tbSName.Text, Convert.ToInt32(cbType.SelectedValue), Convert.ToDateTime(tbSPubDate.Text), tbSPrice.Text, Convert.ToInt32(cbUnit.SelectedValue), Convert.ToInt32(cbClass.SelectedValue), picpath, rtMemo.Text);

                }
                else
                {
                    stampinfoTA.UpdateByID(tbSCode.Text, tbSName.Text, Convert.ToInt32(cbType.SelectedValue), Convert.ToDateTime(tbSPubDate.Text), tbSPrice.Text, Convert.ToInt32(cbUnit.SelectedValue), Convert.ToInt32(cbClass.SelectedValue), picpath, rtMemo.Text, Convert.ToInt32(this.Tag));
               /////////需要将主界面的数据即时更新。
                
                
                
                }
                
                
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("新增信息不成功，请检查数据输入是否正确！");
            }
            
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "图片文件(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png|(All file(*.*)|*.*";
                fileDialog.Multiselect = true;
                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] imgPath = fileDialog.FileNames;
                    //string directory = Path.GetDirectoryName(imgPath);
                    int i = 0;
                    foreach (string img in imgPath)
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
                        picBox.Tag = i;
                        //panel.Name = Path.GetFileNameWithoutExtension(img);
                        

                        Button btnEditImg = new Button();
                        Button btnDelImg = new Button();
                        btnEditImg.Name = "btnEditImg";
                        btnEditImg.Text = "编辑图片";
                        btnEditImg.TextAlign = ContentAlignment.MiddleCenter;
                        btnEditImg.Width = 80;
                        btnEditImg.Height = 25;
                        btnEditImg.Location = new Point(10, 155);
                        btnEditImg.Tag = newbitmap;
                        btnEditImg.Click += new System.EventHandler(this.btnEditImg_Click);

                        btnDelImg.Name = "btnDelImg";
                        btnDelImg.Text = "放弃插入";
                        btnEditImg.TextAlign = ContentAlignment.MiddleCenter;
                        btnDelImg.Width = 80;
                        btnDelImg.Height = 25;
                        btnDelImg.Location = new Point(110, 155);
                        btnDelImg.Tag = img;
                        btnDelImg.Click += new System.EventHandler(this.btnDelImg_Click);

                        panel.Controls.Add(picBox);
                        panel.Controls.Add(btnEditImg);
                        panel.Controls.Add(btnDelImg);



                        this.flowLayoutPanel1.Controls.Add(panel);
                        imgArray.Add(img);
                        listImage.Add(newbitmap);
                        i++;//标识图片在listImage中的序号



                        //File.Copy(img,img+DateTime.Today.
                    }
                    
                    
                    
                    
                    //imgArray = ImageManager.GetImgCollection(directory);
                    

                    
                    
                    
                    
                    //picBoxView.SizeMode = PictureBoxSizeMode.Zoom;
                    //imgPath = fileDialog.FileName;
                    //// 初始化图片集合
                    //

                    //newbitmap = (Bitmap)Image.FromFile(imgPath);
                    //picBoxView.Image = newbitmap;
                }


            }
        }

        private void btnEditImg_Click(object sender, EventArgs e)
        {
            try
            {
                EditImageForm editImgForm = new EditImageForm();
                editImgForm.Tag = ((Button)sender).Tag;
                if (editImgForm.ShowDialog() == DialogResult.OK)
                {
                    ((PictureBox)((Button)sender).Parent.Controls[0]).Image = (Image)editImgForm.Tag;
                    ((Button)sender).Tag = (Image)editImgForm.Tag;
                    listImage[Convert.ToInt32(((PictureBox)((Button)sender).Parent.Controls[0]).Tag)] = (Bitmap)editImgForm.Tag;
                }
            }
            catch
            {
            }
        }

        private void btnDelImg_Click(object sender, EventArgs e)
        {
            string img = ((Button)sender).Tag.ToString();
            imgArray.Remove(img);
            listImage.RemoveAt(Convert.ToInt32(((PictureBox)((Button)sender).Parent.Controls[0]).Tag));
            this.flowLayoutPanel1.Controls.Remove(((Button)sender).Parent);

        }
    }
}
