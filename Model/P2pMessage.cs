using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class P2pMessage
    {
        private int mId;
        public int MId
        {
            get { return this.mId; }
            set { this.mId = value; }
        }

        private int hostId;
        public int HostId
        {
            get { return hostId; }
            set { this.hostId = value; }
        }

        private int guestId;
        public int GuestId
        {
            get { return guestId; }
            set { this.guestId = value; }
        }

        private string contents;
        public string Contents
        {
            get { return this.contents; }
            set { this.contents = value; }
        }

        private string time;
        public string Time
        {
            get {return this.time;}
            set { this.time = value; }
        }

        private string face;
        public string Face 
        {
            get { return this.face; }
            set {this.face = value;}
        }

        public string image;
        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
    }
}
