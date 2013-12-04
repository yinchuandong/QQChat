using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

using SqlDal;
using Model;
using Bll;
using Util;
using Socket;

using Widget._ChatListBox;
using Widget._TabControl;

namespace QQChat.UiForm
{
    public partial class FriendListForm : BaseForm
    {
       

        #region 成员变量

        private UserBll userBll;
        private SessionBll session;
        private User user;
        public Dictionary<int, P2pChatForm> p2pFormList;
        public Dictionary<int, TcpClient> p2pSocketList;
        private P2pServerSocket p2pServerSocket; //p2p服务端socket线程


        #endregion

        public FriendListForm()
        {
            InitializeComponent();
            userBll = new UserBll();
            session = SessionBll.GetInstance();
            user = session.User;
            string ip = AppUtil.GetLocalIp();
            p2pFormList = new Dictionary<int, P2pChatForm>();
            p2pSocketList = new Dictionary<int, TcpClient>();

            p2pServerSocket = new P2pServerSocket();
            p2pServerSocket.Start();//开启监听
        }

        private void FriendListForm_Load(object sender, EventArgs e)
        {
            friendListBox.IconSizeMode = ChatListItemIcon.Large;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                ChatListItem item = new ChatListItem("group" + i);
                for (int j = 0; j < 10; j++)
                {
                    ChatListSubItem subItem = new ChatListSubItem("nickname", "displayname" + j, "personalmsg");
                    subItem.HeadImage = Image.FromFile("Head/1 (" + rnd.Next(0, 45) + ").png");
                    subItem.Status = (ChatListSubItem.UserStatus)(j % 6);
                    subItem.ID = j;
                    item.SubItems.Add(subItem);
                }
                friendListBox.Items.Add(item);
            }
        }

        private void friendListBox_MouseEnterHead(object sender, ChatListEventArgs e)
        {
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void friendListBox_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            P2pChatForm form = new P2pChatForm(e.SelectSubItem);
            int guestId = e.SelectSubItem.ID;
            if (p2pServerSocket.SocketDict.ContainsKey(guestId))
            {
                TcpClient server = p2pServerSocket.SocketDict[guestId];
                form.ServerSocket = server;
            } 
            else
            {
                try
                {
                    User guest = userBll.getUser("342916053@qq.com");
                    string ip = guest.LastLoginIp;
                    TcpClient client = new TcpClient(ip,8009);
                    form.ServerSocket = client;
                }
                catch (System.Exception ex)
                {
                	
                }
            }
            form.Show();
        }

       
    }
}
