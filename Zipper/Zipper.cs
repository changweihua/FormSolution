using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;
using System.IO;

namespace Zipper
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       ZipHelper
     * 机器名称:       HSERVER
     * 命名空间:       Zipper
     * 文 件 名:       ZipHelper
     * 创建时间:       2012/11/22  23:33:02
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    /// <summary>
    /// 添加类描述
    /// </summary>
    class Zipper
    {
        private List<FileInfo> GetFileList(string sDirectoryPath, PackingScope scope)
        {
            List<FileInfo> filesInfo = new List<FileInfo>();
            DirectoryInfo dir = new DirectoryInfo(sDirectoryPath);
            if (scope != PackingScope.Folder)
            {
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo fTemp in files)
                {
                    filesInfo.Add(fTemp);
                }
            }
            if (scope != PackingScope.File)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo dirTemp in dirs)
                {
                    List<FileInfo> templist = GetFileList(dirTemp.FullName, PackingScope.All);
                    foreach (FileInfo fileTemp in templist)
                    {
                        filesInfo.Add(fileTemp);
                    }
                }
            }
            return filesInfo;

        }
        /// <summary>
        /// 把文件夹里面的文件为一个压缩包文件
        /// </summary>
        /// <param name="sDirectoryPath">需要打包的目录</param>
        /// <param name="FileName">打包之后保存的文件名称，如D:\packing.zip</param>
        /// <param name="scope">打包的范围</param>
        /// <returns></returns>
        public bool ToFile(string sDirectoryPath, string FileName, PackingScope scope)
        {
            bool result = false;
            List<FileInfo> filesInfo = new List<FileInfo>();
            Crc32 crc = new Crc32();
            ZipOutputStream s = null;
            int i = 1;
            try
            {
                FileInfo filedd = new FileInfo(FileName);
                if (!Directory.Exists(filedd.Directory.FullName))
                {
                    Directory.CreateDirectory(filedd.Directory.FullName);
                }
                s = new ZipOutputStream(File.OpenWrite(FileName));
                s.SetLevel(9);

                DirectoryInfo mainDir = new DirectoryInfo(sDirectoryPath);
                filesInfo = GetFileList(mainDir.FullName, scope);
                foreach (FileInfo file in filesInfo)
                {
                    using (FileStream fs = File.OpenRead(file.FullName))
                    {
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        ZipEntry entry = new ZipEntry(ZipEntry.CleanName(file.FullName.Replace(mainDir.FullName + "\\", "")));
                        entry.DateTime = DateTime.Now;
                        entry.Comment = i.ToString();
                        entry.ZipFileIndex = i++;
                        entry.Size = fs.Length;
                        fs.Close();
                        crc.Reset();
                        crc.Update(buffer);
                        entry.Crc = crc.Value;
                        s.PutNextEntry(entry);
                        s.Write(buffer, 0, buffer.Length);
                    }
                }
                s.Finish();
                s.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                s.Close();
            }
            return result;
        }
        /// <summary>
        /// 把一个文件打包
        /// </summary>
        /// <param name="sFileFullPath">文件的全路径</param>
        /// <param name="FileName">打包之后保存的文件名称</param>
        /// <returns></returns>
        public bool ToFile(string sFileFullPath, string FileName)
        {
            bool result = false;
            Crc32 crc = new Crc32();
            ZipOutputStream s = null;
            int i = 1;
            try
            {
                FileInfo filedd = new FileInfo(FileName);
                //DirectoryInfo mainDir = new DirectoryInfo(sDirectoryPath);
                if (!Directory.Exists(filedd.Directory.FullName))
                {
                    Directory.CreateDirectory(filedd.Directory.FullName);
                }
                s = new ZipOutputStream(File.OpenWrite(FileName));
                s.SetLevel(9);
                FileInfo file = new FileInfo(sFileFullPath);
                using (FileStream fs = File.OpenRead(file.FullName))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    ZipEntry entry = new ZipEntry(ZipEntry.CleanName(file.Name));
                    entry.DateTime = DateTime.Now;
                    entry.Comment = i.ToString();
                    entry.ZipFileIndex = i++;
                    entry.Size = fs.Length;
                    fs.Close();
                    crc.Reset();
                    crc.Update(buffer);
                    entry.Crc = crc.Value;
                    s.PutNextEntry(entry);
                    s.Write(buffer, 0, buffer.Length);
                }
                s.Finish();
                s.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                s.Close();
            }
            return result;
        }

        /// <summary>
        /// 解压文件
        /// </summary>
        /// <param name="zipPathAndFile">需要解压文件的路径</param>
        /// <param name="outputFolder">解压到哪里</param>
        /// <param name="deleteZipFile">是否删除</param>
        public void UnZipFiles(string zipPathAndFile, string outputFolder, bool deleteZipFile)
        {
            ZipInputStream s = new ZipInputStream(File.OpenRead(zipPathAndFile));
            ZipEntry theEntry;
            string tmpEntry = String.Empty;
            while ((theEntry = s.GetNextEntry()) != null)
            {
                string directoryName = outputFolder;
                string fileName = Path.GetFileName(theEntry.Name);
                // create directory 
                if (directoryName != "")
                {
                    Directory.CreateDirectory(directoryName);
                }
                if (fileName != String.Empty)
                {
                    if (theEntry.Name.IndexOf(".ini") < 0)
                    {
                        string fullPath = directoryName + "\\" + theEntry.Name;
                        fullPath = fullPath.Replace("\\ ", "\\");
                        string fullDirPath = Path.GetDirectoryName(fullPath);
                        if (!Directory.Exists(fullDirPath)) Directory.CreateDirectory(fullDirPath);
                        //Console.WriteLine(System.Web.HttpUtility.UrlDecode(fullPath));
                        FileStream streamWriter = File.Create(System.Web.HttpUtility.UrlDecode(fullPath));
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
                    }
                }
            }
            s.Close();
            if (deleteZipFile)
                File.Delete(zipPathAndFile);
        }
    }

    public enum PackingScope
    {
        Folder,
        File,
        All
    }
}
