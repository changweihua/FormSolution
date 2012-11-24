using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }


        private void UpdateLabel(Control ctrl, string s)
        {
            ctrl.Text = s;
        }

        private delegate void UpdateLabelDelegate(Control ctrl, string s);

        void PrintTime()
        {
            if (label1.InvokeRequired == true)
            {
                UpdateLabelDelegate uld = new UpdateLabelDelegate(UpdateLabel);
                while (true)
                {
                    label1.Invoke(uld, new object[] { label1, DateTime.Now.ToString() });
                }
            }
            else
            {
                while (true)
                {
                    label1.Text = DateTime.Now.ToString();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            PrintTime();
        }
    }
}
