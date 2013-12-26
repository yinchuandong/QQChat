using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

using SqlDal;
using Model;
using Util;
using Bll;

using Widget._ChatListBox;
using Widget._TabControl;

namespace QQChat.UiForm
{
    public partial class AddNewChatRoom : Form
    {
        private SessionBll session;
        private ChatRoomMemberDal chatroommemberdal = new ChatRoomMemberDal();
        private ChatRoomMemberBll chatRoomMemberBll = new ChatRoomMemberBll();
        private User user;//当前用户
        private ArrayList searchList;//查询结果

        Chatroom chatroom1 = new Chatroom();
        public AddNewChatRoom()
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            user = session.User;
            searchList=new ArrayList();
        }

        private void NewChatRoomForm_Load(object sender, EventArgs e)
        {
            chatRoomListView.View = View.Details;//搜索结果的排列模式
            chatRoomListView.Size=new Size(340, 265);
            ColumnHeader ch1 = new ColumnHeader();
            ColumnHeader ch2 = new ColumnHeader();
            ColumnHeader ch3 = new ColumnHeader();
            ColumnHeader ch4 = new ColumnHeader();
            ColumnHeader ch5 = new ColumnHeader();
            ch1.Text = "群名";   //设置列标题  
            ch2.Text = "群主";   //设置列标题  
            ch3.Text = "创建日期";   //设置列标题  
            ch4.Text = "限制人数";   //设置列标题  
            ch5.Text = "当前人数";   //设置列标题 
 
            ch1.Width = 68;    //设置列宽度  
            ch2.Width = 68;    //设置列宽度  
            ch3.Width = 68;    //设置列宽度  
            ch4.Width = 68;    //设置列宽度  
            ch5.Width = 68;    //设置列宽度  

            ch1.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式  
            ch2.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式  
            ch3.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式  
            ch4.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式  
            ch5.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式  

           chatRoomListView.Columns.Add(ch1);    //将列头添加到ListView控件。
           chatRoomListView.Columns.Add(ch2);    //将列头添加到ListView控件
           chatRoomListView.Columns.Add(ch3);    //将列头添加到ListView控件
           chatRoomListView.Columns.Add(ch4);    //将列头添加到ListView控件
           chatRoomListView.Columns.Add(ch5);    //将列头添加到ListView控件
        }

        private void Sure_button_Click(object sender, EventArgs e)
        {
            string name = ChatroomName_textBox.Text.Trim();
            string limitNumber = LimitNum_comboBox.Text.Trim();
            if(name.Length==0||limitNumber.Length==0){
                return;
            }
            chatroom1.Name = name;
            chatroom1.Time = System.DateTime.Now;
            chatroom1.LeaderId = user.UId;
            chatroom1.LimitNum = Convert.ToInt32(LimitNum_comboBox.Text);
            String msg= chatRoomMemberBll.addChatRoom(chatroom1, name);
            if(msg!=null){
                MessageBox.Show(msg);
                return;
            }
            int id = chatroommemberdal.getLasteID();//获得到最新的chatroom的id

            ChatRoomMemberDal chatroommemberdal2 = new ChatRoomMemberDal();
            chatroom1.Time = System.DateTime.Now;
            chatroom1.LeaderId = user.UId;
            chatroom1.CId = id;
            chatroommemberdal2.addChatRoomMember(chatroom1); //往群成员中添加作为当前用户作为群主   
            MessageBox.Show("群组创建成功");
            this.Hide();
            Random rnd = new Random();
            Chatroom chatroomdetail = chatroom1;
            ChatListSubItem subItem = new ChatListSubItem();
            subItem.DisplayName = chatroomdetail.Name;
            subItem.ID = chatroomdetail.CId;
            subItem.ChatRoomPort = chatroomdetail.ChatRoomPort;
            subItem.HeadImage = Image.FromFile("Head/1 (" + rnd.Next(0, 45) + ").png");
            Program.mWin.groupListForm.listItem.SubItems.Add(subItem); 

        }

        //查找群
        private void searchRoomBut_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if(name.Length==0){
                return;
            }
            searchList = chatRoomMemberBll.searchChatRoom(name);
            if (searchList == null)
            {
                MessageBox.Show("查找群失败！");
                return;
            }
            else {
                loadSearchInfo(searchList); //加载查询到的信息
            }
        }
       
        private void loadSearchInfo(ArrayList chatRooms)
        {
            chatRoomListView.BeginUpdate();
            foreach(Chatroom chatRoom in chatRooms ){
                User leader = chatRoomMemberBll.searchLeader(chatRoom.LeaderId);
                int current_Num = chatRoomMemberBll.searchNum(chatRoom.CId);
                DateTime time = (DateTime)chatRoom.Time;
                ListViewItem item = new ListViewItem();
                item.Text = chatRoom.Name;
                item.SubItems.Add(leader.Username);
                item.SubItems.Add(time.ToShortDateString());
                item.SubItems.Add(chatRoom.LimitNum.ToString());
                item.SubItems.Add(current_Num.ToString());
                chatRoomListView.Items.Add(item);
            }
            chatRoomListView.EndUpdate();

           
        }

        //加入chatRoom
        private void chatRoomListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("申请加入该群吗？", "群信息", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (chatRoomListView.SelectedIndices != null && chatRoomListView.SelectedIndices.Count>0)
                  {
                    ListView.SelectedIndexCollection c = chatRoomListView.SelectedIndices;
                    int index=chatRoomListView.Items[c[0]].Index;
                    Chatroom chatroom = (Chatroom)searchList[index];
                    int c_id = chatroom.CId;//聊天室的id
                    int u_id = user.UId;//当前用户的id
                    string msg= chatRoomMemberBll.addMember(u_id, c_id);
                    if(msg==null){
                       MessageBox.Show("加入群成功！");
                       Random rnd = new Random();
                       Chatroom chatroomdetail = chatroom;
                       ChatListSubItem subItem = new ChatListSubItem();
                       subItem.DisplayName = chatroomdetail.Name;
                       subItem.ID = chatroomdetail.CId;
                       subItem.ChatRoomPort = chatroomdetail.ChatRoomPort;
                       subItem.HeadImage = Image.FromFile("Head/1 (" + rnd.Next(0, 45) + ").png");
                       Program.mWin.groupListForm.listItem.SubItems.Add(subItem); ;
                       this.Hide();           
                    }else{
                        MessageBox.Show(msg);        
                    }
                      return;
                   }         
            }
            else 
            {
                return;
            }
           
        }
    }
}
