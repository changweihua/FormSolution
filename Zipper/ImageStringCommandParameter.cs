using System.ComponentModel;

namespace Zipper
{
    public enum ImageStringCommandParameter
    {
        [Description("选择图片")]
        SelectImage,
        [Description("选择文件夹")]
        SelectFolder,
        [Description("选择字符串文件")]
        SelectFile,
        [Description("保存图片")]
        SaveImage,
        [Description("保存图片字符串")]
        SaveImageString,
        [Description("图片转成字符串")]
        ImageToString,
        [Description("字符串转成图片")]
        StringToImage
    }
}