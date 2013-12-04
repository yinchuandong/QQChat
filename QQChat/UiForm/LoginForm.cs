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
                sessionBll.User = user;
                sessionBll.IsLogin = true;
                User updateUser = new User();
                updateUser.LastLoginIp = AppUtil.GetLocalIp();
                updateUser.LastLoginTime = DateTime.Now;
                userBll.update(updateUser, user.UId);
                new MainForm().Show();
                this.Hide();
            }else{
                MessageBox.Show("用户名或密码错误");
            }
        }

        //去注册的label click事件
        private void register_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
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
