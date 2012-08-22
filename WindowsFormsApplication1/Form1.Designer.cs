namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WindowsDirectory = new System.Windows.Forms.Label();
            this.SystemDirectory = new System.Windows.Forms.Label();
            this.NumberOfProcessors = new System.Windows.Forms.Label();
            this.ProcessorType = new System.Windows.Forms.Label();
            this.ProcessorLevel = new System.Windows.Forms.Label();
            this.OemId = new System.Windows.Forms.Label();
            this.PageSize = new System.Windows.Forms.Label();
            this.TotalPageFile = new System.Windows.Forms.Label();
            this.AvailPhys = new System.Windows.Forms.Label();
            this.TotalPhys = new System.Windows.Forms.Label();
            this.MemoryLoad = new System.Windows.Forms.Label();
            this.TotalVirtual = new System.Windows.Forms.Label();
            this.AvailVirtual = new System.Windows.Forms.Label();
            this.AvailPageFile = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SystemDirectory);
            this.groupBox1.Controls.Add(this.WindowsDirectory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Windows及系统路径";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Time);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Location = new System.Drawing.Point(378, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统日期信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AvailVirtual);
            this.groupBox3.Controls.Add(this.TotalVirtual);
            this.groupBox3.Controls.Add(this.TotalPageFile);
            this.groupBox3.Controls.Add(this.AvailPhys);
            this.groupBox3.Controls.Add(this.TotalPhys);
            this.groupBox3.Controls.Add(this.MemoryLoad);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 263);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "内存信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AvailPageFile);
            this.groupBox4.Controls.Add(this.PageSize);
            this.groupBox4.Controls.Add(this.OemId);
            this.groupBox4.Controls.Add(this.ProcessorLevel);
            this.groupBox4.Controls.Add(this.ProcessorType);
            this.groupBox4.Controls.Add(this.NumberOfProcessors);
            this.groupBox4.Location = new System.Drawing.Point(378, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 263);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CPU信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "获取信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowsDirectory
            // 
            this.WindowsDirectory.AutoSize = true;
            this.WindowsDirectory.Location = new System.Drawing.Point(29, 27);
            this.WindowsDirectory.Name = "WindowsDirectory";
            this.WindowsDirectory.Size = new System.Drawing.Size(0, 12);
            this.WindowsDirectory.TabIndex = 0;
            // 
            // SystemDirectory
            // 
            this.SystemDirectory.AutoSize = true;
            this.SystemDirectory.Location = new System.Drawing.Point(29, 58);
            this.SystemDirectory.Name = "SystemDirectory";
            this.SystemDirectory.Size = new System.Drawing.Size(0, 12);
            this.SystemDirectory.TabIndex = 0;
            // 
            // NumberOfProcessors
            // 
            this.NumberOfProcessors.AutoSize = true;
            this.NumberOfProcessors.Location = new System.Drawing.Point(39, 33);
            this.NumberOfProcessors.Name = "NumberOfProcessors";
            this.NumberOfProcessors.Size = new System.Drawing.Size(0, 12);
            this.NumberOfProcessors.TabIndex = 0;
            // 
            // ProcessorType
            // 
            this.ProcessorType.AutoSize = true;
            this.ProcessorType.Location = new System.Drawing.Point(39, 65);
            this.ProcessorType.Name = "ProcessorType";
            this.ProcessorType.Size = new System.Drawing.Size(0, 12);
            this.ProcessorType.TabIndex = 0;
            // 
            // ProcessorLevel
            // 
            this.ProcessorLevel.AutoSize = true;
            this.ProcessorLevel.Location = new System.Drawing.Point(39, 97);
            this.ProcessorLevel.Name = "ProcessorLevel";
            this.ProcessorLevel.Size = new System.Drawing.Size(0, 12);
            this.ProcessorLevel.TabIndex = 0;
            // 
            // OemId
            // 
            this.OemId.AutoSize = true;
            this.OemId.Location = new System.Drawing.Point(39, 129);
            this.OemId.Name = "OemId";
            this.OemId.Size = new System.Drawing.Size(0, 12);
            this.OemId.TabIndex = 0;
            // 
            // PageSize
            // 
            this.PageSize.AutoSize = true;
            this.PageSize.Location = new System.Drawing.Point(39, 161);
            this.PageSize.Name = "PageSize";
            this.PageSize.Size = new System.Drawing.Size(0, 12);
            this.PageSize.TabIndex = 0;
            // 
            // TotalPageFile
            // 
            this.TotalPageFile.AutoSize = true;
            this.TotalPageFile.Location = new System.Drawing.Point(29, 120);
            this.TotalPageFile.Name = "TotalPageFile";
            this.TotalPageFile.Size = new System.Drawing.Size(0, 12);
            this.TotalPageFile.TabIndex = 3;
            // 
            // AvailPhys
            // 
            this.AvailPhys.AutoSize = true;
            this.AvailPhys.Location = new System.Drawing.Point(29, 91);
            this.AvailPhys.Name = "AvailPhys";
            this.AvailPhys.Size = new System.Drawing.Size(0, 12);
            this.AvailPhys.TabIndex = 4;
            // 
            // TotalPhys
            // 
            this.TotalPhys.AutoSize = true;
            this.TotalPhys.Location = new System.Drawing.Point(29, 62);
            this.TotalPhys.Name = "TotalPhys";
            this.TotalPhys.Size = new System.Drawing.Size(0, 12);
            this.TotalPhys.TabIndex = 1;
            // 
            // MemoryLoad
            // 
            this.MemoryLoad.AutoSize = true;
            this.MemoryLoad.Location = new System.Drawing.Point(29, 33);
            this.MemoryLoad.Name = "MemoryLoad";
            this.MemoryLoad.Size = new System.Drawing.Size(0, 12);
            this.MemoryLoad.TabIndex = 2;
            // 
            // TotalVirtual
            // 
            this.TotalVirtual.AutoSize = true;
            this.TotalVirtual.Location = new System.Drawing.Point(29, 149);
            this.TotalVirtual.Name = "TotalVirtual";
            this.TotalVirtual.Size = new System.Drawing.Size(0, 12);
            this.TotalVirtual.TabIndex = 3;
            // 
            // AvailVirtual
            // 
            this.AvailVirtual.AutoSize = true;
            this.AvailVirtual.Location = new System.Drawing.Point(29, 178);
            this.AvailVirtual.Name = "AvailVirtual";
            this.AvailVirtual.Size = new System.Drawing.Size(0, 12);
            this.AvailVirtual.TabIndex = 3;
            // 
            // AvailPageFile
            // 
            this.AvailPageFile.AutoSize = true;
            this.AvailPageFile.Location = new System.Drawing.Point(39, 201);
            this.AvailPageFile.Name = "AvailPageFile";
            this.AvailPageFile.Size = new System.Drawing.Size(0, 12);
            this.AvailPageFile.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(41, 27);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 12);
            this.Date.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(41, 58);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 12);
            this.Time.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "系统信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SystemDirectory;
        private System.Windows.Forms.Label WindowsDirectory;
        private System.Windows.Forms.Label AvailVirtual;
        private System.Windows.Forms.Label TotalVirtual;
        private System.Windows.Forms.Label TotalPageFile;
        private System.Windows.Forms.Label AvailPhys;
        private System.Windows.Forms.Label TotalPhys;
        private System.Windows.Forms.Label MemoryLoad;
        private System.Windows.Forms.Label PageSize;
        private System.Windows.Forms.Label OemId;
        private System.Windows.Forms.Label ProcessorLevel;
        private System.Windows.Forms.Label ProcessorType;
        private System.Windows.Forms.Label NumberOfProcessors;
        private System.Windows.Forms.Label AvailPageFile;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
    }
}

