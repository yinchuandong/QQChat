using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Numerics;
using Util;
using Model;

namespace MySocket
{
    public class P2pServerSocket
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        public static Dictionary<int, TcpClient> socketDict;
        //public Dictionary<int, TcpClient> SocketDict
        //{
        //    get { return this.socketDict; }
        //    set { this.socketDict = value; }
        //}
        
        public P2pServerSocket()
        {
            socketDict = new Dictionary<int, TcpClient>();
        }

        public void Start()
        {
            tcpListener = new TcpListener(IPAddress.Parse(AppUtil.GetLocalIp()),8009);
            tcpListener.Start();
            listenThread = new Thread(new ThreadStart(getUserLink));
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void getUserLink()
        {
            while(true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                byte[] buff = new byte[1024];
                int len = stream.Read(buff, 0, buff.Length);
                int guestId;
                try
                {
                    string msg = Encoding.UTF8.GetString(buff, 0, len);
                    guestId = int.Parse(msg);
                    if(!socketDict.ContainsKey(guestId))
                    {
                        socketDict.Add(guestId, client);
                    }else
                    {
                        socketDict[guestId] = client;
                    }  
                }
                catch (System.Exception ex)
                {
                    guestId = -1;
                }
                
            }
        }

    }
}
