using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            new MainForm().Show();
            this.Hide();
        }

        //去注册的label click事件
        private void register_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void register_Enter(object sender, EventArgs e)
        {
            register.ForeColor = Color.Red;
            MessageBox.Show("enter");
        }

        private void register_Leave(object sender, EventArgs e)
        {
            register.ForeColor = Color.Black;
            MessageBox.Show("leave");
        }

    }
}
