using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Friend
    {
        private int uId;
        public int UId
        {
            get { return this.uId; }
            set {this.uId = value;}
        }

        private int friendId;
        public int FriendId
        {
            get { return friendId; }
            set { this.friendId = value;}
        }

        private string time;
        public string Time
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
