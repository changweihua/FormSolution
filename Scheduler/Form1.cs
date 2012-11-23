using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class Form1 : Form
    {
        TaskCenter taskCenter = new TaskCenter();
        IConfig cfg = ConfigFile.Instance;
        Task cycleScheduleTask;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadConfig();
            //if (cfg["StartTaskAtProgrammeRun"] == "1")
            //{
            //    //StartTaskFunc();
            //}
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("aa");
        }


        /// <summary>
        /// 加载配置文件中的信息
        /// </summary>
        protected void LoadConfig()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                ConfigFile.Instance.FileName = path + "\\Schedule.ini";
                cfg["Author"] = "changweihua@outlook.com";
                txtSoft.Text = cfg["ProgramPath"];
                txtProgress.Text = cfg["ProgressName"];
                string seteTime = cfg["ScheduleTime"];
                txtScheduleTime.Text = seteTime != "" ? DateTime.Now.ToString("yyyy-MM-dd") + Convert.ToDateTime(seteTime).ToString("HH:mm:ss") : DateTime.Now.ToString();
                nudHour.Value = Convert.ToDecimal(cfg["Hours"]);
                nudMinute.Value = Convert.ToDecimal(cfg["Minutes"]);
                nudSecond.Value = Convert.ToDecimal(cfg["Seconds"]); ;
                checkBox1.Checked = cfg["StartAtWindowStart"] == "1" ? true : false;
                checkBox2.Checked = cfg["StartTaskAtProgrammeRun"] == "1" ? true : false;
                btnStopSchedule.Enabled = false;
                tbOpacity.Value = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取配置文件出错，请重新设置\r\n" + ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void TestTaskCenter()
        { }

    }
}
