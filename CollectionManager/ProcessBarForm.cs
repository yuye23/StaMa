using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;

namespace CollectionManager
{
    public partial class ProcessBarForm : Form
    {
        public ProcessBarForm()
        {
            InitializeComponent();
        }

        public string task;
        public string savePath;

        private void BackAllData()
        {
            try
            {
                string copyPath = System.Windows.Forms.Application.StartupPath + "\\DATA\\";
                string zipFilePath = System.Windows.Forms.Application.StartupPath + "\\DataBack\\";

                if (!File.Exists(copyPath))
                {
                    Directory.CreateDirectory(copyPath);
                }

                if (!File.Exists(zipFilePath))
                {
                    Directory.CreateDirectory(zipFilePath);
                }

                zipFilePath = zipFilePath + @"back_" + System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".zip";


                ZipFile(copyPath, zipFilePath);
                prcBar.Value = prcBar.Maximum;

                savePath = zipFilePath;
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            catch
            {
                MessageBox.Show("备份不成功!，请重启程序重新备份。");
            }




        }
        public void ZipFile(string strFile, string strZip)
        {
            int fileNum = GetFileNum(strFile);
            prcBar.Maximum = fileNum;
            
            prcBar.Minimum = 0;

            if (strFile[strFile.Length - 1] != Path.DirectorySeparatorChar)
                strFile += Path.DirectorySeparatorChar;
            ZipOutputStream s = new ZipOutputStream(File.Create(strZip));
            s.SetLevel(6); // 0 - store only to 9 - means best compression
            zip(strFile, s, strFile);
            s.Finish();
            s.Close();
        }


        int fileNum = 0;
        /// <summary>
        /// 获取某目录下的所有文件(包括子目录下文件)的数量
        /// </summary>
        /// <param name="srcPath"></param>
        /// <returns></returns>
        public int GetFileNum(string srcPath)
        {
            
            try
            {

                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                string[] fileList = System.IO.Directory.GetFileSystemEntries(srcPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就重新调用GetFileNum(string srcPath)
                    if (System.IO.Directory.Exists(file))
                        GetFileNum(file);
                    else
                        fileNum++;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return fileNum;
        }

        private void zip(string strFile, ZipOutputStream s, string staticFile)
        {
            if (strFile[strFile.Length - 1] != Path.DirectorySeparatorChar) strFile += Path.DirectorySeparatorChar;
            Crc32 crc = new Crc32();

            int num = 1;
            string[] filenames = Directory.GetFileSystemEntries(strFile);
            foreach (string file in filenames)
            {

                if (Directory.Exists(file))
                {
                    zip(file, s, staticFile);
                }

                else // 否则直接压缩文件
                {
                    //打开压缩文件
                    FileStream fs = File.OpenRead(file);

                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    string tempfile = file.Substring(staticFile.LastIndexOf("\\") + 1);
                    ZipEntry entry = new ZipEntry(tempfile);

                    entry.DateTime = DateTime.Now;
                    entry.Size = fs.Length;
                    fs.Close();
                    crc.Reset();
                    crc.Update(buffer);
                    entry.Crc = crc.Value;
                    s.PutNextEntry(entry);

                    s.Write(buffer, 0, buffer.Length);

                    prcBar.Value = prcBar.Value+num;
                }
            }
        }

        private void ProcessBarForm_Shown(object sender, EventArgs e)
        {
            if (task == "BackAllData")
            {
                this.Text = "正在为您备份数据...";
                BackAllData();
            }
        }
    }

}
