using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CPU_INFO
    {
        public uint dwOemId;
        public uint dwPageSize;
        public uint lpMinimumApplicationAddress;
        public uint lpMaximumApplicationAddress;
        public uint dwActiveProcessorMask;
        public uint dwNumberOfProcessros;
        public uint dwProcessorType;
        public uint dwAllocationGranularity;
        public uint dwProcessorLevel;
        public uint dwProcessorRevision;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_INFO
    {
        public uint dwLength;
        public uint dwMemoryLoad;
        public uint dwTotalPhys;
        public uint dwAvailPhys;
        public uint dwTotalPageFile;
        public uint dwAvailPageFile;
        public uint dwTotalVirtual;
        public uint dwAvailVirtual;
    }

    //定义系统时间的信息结构
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME_INFO
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32")]
        public static extern void GetWindowsDirectory(StringBuilder WinDir, int count);

        [DllImport("kernel32")]
        public static extern void GetSystemDirectory(StringBuilder SysDir, int count);

        [DllImport("kernel32")]
        public static extern void GetSystemInfo(ref CPU_INFO cpuInfo);

        [DllImport("kernel32")]
        public static extern void GlobalMemoryStatus(ref MEMORY_INFO memoryInfo);

        [DllImport("kernel32")]
        public static extern void GetSystemTime(ref SYSTEMTIME_INFO timeInfo);

        private void button1_Click(object sender, EventArgs e)
        {
            const int nChars = 128;
            StringBuilder sb = new StringBuilder(nChars);

            GetWindowsDirectory(sb, nChars);
            WindowsDirectory.Text = "Windows 路径 ： " + sb.ToString();

            GetSystemDirectory(sb, nChars);
            SystemDirectory.Text = "系统路径 ： " + sb.ToString();

            CPU_INFO cpuInfo = new CPU_INFO();

            GetSystemInfo(ref cpuInfo);

            NumberOfProcessors.Text = "本计算机中有 " + cpuInfo.dwNumberOfProcessros.ToString() + " 个CPU";
            ProcessorType.Text = "CPU 的类型为" + cpuInfo.dwProcessorType.ToString();
            ProcessorLevel.Text = "CPU 等级为" + cpuInfo.dwProcessorLevel.ToString();
            OemId.Text = "CPU 的 OEM ID 为" + cpuInfo.dwOemId.ToString();
            PageSize.Text = "CPU 中的页面大小为" + cpuInfo.dwPageSize.ToString();

            MEMORY_INFO memoryInfo = new MEMORY_INFO();

            GlobalMemoryStatus(ref memoryInfo);

            MemoryLoad.Text = memoryInfo.dwMemoryLoad.ToString() + "% 的内存正在使用";
            TotalPhys.Text = "物理内存共有" + memoryInfo.dwTotalPhys.ToString() + "字节";
            AvailPhys.Text = "可使用的物理内存有" + memoryInfo.dwAvailPhys.ToString() + "字节";
            TotalPageFile.Text = "交换文件总大小为" + memoryInfo.dwTotalPageFile.ToString() + "字节";
            AvailPageFile.Text = "尚可交换文件大小为" + memoryInfo.dwAvailPageFile.ToString() + "字节";
            TotalVirtual.Text = "总虚拟内存有" + memoryInfo.dwTotalVirtual.ToString() + "字节";
            AvailVirtual.Text = "尚未使用的虚拟内存有" + memoryInfo.dwAvailVirtual.ToString() + "字节";

            SYSTEMTIME_INFO timeInfo = new SYSTEMTIME_INFO();

            GetSystemTime(ref timeInfo);

            Date.Text = timeInfo.wYear.ToString() + "年" + timeInfo.wMonth.ToString() + "月" + timeInfo.wDay.ToString() + "日";
            Time.Text = timeInfo.wHour.ToString() + "时" + timeInfo.wMinute.ToString() + "分" + timeInfo.wSecond.ToString() + "秒";
        }

    }
}
