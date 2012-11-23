using System.Runtime.InteropServices;

namespace Zipper
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct PRINTER_INFO_1
    {
        int flags;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string pDescription;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string pName;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string pComment;
    }
}