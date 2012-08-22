﻿using System;
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
            this.gbFile2.AllowDrop = true;
            this.gbFile2.DoubleClick += gbFile_DoubleClick;
            this.gbFile2.DragEnter += gbFile_DragEnter;
        }

        void gbFile_DragEnter(object sender, DragEventArgs e)
        {
            if ((sender as GroupBox).Name == "gbFile1")
            {
                fileName1 = GetFileName();
            }
            if ((sender as GroupBox).Name == "gbFile2")
            {
                fileName2 = GetFileName();
            }
        }

        void gbFile_DoubleClick(object sender, EventArgs e)
        {
            ComputeMD5andSHA1 computer = null;
            if ((sender as GroupBox).Name == "gbFile1")
            {
                fileName1 = GetFileName();
                if (string.IsNullOrEmpty(fileName1))
                {
                    return;
                }
                computer = new ComputeMD5andSHA1();
                fileMD5_1 = computer.MD5File(fileName1);
                fileSHA1_1 = computer.SHA1File(fileName1);
                using (StreamReader sr = new StreamReader(fileName1,Encoding.GetEncoding("GB2312")))
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
                fileName2 = GetFileName();
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

        private void gbFile2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if ((fileCRC16_1 == fileCRC16_2) && (fileCRC32_1 == fileCRC32_2) && (fileMD5_1 == fileMD5_2) && (fileSHA1_1 == fileSHA1_2))
            {
                MessageBox.Show("左右两个文件一致", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("左右两个文件一致", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

    }
}
