using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public  class Chatroom
    {
        private int cId;
        public int CId
        {
            get { return this.cId; }
            set { this.cId = value; }
        }

        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private DateTime? time;
        public DateTime? Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        private int limitNum;
        public int LimitNum
        {
            get { return this.limitNum; }
            set { this.limitNum = value; }
        }

        private int leaderId;
        public int LeaderId
        {
            get { return this.leaderId; }
            set { this.leaderId = value; }
        }
        private int chatRoomPort;
        public int ChatRoomPort
        {
            get { return this.chatRoomPort; }
            set { this.chatRoomPort= value; }
        }
    }
}
