namespace QQChat.UiForm
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
            this.SuspendLayout();
            // 
            // GroupChat_Output
            // 
            this.GroupChat_Output.Location = new System.Drawing.Point(0, 53);
            this.GroupChat_Output.Name = "GroupChat_Output";
            this.GroupChat_Output.Size = new System.Drawing.Size(499, 215);
            this.GroupChat_Output.TabIndex = 0;
            this.GroupChat_Output.Text = "";
            // 
            // GroupChat_Input
            // 
            this.GroupChat_Input.Location = new System.Drawing.Point(0, 303);
            this.GroupChat_Input.Name = "GroupChat_Input";
            this.GroupChat_Input.Size = new System.Drawing.Size(498, 103);
            this.GroupChat_Input.TabIndex = 1;
            this.GroupChat_Input.Text = "";
            // 
            // GroupChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 449);
            this.Controls.Add(this.GroupChat_Input);
            this.Controls.Add(this.GroupChat_Output);
            this.Name = "GroupChatForm";
            this.Text = "GroupChatForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox GroupChat_Output;
        private System.Windows.Forms.RichTextBox GroupChat_Input;
    }
}