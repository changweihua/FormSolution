using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static long result = 0;

        private void UpdateLabel(Control ctrl, string s)
        {
            ctrl.Text = s;
        }

        private delegate void UpdateLabelDelegate(Control ctrl, string s);

        private void UpdateProgressBar(ProgressBar ctrl, int n)
        {
            ctrl.Value = n;
        }

        private delegate void UpdateProgressBarDelegate(ProgressBar ctrl, int n);

        private void Sum(object obj)
        {
            result = 0;
            long num = Convert.ToInt64(obj);

            UpdateProgressBarDelegate upd = new UpdateProgressBarDelegate(UpdateProgressBar);

            for (long i = 0; i <= num; i++)
            {
                result += i;
                if (i % 10000 == 0)
                {
                    if (progressBar1.InvokeRequired)
                    {
                        progressBar1.Invoke(upd, new object[] { progressBar1, Convert.ToInt32((100 * i) / num) });
                    }
                    else
                    {
                        progressBar1.Value = Convert.ToInt32(i / num * 100);
                    }
                }
            }

            if (lblResult.InvokeRequired)
            {
                UpdateLabelDelegate uld = new UpdateLabelDelegate(UpdateLabel);
                lblResult.Invoke(uld, new object[] { lblResult, result.ToString() });
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ParameterizedThreadStart(Sum));
            th.IsBackground = true;
            th.Start(textBox1.Text);
        }
    }
}
