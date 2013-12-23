using System;
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
using Socket;

using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace QQChat.UiForm
{
    public partial class GroupChatForm : Form
    {
        private SessionBll session;
        private ChatListSubItem guestItem;
        private int chatRoomId;


        public GroupChatForm()
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            chatRoomId = session.Chatroom.CId;
        }
        public GroupChatForm(ChatListSubItem guestItem)
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            this.guestItem = guestItem;
            this.chatRoomId = guestItem.ID;
            initData();
        }

        public void initData()
        {
            headPicBox.Image = guestItem.HeadImage;
            nameTxt.Text = guestItem.DisplayName;
        }
       
    }
}
