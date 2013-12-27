using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Collections;

using SqlDal;
using Model;
using Util;

namespace Bll
{
    public class P2pMessageBll
    {
        private P2pMessageDal MessageDal = new P2pMessageDal();
        //添加好友分组
        public bool addP2pMessage(Model.P2pMessage Message)
        {
            bool result = MessageDal.addP2pMessage(Message);
            return result;
        }

        //查询离线的信息 
        public Dictionary<int, ArrayList> getP2pMessage(int Uid)
        {
            Dictionary<int,ArrayList> result = MessageDal.getP2pMessage(Uid);
            return result;
        }
    }
}
