namespace QQChat.UiForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.banner = new System.Windows.Forms.PictureBox();
            this.register = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(70, 12);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(247, 107);
            this.banner.TabIndex = 6;
            this.banner.TabStop = false;
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Location = new System.Drawing.Point(193, 235);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(101, 12);
            this.register.TabIndex = 5;
            this.register.Text = "还没账号？去注册";
            this.register.Click += new System.EventHandler(this.register_Click);
            this.register.MouseLeave += new System.EventHandler(this.register_Leave);
            this.register.MouseHover += new System.EventHandler(this.register_Enter);
            // 
            // loginBtn
            // 
            this.loginBtn.BackgroundImage = global::QQChat.Properties.Resources.login;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginBtn.Location = new System.Drawing.Point(103, 215);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(84, 37);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(42, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(42, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "邮箱：";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordTxt.Location = new System.Drawing.Point(103, 178);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(171, 29);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.Text = "123456";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailTxt.Location = new System.Drawing.Point(103, 140);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(171, 29);
            this.emailTxt.TabIndex = 0;
            this.emailTxt.Text = "670467728@qq.com";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(396, 278);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.register);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailTxt);
            this.Name = "LoginForm";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.PictureBox banner;
    }
}