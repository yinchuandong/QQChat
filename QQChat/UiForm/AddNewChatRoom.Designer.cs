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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChatroomName_textBox = new System.Windows.Forms.TextBox();
            this.LimitNum_comboBox = new System.Windows.Forms.ComboBox();
            this.Sure_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "群名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "群容量：";
            // 
            // ChatroomName_textBox
            // 
            this.ChatroomName_textBox.Location = new System.Drawing.Point(84, 43);
            this.ChatroomName_textBox.Name = "ChatroomName_textBox";
            this.ChatroomName_textBox.Size = new System.Drawing.Size(135, 21);
            this.ChatroomName_textBox.TabIndex = 2;
            // 
            // LimitNum_comboBox
            // 
            this.LimitNum_comboBox.FormattingEnabled = true;
            this.LimitNum_comboBox.Items.AddRange(new object[] {
            "20",
            "60",
            "100",
            "200"});
            this.LimitNum_comboBox.Location = new System.Drawing.Point(84, 101);
            this.LimitNum_comboBox.Name = "LimitNum_comboBox";
            this.LimitNum_comboBox.Size = new System.Drawing.Size(59, 20);
            this.LimitNum_comboBox.TabIndex = 3;
            // 
            // Sure_button
            // 
            this.Sure_button.Location = new System.Drawing.Point(199, 171);
            this.Sure_button.Name = "Sure_button";
            this.Sure_button.Size = new System.Drawing.Size(73, 26);
            this.Sure_button.TabIndex = 4;
            this.Sure_button.Text = "确定";
            this.Sure_button.UseVisualStyleBackColor = true;
            this.Sure_button.Click += new System.EventHandler(this.Sure_button_Click);
            // 
            // AddNewChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.Sure_button);
            this.Controls.Add(this.LimitNum_comboBox);
            this.Controls.Add(this.ChatroomName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewChatRoom";
            this.Text = "AddChatRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ChatroomName_textBox;
        private System.Windows.Forms.ComboBox LimitNum_comboBox;
        private System.Windows.Forms.Button Sure_button;
    }
}