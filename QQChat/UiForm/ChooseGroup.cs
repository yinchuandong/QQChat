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
        private GroupBll groupBll;
        private GroupMemberBll groupMemberBll;
        private User currUser;      //当前的用户
        private User user;          //被添加的用户
        private int groupID=0;        //当前默认组号

        public ChooseGroup(User currUser,User user,IList<Model.Group> groupList)
        {
            InitializeComponent();
            this.currUser = currUser;
            this.groupList=groupList;
            this.user = user;
            this.groupMemberBll = new GroupMemberBll();
            this.groupBll = new GroupBll();
            this.friendBll = new FriendBll();
        }

        private void ChooseGroup_Load(object sender, EventArgs e)
        {
            Object[] groupArray=groupList.ToArray();
            string[] groupName = new string[groupArray.Length];
            int i=0;
            foreach(Group group in groupArray){
                groupName[i] = group.Name;
                ++i;
            }
            groupComboBox.Items.AddRange(groupName);
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = groupComboBox.SelectedIndex;
            Group[] groupArray = groupList.ToArray();         
            groupID=groupArray[index ].GId;     
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //判断好友关系
            bool isFriend = friendBll.isFriend(currUser.UId, user.UId);
            if(isFriend){
                MessageBox.Show("他已经是你好友，重复添加无效");
                return;
            }
            Friend friend = new Friend();
            friend.UId = currUser.UId;
            friend.FriendId = user.UId;
            friend.Time =(DateTime?) System.DateTime.Now;
            friend.NickName = user.Username;
            friend.GId = groupID;  //d当前friend所属的分组的groupID
            friend.FriendName = friend.NickName;
            Program.mWin.friendListForm.addPengyou(groupID, friend);
            string msg = friendBll.addFriend(friend);

           
            MessageBox.Show(msg);

            //添加到GroupMember中去
            try
            {
                GroupMember groupMember = new GroupMember();
                groupMember.GroupId = groupMemberBll.getGroupID(currUser.UId, groupComboBox.Text.Trim());
                groupMember.UId = user.UId;
                groupMember.Time = (DateTime?)System.DateTime.Now;
                groupMemberBll.insertMember(groupMember);                 
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
         

        }

        //新添加分组
        private void newGroupButton_Click(object sender, EventArgs e)
        {
            string groupName=groupComboBox.Text.Trim();
            bool isExist=groupBll.isGroupByName(currUser.UId,groupName);
            if (isExist)
            {
                MessageBox.Show("分组已经存在");
                return;
            }
            else 
            {
                if (groupName.Length <= 0 || groupComboBox.SelectedIndex==0)
                {
                    return;
                }
                Group group = new Group();
                group.UId = currUser.UId;
                group.Name = groupName;
                group.GId = groupID;
              
                if (groupBll.addGroup(group))
                {
                    try
                    {
                        groupID = groupBll.getGroupID(group.UId, group.Name);
                    }
                    catch {
                        Console.WriteLine("GroupID Exception ");
                    }
                    MessageBox.Show("创建新分组成功");
                    groupComboBox.Text = groupName;
                }
                else 
                {
                    MessageBox.Show("创建失败");
                }
            
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
