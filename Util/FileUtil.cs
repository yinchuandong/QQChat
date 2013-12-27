using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;



namespace Util
{
    public class FileUtil
    {
        public static String basePath = AppDomain.CurrentDomain.BaseDirectory;

       //保存到本地文件
        public static void  save2File(int guestId,string userName,string content)
        {
            //创建一个文件流，用以写入或者创建一个StreamWriter 
            string dirPath = basePath + userName;
            string path = guestId.ToString() + ".txt";
            //创建文件夹
            if (!Directory.Exists(dirPath))//判断文件夹是否已经存在
            {
                DirectoryInfo dir= Directory.CreateDirectory(dirPath);//创建文件夹
                StreamWriter sw = File.CreateText(dirPath + "\\" + guestId.ToString() + ".txt");
                sw.WriteLine(content);
                sw.Close();
            }         
            else 
            {
                FileStream fs = new FileStream(dirPath + "\\" + guestId.ToString() + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs);
                m_streamWriter.Flush();  // 使用StreamWriter来往文件中写入内容
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                m_streamWriter.Write(content);    // 把内容写入文件
                m_streamWriter.Close(); //关闭此文件  m_streamWriter.Flush ( ) ;
            }                
        }

        public static string readFromFile(int guestId, string userName)
        {  //读取文档

            string dirPath = basePath + userName;
            string fileName = guestId.ToString() + ".txt";
            string path = dirPath + "\\" + guestId.ToString() + ".txt";
            string content="";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
           StreamReader m_streamReader = new StreamReader(fs);  //使用StreamReader类来读取文件
           m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);  // 从数据流中读取每一行，直到文件的最后一行，并在richTextBox1中显示出内容   

           string strLine = m_streamReader.ReadLine();
           while (strLine != null)
           { 
             content += strLine;
             strLine = m_streamReader.ReadLine();
           }
           //关闭此StreamReader对象
           m_streamReader.Close();
          return content;
        }
        //格式化对象


    }
}
