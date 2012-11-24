using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void ControlTextMethod(Control control, string text);

        private void SetControlText(Control control, string text)
        {
            if (this.InvokeRequired)
            {
                ControlTextMethod ctm = new ControlTextMethod(SetControlText);
                this.Invoke(ctm, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }


        private void Method()
        {
            for (int i = 0; i < 1000000; i++)
            {
                this.SetControlText(label1, i.ToString());
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Method();
        }

    }
}
