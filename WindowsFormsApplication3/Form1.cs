using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateLabel(Control ctrl, string s)
        {
            ctrl.Text = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(PrintTime));
            th.IsBackground = true;
            th.Start();
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

    }
}
