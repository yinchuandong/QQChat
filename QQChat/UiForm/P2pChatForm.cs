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
using Socket;

using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap ;
using System.IO;

namespace QQChat.UiForm
{
    public partial class P2pChatForm : Form
    {
        
        #region 成员属性
        
        private int guestId = -1; //聊天对方的id
        private int hostId; // 用户自己的id
        private SessionBll session;
        private UserBll userBll = new UserBll();

        private ChatListSubItem guestItem; //当前对话方的实体
        private User guestModel; //当前对话用户的数据库信息
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
        private bool receiveFlag = true;

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
            this.guestId = guestItem.ID;
            initData();
            initSocket();
        }

        //初始化相关数据
        private void initData()
        {
            guestModel = userBll.getUser(guestItem.ID);
            headPicBox.Image = guestItem.HeadImage;
            nameTxt.Text = guestItem.DisplayName;
            signTxt.Text = guestItem.PersonalMsg;
            //clientSocket = new TcpClient(guestItem.IpAddress, 8009);
            //try
            //{
            //    P2pMessage msg = new P2pMessage();
            //    msg.Time = DateTime.Now;
            //    msg.GuestName = "";
            //    msg.Contents = "";
            //    appendText(msg);
            //    sendRichBox.Text = string.Empty;
            //}
            //catch (System.Exception ex)
            //{

            //}
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
            P2pMessage message = new P2pMessage();
            message.HostId = hostId;
            message.GuestId = guestItem.ID;
            message.GuestName = guestItem.DisplayName;
            message.Contents = msg;
            message.Time = DateTime.Now;
            this.send(message);
            this.appendText(message);
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            receiveFlag = false;
        }

        #endregion

        #region 初始化socket
        private void initSocket()
        {
            int guestId = guestItem.ID;
            if (P2pServerSocket.socketDict.ContainsKey(guestId))
            {
                TcpClient server = P2pServerSocket.socketDict[guestId];
                this.ServerSocket = server;
            }
            else
            {
                try
                {
                    string ip = guestModel.LastLoginIp;
                    TcpClient client = new TcpClient(ip, 8009);
                    P2pServerSocket.socketDict[guestId] = client;
                    byte[] buff = new byte[4096];
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine(session.User.UId); //告诉对方自己的id
                    writer.Flush();
                    this.ServerSocket = client;
                }
                catch (System.Exception ex)
                {

                }
            }
        }
        #endregion

        #region 接收对方的消息
        private void service()
        {
            while(receiveFlag)
            {
                P2pMessage msg = null; //接收到的信息对象，放这里主要是为了解决appendText的异步问题
                try
                {
                    this.serverSocket = P2pServerSocket.socketDict[guestId];
                    byte[] buff = new byte[4096];
                    MemoryStream mStream = new MemoryStream();
                    mStream.Position = 0;
                    NetworkStream nStream = serverSocket.GetStream();
                    while (true)
                    {
                        int len = nStream.Read(buff, 0, buff.Length);
                        mStream.Write(buff, 0, len);
                        if (len < 4096)
                        {
                            break;
                        }
                    }
                    BinaryFormatter formmater = new BinaryFormatter();
                    //DataContractSerializer formmater = new DataContractSerializer(typeof(P2pMessage));
                    //mStream.Flush();
                    mStream.Position = 0;
                    if (mStream.Capacity > 0)
                    {
                        //msg = (P2pMessage)formmater.ReadObject(mStream);
                        msg = formmater.Deserialize(mStream) as P2pMessage;
                        appendText(msg);
                    }
                }catch(System.Runtime.Serialization.SerializationException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                catch (System.ObjectDisposedException ex)
                {
                    string test = ex.Message;
                    //appendText(msg);
                }
                catch (System.Exception ex)//如果对方退出了程序
                {
                    if (serverSocket != null)
                    {
                        serverSocket.Close();
                        serverSocket = null;
                    }

                    if (P2pServerSocket.socketDict.ContainsKey(guestId))
                    {
                        P2pServerSocket.socketDict.Remove(guestId);
                    }
                    initSocket();
                    Thread.Sleep(1000);
                }
            }

        }

        public delegate void InvokeDelegate(P2pMessage msg);//事件委托，跨线程调用winform控件需要

        private void appendText(P2pMessage msg)//给messageBox添加
        {
            if (messageRichBox.InvokeRequired)
            {
                InvokeDelegate invoke = new InvokeDelegate(appendText);
                this.Invoke(invoke,new object[]{msg});
            }else{
                this.messageRichBox.AppendText(msg.GuestName + " [" + msg.Time.ToString() + "] \r\n");
                this.messageRichBox.AppendRtf(msg.Contents);
                this.messageRichBox.AppendTextAsRtf("\r\n");
                this.messageRichBox.ScrollToCaret();
            }
        }
        #endregion

        #region 发送给对方消息
        
        private void send(P2pMessage message)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                //DataContractSerializer formatter = new DataContractSerializer(message.GetType()) ;
                IFormatter formatter = new BinaryFormatter();
                //formatter.WriteObject(mStream, message);
                formatter.Serialize(mStream, message);
                mStream.Flush();
                mStream.Position = 0;
                byte[] buff = new byte[4096];
                int len = 0;
                NetworkStream nStream = serverSocket.GetStream();
                while ((len = mStream.Read(buff, 0, buff.Length)) > 0)
                {
                    nStream.Write(buff, 0, len);
                }
                mStream.Flush();
                mStream.Position = 0;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        #endregion


    }
}
