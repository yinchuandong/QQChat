using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Bll;
using Model;
namespace QQChat.UiForm
{
    public partial class ChooseGroup : Form
    {
        private IList<Model.Group> groupList;
        private FriendBll friendBll;
        private User currUser;      //当前的用户
        private User user;          //被添加的用户

        public ChooseGroup(User currUser,User user,IList<Model.Group> groupList)
        {
            InitializeComponent();
            this.currUser = currUser;
            this.groupList=groupList;
            this.user = user;
        }

        private void ChooseGroup_Load(object sender, EventArgs e)
        {
            Object[] groupArray=groupList.ToArray();
            groupComboBox.Items.AddRange(groupArray);
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //获取groupID
            Friend friend = new Friend();
            friend.UId = currUser.UId;
            friend.FriendId = user.UId;
            friend.Time = System.DateTime.Now;
            friend.NickName = user.Username;
            friend.GId = 10;
            string msg = friendBll.addFriend(friend);
            MessageBox.Show(msg);
        }

        
    }
}
