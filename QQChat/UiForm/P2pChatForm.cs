using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Widget._ImagePopup;

namespace QQChat.UiForm
{
    public partial class P2pChatForm : Form
    {
        public P2pChatForm()
        {
            InitializeComponent();
        }

        private ImagePopup faceForm = null;
        public ImagePopup FaceForm
        {
            get
            {
                if (this.faceForm == null)
                {
                    this.faceForm = new ImagePopup
                    {
                        ImagePath = "Face\\",
                        CustomImagePath = "Face\\Custom\\",
                        CanManage = true,
                        ShowDemo = true,
                    };

                    this.faceForm.Init(24, 24, 8, 8, 12, 8);
                    this.faceForm.Selected += this.faceForm_AddFace;

                }

                return this.faceForm;
            }
        }

        string faceName = "";//选择的表情的名字
        //表情框选择了表情之后的事件
        void faceForm_AddFace(object sender, SelectFaceArgs e)
        {
            this.faceName = e.Img.FullName.Replace(Application.StartupPath + "\\", "");
            this.sendRichBox.InsertImage(e.Img.Image);
        }

        //显示表情button按钮
        private void faceBtn_Click(object sender, EventArgs e)
        {
            Point pt = this.PointToScreen(new Point(((Button)sender).Left, ((Button)sender).Height + 5));
            this.FaceForm.Show(pt.X, pt.Y, ((Button)sender).Height);
        }

        //发送消息的button
        private void sendBtn_Click(object sender, EventArgs e)
        {
            string msg = sendRichBox.Rtf;
            sendRichBox.Text = String.Empty;
            messageRichBox.AppendRtf(msg);
            messageRichBox.ScrollToCaret();
        }
    }
}
