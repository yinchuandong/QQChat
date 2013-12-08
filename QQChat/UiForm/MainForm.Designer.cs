namespace QQChat.UiForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Sign_label = new System.Windows.Forms.Label();
            this.NickName_label = new System.Windows.Forms.Label();
            this.tabControl = new Widget._TabControl.TabControlEx();
            this.friendPage = new System.Windows.Forms.TabPage();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sign_label
            // 
            this.Sign_label.AutoSize = true;
            this.Sign_label.Location = new System.Drawing.Point(124, 46);
            this.Sign_label.Name = "Sign_label";
            this.Sign_label.Size = new System.Drawing.Size(77, 12);
            this.Sign_label.TabIndex = 2;
            this.Sign_label.Text = "编辑个性签名";
            // 
            // NickName_label
            // 
            this.NickName_label.AutoSize = true;
            this.NickName_label.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NickName_label.ForeColor = System.Drawing.Color.Magenta;
            this.NickName_label.Location = new System.Drawing.Point(111, 12);
            this.NickName_label.Name = "NickName_label";
            this.NickName_label.Size = new System.Drawing.Size(115, 21);
            this.NickName_label.TabIndex = 3;
            this.NickName_label.Text = "用户的昵称";
            // 
            // tabControl
            // 
            this.tabControl.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.tabControl.Controls.Add(this.friendPage);
            this.tabControl.Controls.Add(this.groupPage);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(123, 25);
            this.tabControl.Location = new System.Drawing.Point(1, 78);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowClose = false;
            this.tabControl.Size = new System.Drawing.Size(254, 452);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 4;
            // 
            // friendPage
            // 
            this.friendPage.Location = new System.Drawing.Point(4, 29);
            this.friendPage.Name = "friendPage";
            this.friendPage.Padding = new System.Windows.Forms.Padding(3);
            this.friendPage.Size = new System.Drawing.Size(246, 419);
            this.friendPage.TabIndex = 0;
            this.friendPage.Text = "friendPage";
            this.friendPage.UseVisualStyleBackColor = true;
            // 
            // groupPage
            // 
            this.groupPage.Location = new System.Drawing.Point(4, 29);
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupPage.Size = new System.Drawing.Size(246, 419);
            this.groupPage.TabIndex = 1;
            this.groupPage.Text = "groupPage";
            this.groupPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 528);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.NickName_label);
            this.Controls.Add(this.Sign_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "呵呵";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Sign_label;
        private System.Windows.Forms.Label NickName_label;
        private Widget._TabControl.TabControlEx tabControl;
        private System.Windows.Forms.TabPage friendPage;
        private System.Windows.Forms.TabPage groupPage;
    }
}

