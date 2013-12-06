using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Friend
    {
        private int uId;
        public int UId
        {
            get { return this.uId; }
            set {this.uId = value;}
        }

        private int gId;
        public int GId
        {
            get { return this.gId; }
            set { this.gId = value; }
        }

        private int friendId;
        public int FriendId
        {
            get { return friendId; }
            set { this.friendId = value;}
        }

        private string friendName;
        public string FriendName
        {
            get { return this.friendName; }
            set { this.friendName = value; }
        }

        private DateTime? time;
        public DateTime? Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        private string nickName;
        public string NickName
        {
            get { return this.nickName; }
            set {this.nickName = value;}
        }


    }
}
