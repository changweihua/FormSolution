using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;
using DevComponents.DotNetBar;

namespace ImageToBase64String
{
    public partial class Form1 : Office2007Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;
            button2.Enabled = false;
            InitComboBox();
            this.radioButton1.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
        }

        void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = radioButton2.Checked;
            button2.Enabled = radioButton1.Checked;
        }

        private void InitComboBox()
        {
            this.comboBox1.Items.Add(".png");
            this.comboBox1.Items.Add(".gif");
            this.comboBox1.Items.Add(".jpg");
            this.comboBox1.Enabled = false;
            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "所有文件|*.*|PNG|*.png|JPEG|*.jpg";
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString();
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog1.FileName;
                button2.Enabled = !button2.Enabled;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = !button2.Enabled;
            ImgFormat imgFormat = new ImgFormat();
            string name = txtImagePath.Text;
            //using (Image img = Image.FromFile(name))
            //{
            //    string extension = name.Substring(name.LastIndexOf('.'));
            //    // MessageBox.Show(ImageFormat.Jpeg.ToString());
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        img.Save(ms, imgFormat[extension]);
            //        textBox2.Text = Convert.ToBase64String(ms.GetBuffer());
            //    }
            //}
            Calc(name);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(textBox2.Text)))
            {
                using (Bitmap img = new Bitmap(ms))
                {
                    img.Save(txtImageSavedPath.Text +"\\" + txtImageSavedName.Text+comboBox1.SelectedItem.ToString());
                    MessageBox.Show("Completed!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                this.txtImageSavedPath.Text = folderBrowserDialog1.SelectedPath;
            }

        }


        private void Calc(string name)
        {
            ImgFormat imgFormat = new ImgFormat();
            using (Image img = Image.FromFile(name))
            {
                string extension = name.Substring(name.LastIndexOf('.'));
                // MessageBox.Show(ImageFormat.Jpeg.ToString());
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, imgFormat[extension]);
                    textBox2.Text = Convert.ToBase64String(ms.GetBuffer());

                }
            }
            
        }


    }


    public class ImgFormat
    {
        public ImageFormat this[string extension]
        {
            get
            {
                ImageFormat format = null;

                switch (extension)
                {
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".gif":
                        format = ImageFormat.Gif;
                        break;
                    default:
                        format = ImageFormat.Jpeg;
                        break;
                }
                return format;
            }
        }

    }

}