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
            this.chatListBox = new Widget.ChatListBox();
            this.SuspendLayout();
            // 
            // chatListBox
            // 
            this.chatListBox.BackColor = System.Drawing.Color.White;
            this.chatListBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBox.Location = new System.Drawing.Point(12, 12);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.Size = new System.Drawing.Size(190, 433);
            this.chatListBox.TabIndex = 0;
            this.chatListBox.Text = "chatListBox";
            this.chatListBox.MouseEnterHead += new Widget.ChatListBox.ChatListEventHandler(this.chatListBox_MouseEnterHead);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 457);
            this.Controls.Add(this.chatListBox);
            this.Name = "MainForm";
            this.Text = "呵呵";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Widget.ChatListBox chatListBox;
    }
}

