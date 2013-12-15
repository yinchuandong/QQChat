using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Model;
using Util;


namespace SqlDal
{
   public  class ChatRoomDal
    {
       public bool createNewsRoom(Chatroom chatRoom) {

           string sql = "insert into [chatroom] (name,time,limit_num,leader_id) values (@Name,@Time,@Limit_num,@Leader_id)";

           List<SqlParameter> parameters = new List<SqlParameter>();
           parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));
           parameters.Add(new SqlParameter("@Time", SqlDbType.DateTime));
           parameters.Add(new SqlParameter("@Limit_num", SqlDbType.Int));
           parameters.Add(new SqlParameter("@Leader_id", SqlDbType.Int));

           parameters[0].Value = chatRoom.Name;
           parameters[1].Value = chatRoom.Time;
           parameters[2].Value = chatRoom.LimitNum;
           parameters[3].Value = chatRoom.LeaderId;

           int row = SqlDbHelper.ExecuteNoQuery(sql, CommandType.Text, parameters);
           if (row == 1)
           {
               return true;
           }
           else
           {
               return false;
           }
          
       }
    }
}
