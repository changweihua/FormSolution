using System;
using System.ComponentModel;

namespace Zipper
{
    [FlagsAttribute]
    public enum PrinterEnumFlags
    {
        //[Description("描述")]  
        [EnumDescription("默认")]
        PRINTER_ENUM_DEFAULT = 0x00000001,
       [EnumDescription("本地")]
        PRINTER_ENUM_LOCAL = 0x00000002,
        [EnumDescription("连接")]
        PRINTER_ENUM_CONNECTIONS = 0x00000004,
        [EnumDescription("喜欢")]
        PRINTER_ENUM_FAVORITE = 0x00000004,
        [EnumDescription("名称")]
        PRINTER_ENUM_NAME = 0x00000008,
        [EnumDescription("远程")]
        PRINTER_ENUM_REMOTE = 0x00000010,
        [EnumDescription("共享")]
        PRINTER_ENUM_SHARED = 0x00000020,
        [EnumDescription("网络")]
        PRINTER_ENUM_NETWORK = 0x00000040,
        [EnumDescription("拓展")]
        PRINTER_ENUM_EXPAND = 0x00004000,
        [EnumDescription("容器")]
        PRINTER_ENUM_CONTAINER = 0x00008000,
        PRINTER_ENUM_ICONMASK = 0x00ff0000,
        PRINTER_ENUM_ICON1 = 0x00010000,
        PRINTER_ENUM_ICON2 = 0x00020000,
        PRINTER_ENUM_ICON3 = 0x00040000,
        PRINTER_ENUM_ICON4 = 0x00080000,
        PRINTER_ENUM_ICON5 = 0x00100000,
        PRINTER_ENUM_ICON6 = 0x00200000,
        PRINTER_ENUM_ICON7 = 0x00400000,
        PRINTER_ENUM_ICON8 = 0x00800000,
        PRINTER_ENUM_HIDE = 0x01000000
    }
}