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
    public partial class AddChatRoomForm : Form
    {
        private ChatRoomBll chatRoomBll;
        private User user;
        private String limitNum = "";
        public AddChatRoomForm(User user)
        {
            InitializeComponent();
            chatRoomBll = new ChatRoomBll();
            this.user = user;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int selectedIndex = comboBox1.SelectedIndex;          
           // MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
             //              "Index: " + selectedIndex.ToString());

            Object selectedItem = comboBox1.SelectedItem;
            limitNum = selectedItem.ToString();
           
            
        }

        private void AddChatRoomForm_Load(object sender, EventArgs e)
        {

            Dictionary<String, String> dic = new Dictionary<string, String>();
            dic.Add("20", "20");
            dic.Add("50", "50");
            dic.Add("100 ","100 ");
            dic.Add("200", "200");
            dic.Add("500", "500");
            foreach (KeyValuePair<string, String> kv in dic)
            {
                comboBox1.Items.Add(kv.Key); 
            }
         
            /**
            foreach (var item in dic)
            {
                comboBox1.Items.Add(item); 
            }
             * */
         
        }

        private void createButton_Click(object sender, EventArgs e)
        {
           Chatroom chatRoom= new Chatroom();
            String name=textBox1.Text.Trim();
            String limit = limitNum;
            if (name.Length==0||limit.Length==0) {
                return;
            }
            chatRoom.Name = name;
            chatRoom.LimitNum = int.Parse(limit);
            chatRoom.Time = System.DateTime.Now;
            chatRoom.LeaderId = user.UId;
            if (chatRoomBll.createNewsRoom(chatRoom))
            {
                MessageBox.Show("创建群成功！");
            }
            else {
                MessageBox.Show("创建群失败！");
            }

        }
    }
 
    
}
