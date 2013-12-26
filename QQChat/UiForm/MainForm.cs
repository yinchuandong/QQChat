using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

using SqlDal;
using Model;
using Bll;
using Util;
using MySocket;

using Widget._ChatListBox;
using Widget._TabControl;


namespace QQChat.UiForm
{
    public partial class MainForm : BaseForm
    {
        private User user;
        private SessionBll session;
        public MainForm()
        {
            session = SessionBll.GetInstance();
            user = session.User;
            InitializeComponent();
            NickName_label.Text = user.Username;
            Sign_label.Text = user.Sign;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //添加头像
            if (user.Photo == null)
            {
                Image errorIm = Image.FromFile("Head/error.jpg");
                Size size=new Size(60, 60);
                pictureBox1.Image = new Bitmap(errorIm, size);
               
            }
            else {
                MemoryStream stream = new MemoryStream(user.Photo);
                Size size = new Size(60, 60);
               Bitmap im=new Bitmap(stream);
               pictureBox1.Image = new Bitmap(im,size);
            }
           
             friendListForm = new FriendListForm();
            friendListForm.TopLevel = false;
            friendListForm.Dock = DockStyle.Fill;
            friendPage.Controls.Add(friendListForm);
            friendListForm.Show();

             groupListForm = new GroupListForm();
            groupListForm.TopLevel = false;
            groupListForm.Dock = DockStyle.Fill;
            groupPage.Controls.Add(groupListForm);
            groupListForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new UserInfoForm().Show();
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            } 
            
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            user.Status = 0;
        }




        
    }
}
