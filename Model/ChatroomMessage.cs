using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class ChatroomMessage
    {
        private int mId;
        public int MId
        {
            get { return this.mId; }
            set {this.mId = value;}
        }

        private int hostId;
        public int HostId
        {
            get { return this.hostId; }
            set { this.hostId = value; }
        }

        private int chatroomId;
        public int ChatroomId
        {
            get { return this.chatroomId; }
            set { this.chatroomId = value; }
        }

        private string contents;
        public string Contents
        {
            get { return this.contents; }
            set { this.contents = value; }
        }

        private DateTime? time;
        public DateTime? Time
        {
            get { return this.time; }
            set {this.time = value;}
        }

        private string image;
        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        private string face;
        public string Face
        {
            get { return this.face; }
            set { this.face = value; }
        }
    }
}
