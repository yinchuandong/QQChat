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
   
      public int addChatRoom(Model.Chatroom chatroom)
        {
            string sql = "insert into [chatroom] ([name],[time],[limit_num],[leader_id]) values (@Name,@Time,@LimitNum,@LeaderId)" ;
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            SqlParameter Time= new SqlParameter("@Time", SqlDbType.DateTime);
            SqlParameter LimitNum = new SqlParameter("@LimitNum", SqlDbType.Int);
            SqlParameter LeaderId = new SqlParameter("@LeaderId", SqlDbType.Int);
            SqlParameter CId = new SqlParameter("@CId", SqlDbType.Int);
            
            
            Name.Value = chatroom.Name;
            parameters.Add(Name);
            Time.Value = chatroom.Time;
            parameters.Add(Time);
            LimitNum.Value = chatroom.LimitNum;
            parameters.Add(LimitNum);
            LeaderId.Value = chatroom.LeaderId;
            parameters.Add(LeaderId);
            CId.Value = chatroom.CId;
            parameters.Add(CId);

            int id = 0;
            int result = SqlDbHelper.ExecuteNoQuery(sql, CommandType.Text, parameters);            
            return id;
        }

      //查询最新插入的chatRoom的id
      public int getLasteID() 
      {
          string sqlStr = "select top 1 c_id from [chatRoom] order by time Desc ;";
          int id = 0;
          SqlDataReader reader = SqlDbHelper.ExecuteReader(sqlStr, CommandType.Text, null);
          if (reader.HasRows)
          {

              while (reader.Read())
              {
                  id = Convert.ToInt32(reader["c_id"].ToString());
              }
          }
               
          return id;
      
      }





      public int addChatRoomMember(Model.Chatroom chatroom)
      {
          string sql = "insert into [chatroom_member] ([chatroom_id],[time],[u_id]) values (@CId,@Time,@LeaderId)";
          List<SqlParameter> parameters = new List<SqlParameter>();
          SqlParameter CId = new SqlParameter("@CId", SqlDbType.Int);
          SqlParameter Time = new SqlParameter("@Time", SqlDbType.DateTime);
          SqlParameter LeaderId = new SqlParameter("@LeaderId", SqlDbType.Int);

          Time.Value = chatroom.Time;
          parameters.Add(Time);
          LeaderId.Value = chatroom.LeaderId;
          parameters.Add(LeaderId);
          CId.Value = chatroom.CId;
          parameters.Add(CId);

          int result = SqlDbHelper.ExecuteNoQuery(sql, CommandType.Text, parameters);
          return result;
      }
}
}