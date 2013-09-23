using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CollectionManager.DATA.Database.CollectionDataSetTableAdapters;
using System.IO;

namespace CollectionManager
{
    public partial class AddCoinForm : Form
    {

        List<Bitmap> listImage = new List<Bitmap>();

        coininfoTableAdapter coininfoTA = new coininfoTableAdapter();


        public AddCoinForm()
        {
            InitializeComponent();
        }

        private void AddCoinForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“collectionDataSet.coinclass”中。您可以根据需要移动或删除它。
            this.coinclassTableAdapter.Fill(this.collectionDataSet.coinclass);
            // TODO: 这行代码将数据加载到表“collectionDataSet.cointype”中。您可以根据需要移动或删除它。
            this.cointypeTableAdapter.Fill(this.collectionDataSet.cointype);
            // TODO: 这行代码将数据加载到表“collectionDataSet.coinunit”中。您可以根据需要移动或删除它。
            this.coinunitTableAdapter.Fill(this.collectionDataSet.coinunit);
            if (this.Text == "编辑钱币")
            {

                if (this.Tag != null)
                {
                    List<string> imgArray = new List<string>();
                    //this.Text = "编辑钱币";
                    this.btnAccept.Text = "保存编辑";
                    CollectionManager.DATA.Database.CollectionDataSet.coininfoDataTable coininfo = coininfoTA.GetDataByID(Convert.ToInt32(this.Tag));
                    if (coininfo != null)
                    {
                        this.tbCPublisher.Text = coininfo.Rows[0]["publisher"].ToString();
                        this.tbCName.Text = coininfo.Rows[0]["name"].ToString();
                        this.tbCPubDate.Text = Convert.ToDateTime(coininfo.Rows[0]["publishdate"].ToString()).ToShortDateString();
                        this.tbCPrice.Text = coininfo.Rows[0]["price_ori"].ToString();
                        this.cbCUnit.SelectedValue = coininfo.Rows[0]["unitid"].ToString();
                        this.cbCType.SelectedValue = coininfo.Rows[0]["typeid"].ToString();
                        this.cbCClass.SelectedValue = coininfo.Rows[0]["classid"].ToString();
                        this.rtCMemo.Text=coininfo.Rows[0]["memo"].ToString();
                        string picPath = coininfo.Rows[0]["picpath"].ToString();
                        String imgdr = System.Windows.Forms.Application.StartupPath + "\\DATA\\CoinPicture\\";
                        while (picPath.IndexOf(",") != -1)
                        {
                            imgArray.Add(imgdr + picPath.Substring(0, picPath.IndexOf(",")));
                            picPath = picPath.Substring(picPath.IndexOf(",") + 1);


                        }

                        this.flowLayoutPanel1.Controls.Clear();

                        foreach (string img in imgArray)
                        {
                            Panel panel = new Panel();
                            panel.Size = new System.Drawing.Size(200, 185);
                            panel.BorderStyle = BorderStyle.FixedSingle;
                            try
                            {
                                Bitmap newbitmap = (Bitmap)Image.FromFile(img);
                                PictureBox picBox = new PictureBox();
                                picBox.Image = newbitmap;
                                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                                picBox.Width = 200;
                                picBox.Height = 150;
                                picBox.Location = new Point(0, 0);
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
                                btnDelImg.Tag = newbitmap;
                                btnDelImg.Click += new System.EventHandler(this.btnDelImg_Click);

                                panel.Controls.Add(picBox);
                                panel.Controls.Add(btnEditImg);
                                panel.Controls.Add(btnDelImg);



                                this.flowLayoutPanel1.Controls.Add(panel);
                                //imgArray.Add(img);
                                listImage.Add(newbitmap);

                            }
                            catch
                            {

                            }

                        }


                    }
                }
                else
                {
                    MessageBox.Show("请先选择要编辑的钱币！");
                }


            }
            else
            {
                this.cbCType.SelectedValue = this.Tag.ToString();
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
                    //int i = 0;
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
                        //picBox.Tag = newbitmap;
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
                        btnDelImg.Tag = newbitmap;
                        btnDelImg.Click += new System.EventHandler(this.btnDelImg_Click);

                        panel.Controls.Add(picBox);
                        panel.Controls.Add(btnEditImg);
                        panel.Controls.Add(btnDelImg);



                        this.flowLayoutPanel1.Controls.Add(panel);
                        //imgArray.Add(img);
                        listImage.Add(newbitmap);
                        //i++;//标识图片在listImage中的序号



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


                    listImage[listImage.IndexOf((Bitmap)((Button)sender).Tag)] = (Bitmap)editImgForm.Tag;
                    ((Button)sender).Tag = (Image)editImgForm.Tag;
                }
                editImgForm.Dispose();
            }
            catch
            {
            }
        }

        private void btnDelImg_Click(object sender, EventArgs e)
        {
            //string img = ((Button)sender).Tag.ToString();
            //imgArray.Remove(img);
            Bitmap delimg = (Bitmap)((Button)sender).Tag;
            listImage.Remove(delimg);
            //listImage.RemoveAt(Convert.ToInt32(((PictureBox)((Button)sender).Parent.Controls[0]).Tag));
            this.flowLayoutPanel1.Controls.Remove(((Button)sender).Parent);

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.tbCName.Text == "")
            {
                MessageBox.Show("名称不能为空!");
                return;
            }
            if (this.tbCPubDate.Text == "")
            {
                MessageBox.Show("出版时间不能为空!");
                return;
            }
            if (cbCType.SelectedIndex == 0)
            {
                MessageBox.Show("请选择自建分类！");
                return;
            }


            
            string picpath = "";
            try
            {
                //List<string> picnames = new List<string>();
                String targetPathDr = System.Windows.Forms.Application.StartupPath + "\\DATA\\CoinPicture\\";
                if (!System.IO.Directory.Exists(targetPathDr))
                {
                    // 目录不存在，建立目录 
                    System.IO.Directory.CreateDirectory(targetPathDr);
                }
                foreach (Bitmap img in listImage)
                {
                    string targetimgPath = targetPathDr + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".jpg";

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
                    coininfoTA.Insert(tbCPublisher.Text, tbCName.Text, Convert.ToInt32(cbCType.SelectedValue), Convert.ToDateTime(tbCPubDate.Text), tbCPrice.Text, Convert.ToInt32(cbCUnit.SelectedValue), Convert.ToInt32(cbCClass.SelectedValue), picpath, rtCMemo.Text);

                }
                else
                {
                    coininfoTA.UpdateByID(tbCPublisher.Text, tbCName.Text, Convert.ToInt32(cbCType.SelectedValue), Convert.ToDateTime(tbCPubDate.Text), tbCPrice.Text, Convert.ToInt32(cbCUnit.SelectedValue), Convert.ToInt32(cbCClass.SelectedValue), picpath, rtCMemo.Text, Convert.ToInt32(this.Tag));
                    /////////需要将主界面的数据即时更新。



                }


                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("新增信息不成功，请检查数据输入是否正确！");
            }

            //返回增加邮票的分类
            this.Tag = cbCType.SelectedValue;
        }


        private void tbCPubDate_Validating(object sender, CancelEventArgs e)
        {
            if (this.tbCPubDate.Text != null)
            {
                try
                {
                    DateTime.Parse(this.tbCPubDate.Text);
                }
                catch
                {
                    MessageBox.Show("输入有误请按“1970/1/1”的格式输入日期！");
                }
            }
        }
    }
}
