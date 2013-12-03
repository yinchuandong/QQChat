using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SqlDal;
using Model;
using Bll;

using Widget._ChatListBox;
using Widget._TabControl;


namespace QQChat.UiForm
{
    public partial class MainForm : BaseForm
    {
        private SessionBll session;
        private User user;

        public MainForm()
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            user = session.User;
        }

        private void MainForm_Load(object sender, EventArgs e)
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
            new P2pChatForm().Show();
        }


        
    }
}
