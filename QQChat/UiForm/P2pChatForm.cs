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

using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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

        private TcpClient serverSocket = null;
        public TcpClient ServerSocket
        {
            get { return this.serverSocket; }
            set { this.serverSocket = value; }
        }

      

        private Thread receiveThread;

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
            //clientSocket = new TcpClient(guestItem.IpAddress, 8009);
        }

        #endregion

        #region 绑定的事件

        //界面加载完成事件
        private void P2pChatForm_Load(object sender, EventArgs e)
        {
            receiveThread = new Thread(new ThreadStart(service));
            receiveThread.Start();
        }

        //表情框选择了表情之后的事件
        void faceForm_AddFace(object sender, SelectFaceArgs e)
        {
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
            P2pMessage message = new P2pMessage();
            message.HostId = hostId;
            message.GuestId = guestItem.ID;
            message.GuestName = guestItem.DisplayName;
            message.Contents = sendRichBox.Rtf;
            message.Time = DateTime.Now;
            this.send(message);
        }

        #endregion

        #region 接收对方的消息
        private void service()
        {
            while(true)
            {
                try
                {
                    byte[] buff = new byte[1024];
                    MemoryStream mStream = new MemoryStream();
                    mStream.Position = 0;
                    NetworkStream nStream = serverSocket.GetStream();
                    while (true)
                    {
                        int len = nStream.Read(buff, 0, buff.Length);
                        mStream.Write(buff, 0, len);
                        if (len < 1024)
                        {
                            break;
                        }
                    }
                    BinaryFormatter formmater = new BinaryFormatter();
                    mStream.Flush();
                    mStream.Position = 0;
                    if (mStream.Capacity > 0)
                    {
                        P2pMessage msg = (P2pMessage)formmater.Deserialize(mStream);
                        appendText(msg.GuestName + "[" + msg.Time.ToString() + "] \r\n" + msg.Contents);
                    }
                }
                catch (System.Exception ex)
                {
                    //MessageBox.Show("对方不在线");
                }
            }

        }

        public delegate void InvokeDelegate(string str);//事件委托，跨线程调用winform控件需要

        private void appendText(String text)//给messageBox添加
        {
            if (messageRichBox.InvokeRequired)
            {
                InvokeDelegate invoke = new InvokeDelegate(appendText);
                this.Invoke(invoke,new object[]{text});
            }else{
                this.messageRichBox.AppendText(text);
            }
        }
        #endregion

        #region 发送给对方消息
        
        private void send(P2pMessage message)
        {
            MemoryStream mStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(mStream,message);
            mStream.Flush();
            mStream.Position = 0;
            byte[] buff = new byte[1024];
            int len = 0;
            NetworkStream nStream = serverSocket.GetStream();
            while ((len = mStream.Read(buff,0,buff.Length)) > 0)
            {
                nStream.Write(buff, 0, len);
            }
        }

        #endregion

    }
}
