using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Util;
using Model;
using SqlDal;
using Bll;

namespace QQChat.UiForm
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            banner.Image = Properties.Resources.login_banner;
        }

        //登陆按钮click事件
        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserBll userBll = new UserBll();
            string email = emailTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            if (userBll.checkLogin(email,password))
            {
                SessionBll sessionBll = SessionBll.GetInstance();
                User user = userBll.getUser(email);
                user.LastLoginIp = AppUtil.GetLocalIp();
                user.LastLoginTime = DateTime.Now;
                sessionBll.User = user;
                sessionBll.IsLogin = true;
                User updateUser = new User();
                updateUser.LastLoginIp = user.LastLoginIp;
                updateUser.LastLoginTime = user.LastLoginTime;
                updateUser.Status =1;
                userBll.update(updateUser, user.UId);
               Program.mWin=  new MainForm();
               Program.mWin.Show();
                this.Hide();
            }else{
                MessageBox.Show("用户名或密码错误");
            }
        }
        //去注册的label click事件
        private void register_Click(object sender, EventArgs e)
        {
            //FriendBll friendBll = new FriendBll();
            //Friend friend = new Friend();
            //friend.UId = 3;
            //friend.FriendId = 4;
            //friend.GId = 1;
            //friend.Time = DateTime.Now;
            //friend.NickName = "";
            //friendBll.addFriend(friend);
            new RegisterForm().Show();
            //friendBll.getOneFriend(3,4);
            //GroupBll groupBll = new GroupBll();
            //IList<Group> list= groupBll.getGroupList(3);
        }

        private void register_Enter(object sender, EventArgs e)
        {
            register.ForeColor = Color.Red;
        }

        private void register_Leave(object sender, EventArgs e)
        {
            register.ForeColor = Color.Black;
        }

    }
}
