﻿namespace QQChat.UiForm
{
    partial class GroupChatForm
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
            this.GroupChat_Output = new System.Windows.Forms.RichTextBox();
            this.GroupChat_Input = new System.Windows.Forms.RichTextBox();
            this.headPicBox = new System.Windows.Forms.PictureBox();
            this.nameTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupChat_Output
            // 
            this.GroupChat_Output.Location = new System.Drawing.Point(-1, 81);
            this.GroupChat_Output.Name = "GroupChat_Output";
            this.GroupChat_Output.Size = new System.Drawing.Size(499, 215);
            this.GroupChat_Output.TabIndex = 0;
            this.GroupChat_Output.Text = "";
            // 
            // GroupChat_Input
            // 
            this.GroupChat_Input.Location = new System.Drawing.Point(0, 328);
            this.GroupChat_Input.Name = "GroupChat_Input";
            this.GroupChat_Input.Size = new System.Drawing.Size(498, 103);
            this.GroupChat_Input.TabIndex = 1;
            this.GroupChat_Input.Text = "";
            // 
            // headPicBox
            // 
            this.headPicBox.Location = new System.Drawing.Point(3, 2);
            this.headPicBox.Name = "headPicBox";
            this.headPicBox.Size = new System.Drawing.Size(84, 79);
            this.headPicBox.TabIndex = 2;
            this.headPicBox.TabStop = false;
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Location = new System.Drawing.Point(93, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(41, 12);
            this.nameTxt.TabIndex = 3;
            this.nameTxt.Text = "label1";
            // 
            // GroupChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 471);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.headPicBox);
            this.Controls.Add(this.GroupChat_Input);
            this.Controls.Add(this.GroupChat_Output);
            this.Name = "GroupChatForm";
            this.Text = "GroupChatForm";
            ((System.ComponentModel.ISupportInitialize)(this.headPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox GroupChat_Output;
        private System.Windows.Forms.RichTextBox GroupChat_Input;
        private System.Windows.Forms.PictureBox headPicBox;
        private System.Windows.Forms.Label nameTxt;
    }
}