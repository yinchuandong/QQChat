namespace QQChat.UiForm
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.repasswordTxt = new System.Windows.Forms.TextBox();
            this.activeCodeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tips1 = new System.Windows.Forms.Label();
            this.tips5 = new System.Windows.Forms.Label();
            this.tips4 = new System.Windows.Forms.Label();
            this.tips3 = new System.Windows.Forms.Label();
            this.tips2 = new System.Windows.Forms.Label();
            this.tipsAll = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.tipsMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usernameTxt.Location = new System.Drawing.Point(109, 55);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(207, 26);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(109, 102);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(207, 26);
            this.emailTxt.TabIndex = 1;
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(109, 221);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(207, 26);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Leave += new System.EventHandler(this.passwordTxt_Leave);
            // 
            // repasswordTxt
            // 
            this.repasswordTxt.Location = new System.Drawing.Point(109, 268);
            this.repasswordTxt.Name = "repasswordTxt";
            this.repasswordTxt.PasswordChar = '*';
            this.repasswordTxt.Size = new System.Drawing.Size(207, 26);
            this.repasswordTxt.TabIndex = 3;
            this.repasswordTxt.Leave += new System.EventHandler(this.repasswordTxt_Leave);
            // 
            // activeCodeTxt
            // 
            this.activeCodeTxt.Location = new System.Drawing.Point(109, 178);
            this.activeCodeTxt.Name = "activeCodeTxt";
            this.activeCodeTxt.Size = new System.Drawing.Size(93, 26);
            this.activeCodeTxt.TabIndex = 9;
            this.activeCodeTxt.Leave += new System.EventHandler(this.activeCodeTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "邮箱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "重复密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "激活码";
            // 
            // tips1
            // 
            this.tips1.AutoSize = true;
            this.tips1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips1.ForeColor = System.Drawing.Color.Red;
            this.tips1.Location = new System.Drawing.Point(322, 59);
            this.tips1.Name = "tips1";
            this.tips1.Size = new System.Drawing.Size(82, 17);
            this.tips1.TabIndex = 10;
            this.tips1.Text = "1-10位中英文";
            // 
            // tips5
            // 
            this.tips5.AutoSize = true;
            this.tips5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips5.ForeColor = System.Drawing.Color.Red;
            this.tips5.Location = new System.Drawing.Point(211, 182);
            this.tips5.Name = "tips5";
            this.tips5.Size = new System.Drawing.Size(128, 17);
            this.tips5.TabIndex = 11;
            this.tips5.Text = "请输入邮件中的验证码";
            // 
            // tips4
            // 
            this.tips4.AutoSize = true;
            this.tips4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips4.ForeColor = System.Drawing.Color.Red;
            this.tips4.Location = new System.Drawing.Point(322, 272);
            this.tips4.Name = "tips4";
            this.tips4.Size = new System.Drawing.Size(0, 17);
            this.tips4.TabIndex = 12;
            // 
            // tips3
            // 
            this.tips3.AutoSize = true;
            this.tips3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips3.ForeColor = System.Drawing.Color.Red;
            this.tips3.Location = new System.Drawing.Point(322, 224);
            this.tips3.Name = "tips3";
            this.tips3.Size = new System.Drawing.Size(106, 17);
            this.tips3.TabIndex = 13;
            this.tips3.Text = "6-16位数字和字母";
            // 
            // tips2
            // 
            this.tips2.AutoSize = true;
            this.tips2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips2.ForeColor = System.Drawing.Color.Red;
            this.tips2.Location = new System.Drawing.Point(322, 106);
            this.tips2.Name = "tips2";
            this.tips2.Size = new System.Drawing.Size(0, 17);
            this.tips2.TabIndex = 14;
            // 
            // tipsAll
            // 
            this.tipsAll.AutoSize = true;
            this.tipsAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipsAll.ForeColor = System.Drawing.Color.Red;
            this.tipsAll.Location = new System.Drawing.Point(220, 322);
            this.tipsAll.Name = "tipsAll";
            this.tipsAll.Size = new System.Drawing.Size(0, 17);
            this.tipsAll.TabIndex = 15;
            // 
            // submitBtn
            // 
            this.submitBtn.BackgroundImage = global::QQChat.Properties.Resources.register;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submitBtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.submitBtn.Location = new System.Drawing.Point(109, 310);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(93, 36);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.sendMailBtn.Location = new System.Drawing.Point(109, 134);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(93, 30);
            this.sendMailBtn.TabIndex = 17;
            this.sendMailBtn.Text = "验证邮箱";
            this.sendMailBtn.UseVisualStyleBackColor = true;
            this.sendMailBtn.Click += new System.EventHandler(this.sendMailBtn_Click);
            // 
            // tipsMail
            // 
            this.tipsMail.AutoSize = true;
            this.tipsMail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipsMail.ForeColor = System.Drawing.Color.Red;
            this.tipsMail.Location = new System.Drawing.Point(212, 145);
            this.tipsMail.Name = "tipsMail";
            this.tipsMail.Size = new System.Drawing.Size(0, 17);
            this.tipsMail.TabIndex = 18;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(453, 392);
            this.Controls.Add(this.tipsMail);
            this.Controls.Add(this.sendMailBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.tipsAll);
            this.Controls.Add(this.tips2);
            this.Controls.Add(this.tips3);
            this.Controls.Add(this.tips4);
            this.Controls.Add(this.tips5);
            this.Controls.Add(this.tips1);
            this.Controls.Add(this.activeCodeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repasswordTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.usernameTxt);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "RegisterForm";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox repasswordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox activeCodeTxt;
        private System.Windows.Forms.Label tips1;
        private System.Windows.Forms.Label tips5;
        private System.Windows.Forms.Label tips4;
        private System.Windows.Forms.Label tips3;
        private System.Windows.Forms.Label tips2;
        private System.Windows.Forms.Label tipsAll;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button sendMailBtn;
        private System.Windows.Forms.Label tipsMail;
    }
}