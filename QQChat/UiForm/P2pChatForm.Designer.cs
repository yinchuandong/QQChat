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
            this.messageRichBox = new Widget._RichTextBox.ExRichTextBox();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.faceBtn = new System.Windows.Forms.Button();
            this.sendRichBox = new Widget._RichTextBox.ExRichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.toolPanel.SuspendLayout();
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
            // P2pChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 449);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendRichBox);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.messageRichBox);
            this.Name = "P2pChatForm";
            this.Text = "P2pChatForm";
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Widget._RichTextBox.ExRichTextBox messageRichBox;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button faceBtn;
        private Widget._RichTextBox.ExRichTextBox sendRichBox;
        private System.Windows.Forms.Button sendBtn;
    }
}