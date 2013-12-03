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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.faceBtn = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 208);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.faceBtn);
            this.panel1.Location = new System.Drawing.Point(2, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 34);
            this.panel1.TabIndex = 1;
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
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(3, 310);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(482, 105);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(405, 421);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(80, 28);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            // 
            // P2pChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 449);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "P2pChatForm";
            this.Text = "P2pChatForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button faceBtn;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button sendBtn;
    }
}