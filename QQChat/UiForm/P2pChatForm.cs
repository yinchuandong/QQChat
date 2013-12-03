using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Widget._ImagePopup;
using Model;
using Bll;
using Widget._ChatListBox;

namespace QQChat.UiForm
{
    public partial class P2pChatForm : Form
    {
        
        #region 成员属性
        
        private int guestId = -1; //聊天对方的id
        private int hostId; // 用户自己的id
        private SessionBll session;

        private ChatListSubItem guestItem; //当前对话方的实体
        private ImagePopup faceForm = null;
        //表情框
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

        #endregion

        #region 成员方法

        public P2pChatForm()
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            hostId = session.User.UId;
        }
        public P2pChatForm(ChatListSubItem guestItem)
        {
            InitializeComponent();
            session = SessionBll.GetInstance();
            hostId = session.User.UId;
            this.guestItem = guestItem;
            initData();
        }

        //初始化相关数据
        private void initData()
        {
            headPicBox.Image = guestItem.HeadImage;
            nameTxt.Text = guestItem.DisplayName;
            signTxt.Text = guestItem.PersonalMsg;
        }
        #endregion

        #region 绑定的事件

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

        #endregion
    }
}
