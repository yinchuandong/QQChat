using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlDal;

using Widget._ChatListBox;

namespace QQChat.UiForm
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("12213");
            //String test = SqlDbHelper.ConnectString;
            //MessageBox.Show(SqlDbHelper.ConnectString);
            chatListBox.IconSizeMode = ChatListItemIcon.Large;
            Random rnd = new Random();
            for(int i=0;i<10;i++)
            {
                ChatListItem item = new ChatListItem("group" + i);
                for (int j = 0; j < 10; j++)
                {
                    ChatListSubItem subItem = new ChatListSubItem("nickname", "displayname" + j, "personalmsg");
                    subItem.HeadImage = Image.FromFile("Head/1 (" + rnd.Next(0, 45) + ").png");
                    subItem.Status = (ChatListSubItem.UserStatus)(j % 6);
                    item.SubItems.Add(subItem);
                }
                chatListBox.Items.Add(item);
            }
        }

        private void chatListBox_MouseEnterHead(object sender, ChatListEventArgs e)
        {
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
