using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;
using Bll;
using Model;
using SqlDal;


namespace QQChat.UiForm
{
    public partial class UserInfoForm : Form
    {
        private SessionBll session;
        private User user;
        public UserInfoForm()
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            user = session.User;
            UserName_label.Text = Convert.ToString(user.Username);
            
            if (user.Sex == -1)
               label_Sex.Text="男";
            else
               label_Sex.Text = "女";
          
            if (user.Age == -1)
            {
                label_Age.Text = "0";
            }
            else
                label_Age.Text = Convert.ToString(user.Age);

            label_Uid.Text = Convert.ToString(user.Email);
            label_NickName.Text = Convert.ToString(user.Username) ;
            label_Email.Text = Convert.ToString(user.Email);
            Sign_textBox.Text = Convert.ToString(user.Sign);
            Sign_textBox.ReadOnly = true;
            
        }

        private void EditInfo_Click(object sender, EventArgs e)
        {
            UserInfopanel.Hide();
            Sign_textBox.Enabled = true;
            Sign_textBox.ReadOnly =false;
            if (user.Sex == -1)
               SexChoice_comboBox.Text = "男";
            else
               SexChoice_comboBox.Text = "女";

            if (user.Age == -1)
            {
                Age_textBox.Text = "0";
            }
            else
                Age_textBox.Text = Convert.ToString(user.Age);
            label2_Uid.Text = user.Email;
            NickName_textBox.Text = user.Username;
            Email_textBox.Text = user.Email;
            Sign_textBox.Text = user.Sign;    
        }

        private void Save_button_Click(object sender, EventArgs e)
        {

            UserDal userdal = new UserDal();
            string signUpdate = Sign_textBox.Text;
            user.Sign = signUpdate;

            string nicknameUpdate = NickName_textBox.Text;
            user.Username = nicknameUpdate;

            string sexUpdate = SexChoice_comboBox.Text;
            if (sexUpdate == "男")
                user.Sex = -1;
            else
                user.Sex = 0;
            try
            {
                int ageUpdate = Int32.Parse(Age_textBox.Text);
                user.Age = ageUpdate;
            }
            catch
            {
                MessageBox.Show("输入有误!");
                Age_textBox.Focus();
                Age_textBox.ForeColor = System.Drawing.Color.Red;
                return;
            }

            
            string emailUpdate = Email_textBox.Text;
            user.Email = emailUpdate;
            userdal.update(user,user.UId);
            label_Uid.Text = Convert.ToString(user.Email);
            label_NickName.Text = Convert.ToString(user.Username);
            label_Email.Text = Convert.ToString(user.Email);
            Sign_textBox.Text = Convert.ToString(user.Sign);
             UserInfopanel.Show();
            Sign_textBox.ReadOnly = true;
        }

        private void backUpdate_Click(object sender, EventArgs e)
        { 
            Panel EditInfo_Panel = new Panel();
            EditInfo_Panel.Hide();
            UserInfopanel.Show();
            
        }     
        
    }
}
