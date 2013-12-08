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
        private FriendBll friendBll;
        private GroupBll groupBll;
        private User currUser;              //当前用户
        private ArrayList searchList;       //查询结果
        ImageList faceList;                 //用户头像列表

        public AddFriendsForm(User user)
        {
            InitializeComponent();
            currUser = user;
            friendBll = new FriendBll();
            groupBll = new GroupBll();
        
        }
        
        private void AddFriendsForm_Load(object sender, EventArgs e)
        {
            ImageList faceList = new ImageList();
            faceList.ImageSize = new Size(60, 80);
            friendsListView.LargeImageList = faceList;
            friendsListView.AutoArrange = true;
        }
        //加载查询到的信息
        private void loadSearchInfo(User user,int index) 
        {   
            //为ImageList添加图片
            faceList.Images.Add(user.Username.ToString(), Image.FromFile("Head/1 (" + 1 + ").png"));
            friendsListView.BeginUpdate();
            ListViewItem item = new ListViewItem();
            item.ImageIndex = index-1;              
            item.Text = user.Username;
            friendsListView.Items.Add(item);          
            friendsListView.EndUpdate();

        }
     

        private void friendsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string text = "添加好友？";
            string title = "添加好友信息";

            if (MessageBox.Show(text, title, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                Friend friend = new Friend();
              
                ListViewItem i = friendsListView.SelectedItems[0];
                int index=i.Index;//选中的index
                User user =(User) searchList[index];
                //选择群
                IList<Model.Group> groupList = groupBll.getGroupList(user.UId);
                //弹出下拉表单进行选择分组
                ChooseGroup chooseGroup = new ChooseGroup(currUser,user,groupList);
                chooseGroup.Visible = true;            
            }
           

        }

        private void chechFrinedsBut_Click(object sender, EventArgs e)
        {
            friendsListView.Clear();                //清理上次查询结果
            string key = checkTextBox.Text.Trim();
            searchList = friendBll.searchUser(key);
            int i = 1;
            foreach (User user in searchList)
            {
                loadSearchInfo(user,i);
                ++i;
            }
          
        }
      

       

    }
}
