using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebKit;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebKitBrowser browser = new WebKitBrowser();
            browser.Dock = DockStyle.Fill;
            this.Controls.Add(browser);
            browser.Navigate("http://html5test.com/");
        }
    }
}
