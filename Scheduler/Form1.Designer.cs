namespace Scheduler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.lblScheduleTime = new System.Windows.Forms.Label();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.lblProgressPath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.txtSystemTime = new System.Windows.Forms.TextBox();
            this.txtScheduleTime = new System.Windows.Forms.TextBox();
            this.txtSoft = new System.Windows.Forms.TextBox();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnCancelShutdown = new System.Windows.Forms.Button();
            this.btnChooseSoft = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnChooseProgress = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnStartWithLogin = new System.Windows.Forms.Button();
            this.btnAutoStart = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnStartSchedule = new System.Windows.Forms.Button();
            this.btnStopSchedule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOpacity = new System.Windows.Forms.TrackBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).BeginInit();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.AutoSize = true;
            this.lblSystemTime.Location = new System.Drawing.Point(24, 15);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(53, 12);
            this.lblSystemTime.TabIndex = 0;
            this.lblSystemTime.Text = "系统时间";
            // 
            // lblScheduleTime
            // 
            this.lblScheduleTime.AutoSize = true;
            this.lblScheduleTime.Location = new System.Drawing.Point(24, 57);
            this.lblScheduleTime.Name = "lblScheduleTime";
            this.lblScheduleTime.Size = new System.Drawing.Size(77, 12);
            this.lblScheduleTime.TabIndex = 0;
            this.lblScheduleTime.Text = "计划运行时间";
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Location = new System.Drawing.Point(24, 99);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(29, 12);
            this.lblSoftware.TabIndex = 0;
            this.lblSoftware.Text = "程序";
            // 
            // lblProgressPath
            // 
            this.lblProgressPath.AutoSize = true;
            this.lblProgressPath.Location = new System.Drawing.Point(24, 141);
            this.lblProgressPath.Name = "lblProgressPath";
            this.lblProgressPath.Size = new System.Drawing.Size(53, 12);
            this.lblProgressPath.TabIndex = 0;
            this.lblProgressPath.Text = "进程路径";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "从运行时间开始，每   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "时";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "分";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "秒   运行一次";
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(161, 181);
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(46, 21);
            this.nudHour.TabIndex = 1;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(252, 181);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(46, 21);
            this.nudMinute.TabIndex = 2;
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(331, 181);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(46, 21);
            this.nudSecond.TabIndex = 3;
            // 
            // txtSystemTime
            // 
            this.txtSystemTime.Location = new System.Drawing.Point(126, 12);
            this.txtSystemTime.Name = "txtSystemTime";
            this.txtSystemTime.Size = new System.Drawing.Size(195, 21);
            this.txtSystemTime.TabIndex = 4;
            // 
            // txtScheduleTime
            // 
            this.txtScheduleTime.Location = new System.Drawing.Point(126, 54);
            this.txtScheduleTime.Name = "txtScheduleTime";
            this.txtScheduleTime.Size = new System.Drawing.Size(195, 21);
            this.txtScheduleTime.TabIndex = 5;
            // 
            // txtSoft
            // 
            this.txtSoft.Location = new System.Drawing.Point(126, 96);
            this.txtSoft.Name = "txtSoft";
            this.txtSoft.Size = new System.Drawing.Size(195, 21);
            this.txtSoft.TabIndex = 6;
            // 
            // txtProgress
            // 
            this.txtProgress.Location = new System.Drawing.Point(126, 138);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(195, 21);
            this.txtProgress.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(333, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 21);
            this.textBox5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "秒后   ";
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(448, 10);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnShutdown.TabIndex = 10;
            this.btnShutdown.Text = "关机";
            this.btnShutdown.UseVisualStyleBackColor = true;
            // 
            // btnCancelShutdown
            // 
            this.btnCancelShutdown.Location = new System.Drawing.Point(529, 10);
            this.btnCancelShutdown.Name = "btnCancelShutdown";
            this.btnCancelShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnCancelShutdown.TabIndex = 11;
            this.btnCancelShutdown.Text = "取消关机";
            this.btnCancelShutdown.UseVisualStyleBackColor = true;
            // 
            // btnChooseSoft
            // 
            this.btnChooseSoft.Location = new System.Drawing.Point(331, 94);
            this.btnChooseSoft.Name = "btnChooseSoft";
            this.btnChooseSoft.Size = new System.Drawing.Size(67, 23);
            this.btnChooseSoft.TabIndex = 12;
            this.btnChooseSoft.Text = "选择";
            this.btnChooseSoft.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "测试运行";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnChooseProgress
            // 
            this.btnChooseProgress.Location = new System.Drawing.Point(333, 136);
            this.btnChooseProgress.Name = "btnChooseProgress";
            this.btnChooseProgress.Size = new System.Drawing.Size(67, 23);
            this.btnChooseProgress.TabIndex = 14;
            this.btnChooseProgress.Text = "选择";
            this.btnChooseProgress.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 225);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "开机启动程序";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnStartWithLogin
            // 
            this.btnStartWithLogin.Location = new System.Drawing.Point(140, 221);
            this.btnStartWithLogin.Name = "btnStartWithLogin";
            this.btnStartWithLogin.Size = new System.Drawing.Size(67, 23);
            this.btnStartWithLogin.TabIndex = 16;
            this.btnStartWithLogin.Text = "确定";
            this.btnStartWithLogin.UseVisualStyleBackColor = true;
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.Location = new System.Drawing.Point(363, 221);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(67, 23);
            this.btnAutoStart.TabIndex = 18;
            this.btnAutoStart.Text = "确定";
            this.btnAutoStart.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(225, 225);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(132, 16);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "运行后自动启动任务";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnStartSchedule
            // 
            this.btnStartSchedule.Location = new System.Drawing.Point(26, 271);
            this.btnStartSchedule.Name = "btnStartSchedule";
            this.btnStartSchedule.Size = new System.Drawing.Size(129, 23);
            this.btnStartSchedule.TabIndex = 19;
            this.btnStartSchedule.Text = "启动任务";
            this.btnStartSchedule.UseVisualStyleBackColor = true;
            // 
            // btnStopSchedule
            // 
            this.btnStopSchedule.Location = new System.Drawing.Point(178, 271);
            this.btnStopSchedule.Name = "btnStopSchedule";
            this.btnStopSchedule.Size = new System.Drawing.Size(129, 23);
            this.btnStopSchedule.TabIndex = 19;
            this.btnStopSchedule.Text = "停止任务";
            this.btnStopSchedule.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "透明度";
            // 
            // tbOpacity
            // 
            this.tbOpacity.Location = new System.Drawing.Point(71, 324);
            this.tbOpacity.Name = "tbOpacity";
            this.tbOpacity.Size = new System.Drawing.Size(382, 45);
            this.tbOpacity.TabIndex = 21;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(575, 324);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "帮助";
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(123, 48);
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 370);
            this.ContextMenuStrip = this.cms1;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbOpacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStopSchedule);
            this.Controls.Add(this.btnStartSchedule);
            this.Controls.Add(this.btnAutoStart);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btnStartWithLogin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnChooseProgress);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnChooseSoft);
            this.Controls.Add(this.btnCancelShutdown);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.txtSoft);
            this.Controls.Add(this.txtScheduleTime);
            this.Controls.Add(this.txtSystemTime);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProgressPath);
            this.Controls.Add(this.lblSoftware);
            this.Controls.Add(this.lblScheduleTime);
            this.Controls.Add(this.lblSystemTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "定时任务工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).EndInit();
            this.cms1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.Label lblScheduleTime;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.Label lblProgressPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.TextBox txtSystemTime;
        private System.Windows.Forms.TextBox txtScheduleTime;
        private System.Windows.Forms.TextBox txtSoft;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnCancelShutdown;
        private System.Windows.Forms.Button btnChooseSoft;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnChooseProgress;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnStartWithLogin;
        private System.Windows.Forms.Button btnAutoStart;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnStartSchedule;
        private System.Windows.Forms.Button btnStopSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbOpacity;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer2;
    }
}

