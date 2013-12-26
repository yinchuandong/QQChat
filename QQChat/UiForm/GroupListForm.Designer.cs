using Widget._ChatListBox;
namespace QQChat.UiForm
{
    partial class GroupListForm
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
            this.newGroup_button = new System.Windows.Forms.Button();
            this.groupListBox = new Widget.ChatListBox();
            this.SuspendLayout();
            // 
            // newGroup_button
            // 
            this.newGroup_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newGroup_button.Location = new System.Drawing.Point(3, 369);
            this.newGroup_button.Name = "newGroup_button";
            this.newGroup_button.Size = new System.Drawing.Size(235, 38);
            this.newGroup_button.TabIndex = 1;
            this.newGroup_button.Text = "群组管理";
            this.newGroup_button.UseVisualStyleBackColor = true;
            this.newGroup_button.Click += new System.EventHandler(this.newGroup_button_Click);
            // 
            // groupListBox
            // 
            this.groupListBox.BackColor = System.Drawing.Color.White;
            this.groupListBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupListBox.Location = new System.Drawing.Point(3, 0);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(235, 363);
            this.groupListBox.TabIndex = 2;
            this.groupListBox.Text = "groupListBox";
            this.groupListBox.DoubleClickSubItem += new Widget.ChatListBox.ChatListEventHandler(this.GroupListBox_DoubleClickSubItem);
            // 
            // GroupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(235, 406);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.newGroup_button);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupListForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "GroupListForm";
            this.Load += new System.EventHandler(this.GroupListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGroup_button;
        private Widget.ChatListBox groupListBox;
        public ChatListItem listItem;
    }
}