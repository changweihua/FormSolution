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

namespace Zipper
{
    public partial class Form1 : Office2007RibbonForm
    {
        Thread th1 = null;

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
                PrinterCommandParamter pcp = EnumHelper.Contains<PrinterCommandParamter>(cmdParameter);
                switch (pcp)
                {
                    case PrinterCommandParamter.None:
                        ShowError();
                        break;
                    case PrinterCommandParamter.Search:
                        SearchPrinter();
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

        delegate void ShowSearchPrinterCallback(List<PRINTER_INFO_1> list);

        private void SearchPrinter()
        {
            //PrinterEnumFlags pef = EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem2.SelectedItem)).Tag.ToString()) | EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem3.SelectedItem)).Tag.ToString());
            //List<PRINTER_INFO_1> list = PrinterHelper.GetPrinters(pef);
            //var query = from item in list
            //            select new { item.pName, item.pComment, item.pDescription };

            //this.dataGridViewX1.DataSource = query.ToList();

            if (th1.IsAlive)
            {
                th1.Join();
            }
            else
            {
                th1.Start();
            }

            try
            {
                while (true)
                {
                    PrinterEnumFlags pef = EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem2.SelectedItem)).Tag.ToString()) | EnumHelper.Contains<PrinterEnumFlags>(((ComboItem)(this.comboBoxItem3.SelectedItem)).Tag.ToString());
                    List<PRINTER_INFO_1> list = PrinterHelper.GetPrinters(pef);
                    ShowSearchPrintResult(list);
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void ShowSearchPrintResult(List<PRINTER_INFO_1> list)
        {

            if (list.Count <= 0)
            {
                MessageBox.Show("没找到打印机 ");
            }
            else
            {
                if (this.dataGridViewX1.InvokeRequired)
                {

                    this.dataGridViewX1.Invoke(new ShowSearchPrinterCallback(ShowSearchPrintResult), new object[] { list });
                }
                else
                {
                    var query = from item in list
                                select new { item.pName, item.pComment, item.pDescription };

                    this.dataGridViewX1.DataSource = query.ToList();
                    th1.Suspend();
                }
            }
           
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

            th1 = new Thread(new ThreadStart(SearchPrinter));
            th1.IsBackground = true;

        }

        private void comboBoxItem2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<EnumDescription> list = EnumHelper.EnumToDescriptionList<PrinterEnumFlags>();

            var query = from item in list
                        where item.Name != ((ComboItem)(this.comboBoxItem2.SelectedItem)).Tag.ToString()
                        select new { item.Name,item.Description };
            ComboItem ci = null;
            foreach (var item in query)
            {
                ci = new ComboItem { Text = item.Description, Tag = item.Name };
                this.comboBoxItem3.Items.Add(ci);
            }

            this.comboBoxItem3.Enabled = true;
        }

        private void comboBoxItem3_Click(object sender, EventArgs e)
        {

        }

    }

    enum PrinterCommandParamter
    { 
        None,
        Search
    }
    //Alignment a = (Alignment)Enum.Parse(typeof(Alignment), name, false);
    //foreach(string name in Enum.GetNames(typeof(Day))) Console.WriteLine(name);   还有一个Enum.GetName()


}
