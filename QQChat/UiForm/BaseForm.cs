using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QQChat.UiForm
{
    public class BaseForm:Form
    {

        private void InitEvent()
        {
            this.SuspendLayout();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.ResumeLayout(false);
        }

        public BaseForm()
        {
            this.InitEvent();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
