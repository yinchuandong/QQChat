using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Widget._ImagePopup;
using Model;
using Bll;
using Widget._ChatListBox;


using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Net;


namespace QQChat.UiForm
{
    public partial class GroupChatForm : Form
    {
        private SessionBll session;
        private ChatListSubItem guestItem;
        private int chatRoomId;
        private int chatRoomPort;

        private User user;
        private IPEndPoint ServerInfo;//存储服务器ip和端口信息
        private Socket ClientSocket;//客户端的Socket
        private Byte[] MsgBuffer;//存放消息数据,使用msgbuffer方便发送图片那些
        private Byte[] MsgSend;//存放发送对象

        private string serverIP = "192.168.202.81";//服务器IP

        ChatRoomMemberBll chatroommemberbll = new ChatRoomMemberBll();
        private ArrayList onlineip;

        public GroupChatForm()
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            user = session.User;
            chatRoomId = session.Chatroom.CId;
            chatRoomPort = session.Chatroom.ChatRoomPort;
          
        }
        public GroupChatForm(ChatListSubItem guestItem)
        {
            InitializeComponent();     
            session = SessionBll.GetInstance();
            user = session.User;
            this.guestItem = guestItem;
            this.chatRoomId = guestItem.ID;
            this.chatRoomPort = guestItem.ChatRoomPort;
            initData();
        }

        public void initData()
        {
            onlineip = chatroommemberbll.searchIp(chatRoomId);
            headPicBox.Image = guestItem.HeadImage;
            nameTxt.Text = guestItem.DisplayName ;
        }

        private void GroupChatForm_Load(object sender, EventArgs e)
        {
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建Socket
            MsgBuffer = new Byte[65535];
            MsgSend = new Byte[65535];
            CheckForIllegalCrossThreadCalls = false;//不捕获对错误线程的调用
            //链接服务器
            ServerInfo = new IPEndPoint(IPAddress.Parse(serverIP), Convert.ToInt32(9001));//服务器的地址
            try
            {
                ClientSocket.Connect(ServerInfo);
               // ClientSocket.Send(Encoding.Unicode.GetBytes("用户：" + nicName + "进入系统！\n"));
                ClientSocket.BeginReceive(MsgBuffer, 0, MsgBuffer.Length, 0, new AsyncCallback(ReceiveCallBack), null);
            }
            catch
            {
                Console.WriteLine("登录服务器失败，请确认服务器是否正常工作！");
                this.GroupChat_Output.Text = "登录服务器失败，请确认服务器是否正常工作！";
            }
        }
        private void ReceiveCallBack(IAsyncResult AR)
        {
            try
            {
                int REnd = ClientSocket.EndReceive(AR);
                this.GroupChat_Output.Text += (Encoding.Unicode.GetString(MsgBuffer, 0, REnd) + "\n");
                ClientSocket.BeginReceive(MsgBuffer, 0, MsgBuffer.Length, 0, new AsyncCallback(ReceiveCallBack), null);

            }
            catch
            {
                this.GroupChat_Output.Text = "已经与服务器断开连接！";
                this.Close();
            }
        }
<<<<<<< HEAD
         private void ReceiveCallBack(IAsyncResult AR)
          {
              try
              {
                  int REnd = ClientSocket.EndReceive(AR);
                  this.GroupChat_Output.Text+=(Encoding.Unicode.GetString(MsgBuffer, 0, REnd)+"\n");
                  ClientSocket.BeginReceive(MsgBuffer, 0, MsgBuffer.Length, 0, new AsyncCallback(ReceiveCallBack), null);
  
              }
              catch
             {
                 this.GroupChat_Output.Text="已经与服务器断开连接！";
                 this.Close();
              }
          }
=======
>>>>>>> d72d5f6db7b0d2361f5b0540de2ff784405dc3d0
        //断开链接
        private void Discon_server_Click(object sender, EventArgs e)
        {

            if (ClientSocket.Connected)
            {
                //ClientSocket.Send(Encoding.Unicode.GetBytes(this.GroupChat_Output.Text + "离开了房间！\n"));
                ClientSocket.Shutdown(SocketShutdown.Both);
                ClientSocket.Disconnect(false);
                ClientSocket.Close();
            }

        }
        private void sendMsgbutton_Click(object sender, EventArgs e)
        {
            string msg = DateTime.Now.ToString() + "#" + user.Username + "#" + "   说：\n" + GroupChat_Input.Text + "\n";
            MsgSend = Encoding.Unicode.GetBytes(msg);
            if (ClientSocket.Connected)
            {
                ClientSocket.Send(MsgSend);
                this.GroupChat_Input.Text = "";
            }
            else
            {
                sendMsgbutton.Enabled = false;
                this.GroupChat_Output.Text = "当前与服务器断开连接，无法发送信息！";
            }

        }

        private void GroupChat_Output_TextChanged(object sender, EventArgs e)
        {
            GroupChat_Output.SelectionStart = GroupChat_Output.TextLength;
            GroupChat_Output.ScrollToCaret();
        }
    }
<<<<<<< HEAD
       
 }
=======

}
>>>>>>> d72d5f6db7b0d2361f5b0540de2ff784405dc3d0

