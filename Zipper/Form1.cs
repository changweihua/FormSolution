using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Drawing.Printing;
using System.Collections;
using DevComponents.Editors;
using System.Threading;
using System.IO;


namespace Zipper
{
    public partial class Form1 : Office2007RibbonForm
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void printerCommand_Executed(object sender, EventArgs e)
        {
            this.comboBoxItem3.Enabled = false;

            ButtonItem buttonItem = sender as ButtonItem;

            if (buttonItem != null)
            {
                string cmdParameter = buttonItem.CommandParameter.ToString().ToLower();
                PrinterCommandParameter pcp = EnumHelper.Contains<PrinterCommandParameter>(cmdParameter);
                switch (pcp)
                {
                    case PrinterCommandParameter.None:
                        ShowError();
                        break;
                    case PrinterCommandParameter.Search:
                        backgroundWorker1.RunWorkerAsync();
                        break;
                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("没有找到按钮", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        PrinterEnumFlags pef1 = PrinterEnumFlags.PRINTER_ENUM_DEFAULT;
        PrinterEnumFlags pef2 = PrinterEnumFlags.PRINTER_ENUM_DEFAULT;

        List<PRINTER_INFO_1> printers = null;
        private void SearchPrinter()
        {
            //PrinterEnumFlags pef = EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem2.SelectedItem)).Tag.ToString()) | EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem3.SelectedItem)).Tag.ToString());
            PrinterEnumFlags pef = pef1 | pef2;
            List<PRINTER_INFO_1> list = PrinterHelper.GetPrinters(pef);


            printers = list;

            //try
            //{
            //    while (true)
            //    {
            //        PrinterEnumFlags pef = EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem2.SelectedItem)).Tag.ToString()) | EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem3.SelectedItem)).Tag.ToString());
            //        List<PRINTER_INFO_1> list = PrinterHelper.GetPrinters(pef);
            //        ShowSearchPrintResult(list);
            //        Application.DoEvents();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }


        private void ShowError()
        {
            MessageBox.Show("操作参数有误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var query = EnumHelper.EnumToDescriptionList<PrinterEnumFlags>().ToArray<EnumDescription>();
            ComboItem ci = null;
            foreach (var item in query)
            {
                ci = new ComboItem { Text = item.Description, Tag = item.Name };
                this.comboBoxItem2.Items.Add(ci);
            }
            this.ribbonControl1.SelectedRibbonTabChanged += new EventHandler(ribbonControl_SelectedRibbonTabChanged);

            InitImageFormat();

            this.ribbonTabItem1.Select();
            
        }

        private void comboBoxItem2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<EnumDescription> list = EnumHelper.EnumToDescriptionList<PrinterEnumFlags>();

            var query = from item in list
                        where item.Name != ((ComboItem)(this.comboBoxItem2.SelectedItem)).Tag.ToString()
                        select new { item.Name, item.Description };
            ComboItem ci = null;
            this.comboBoxItem3.Items.Clear();
            foreach (var item in query)
            {
                ci = new ComboItem { Text = item.Description, Tag = item.Name };
                this.comboBoxItem3.Items.Add(ci);
            }
            pef1 = EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem2.SelectedItem)).Tag.ToString());
            this.comboBoxItem3.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            SearchPrinter();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var query = from printer in printers
                        select new { printer.pName, printer.pComment, printer.pDescription };

            this.dataGridViewX1.DataSource = query.ToList();

        }

        private void comboBoxItem3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pef2 = EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem3.SelectedItem)).Tag.ToString());
        }

        string selectedFolderName = string.Empty;
        string selectedFileName = string.Empty;
        List<string> selectedFileNames = null;


        private void zipperCommand_Executed(object sender, EventArgs e)
        {
            ButtonItem buttonItem = sender as ButtonItem;

            if (buttonItem != null)
            {
                string cmdParameter = buttonItem.CommandParameter.ToString().ToLower();
                ZipperCommandParameter zcp = EnumHelper.Contains<ZipperCommandParameter>(cmdParameter);

                switch (zcp)
                {
                    case ZipperCommandParameter.SelectFolder:
                        GetFolderName();
                        break;
                    case ZipperCommandParameter.SelectFile:
                        GetFileName("RAR|*.rar|ZIP|*.zip|7Z|*.7z");
                        break;
                    case ZipperCommandParameter.SelectSavePath:
                        break;
                    case ZipperCommandParameter.Compress:
                        Compress();
                        break;
                    case ZipperCommandParameter.Extract:
                        Extract();
                        break;
                    default:
                        break;
                }

            }
        }


        private void GetFileNames()
        {
            ofd.Multiselect = true;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                selectedFileNames = new List<string>();
                selectedFileNames = ofd.FileNames.ToList();
            }

        }

        private void GetFileName(string filter)
        {
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (!string.IsNullOrEmpty(filter))
            {
                ofd.Filter = filter;
            }

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                selectedFileName = ofd.FileName;
            }

        }

        private void GetFolderName()
        {
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;

            DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                selectedFolderName = fbd.SelectedPath.ToString();
            }

        }

        public void Compress()
        {
            Zipper zipper = new Zipper();
            zipper.ToFile(selectedFolderName, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\aa.zip", PackingScope.File);
        }

        public void Extract()
        {
            Zipper zipper = new Zipper();
            zipper.UnZipFiles(selectedFileName, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\aa", true);
        }

        private void ribbonControl_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(ribbonControl1.SelectedRibbonTabItem.Name);
            this.dataGridViewX1.Visible = this.ribbonTabItem3.Checked;
            this.dataGridViewX1.Dock = DockStyle.Fill;

            this.rtbBase64String.Visible = this.ribbonTabItem2.Checked;
            this.rtbBase64String.Dock = DockStyle.Fill;

            this.networkToolPanel.Visible = this.ribbonTabItem4.Checked;
            this.networkToolPanel.Dock = DockStyle.Fill;
        }

        private void imageStringCommand_Executed(object sender, EventArgs e)
        {
            ButtonItem buttonItem = sender as ButtonItem;

            if (buttonItem != null)
            {
                string cmdParameter = buttonItem.CommandParameter.ToString().ToLower();
                ImageStringCommandParameter iscp = EnumHelper.Contains<ImageStringCommandParameter>(cmdParameter);

                switch (iscp)
                {
                    case ImageStringCommandParameter.SelectImage:
                        GetFileName("JPEG|*.jpg|PNG|*.png|GIF|*.gif");
                        break;
                    case ImageStringCommandParameter.SelectFolder:
                        GetFolderName();
                        break;
                    case ImageStringCommandParameter.SaveImage:

                        break;
                    case ImageStringCommandParameter.SaveImageString:
                        DoSaveImageStringAsTxt("txt文件|*.txt");
                        break;
                    case ImageStringCommandParameter.ImageToString:
                        PreDoImageToString();
                        break;
                    case ImageStringCommandParameter.StringToImage:
                        PreDoStringToImage();
                        break;
                    case ImageStringCommandParameter.SelectFile:
                        GetFileName("txt|*.txt");
                        break;
                    default:
                        break;
                }
            }

        }

        #region 图片转字符串变量

        string imageString = string.Empty;
        bool fileToImage = false;
        string fileSaveName = string.Empty;

        #endregion 图片转字符串变量


        void PreDoImageToString()
        {
            this.backgroundWorker2.RunWorkerAsync();
        }

        void DoImageToString()
        {
            imageString = ImageStringHelper.ImageToString(selectedFileName);
        }

        void PreDoStringToImage()
        {
            imageString = this.rtbBase64String.Text;
            fileSaveName = selectedFolderName + "\\" + txtSaveFileName.Text.Trim() + (cbImageFormat.SelectedItem as ComboItem).Tag.ToString();
            this.backgroundWorker3.RunWorkerAsync();
        }

        void DoStringToImage()
        {
            string text = imageString;
            string fileName = selectedFileName;
            string saveName = fileSaveName;
            if (fileToImage)
            {
                ImageStringHelper.FileToImage(fileName, saveName);
            }
            else
            {
                ImageStringHelper.StringToImage(text, saveName);
            }
        }

        void DoSaveImageStringAsTxt(string filter)
        {
            sfd.Filter = filter;
            sfd.FileName = "图片字符串";
            DialogResult dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.Default))
                {
                    writer.Write(imageString);
                }

                MessageBox.Show("保存成功");
            }

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            DoImageToString();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.rtbBase64String.Text = imageString;
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            DoStringToImage();
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("转换结束");
        }

        private void switchButtonItem_ValueChanged(object sender, EventArgs e)
        {
            SwitchButtonItem switchButtonItem = sender as SwitchButtonItem;

            if (switchButtonItem != null)
            {
                string name = switchButtonItem.Name;

                switch (name)
                {
                    case "switchButtonItem2":
                        EnableChooseTextButton();
                        break;
                    default:
                        break;
                }

            }

        }


        void EnableChooseTextButton()
        {
            this.btnChooseTextFile.Enabled = !this.btnChooseTextFile.Enabled;
            this.rtbBase64String.Enabled = !this.rtbBase64String.Enabled;
            fileToImage = !fileToImage;
        }

        void InitImageFormat()
        {
            this.cbImageFormat.Items.AddRange(new ComboItem[]{
                 new ComboItem{ Text="PNG", Tag=".png"},
                 new ComboItem{ Text="JPG", Tag=".jpg"},
                 new ComboItem{ Text="GIF", Tag=".gif"}
            });

            this.cbImageFormat.SelectedIndex = 0;
        }
    }

    /// <summary>
    /// 打印机操作的参数
    /// </summary>
    enum PrinterCommandParameter
    { 
        None,
        Search
    }
    //Alignment a = (Alignment)Enum.Parse(typeof(Alignment), name, false);
    //foreach(string name in Enum.GetNames(typeof(Day))) Console.WriteLine(name);   还有一个Enum.GetName()


    /// <summary>
    /// 解压缩操作的参数
    /// </summary>
    enum ZipperCommandParameter
    { 
        [Description("选择文件夹")]
        SelectFolder,
        [Description("选择文件")]
        SelectFile,
        [Description("选择保存路径")]
        SelectSavePath,
        [Description("压缩")]
        Compress,
        [Description("解压")]
        Extract 
    }

}
