namespace QQChat.UiForm
{
    partial class AddFriendsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFriendsForm));
            this.chechFrinedsBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.friendsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // chechFrinedsBut
            // 
            this.chechFrinedsBut.Location = new System.Drawing.Point(301, 36);
            this.chechFrinedsBut.Name = "chechFrinedsBut";
            this.chechFrinedsBut.Size = new System.Drawing.Size(75, 23);
            this.chechFrinedsBut.TabIndex = 0;
            this.chechFrinedsBut.Text = " 查找";
            this.chechFrinedsBut.UseVisualStyleBackColor = true;
            this.chechFrinedsBut.Click += new System.EventHandler(this.chechFrinedsBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查找好友(请输入需要寻找用户的昵称)";
            // 
            // checkTextBox
            // 
            this.checkTextBox.Location = new System.Drawing.Point(33, 38);
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.Size = new System.Drawing.Size(238, 21);
            this.checkTextBox.TabIndex = 2;
            // 
            // friendsListView
            // 
            this.friendsListView.Location = new System.Drawing.Point(35, 74);
            this.friendsListView.Name = "friendsListView";
            this.friendsListView.Size = new System.Drawing.Size(340, 265);
            this.friendsListView.TabIndex = 3;
            this.friendsListView.UseCompatibleStateImageBehavior = false;
            this.friendsListView.SelectedIndexChanged += new System.EventHandler(this.friendsListView_SelectedIndexChanged);
            // 
            // AddFriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 364);
            this.Controls.Add(this.friendsListView);
            this.Controls.Add(this.checkTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chechFrinedsBut);
            this.Name = "AddFriendsForm";
            this.Text = "查找好友";
            this.Load += new System.EventHandler(this.AddFriendsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chechFrinedsBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.ListView friendsListView;
    }
}