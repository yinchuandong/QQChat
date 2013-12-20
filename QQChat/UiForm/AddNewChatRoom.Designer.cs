namespace QQChat.UiForm
{
    partial class AddNewChatRoom
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
            this.searchChatRoom = new System.Windows.Forms.TabControl();
            this.newPage = new System.Windows.Forms.TabPage();
            this.Sure_button = new System.Windows.Forms.Button();
            this.LimitNum_comboBox = new System.Windows.Forms.ComboBox();
            this.ChatroomName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.chatRoomListView = new System.Windows.Forms.ListView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchRoomBut = new System.Windows.Forms.Button();
            this.searchChatRoom.SuspendLayout();
            this.newPage.SuspendLayout();
            this.searchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchChatRoom
            // 
            this.searchChatRoom.Controls.Add(this.newPage);
            this.searchChatRoom.Controls.Add(this.searchPage);
            this.searchChatRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchChatRoom.ItemSize = new System.Drawing.Size(123, 25);
            this.searchChatRoom.Location = new System.Drawing.Point(0, 0);
            this.searchChatRoom.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.searchChatRoom.Name = "searchChatRoom";
            this.searchChatRoom.SelectedIndex = 0;
            this.searchChatRoom.Size = new System.Drawing.Size(446, 408);
            this.searchChatRoom.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.searchChatRoom.TabIndex = 4;
            // 
            // newPage
            // 
            this.newPage.BackColor = System.Drawing.Color.Transparent;
            this.newPage.Controls.Add(this.Sure_button);
            this.newPage.Controls.Add(this.LimitNum_comboBox);
            this.newPage.Controls.Add(this.ChatroomName_textBox);
            this.newPage.Controls.Add(this.label2);
            this.newPage.Controls.Add(this.label1);
            this.newPage.Font = new System.Drawing.Font("宋体", 9F);
            this.newPage.Location = new System.Drawing.Point(4, 29);
            this.newPage.Name = "newPage";
            this.newPage.Padding = new System.Windows.Forms.Padding(3);
            this.newPage.Size = new System.Drawing.Size(438, 375);
            this.newPage.TabIndex = 0;
            this.newPage.Text = "新建群";
            this.newPage.ToolTipText = "点击搜索";
            // 
            // Sure_button
            // 
            this.Sure_button.Location = new System.Drawing.Point(291, 214);
            this.Sure_button.Name = "Sure_button";
            this.Sure_button.Size = new System.Drawing.Size(73, 26);
            this.Sure_button.TabIndex = 9;
            this.Sure_button.Text = "确定";
            this.Sure_button.UseVisualStyleBackColor = true;
            this.Sure_button.Click += new System.EventHandler(this.Sure_button_Click);
            // 
            // LimitNum_comboBox
            // 
            this.LimitNum_comboBox.FormattingEnabled = true;
            this.LimitNum_comboBox.Items.AddRange(new object[] {
            "20",
            "60",
            "100",
            "200"});
            this.LimitNum_comboBox.Location = new System.Drawing.Point(176, 144);
            this.LimitNum_comboBox.Name = "LimitNum_comboBox";
            this.LimitNum_comboBox.Size = new System.Drawing.Size(59, 20);
            this.LimitNum_comboBox.TabIndex = 8;
            // 
            // ChatroomName_textBox
            // 
            this.ChatroomName_textBox.Location = new System.Drawing.Point(176, 86);
            this.ChatroomName_textBox.Name = "ChatroomName_textBox";
            this.ChatroomName_textBox.Size = new System.Drawing.Size(135, 21);
            this.ChatroomName_textBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(112, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "群容量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "群名：";
            // 
            // searchPage
            // 
            this.searchPage.BackColor = System.Drawing.Color.Transparent;
            this.searchPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPage.Controls.Add(this.chatRoomListView);
            this.searchPage.Controls.Add(this.nameTextBox);
            this.searchPage.Controls.Add(this.label3);
            this.searchPage.Controls.Add(this.searchRoomBut);
            this.searchPage.Location = new System.Drawing.Point(4, 29);
            this.searchPage.Name = "searchPage";
            this.searchPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPage.Size = new System.Drawing.Size(438, 375);
            this.searchPage.TabIndex = 1;
            this.searchPage.Text = "群搜索";
            this.searchPage.ToolTipText = "点击群";
            // 
            // chatRoomListView
            // 
            this.chatRoomListView.Location = new System.Drawing.Point(47, 79);
            this.chatRoomListView.Name = "chatRoomListView";
            this.chatRoomListView.Size = new System.Drawing.Size(340, 265);
            this.chatRoomListView.TabIndex = 7;
            this.chatRoomListView.UseCompatibleStateImageBehavior = false;
            this.chatRoomListView.SelectedIndexChanged += new System.EventHandler(this.chatRoomListView_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(47, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(238, 21);
            this.nameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "查找群(请输入需要寻找群的名字)";
            // 
            // searchRoomBut
            // 
            this.searchRoomBut.Location = new System.Drawing.Point(315, 41);
            this.searchRoomBut.Name = "searchRoomBut";
            this.searchRoomBut.Size = new System.Drawing.Size(75, 23);
            this.searchRoomBut.TabIndex = 4;
            this.searchRoomBut.Text = " 查找";
            this.searchRoomBut.UseVisualStyleBackColor = true;
            this.searchRoomBut.Click += new System.EventHandler(this.searchRoomBut_Click);
            // 
            // AddNewChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 408);
            this.Controls.Add(this.searchChatRoom);
            this.Name = "AddNewChatRoom";
            this.Text = "群组管理";
            this.Load += new System.EventHandler(this.NewChatRoomForm_Load);
            this.searchChatRoom.ResumeLayout(false);
            this.newPage.ResumeLayout(false);
            this.newPage.PerformLayout();
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl searchChatRoom;
        private System.Windows.Forms.TabPage newPage;
        private System.Windows.Forms.TabPage searchPage;
        private System.Windows.Forms.Button Sure_button;
        private System.Windows.Forms.ComboBox LimitNum_comboBox;
        private System.Windows.Forms.TextBox ChatroomName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView chatRoomListView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchRoomBut;
    }
}