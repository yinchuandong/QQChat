using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

using Model;
using Util;
namespace SqlDal
{
   public class P2pMessageDal
    {     
       public bool addP2pMessage(Model.P2pMessage Message); //添加P2p消息       
       public Dictionary<int, ArrayList> getP2pMessage(int Uid);//查询离线的信息 
    }
}
