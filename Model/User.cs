using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class User
    {
        private int uId;
        public int UId
        {
            get { return this.uId; }
            set {this.uId = value; }
        }

        private string username="";
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        private string email = "";
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        private string password = "";
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        private int age = -1;
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        private int sex = -1;
        public int Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        private string sign = "";
        public string Sign
        {
            get { return this.sign; }
            set { this.sign = value; }
        }

        private string photo = "";
        public string Photo
        {
            get { return this.photo; }
            set { this.photo = value; }
        }

        private string lastLoginTime = "";
        public String LastLoginTime
        {
            get { return this.lastLoginTime; }
            set {this.lastLoginTime = value; }
        }

        private string lastLoginIp = "";
        public string LastLoginIp
        {
            get { return this.lastLoginIp; }
            set { this.lastLoginIp = value; }
        }

        private int status = -1;
        public int Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

    }
}
