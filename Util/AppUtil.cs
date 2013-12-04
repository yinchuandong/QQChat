using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
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

        public static void SendMail(string mailTo,string subject,string body)
        {
            string mailServerName = "smtp.qq.com";
            string mailFrom = "2321771525@qq.com";
            using(MailMessage message = new MailMessage(mailFrom,mailTo,subject,body))
            {
                SmtpClient mailClient = new SmtpClient(mailServerName);
                mailClient.Credentials = new NetworkCredential("2321771525@qq.com", "yin543211");
                mailClient.Send(message);      
            }
        }


        public static string GetLocalIp()
        {
            IPHostEntry MyEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] MyAddress = MyEntry.AddressList;
            foreach(IPAddress ip in MyAddress)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "";
        }
        
    }
}
