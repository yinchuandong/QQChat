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
using System.IO;

namespace QQChat.UiForm
{
    public partial class FriendListForm : BaseForm
    {
       

        #region 成员变量

        private UserBll userBll;
        private GroupBll groupBll;
        private FriendBll friendBll;
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
            groupBll = new GroupBll();
            friendBll = new FriendBll();
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
            
            IList<Group> groupList = groupBll.getGroupList(user.UId);
            Console.WriteLine("user.UId----------------------->>>>>>>>" + user.UId+"count----->"+groupList.Count);
            
            foreach (Group group in groupList)
            {

                Console.WriteLine("group" + group.Name + "groupid" + group.GId);



                ChatListItem groupItem = new ChatListItem(group.Name);
                IList<Friend> friendList = friendBll.getFriendByGroup(user.UId, group.GId);
                Console.WriteLine("user.UId" + user.UId + "group.GId" + group.GId);
                Console.WriteLine("friendList" + friendList.Count);
                foreach (Friend friend in friendList)
                {
                    Console.WriteLine("friendList" + friend.NickName);
                    User fModel = userBll.getUser(friend.FriendId);
                    ChatListSubItem friendItem = new ChatListSubItem();
                    friendItem.DisplayName = friend.FriendName;
                    friendItem.ID = friend.FriendId;
                    friendItem.HeadImage = Image.FromFile("Head/1 (" + rnd.Next(0, 45) + ").png");
                    friendItem.NicName = friend.NickName;
                    friendItem.PersonalMsg = fModel.Sign;
                    friendItem.IpAddress = fModel.LastLoginIp;
                    groupItem.SubItems.Add(friendItem);
                }
                friendListBox.Items.Add(groupItem);
            }
        }

        private void friendListBox_MouseEnterHead(object sender, ChatListEventArgs e)
        {
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void friendListBox_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            P2pChatForm form = new P2pChatForm(e.SelectSubItem);
            //int guestId = e.SelectSubItem.ID;
            //if (P2pServerSocket.socketDict.ContainsKey(guestId))
            //{
            //    TcpClient server = P2pServerSocket.socketDict[guestId];
            //    form.ServerSocket = server;
            //} 
            //else
            //{
            //    try
            //    {
            //        User guest = userBll.getUser("342916053@qq.com");
            //        string ip = guest.LastLoginIp;
            //        TcpClient client = new TcpClient(ip,8009);
            //        byte[] buff = new byte[1024];
            //        StreamWriter writer = new StreamWriter(client.GetStream());
            //        writer.WriteLine(user.UId); //告诉对方自己的id
            //        writer.Flush();
            //        form.ServerSocket = client;
            //    }
            //    catch (System.Exception ex)
            //    {
                	
            //    }
            //}
            form.Show();
        }
        //添加好友
        private void addFriendButton_Click(object sender, EventArgs e)
        {
            new AddFriendsForm(user).Visible=true;
        }

       
    }
}
