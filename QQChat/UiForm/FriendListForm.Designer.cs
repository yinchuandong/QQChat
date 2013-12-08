namespace QQChat.UiForm
{
    partial class FriendListForm
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.friendListBox = new Widget.ChatListBox();
            this.addFriendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // friendListBox
            // 
            this.friendListBox.BackColor = System.Drawing.Color.White;
            this.friendListBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.friendListBox.Location = new System.Drawing.Point(3, 3);
            this.friendListBox.Name = "friendListBox";
            this.friendListBox.Size = new System.Drawing.Size(235, 377);
            this.friendListBox.TabIndex = 0;
            this.friendListBox.Text = "friendListBox";
            this.friendListBox.DoubleClickSubItem += new Widget.ChatListBox.ChatListEventHandler(this.friendListBox_DoubleClickSubItem);
            this.friendListBox.MouseEnterHead += new Widget.ChatListBox.ChatListEventHandler(this.friendListBox_MouseEnterHead);
            // 
            // addFriendButton
            // 
            this.addFriendButton.Location = new System.Drawing.Point(148, 386);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(75, 23);
            this.addFriendButton.TabIndex = 1;
            this.addFriendButton.Text = "添加好友";
            this.addFriendButton.UseVisualStyleBackColor = true;
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // FriendListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 412);
<<<<<<< HEAD
            this.Controls.Add(this.addFriendButton);
=======
>>>>>>> f4834623f93eade1b69378474ef8482456ac5eb0
            this.Controls.Add(this.friendListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FriendListForm";
            this.Text = "FriendListForm";
            this.Load += new System.EventHandler(this.FriendListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Widget.ChatListBox friendListBox;
<<<<<<< HEAD
        private System.Windows.Forms.Button addFriendButton;
=======
        private System.IO.Ports.SerialPort serialPort1;
>>>>>>> f4834623f93eade1b69378474ef8482456ac5eb0
    }
}