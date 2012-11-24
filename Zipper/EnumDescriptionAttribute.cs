using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zipper
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       EnumDescriptionAttribute
     * 机器名称:       HSERVER
     * 命名空间:       Zipper
     * 文 件 名:       EnumDescriptionAttribute
     * 创建时间:       2012/11/21  20:27:15
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
    /// 
    /// 
    [AttributeUsage(AttributeTargets.Field)]  
    public class EnumDescriptionAttribute : Attribute
    {
        private string text;

        public string Text
        { 
            get
            {
                return this.text;
            }
        }

        public EnumDescriptionAttribute(string t)
        {
            this.text = t;
        }

    }
}
