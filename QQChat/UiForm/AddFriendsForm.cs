using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using  Bll;
using Model;
namespace QQChat.UiForm
{
    public partial class AddFriendsForm : Form
    {
        private ImageList faceList;//用户头像List
        private List<string> nickNameList;
        private FriendsBll friendBll;

        public AddFriendsForm()
        {
            InitializeComponent();
            faceList = new ImageList();
            nickNameList = new List<string>();
            friendBll = new FriendsBll();
        
        }
        
        private void AddFriendsForm_Load(object sender, EventArgs e)
        {
            //设置ListView
            friendsListView.View = View.LargeIcon;
            faceList.ImageSize = new Size(60, 80);
            friendsListView.LargeImageList = faceList;
            friendsListView.AutoArrange = true;
        }
        //加载查询到的信息
        private void loadSearchInfo(User user) 
        {
            //为ImageList添加图片
            faceList.Images.Add(user.Username.ToString(), Image.FromFile("Head/1 (" + 1 + ").png"));

            ListViewItem item = new ListViewItem();
            ListViewItem.ListViewSubItem subItem= new ListViewItem.ListViewSubItem();
            item.Text = user.Username;
            item.ImageIndex = 0;
            friendsListView.AutoArrange = true;
            subItem.Text = user.Sign;
            item.SubItems.Add(subItem);
            friendsListView.Items.Add(item);

        }

        private void friendsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string text = "添加好友？";
            string title = "添加好友信息";
            if (MessageBox.Show("添加好友？", "查找好友", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               // friendBll.addFriend(5, 4);

            }
           

        }

        private void chechFrinedsBut_Click(object sender, EventArgs e)
        {
            friendsListView.Clear();//清理上次查询结果
            string key = checkTextBox.Text.Trim();
            Console.WriteLine("输入"+key);
            ArrayList userList = friendBll.searchUser(key);
            int i = 0;
            foreach (User user in userList) {
                loadSearchInfo(user);
            }
            Console.WriteLine(i);
           
            Console.WriteLine("结果"+userList.ToString());
            Console.WriteLine("数目："+userList.Count);

        }
      

       

    }
}
