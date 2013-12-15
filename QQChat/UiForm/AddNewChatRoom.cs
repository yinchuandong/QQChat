using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.Data;

using SqlDal;
using Model;
using Util;
using Bll;

namespace QQChat.UiForm
{ 
    public partial class AddNewChatRoom : Form
    {
        private SessionBll session;

        private User user; 

        Chatroom chatroom1 = new Chatroom();

        public AddNewChatRoom()
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            user = session.User;
            
        }
       
        private void Sure_button_Click(object sender, EventArgs e)
        {

            ChatRoomMemberDal chatroommemberdal = new ChatRoomMemberDal();
            chatroom1.Name = ChatroomName_textBox.Text;
            chatroom1.Time = System.DateTime.Now;
            chatroom1.LeaderId = user.UId;
            chatroom1.LimitNum = Convert.ToInt32(LimitNum_comboBox.Text);
            int result=chatroommemberdal.addChatRoom(chatroom1);
            int id = chatroommemberdal.getLasteID();

            ChatRoomMemberDal chatroommemberdal2 = new ChatRoomMemberDal();
            chatroom1.Time = System.DateTime.Now;
            chatroom1.LeaderId = user.UId;
            chatroom1.CId=id;
            chatroommemberdal2.addChatRoomMember(chatroom1);
            this.Hide();
            MessageBox.Show("群组创建成功");
        }

    }
}
