using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace CollectionManager
{
    public partial class EditImageForm : Form
    {
        public EditImageForm()
        {
            InitializeComponent();
            
            
        }
        int imgHeight=0;
        int imgWidth=0;
        int isSaveed = 1;
        private void EditImageForm_Load(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            //string img = this.Tag.ToString();
            //Bitmap newbitmap = (Bitmap)Image.FromFile(img);
            pictureBox1.Image = (Bitmap)this.Tag;
            
            imgHeight = 600;
            imgWidth = (int)(pictureBox1.Image.Width / (((float)pictureBox1.Image.Height / 600)));
            pictureBox1.Height = imgHeight;
            pictureBox1.Width = imgWidth;
            pictureBox1.Location = new Point(0, 0);

            if (this.Text == "查看大图")
            {
                this.btnCut.Visible = false;
                this.btnL90.Visible = false;
                this.btnLRotate.Visible = false;
                this.btnQuit.Visible = false;
                this.btnR90.Visible = false;
                this.btnRRotate.Visible = false;
                this.btnSave.Visible = false;
                this.btnEndView.Visible = true;

            }
        }

        private void btnLRotate_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManager.Rotate((Bitmap)pictureBox1.Image, 1);
            isSaveed = 0;
        }

        private void btnL90_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManager.KiRotate270((Bitmap)pictureBox1.Image);
            isSaveed = 0;
        }

        private void btnR90_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManager.KiRotate90((Bitmap)pictureBox1.Image);
            isSaveed = 0;
        }

        private void btnRRotate_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageManager.Rotate((Bitmap)pictureBox1.Image, -1);
            isSaveed = 0;
        }
        bool isDrag = false;
        Rectangle theRectangle = new Rectangle(new Point(0, 0), new Size(0, 0));
        Point startPoint, oldPoint;
        private Graphics ig;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Text == "编辑图片")
            {
                if (e.Button == MouseButtons.Left)
                {
                    //如果开始绘制，则开始记录鼠标位置
                    if ((isDrag = !isDrag) == true)
                    {
                        startPoint = new Point(e.X, e.Y);
                        oldPoint = new Point(e.X, e.Y);
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
            if (isDrag)
            {
                Graphics g = pictureBox1.CreateGraphics();
                pictureBox1.Refresh();
                g.DrawRectangle(new Pen(Color.Black, 1), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Text == "编辑图片")
            {
                isDrag = false;
                ig = pictureBox1.CreateGraphics();
                ig.DrawRectangle(new Pen(Color.Black, 1), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                theRectangle = new Rectangle(startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            try
            {
                //Graphics graphics = this.CreateGraphics();
                //Bitmap bitmap = new Bitmap(pictureBox1.Image);
                //Bitmap cloneBitmap = bitmap.Clone(theRectangle, PixelFormat.DontCare);
                //pictureBox1.Visible = false;

                //Button btn = (Button)sender;
                //graphics.DrawImage(cloneBitmap, btn.Parent.Location.X, btn.Parent.Location.Y);
                //Graphics g = pictureBox1.CreateGraphics();
                //SolidBrush myBrush = new SolidBrush(Color.White);
                //g.FillRectangle(myBrush, theRectangle);


                int x = theRectangle.X * pictureBox1.Image.Width / imgWidth;
                int y = theRectangle.Y * pictureBox1.Image.Height / imgHeight;
                int width = theRectangle.Width * pictureBox1.Image.Width / imgWidth;
                int height = theRectangle.Height * pictureBox1.Image.Height / imgHeight;
                

                
                

                pictureBox1.Image =
                    ImageManager.CutImage((Bitmap)pictureBox1.Image, x, y, width, height);

                imgHeight = 600;
                imgWidth = (int)(pictureBox1.Image.Width / (((float)pictureBox1.Image.Height / 600)));
                pictureBox1.Height = imgHeight;
                pictureBox1.Width = imgWidth;
                pictureBox1.Location = new Point(0, 0);
                isSaveed = 0;
                //pictureBox1.Image = ImageManager.CutImage((Bitmap)pictureBox1.Image, theRectangle.X, theRectangle.Y, theRectangle.Width, theRectangle.Height);
            }
            catch
            { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Tag = pictureBox1.Image;
            isSaveed = 1;
            //((PictureBox)(((Button)sender).Parent.Controls[0])).Image = pictureBox1.Image;
            //this.DialogResult = DialogResult.OK;
        }


        private void btnEndView_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaveed == 0)
            {
                if (MessageBox.Show((EditImageForm)sender, "您还没有保存编辑过的图片，是否保存？", "提示", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    this.Tag = pictureBox1.Image;
                    isSaveed = 1;
                    //((PictureBox)(((Button)sender).Parent.Controls[0])).Image = pictureBox1.Image;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;

        }



    }
}
