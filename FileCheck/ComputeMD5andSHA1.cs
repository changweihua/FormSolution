using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace FileCheck
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.269
     * 类 名 称:       ComputeMD5andSHA1
     * 机器名称:       HSERVER
     * 命名空间:       FileCheck
     * 文 件 名:       ComputeMD5andSHA1
     * 创建时间:       2012/8/21 20:57:03
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
    public class ComputeMD5andSHA1
    {
        public string MD5File(string fileName)
        {
            return HashFile(fileName, HashType.MD5);
        }

        public string SHA1File(string fileName)
        {
            return HashFile(fileName, HashType.SHA1);
        }

        private string HashFile(string fileName, HashType hashType)
        {
            if (!File.Exists(fileName))
                return string.Empty;

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] hashBytes = HashData(fs, hashType);
                return ByteArrayToHexString(hashBytes);
            }
        }

        private byte[] HashData(Stream stream, HashType hashType)
        {
            HashAlgorithm algorithm = null;

            if (hashType == HashType.SHA1)
            {
                algorithm = SHA1.Create();
            }
            else if (hashType == HashType.MD5)
            {
                algorithm = MD5.Create();
            }

            return algorithm.ComputeHash(stream);
        }

        private string ByteArrayToHexString(byte[] buf)
        {
            return BitConverter.ToString(buf).Replace("-", "");
        }

    }

    public enum HashType
    {
        MD5,
        SHA1,
        CRC16,
        CRC32
    }

}
