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
   public class ChatRoomMemberDal
    {

       public DataTable getChatRoomDetail(int uId)//获得每个群组具体信息
       {
           string sql = "select c.c_id as  CId, c.name as Name, c.time as Time, c.limit_num as LimitNum,c.leader_id as LeaderID "
               + " from [chatroom] as c,[chatroom_member] as cm"
               + " where c.[c_id]=cm.[chatroom_id] and cm.u_id=@UId";
           List<SqlParameter> parameters = new List<SqlParameter>();
           SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
           UId.Value = uId;
           parameters.Add(UId);
           DataTable result = SqlDbHelper.ExecueteDataTable(sql, CommandType.Text, parameters);
           return result;
       }
    }
}
