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
        public string restoreFilePath;
        public string restoreDate;


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

                zipFilePath = zipFilePath + @"back_" + System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".cmz";


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

            if (task == "RestoreAllData")
            {
                this.Text = "正在为您恢复数据...";
                RestoreAllData();
            }
        }


        private void RestoreAllData()
        {
            try
            {
                deleteOldData();


                string restorePath = System.Windows.Forms.Application.StartupPath + "\\DATA";           


                unZipFile(this.restoreFilePath,restorePath);

                prcBar.Value = prcBar.Maximum;
                                
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            catch
            {
                MessageBox.Show("恢复不成功!，请重启程序重新恢复。");
            }




        }

        public int GetZipFileNum(string srcPath)
        {

                //读取压缩文件(zip文件)，准备解压缩
                ZipInputStream s = new ZipInputStream(File.OpenRead(srcPath.Trim()));
                ZipEntry theEntry;

                int num = 0;
                //根目录下的第一个子文件夹的名称
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    num++;
                    int size = 2048;
                    byte[] data = new byte[2048];
                    while (true)
                    {
                        size = s.Read(data, 0, data.Length);
                        if (size > 0)
                        {
                            
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return num;


        }


        public string unZipFile(string TargetFile, string fileDir)
        {
            int zipFileNum = GetZipFileNum(TargetFile);
            prcBar.Maximum = zipFileNum;

            prcBar.Minimum = 0;



            string rootFile = " ";
            try
            {
                //读取压缩文件(zip文件)，准备解压缩
                ZipInputStream s = new ZipInputStream(File.OpenRead(TargetFile.Trim()));
                ZipEntry theEntry;
                string path = fileDir;
                //解压出来的文件保存的路径

                string rootDir = " ";
                //根目录下的第一个子文件夹的名称
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    rootDir = Path.GetDirectoryName(theEntry.Name);
                    //得到根目录下的第一级子文件夹的名称
                    if (rootDir.IndexOf("\\") >= 0)
                    {
                        rootDir = rootDir.Substring(0, rootDir.IndexOf("\\") + 1);
                    }
                    string dir = Path.GetDirectoryName(theEntry.Name);
                    //根目录下的第一级子文件夹的下的文件夹的名称
                    string fileName = Path.GetFileName(theEntry.Name);
                    //根目录下的文件名称
                    if (dir != " ")
                    //创建根目录下的子文件夹,不限制级别
                    {
                        if (!Directory.Exists(fileDir + "\\" + dir))
                        {
                            path = fileDir + "\\" + dir;
                            //在指定的路径创建文件夹
                            Directory.CreateDirectory(path);
                        }
                    }
                    else if (dir == " " && fileName != "")
                    //根目录下的文件
                    {
                        path = fileDir;
                        rootFile = fileName;
                    }
                    else if (dir != " " && fileName != "")
                    //根目录下的第一级子文件夹下的文件
                    {
                        if (dir.IndexOf("\\") > 0)
                        //指定文件保存的路径
                        {
                            path = fileDir + "\\" + dir;
                        }
                    }

                    if (dir == rootDir)
                    //判断是不是需要保存在根目录下的文件
                    {
                        path = fileDir + "\\" + rootDir;
                    }

                    //以下为解压缩zip文件的基本步骤
                    //基本思路就是遍历压缩文件里的所有文件，创建一个相同的文件。
                    if (fileName != String.Empty)
                    {
                        FileStream streamWriter = File.Create(path + "\\" + fileName);

                        int size = 2048;
                        byte[] data = new byte[2048];
                        while (true)
                        {
                            size = s.Read(data, 0, data.Length);
                            if (size > 0)
                            {
                                streamWriter.Write(data, 0, size);
                            }
                            else
                            {
                                break;
                            }
                        }

                        streamWriter.Close();


                        prcBar.Value = prcBar.Value + 1;
                    }
                }
                s.Close();

                return rootFile;
            }
            catch (Exception ex)
            {
                return "1; " + ex.Message;
            }
        }


        private void deleteOldData()
        {
            deleteOldData("\\DATA\\StampPicture\\");
            deleteOldData("\\DATA\\Database\\");
            deleteOldData("\\DATA\\CoinPicture\\");
        }





        private void deleteOldData(string dir)
        {
            //返回picture下所有文件列表
            DirectoryInfo TheFolder = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + dir);
            FileInfo[] files = TheFolder.GetFiles();
            List<string> allFiles = new List<string>();
            foreach (FileInfo file in files)
            {
                allFiles.Add(file.FullName);
            }

            //删除picture下allFiles中剩余的文件
            foreach (string file in allFiles)
            {
                try
                {
                    if (File.Exists(file))
                    {
                        //如果存在则删除
                        File.Delete(file);
                    }
                }
                catch
                {
                }
            }

        }

    }

}
