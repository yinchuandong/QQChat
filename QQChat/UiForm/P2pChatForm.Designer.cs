namespace QQChat.UiForm
{
    partial class P2pChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P2pChatForm));
            this.messageRichBox = new Widget._RichTextBox.ExRichTextBox();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.faceBtn = new System.Windows.Forms.Button();
            this.sendRichBox = new Widget._RichTextBox.ExRichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.headPicBox = new System.Windows.Forms.PictureBox();
            this.nameTxt = new System.Windows.Forms.Label();
            this.signTxt = new System.Windows.Forms.Label();
            this.toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // messageRichBox
            // 
            this.messageRichBox.HiglightColor = Widget._RichTextBox.RtfColor.White;
            this.messageRichBox.Location = new System.Drawing.Point(2, 69);
            this.messageRichBox.Name = "messageRichBox";
            this.messageRichBox.Size = new System.Drawing.Size(484, 208);
            this.messageRichBox.TabIndex = 0;
            this.messageRichBox.Text = "";
            this.messageRichBox.TextColor = Widget._RichTextBox.RtfColor.Black;
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.faceBtn);
            this.toolPanel.Location = new System.Drawing.Point(2, 277);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(483, 34);
            this.toolPanel.TabIndex = 1;
            // 
            // faceBtn
            // 
            this.faceBtn.Location = new System.Drawing.Point(6, 3);
            this.faceBtn.Name = "faceBtn";
            this.faceBtn.Size = new System.Drawing.Size(55, 29);
            this.faceBtn.TabIndex = 0;
            this.faceBtn.Text = "表情";
            this.faceBtn.UseVisualStyleBackColor = true;
            this.faceBtn.Click += new System.EventHandler(this.faceBtn_Click);
            // 
            // sendRichBox
            // 
            this.sendRichBox.HiglightColor = Widget._RichTextBox.RtfColor.White;
            this.sendRichBox.Location = new System.Drawing.Point(3, 310);
            this.sendRichBox.Name = "sendRichBox";
            this.sendRichBox.Size = new System.Drawing.Size(482, 105);
            this.sendRichBox.TabIndex = 2;
            this.sendRichBox.Text = "";
            this.sendRichBox.TextColor = Widget._RichTextBox.RtfColor.Black;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(405, 421);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(80, 28);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // headPicBox
            // 
            this.headPicBox.Location = new System.Drawing.Point(3, 4);
            this.headPicBox.Name = "headPicBox";
            this.headPicBox.Size = new System.Drawing.Size(60, 60);
            this.headPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headPicBox.TabIndex = 4;
            this.headPicBox.TabStop = false;
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.BackColor = System.Drawing.Color.Transparent;
            this.nameTxt.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.nameTxt.Location = new System.Drawing.Point(75, 6);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(69, 25);
            this.nameTxt.TabIndex = 5;
            this.nameTxt.Text = "尹川东";
            // 
            // signTxt
            // 
            this.signTxt.AutoSize = true;
            this.signTxt.BackColor = System.Drawing.Color.Transparent;
            this.signTxt.Location = new System.Drawing.Point(83, 38);
            this.signTxt.Name = "signTxt";
            this.signTxt.Size = new System.Drawing.Size(89, 12);
            this.signTxt.TabIndex = 6;
            this.signTxt.Text = "今天天气好好啊";
            // 
            // P2pChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(498, 449);
            this.Controls.Add(this.signTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.headPicBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendRichBox);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.messageRichBox);
            this.Name = "P2pChatForm";
            this.Text = "两只呵呵的聊天";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.P2pChatForm_Load);
            this.toolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Widget._RichTextBox.ExRichTextBox messageRichBox;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button faceBtn;
        private Widget._RichTextBox.ExRichTextBox sendRichBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.PictureBox headPicBox;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label signTxt;
    }
}