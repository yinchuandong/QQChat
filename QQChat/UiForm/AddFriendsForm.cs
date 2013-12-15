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
            faceList = new ImageList();
            faceList.ImageSize = new Size(60, 80);
            friendsListView.LargeImageList = faceList;
            friendsListView.AutoArrange = true;
            friendsListView.MultiSelect = false;
        }
        //加载查询到的信息
        private void loadSearchInfo(User user,int index) 
        {   
            
            Random rnd=new Random();
            string facePath = "Head/1 (" + rnd.Next(0, 45) + ").png";//为ImageList添加图片
            faceList.Images.Add(user.Username.ToString(),Image.FromFile(facePath));
            friendsListView.BeginUpdate();
            ListViewItem item = new ListViewItem();  
            item.ImageIndex = index;              
            item.Text = user.Username;
            friendsListView.Items.Add(item);          
            friendsListView.EndUpdate();
        }
     

        private void friendsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (friendsListView.SelectedItems.Count > 0)
            {               
                int index=0;
                foreach (ListViewItem lvi in friendsListView.SelectedItems)  //选中项遍历  
                {
                    index = lvi.Index;
                }

                User selectedUser = (User)searchList[index];
                //判断好友关系
                bool isFriend = friendBll.isFriend(currUser.UId, selectedUser.UId);
                if (isFriend)
                {
                    MessageBox.Show("对方已是您好友，重复添加无效！");
                    return;
                }       
                string text = "添加好友？";
                string title = "添加好友信息";
                if (MessageBox.Show(text, title, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Friend friend = new Friend();
                    //选择群
                    IList<Model.Group> groupList = groupBll.getGroupList(currUser.UId);
                    //弹出下拉表单进行选择分组
                    ChooseGroup chooseGroup = new ChooseGroup(currUser, selectedUser, groupList);
                    chooseGroup.Visible = true;
                }
            }
            else {
                return;
            }        

        }

        private void chechFrinedsBut_Click(object sender, EventArgs e)
        {
            friendsListView.Clear();                //清理上次查询结果
            string key = checkTextBox.Text.Trim();
            if(key.Length<=0||key==null){
                return;
            }
            searchList = friendBll.searchUser(currUser.UId, key);
           if(searchList.Count==0){
             
               return;
           }
            int i = 0;
            foreach (User user in searchList)
            {
                loadSearchInfo(user,i);
                ++i;
            }
          
        }
 }
}
