namespace FileCheck
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCompare = new System.Windows.Forms.Button();
            this.gbFile1 = new System.Windows.Forms.GroupBox();
            this.lblFileCRC32_1 = new System.Windows.Forms.Label();
            this.lblFileCRC16_1 = new System.Windows.Forms.Label();
            this.lblFileSHA1_1 = new System.Windows.Forms.Label();
            this.lblFileMD5_1 = new System.Windows.Forms.Label();
            this.lblFileName1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFile2 = new System.Windows.Forms.GroupBox();
            this.lblFileCRC32_2 = new System.Windows.Forms.Label();
            this.lblFileCRC16_2 = new System.Windows.Forms.Label();
            this.lblFileMD5_2 = new System.Windows.Forms.Label();
            this.lblFileName2 = new System.Windows.Forms.Label();
            this.lblFileSHA1_2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbFile1.SuspendLayout();
            this.gbFile2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(628, 294);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "比较";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // gbFile1
            // 
            this.gbFile1.Controls.Add(this.lblFileCRC32_1);
            this.gbFile1.Controls.Add(this.lblFileCRC16_1);
            this.gbFile1.Controls.Add(this.lblFileSHA1_1);
            this.gbFile1.Controls.Add(this.lblFileMD5_1);
            this.gbFile1.Controls.Add(this.lblFileName1);
            this.gbFile1.Controls.Add(this.label5);
            this.gbFile1.Controls.Add(this.label4);
            this.gbFile1.Controls.Add(this.label3);
            this.gbFile1.Controls.Add(this.label2);
            this.gbFile1.Controls.Add(this.label1);
            this.gbFile1.Location = new System.Drawing.Point(12, 12);
            this.gbFile1.Name = "gbFile1";
            this.gbFile1.Size = new System.Drawing.Size(409, 267);
            this.gbFile1.TabIndex = 1;
            this.gbFile1.TabStop = false;
            this.gbFile1.Text = "文件1";
            // 
            // lblFileCRC32_1
            // 
            this.lblFileCRC32_1.AutoSize = true;
            this.lblFileCRC32_1.Location = new System.Drawing.Point(6, 234);
            this.lblFileCRC32_1.Name = "lblFileCRC32_1";
            this.lblFileCRC32_1.Size = new System.Drawing.Size(71, 12);
            this.lblFileCRC32_1.TabIndex = 4;
            this.lblFileCRC32_1.Text = "           ";
            // 
            // lblFileCRC16_1
            // 
            this.lblFileCRC16_1.AutoSize = true;
            this.lblFileCRC16_1.Location = new System.Drawing.Point(12, 190);
            this.lblFileCRC16_1.Name = "lblFileCRC16_1";
            this.lblFileCRC16_1.Size = new System.Drawing.Size(65, 12);
            this.lblFileCRC16_1.TabIndex = 5;
            this.lblFileCRC16_1.Text = "          ";
            // 
            // lblFileSHA1_1
            // 
            this.lblFileSHA1_1.AutoSize = true;
            this.lblFileSHA1_1.Location = new System.Drawing.Point(12, 146);
            this.lblFileSHA1_1.Name = "lblFileSHA1_1";
            this.lblFileSHA1_1.Size = new System.Drawing.Size(59, 12);
            this.lblFileSHA1_1.TabIndex = 3;
            this.lblFileSHA1_1.Text = "         ";
            // 
            // lblFileMD5_1
            // 
            this.lblFileMD5_1.AutoSize = true;
            this.lblFileMD5_1.Location = new System.Drawing.Point(12, 102);
            this.lblFileMD5_1.Name = "lblFileMD5_1";
            this.lblFileMD5_1.Size = new System.Drawing.Size(47, 12);
            this.lblFileMD5_1.TabIndex = 1;
            this.lblFileMD5_1.Text = "       ";
            // 
            // lblFileName1
            // 
            this.lblFileName1.AutoSize = true;
            this.lblFileName1.Location = new System.Drawing.Point(6, 58);
            this.lblFileName1.Name = "lblFileName1";
            this.lblFileName1.Size = new System.Drawing.Size(41, 12);
            this.lblFileName1.TabIndex = 2;
            this.lblFileName1.Text = "      ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "CRC32值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "CRC16值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "SHA1值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "MD5值";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件名称";
            // 
            // gbFile2
            // 
            this.gbFile2.Controls.Add(this.lblFileCRC32_2);
            this.gbFile2.Controls.Add(this.lblFileCRC16_2);
            this.gbFile2.Controls.Add(this.lblFileMD5_2);
            this.gbFile2.Controls.Add(this.lblFileName2);
            this.gbFile2.Controls.Add(this.lblFileSHA1_2);
            this.gbFile2.Controls.Add(this.label11);
            this.gbFile2.Controls.Add(this.label12);
            this.gbFile2.Controls.Add(this.label13);
            this.gbFile2.Controls.Add(this.label14);
            this.gbFile2.Controls.Add(this.label15);
            this.gbFile2.Location = new System.Drawing.Point(427, 12);
            this.gbFile2.Name = "gbFile2";
            this.gbFile2.Size = new System.Drawing.Size(387, 267);
            this.gbFile2.TabIndex = 1;
            this.gbFile2.TabStop = false;
            this.gbFile2.Text = "文件2";
            // 
            // lblFileCRC32_2
            // 
            this.lblFileCRC32_2.AutoSize = true;
            this.lblFileCRC32_2.Location = new System.Drawing.Point(6, 234);
            this.lblFileCRC32_2.Name = "lblFileCRC32_2";
            this.lblFileCRC32_2.Size = new System.Drawing.Size(71, 12);
            this.lblFileCRC32_2.TabIndex = 19;
            this.lblFileCRC32_2.Text = "           ";
            // 
            // lblFileCRC16_2
            // 
            this.lblFileCRC16_2.AutoSize = true;
            this.lblFileCRC16_2.Location = new System.Drawing.Point(6, 190);
            this.lblFileCRC16_2.Name = "lblFileCRC16_2";
            this.lblFileCRC16_2.Size = new System.Drawing.Size(65, 12);
            this.lblFileCRC16_2.TabIndex = 20;
            this.lblFileCRC16_2.Text = "          ";
            // 
            // lblFileMD5_2
            // 
            this.lblFileMD5_2.AutoSize = true;
            this.lblFileMD5_2.Location = new System.Drawing.Point(6, 102);
            this.lblFileMD5_2.Name = "lblFileMD5_2";
            this.lblFileMD5_2.Size = new System.Drawing.Size(47, 12);
            this.lblFileMD5_2.TabIndex = 16;
            this.lblFileMD5_2.Text = "       ";
            // 
            // lblFileName2
            // 
            this.lblFileName2.AutoEllipsis = true;
            this.lblFileName2.AutoSize = true;
            this.lblFileName2.Location = new System.Drawing.Point(6, 58);
            this.lblFileName2.Name = "lblFileName2";
            this.lblFileName2.Size = new System.Drawing.Size(41, 12);
            this.lblFileName2.TabIndex = 17;
            this.lblFileName2.Text = "      ";
            // 
            // lblFileSHA1_2
            // 
            this.lblFileSHA1_2.AutoEllipsis = true;
            this.lblFileSHA1_2.AutoSize = true;
            this.lblFileSHA1_2.Location = new System.Drawing.Point(6, 146);
            this.lblFileSHA1_2.Name = "lblFileSHA1_2";
            this.lblFileSHA1_2.Size = new System.Drawing.Size(59, 12);
            this.lblFileSHA1_2.TabIndex = 13;
            this.lblFileSHA1_2.Text = "         ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "CRC32值";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "CRC16值";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "SHA1值";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "MD5值";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "文件名称";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(739, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(517, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "清空";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCompare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(826, 329);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbFile2);
            this.Controls.Add(this.gbFile1);
            this.Controls.Add(this.btnCompare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件查看器";
            this.gbFile1.ResumeLayout(false);
            this.gbFile1.PerformLayout();
            this.gbFile2.ResumeLayout(false);
            this.gbFile2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.GroupBox gbFile1;
        private System.Windows.Forms.GroupBox gbFile2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFileCRC32_1;
        private System.Windows.Forms.Label lblFileCRC16_1;
        private System.Windows.Forms.Label lblFileSHA1_1;
        private System.Windows.Forms.Label lblFileMD5_1;
        private System.Windows.Forms.Label lblFileName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileCRC32_2;
        private System.Windows.Forms.Label lblFileCRC16_2;
        private System.Windows.Forms.Label lblFileMD5_2;
        private System.Windows.Forms.Label lblFileName2;
        private System.Windows.Forms.Label lblFileSHA1_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnReset;
    }
}

