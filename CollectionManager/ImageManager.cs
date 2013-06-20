using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;


namespace CollectionManager
{
    public class ImageManager
    {
        
        /// <summary>
        /// Resize图片
        /// </summary>
        /// <param name="bmp">原始Bitmap</param>
        /// <param name="newW">新的宽度</param>
        /// <param name="newH">新的高度</param>
        /// <param name="Mode">保留着，暂时未用</param>
        /// <returns>处理以后的图片</returns>
        public static Bitmap ResizeImage(Bitmap bmp, int newW, int newH, int Mode)
        {
            try
            {
                Bitmap b = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(b);

                // 插值算法的质量
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();

                return b;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 高质量保存                
        /// </summary>
        /// <param name="image"></param>
        /// <param name="path"></param>
        public static void SaveQuality(Image image, String path)
        {
            ImageCodecInfo[] myImageCodecInfos;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;
            myImageCodecInfos = ImageCodecInfo.GetImageEncoders();
            ImageCodecInfo myImageCodecInfo = null;
            foreach (ImageCodecInfo item in myImageCodecInfos)
            {
                if (item.MimeType == "image/jpeg")
                {
                    myImageCodecInfo = item;
                }
            }
            if (myImageCodecInfo == null)
            {
                foreach (ImageCodecInfo item in myImageCodecInfos)
                {
                    if (item.MimeType == "image/jpeg" || item.MimeType == "image/bmp" || item.MimeType == "image/png" || item.MimeType == "image/gif")
                    {
                        myImageCodecInfo = item;
                    }
                }

            }

            myEncoder = Encoder.Quality;
            myEncoderParameters = new EncoderParameters(1);
            myEncoderParameter = new EncoderParameter(myEncoder, 100L); // 0-100
            myEncoderParameters.Param[0] = myEncoderParameter;
            try
            {
                image.Save(path, myImageCodecInfo, myEncoderParameters);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("图片插入不成功，请检查文件名，重新插入！");
                return;
            }
            finally
            {
                myEncoderParameter.Dispose();
                myEncoderParameters.Dispose();
            }
        }

        // ===============================

        /// <summary>
        /// 剪裁 -- 用GDI+
        /// </summary>
        /// <param name="b">原始Bitmap</param>
        /// <param name="StartX">开始坐标X</param>
        /// <param name="StartY">开始坐标Y</param>
        /// <param name="iWidth">宽度</param>
        /// <param name="iHeight">高度</param>
        /// <returns>剪裁后的Bitmap</returns>
        public static Bitmap CutImage(Bitmap b, int StartX, int StartY, int iWidth, int iHeight)
        {
            if (b == null)
            {
                return null;
            }

            int w = b.Width;
            int h = b.Height;

            if (StartX >= w || StartY >= h)
            {
                return null;
            }

            if (StartX + iWidth > w)
            {
                iWidth = w - StartX;
            }

            if (StartY + iHeight > h)
            {
                iHeight = h - StartY;
            }

            try
            {
                Bitmap bmpOut = new Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb);

                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(b, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX, StartY, iWidth, iHeight), GraphicsUnit.Pixel);
                g.Dispose();

                return bmpOut;
            }
            catch
            {
                return null;
            }
        }






        //以逆时针为方向对图像进行旋转 
        /// <summary> 
        /// 以逆时针为方向对图像进行旋转 
        /// </summary> 
        /// <param name="b">位图流</param> 
        /// <param name="angle">旋转角度[0,360](前台给的)</param> 
        /// <returns></returns> 
        public static Bitmap Rotate(Bitmap b, int angle)
        {

            angle = angle % 360;             //弧度转换 
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
            //原图的宽和高 
            int w = b.Width;
            int h = b.Height;
            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));
            //目标位图 
            Bitmap dsImage = new Bitmap(W, H);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(dsImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //计算偏移量 
            Point Offset = new Point((W - w) / 2, (H - h) / 2);
            //构造图像显示区域：让图像的中心与窗口的中心点一致 
            Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(360 - angle);
            //恢复图像在水平和垂直方向的平移 
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(b, rect);
            //重至绘图的所有变换 
            g.ResetTransform();
            g.Save();
            g.Dispose();
            //dsImage.Save("yuancd.jpg", System.Drawing.Imaging.ImageFormat.Jpeg); 
            return dsImage;

        }
        //旋转90度
        /// <summary>
        /// 旋转90度
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static Bitmap KiRotate90(Bitmap img)
        {
            try
            {
                //顺时针旋转90度     RotateFlipType.Rotate90FlipNone
                //逆时针旋转90度     RotateFlipType.Rotate270FlipNone
                //        水平翻转    RotateFlipType.Rotate180FlipY
                //        垂直翻转    RotateFlipType.Rotate180FlipX

                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                return img;
            }
            catch
            {
                return null;
            }
        }

            //旋转270度
        /// <summary>
        /// 旋转270度
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static Bitmap KiRotate270(Bitmap img)
        {
            try
            {
                //顺时针旋转90度     RotateFlipType.Rotate90FlipNone
                //逆时针旋转90度     RotateFlipType.Rotate270FlipNone
                //        水平翻转    RotateFlipType.Rotate180FlipY
                //        垂直翻转    RotateFlipType.Rotate180FlipX

                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                return img;
            }
            catch
            {
                return null;
            }
        }
    }
}
