using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Zipper
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       PrinterHelper
     * 机器名称:       HSERVER
     * 命名空间:       Zipper
     * 文 件 名:       PrinterHelper
     * 创建时间:       2012/11/21  19:12:43
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    /// <summary>
    /// 添加类描述
    /// </summary>
    public class PrinterHelper
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool EnumPrinters(PrinterEnumFlags Flags, string Name, uint Level, IntPtr pPrinterEnum, uint cbBuf, ref uint pcbNeeded, ref uint pcReturned);

        private const int ERROR_INSUFFICIENT_BUFFER = 122;

        public static PRINTER_INFO_1[] MyEnumPrinters(PrinterEnumFlags Flags)
        {
            uint cbNeeded = 0;
            uint cReturned = 0;
            IntPtr pPrInfo4 = IntPtr.Zero;
            uint size = 0;

            if (EnumPrinters(Flags, null, 1, IntPtr.Zero, size, ref cbNeeded, ref cReturned))
            {
                return new PRINTER_INFO_1[] { };
            }
            if (cbNeeded != 0)
            {
                pPrInfo4 = Marshal.AllocHGlobal((int)cbNeeded + 128);
                size = cbNeeded + 128;
                EnumPrinters(Flags, null, 1, pPrInfo4, size, ref cbNeeded, ref cReturned);
                if (cReturned != 0)
                {
                    PRINTER_INFO_1[] printerInfo1 = new PRINTER_INFO_1[cReturned];
                    int offset = pPrInfo4.ToInt32();
                    Type type = typeof(PRINTER_INFO_1);
                    int increment = Marshal.SizeOf(type);
                    for (int i = 0; i < cReturned; i++)
                    {
                        printerInfo1[i] = (PRINTER_INFO_1)Marshal.PtrToStructure(new IntPtr(offset), type);
                        offset += increment;
                    }
                    Marshal.FreeHGlobal(pPrInfo4);
                    return printerInfo1;
                }
            }

            return new PRINTER_INFO_1[] { };
        }


        public static List<PRINTER_INFO_1> GetPrinters(PrinterEnumFlags printerEnumFlags)
        {
            PRINTER_INFO_1[] printers = MyEnumPrinters(printerEnumFlags);
            //foreach (PRINTER_INFO_1 printer in printers)
            //{
            //    if (-1 == printer.pName.IndexOf("!!"))
            //    {
            //        Console.WriteLine(printer.pName);
            //    }
            //    else
            //    {
            //        uint cbNeeded = 0;
            //        uint cReturned = 0;
            //        IntPtr pPrInfo4 = IntPtr.Zero;
            //        uint size = 0;
            //        string pNewName = printer.pName;
            //        EnumPrinters(PrinterEnumFlags.PRINTER_ENUM_NAME, pNewName, 1, IntPtr.Zero, size, ref cbNeeded, ref cReturned);
            //        if (cbNeeded != 0)
            //        {
            //            pPrInfo4 = Marshal.AllocHGlobal((int)cbNeeded + 128);
            //            size = cbNeeded + 128;
            //            EnumPrinters(PrinterEnumFlags.PRINTER_ENUM_NAME, pNewName, 1, pPrInfo4, size, ref cbNeeded, ref cReturned);
            //            PRINTER_INFO_1[] printerInfo1 = new PRINTER_INFO_1[cReturned];
            //            int offset = pPrInfo4.ToInt32();
            //            Type type = typeof(PRINTER_INFO_1);
            //            int increment = Marshal.SizeOf(type);
            //            for (int i = 0; i < cReturned; i++)
            //            {
            //                printerInfo1[i] = (PRINTER_INFO_1)Marshal.PtrToStructure(new IntPtr(offset), type);
            //                offset += increment;
            //                Console.WriteLine(printerInfo1[i].pName);
            //            }
            //            Marshal.FreeHGlobal(pPrInfo4);
            //        }
            //    }
            //}


            return printers.ToList();
        }

    }
}
