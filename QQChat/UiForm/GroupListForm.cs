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

    public partial class GroupListForm : Form
    { 
        private UserBll userBll;
        private SessionBll session;
        private User user;
        private Chatroom chatroom;
        private ChatRoomMemberBll chatRoomMemberBll;

        public GroupListForm()
        {
            InitializeComponent();
            chatroom = new Chatroom();
            userBll = new UserBll();
            session = SessionBll.GetInstance();
            chatRoomMemberBll = new ChatRoomMemberBll();
            user = session.User;
            session = SessionBll.GetInstance();
        }
        private void GroupListForm_Load(object sender, EventArgs e)
        {
            groupListBox.IconSizeMode = ChatListItemIcon.Large;
            Random rnd = new Random();
            ChatListItem listItem = new ChatListItem("我的群组");
            IList<Chatroom> chatRoommemberBll = chatRoomMemberBll.getChatRoomDetail(user.UId);
            foreach (Chatroom chatroomdetail in chatRoommemberBll)
            {
                ChatListSubItem subItem = new ChatListSubItem();
                subItem.DisplayName = chatroomdetail.Name;
                subItem.ID = chatroomdetail.CId;
                subItem.HeadImage = Image.FromFile("Head/1 (" + rnd.Next(0, 45) + ").png");
                listItem.SubItems.Add(subItem);
            }
            groupListBox.Items.Add(listItem);
        }
        private void GroupListBox_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            GroupChatForm form = new GroupChatForm(e.SelectSubItem);
            form.Show();
        }
        private void newGroup_button_Click(object sender, EventArgs e)
        {
            new AddNewChatRoom().Show();
        }

        
       
    }
}
