using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class ChatroomMember
    {
        private int chatroomId;
        public int ChatroomId
        {
            get { return chatroomId; }
            set { this.chatroomId = value; }
        }

        private int uId;
        public int UId
        {
            get { return this.uId; }
            set { this.uId = value; }
        }

        private string time;
        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
    }
}
