using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileCheck
{
    public partial class Form1 : Form
    {
        private string fileName1;
        private string fileName2;
        private string fileMD5_1;
        private string fileSHA1_1;
        private string fileCRC16_1;
        private string fileCRC32_1;
        private string fileMD5_2;
        private string fileSHA1_2;
        private string fileCRC16_2;
        private string fileCRC32_2;

        public Form1()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            this.gbFile1.AllowDrop = true;
            this.gbFile1.DoubleClick += new EventHandler(gbFile_DoubleClick);
            this.gbFile1.DragEnter += new DragEventHandler(gbFile_DragEnter);
            this.gbFile1.DragDrop += new DragEventHandler(gbFile_DragDrop);
            this.gbFile2.AllowDrop = true;
            this.gbFile2.DoubleClick += gbFile_DoubleClick;
            this.gbFile2.DragEnter += gbFile_DragEnter;
            this.gbFile2.DragDrop += new DragEventHandler(gbFile_DragDrop);
            btnReset.Visible = false;
        }


        void gbFile_DragDrop(object sender, DragEventArgs e)
        {
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            ComputeAndPrint(sender, fileName);
        }

        void gbFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            
            
        }

        void gbFile_DoubleClick(object sender, EventArgs e)
        {
            string fName = GetFileName();
            ComputeAndPrint(sender, fName);
        }

        private void ComputeAndPrint(object sender, string fName)
        {
            ComputeMD5andSHA1 computer = null;
            if ((sender as GroupBox).Name == "gbFile1")
            {
                fileName1 = fName;
                if (string.IsNullOrEmpty(fileName1))
                {
                    return;
                }
                computer = new ComputeMD5andSHA1();
                fileMD5_1 = computer.MD5File(fileName1);
                fileSHA1_1 = computer.SHA1File(fileName1);
                using (StreamReader sr = new StreamReader(fileName1, Encoding.GetEncoding("GB2312")))
                {
                    string str = sr.ReadToEnd();
                    fileCRC16_1 = CRCITU.GetCrc16(Encoding.UTF8.GetBytes(str)).ToString();
                    fileCRC32_1 = CRCITU.GetCrc32(Encoding.UTF8.GetBytes(str)).ToString();
                }

                lblFileName1.Text = new FileInfo(fileName1).Name;
                lblFileMD5_1.Text = fileMD5_1;
                lblFileSHA1_1.Text = fileSHA1_1;
                lblFileCRC16_1.Text = fileSHA1_1;
                lblFileCRC32_1.Text = fileCRC32_1;
            }
            if ((sender as GroupBox).Name == "gbFile2")
            {
                fileName2 = fName;
                if (string.IsNullOrEmpty(fileName2))
                {
                    return;
                }
                using (StreamReader sr = new StreamReader(fileName2, Encoding.GetEncoding("GB2312")))
                {
                    string str = sr.ReadToEnd();
                    fileCRC16_2 = CRCITU.GetCrc16(Encoding.UTF8.GetBytes(str)).ToString();
                    fileCRC32_2 = CRCITU.GetCrc32(Encoding.UTF8.GetBytes(str)).ToString();
                }
                computer = new ComputeMD5andSHA1();
                fileMD5_2 = computer.MD5File(fileName2);
                fileSHA1_2 = computer.SHA1File(fileName2);
                lblFileName2.Text = new FileInfo(fileName2).Name;
                lblFileMD5_2.Text = fileMD5_2;
                lblFileSHA1_2.Text = fileSHA1_2;
                lblFileCRC16_2.Text = fileSHA1_2;
                lblFileCRC32_2.Text = fileCRC32_2;
            }
        }


        private void Reset()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is GroupBox)
                {
                    foreach (Control lbl in ctl.Controls)
                    {
                        if (lbl is Label)
                        {
                            if ((lbl as Label).Name.Contains("lblFile"))
                            {
                                (lbl as Label).Text = "";
                            }
                        }
                    }
                }              
            }
        }

        private string GetFileName()
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            else
            {
                return "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            DialogResult dr;
            if ((fileCRC16_1 == fileCRC16_2) && (fileCRC32_1 == fileCRC32_2) && (fileMD5_1 == fileMD5_2) && (fileSHA1_1 == fileSHA1_2))
            {
                dr = MessageBox.Show("左右两个文件一致\r\n\r\n是否清除文件信息?", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                dr=MessageBox.Show("左右两个文件不一致\r\n\r\n是否清除文件信息?", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            if (dr == DialogResult.Yes)
            {
                btnReset_Click(btnReset, null);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            (sender as Button).Visible = false;
        }

    }
}
