using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Bll;
using Model;
using Util;
namespace QQChat.UiForm
{
    public partial class RegisterForm : BaseForm
    {
        private UserBll userBll;
        private string activeCode;
        private Random rdm = new Random();
        public RegisterForm()
        {
            InitializeComponent();
            userBll = new UserBll();
            activeCode = rdm.Next(1000, 9999).ToString();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        void usernameTxt_Leave(object sender, System.EventArgs e)
        {
            checkUsername();
        }

        void emailTxt_Leave(object sender, System.EventArgs e)
        {
            checkEmail();
        }

        void passwordTxt_Leave(object sender, System.EventArgs e)
        {
            checkPassword();
        }

        void repasswordTxt_Leave(object sender, System.EventArgs e)
        {
            checkRepassword();
        }

        void activeCodeTxt_Leave(object sender, System.EventArgs e)
        {
            checkActiveCode();
        }

        private void sendMailBtn_Click(object sender, EventArgs e)
        {
            if(checkEmail())
            {
                AppUtil.SendMail(emailTxt.Text.Trim(), "【呵呵的日子】", "您的验证码为"+activeCode);
                tipsMail.Text = "激活码已发送至你的邮箱";
                sendMailBtn.Enabled = false;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(checkForm())
            {  //系统随机分配一个头像
                Random rnd = new Random();          
                FileStream headFile = new FileStream("Head/1 (" + rnd.Next(0, 45) + ").png", FileMode.Open, FileAccess.Read);
                int length = (int)headFile.Length;
                Byte[] headBytes = new Byte[length];
                headFile.Read(headBytes, 0, length);
                headFile.Close();
                //处理注册逻辑
                User user = new User();
                user.Email = emailTxt.Text.Trim();
                user.Username = usernameTxt.Text.Trim();
                user.Password = passwordTxt.Text.Trim();
                
                user.Age = 0;
                user.Sex = 0;
                user.Sign = "我刚刚申请账号成功！";
                user.Photo = headBytes;      
     
                bool result = userBll.register(user);
                if (result)
                {
                    MessageBox.Show("注册成功");                  
                   new UiForm.LoginForm().Visible = true;
                   this.Close();
                }
                else {
                    MessageBox.Show("注册失败，请检查格式或网络！");
                    return;
                }  
            }
        }

        private bool checkUsername()
        {
            string username = usernameTxt.Text.Trim();
            if(userBll.IsValidatedUserName(username))
            {
                tips1.Text = "";
                return true;
            } else{
                tips1.Text = "用户名长度不合法";
                return false;
            }
        }

        private bool checkEmail()
        {
            string email = emailTxt.Text.Trim();
            if(!userBll.IsValidatedEmail(email))
            {
                tips2.Text = "邮箱格式不正确";
                return false;
            }
            if(!userBll.checkUniqueEmail(email)){
                tips2.Text = "此邮箱已经被注册";
                return false;
            }
            tips2.Text = "";
            return true;
        }

        private bool checkPassword()
        {
            string password = passwordTxt.Text.Trim();
            if (!userBll.IsValidatedPassword(password))
            {
                tips3.Text = "密码格式不正确";
                return false;
            }
            tips3.Text = "";
            return true;
        }

        private bool checkRepassword()
        {
            string repassword = repasswordTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            if (!userBll.IsValidatedPassword(repassword))
            {
                tips4.Text = "密码格式不正确";
                return false;
            }
            if(!repassword.Equals(password))
            {
                tips4.Text = "密码不一致";
                return false;
            }
            tips4.Text = "";
            return true;
        }

        private bool checkActiveCode()
        {
            if (activeCode.Equals(activeCodeTxt.Text.Trim()))
            {
                tips5.Text = "";
                return true;
            }else{
                tips5.Text = "激活码错误";
                return false;
            }
            
        }

        private bool checkForm()
        {
            if(checkUsername() && checkEmail() && checkPassword() && checkRepassword() &&checkActiveCode())
            {
                return true;
            }else{
                return false;
            }
        }



    }
}
