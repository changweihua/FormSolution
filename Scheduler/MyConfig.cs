using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Scheduler
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.269
     * 类 名 称:       MyConfig
     * 机器名称:       HSERVER
     * 命名空间:       Scheduler
     * 文 件 名:       MyConfig
     * 创建时间:       2012/8/17 15:51:14
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
    public class ConfigFile : IConfig
    {
        private string fileName = "";
        private static ConfigFile instance;

        private ConfigFile()
        {

        }


        public bool CreateFile()
        {
            bool flag = false;
            if (File.Exists(this.fileName))
            {
                return flag;
            }
            using (File.Create(this.fileName))
            {
                
            }
            return true;
        }


        public bool KeyExists(string key)
        {
            return (this.Keys as ICollection<string>).Contains(key);
        }

        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }


        public static ConfigFile Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigFile();
                }

                return instance;
            }
        }


        public string this[string key]
        {
            get
            {
                if (!this.CreateFile())
                {
                    foreach (string str in File.ReadAllLines(this.fileName, Encoding.UTF8))
                    {
                        Match match = Regex.Match(str, @"(\w+)=([\w\W]+)");
                        string str2 = match.Groups[1].Value;
                        string str3 = match.Groups[2].Value;

                        if (str2 == key)
                        {
                            return str3;
                        }

                    }
                }

                return "";
            }
            set
            {
                if (this.CreateFile())
                {
                    File.AppendAllText(this.fileName, key + "=" + value + "\r\n");
                }
                else
                {
                    string[] contents = File.ReadAllLines(this.fileName, Encoding.UTF8);
                    for (int i = 0; i < contents.Length; i++)
                    {
                        string input = contents[i];
                        Match match = Regex.Match(input, @"(\w+)=(\w+)");
                        string str2 = match.Groups[1].Value;
                        string text1 = match.Groups[2].Value;
                        if (str2 == key)
                        {
                            contents[i] = str2 + "=" + value;
                            File.WriteAllLines(this.fileName, contents);
                            return;
                        }

                    }
                    File.AppendAllText(this.fileName, key + "=" + value + "\r\n");
                }
            }
        }

        public string[] Keys
        {
            get
            {
                List<string> list = new List<string>();
                if (!this.CreateFile())
                {
                    foreach (string str in File.ReadAllLines(this.fileName, Encoding.UTF8))
                    {
                        string item = Regex.Match(str, @"(\w+)=(\w+)").Groups[1].Value;
                        list.Add(item);
                    }
                }
                return list.ToArray();
            }

        }
    }

    public interface IConfig
    {
        bool KeyExists(string key);
        string this[string key] { get; set; }
        string[] Keys { get; }
    }

}
