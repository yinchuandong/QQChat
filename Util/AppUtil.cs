using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography; 

namespace Util
{
    public class AppUtil
    {
        public static String Encrypt(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] InBytes = Encoding.GetEncoding("GB2312").GetBytes(password);
            byte[] OutBytes = md5.ComputeHash(InBytes);
            string OutString = "";
            for (int i = 0; i < OutBytes.Length; i++)
            {
                OutString += OutBytes[i].ToString("x2");
            }
            return OutString;
        }
    }
}
