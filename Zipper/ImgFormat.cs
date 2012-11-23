using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;

namespace Zipper
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       ImgFormat
     * 机器名称:       HSERVER
     * 命名空间:       Zipper
     * 文 件 名:       ImgFormat
     * 创建时间:       2012/11/23  9:08:49
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
    /// 图片格式类，根据字符串返回指定的图片格式枚举值
    /// </summary>
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
