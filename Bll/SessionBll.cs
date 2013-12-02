using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Model;

namespace Bll
{
    public class SessionBll
    {
        private static SessionBll session = null;
        public static SessionBll GetInstance()
        {
            if(session == null)
            {
                session = new SessionBll();
            }
            return session;
        }

        private User user = null;
        public User User
        {
            get { return this.user; }
            set { this.user = value; }
        }

        private bool isLogin = false;
        public bool IsLogin
        {
            get { return this.isLogin; }
            set { this.isLogin = value; }
        }
    }
}
