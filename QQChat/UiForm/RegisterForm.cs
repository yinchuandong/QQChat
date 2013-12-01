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
    public partial class RegisterForm : BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
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

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(checkForm())
            {
                //处理注册逻辑
            }
        }

        private bool checkUsername()
        {
            return false;
        }

        private bool checkEmail()
        {
            return false;
        }

        private bool checkPassword()
        {
            return false;
        }

        private bool checkRepassword()
        {
            return false;
        }

        private bool checkActiveCode()
        {
            return false;
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
