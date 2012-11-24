using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Drawing;

namespace Zipper
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       ImageStringHelper
     * 机器名称:       HSERVER
     * 命名空间:       Zipper
     * 文 件 名:       ImageStringHelper
     * 创建时间:       2012/11/23  9:07:48
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
    public class ImageStringHelper
    {
        public static string ImageToString(string fileName)
        {
            string text = string.Empty;

            ImgFormat imgFormat = new ImgFormat();
            using (Image img = Image.FromFile(fileName))
            {
                string extension = fileName.Substring(fileName.LastIndexOf('.'));
                // MessageBox.Show(ImageFormat.Jpeg.ToString());
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, imgFormat[extension]);
                    text = Convert.ToBase64String(ms.GetBuffer());

                }
            }

            return text;
        }

        public static bool StringToImage(string text, string fileName)
        {
            bool isSuccess = false;

            //string text = string.Empty;

            //using (StreamReader reader = new StreamReader(fileName1, Encoding.Default))
            //{
            //    text = reader.ReadToEnd();
            //}

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(text)))
            {
                using (Bitmap img = new Bitmap(ms))
                {
                    img.Save(fileName);
                    isSuccess = true;
                }
            }

            return isSuccess;
        }

        public static bool FileToImage(string fileName, string saveName)
        {
            bool isSuccess = false;

            string text = string.Empty;

            using (StreamReader reader = new StreamReader(fileName, Encoding.Default))
            {
                text = reader.ReadToEnd();
            }

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(text)))
            {
                using (Bitmap img = new Bitmap(ms))
                {
                    img.Save(saveName);
                    isSuccess = true;
                }
            }

            return isSuccess;
        }


    }
}
