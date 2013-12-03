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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new Widget._TabControl.TabControlEx();
            this.friendPage = new System.Windows.Forms.TabPage();
            this.friendListBox = new Widget.ChatListBox();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.friendPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "编辑个性签名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户的昵称";
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
            this.friendPage.Controls.Add(this.friendListBox);
            this.friendPage.Location = new System.Drawing.Point(4, 29);
            this.friendPage.Name = "friendPage";
            this.friendPage.Padding = new System.Windows.Forms.Padding(3);
            this.friendPage.Size = new System.Drawing.Size(246, 419);
            this.friendPage.TabIndex = 0;
            this.friendPage.Text = "friendPage";
            this.friendPage.UseVisualStyleBackColor = true;
            // 
            // friendListBox
            // 
            this.friendListBox.BackColor = System.Drawing.Color.White;
            this.friendListBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.friendListBox.Location = new System.Drawing.Point(3, 3);
            this.friendListBox.Name = "friendListBox";
            this.friendListBox.Size = new System.Drawing.Size(235, 406);
            this.friendListBox.TabIndex = 0;
            this.friendListBox.Text = "friendListBox";
            this.friendListBox.DoubleClickSubItem += new Widget.ChatListBox.ChatListEventHandler(this.friendListBox_DoubleClickSubItem);
            this.friendListBox.MouseEnterHead += new Widget.ChatListBox.ChatListEventHandler(this.friendListBox_MouseEnterHead);
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 528);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "呵呵";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.friendPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Widget._TabControl.TabControlEx tabControl;
        private System.Windows.Forms.TabPage friendPage;
        private System.Windows.Forms.TabPage groupPage;
        private Widget.ChatListBox friendListBox;
    }
}

