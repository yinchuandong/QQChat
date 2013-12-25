using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

using Model;
using Util;


namespace SqlDal
{
   public class ChatRoomMemberDal
    {

       public DataTable getChatRoomDetail(int uId)//获得所在的每个群组具体信息
       {
           string sql = "select [chatRoom].c_id as  CId, [chatRoom].name as Name, [chatRoom].time as Time, [chatRoom].limit_num as LimitNum,[chatRoom].leader_id as LeaderID,[chatRoom].chatroom_port as ChatRoomPort  from [chatroom],[chatroom_member] where [chatRoom].[c_id]=[chatroom_member].chatroom_id and [chatroom_member].u_id=@UId";
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
            
            Name.Value = chatroom.Name;
            parameters.Add(Name);
            Time.Value = chatroom.Time;
            parameters.Add(Time);
            LimitNum.Value = chatroom.LimitNum;
            parameters.Add(LimitNum);
            LeaderId.Value = chatroom.LeaderId;
            parameters.Add(LeaderId);
            int result = SqlDbHelper.ExecuteNoQuery(sql, CommandType.Text, parameters);
            setPort();//设置端口号
            return result;
        }
       //设置chatPoomport
      public bool setPort() 
      {
          int c_id=getLasteID();
          int port =c_id+10000;
          string sqlStr = "update [chatroom] set chatroom_port =" + port + " where c_id =" + c_id;
          int row = SqlDbHelper.ExecuteNoQuery(sqlStr, CommandType.Text, null);
          if (row >= 1)
              return true;
          else
              return false;
      }

      //查询最新插入的chatRoom的id
      public int getLasteID() 
      {
          string sqlStr = "select top 1 [c_id] as c_id  from [chatRoom] order by time Desc";
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
       //增加群组成员
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
      //判断当前群名字是否存在
      public bool isExist(string Name)
      {
          string sql = "select COUNT(*) as num from [chatroom] where [name] =@Name";
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));
          parameters[0].Value = Name;
          int result = (int)SqlDbHelper.ExecuteScalar(sql, CommandType.Text, parameters);
          if (result == 1)
              return true;
          else
              return false;
      }

       //搜索群
      public SqlDataReader searchChatRoomByName(string Name)
      {
          string sqlStr = "select [c_id] as [c_id],[name] as [name],[chatroom].[time] as [time],[limit_num] as [limit_num],[leader_id] as [leader_id],[u_id] as [u_id] from [chatroom],[chatroom_member] where [chatroom].[c_id] = [chatroom_member].chatroom_id and [chatroom].name like '%" + Name + "%'";
          SqlDataReader result = SqlDbHelper.ExecuteReader(sqlStr, CommandType.Text, null);
          return result;
      }
      //查找聊天室
      public ArrayList searchChatRoom(string key)
      {
          ArrayList chatRoomList = new ArrayList();
          SqlDataReader reader = searchChatRoomByName(key);
          if (reader.HasRows)
          {
              Chatroom chatroom; 
              while (reader.Read())
              {
                  chatroom = new Chatroom();
                  if (!(reader["c_id"] is System.DBNull))
                  {
                      chatroom.CId = Convert.ToInt32(reader["c_id"].ToString().Trim());
                  }
                  if (!(reader["name"] is System.DBNull))
                  {
                      chatroom.Name = reader["name"].ToString().Trim();
                  }
                  if (!(reader["time"] is System.DBNull))
                  {
                      chatroom.Time = Convert.ToDateTime(reader["time"].ToString());
                  }
                  if (!(reader["limit_num"] is System.DBNull))
                  {
                      chatroom.LimitNum = Convert.ToInt32(reader["limit_num"].ToString().Trim());
                  }
                  if (!(reader["leader_id"] is System.DBNull))
                  {
                      chatroom.LeaderId = Convert.ToInt32(reader["leader_id"].ToString());
                  }

                  chatRoomList.Add(chatroom);

              }
          }

          reader.Close();
          return chatRoomList;
      }
      //查找当前聊天室的人数
      public int searchNum(int id) 
      {
          string sql = "select COUNT (*) as [num] from  [chatroom_member] where [chatroom_id]=@ID";
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
          parameters[0].Value = id;
          int result = (int)SqlDbHelper.ExecuteScalar(sql, CommandType.Text, parameters);
          return result;
      }

      //查找群主信息
      public DataTable searchLeader(int uId)
      {
          string sql = "select * from [user] where [user].u_id=@UId";
          List<SqlParameter> parameters = new List<SqlParameter>();
          SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
          UId.Value = uId;
          parameters.Add(UId);
          DataTable result = SqlDbHelper.ExecueteDataTable(sql, CommandType.Text, parameters);
          return result;
      }
       //判断是否是群成员
      public bool isMember(int UId,int c_id) 
      {
          string sql = "select COUNT (*) as num  from  [chatroom_member] where [chatroom_id]=@chatroom_id and [u_id]=@UId";
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(new SqlParameter("@chatroom_id", SqlDbType.Int));
          parameters.Add(new SqlParameter("@UId", SqlDbType.Int));
          parameters[0].Value = c_id;
          parameters[1].Value = UId;
          int result = (int)SqlDbHelper.ExecuteScalar(sql, CommandType.Text, parameters);
          if (result != 1)
          {
              return false;
          }
          else {
              return true;
          }
      
      }
       //加入已存在的群聊天室
      public bool addMember(int UId, int c_id) 
      {
          string sql = "insert into [chatroom_member] ([chatroom_id],[time],[u_id]) values (@CId,@Time,@LeaderId)";
          List<SqlParameter> parameters = new List<SqlParameter>();
          SqlParameter CId = new SqlParameter("@CId", SqlDbType.Int);
          SqlParameter Time = new SqlParameter("@Time", SqlDbType.DateTime);
          SqlParameter LeaderId = new SqlParameter("@LeaderId", SqlDbType.Int);

          Time.Value = System.DateTime.Now;
          parameters.Add(Time);
          LeaderId.Value = UId;
          parameters.Add(LeaderId);
          CId.Value = c_id;
          parameters.Add(CId);

          int result = SqlDbHelper.ExecuteNoQuery(sql, CommandType.Text, parameters);
          if (result!=1)
          {
              return false;
          }
          else
          {
              return true;
          }
      }
        //发起群组聊天，查找群内成员在线人员IP
      public ArrayList searchIp(int Cid)
      {
          string sqlStr = "select last_login_ip from [user] where status=1 and u_id in (select u_id from [chatroom_member] where chatroom_id=@Cid)";
          ArrayList onlineIp = new ArrayList();
          List<SqlParameter> parameters = new List<SqlParameter>();
          SqlParameter chatroom_id = new SqlParameter("@Cid", SqlDbType.Int);
          chatroom_id.Value = Cid;
          parameters.Add(chatroom_id);
          SqlDataReader reader = SqlDbHelper.ExecuteReader(sqlStr, CommandType.Text, parameters);
          if (reader.HasRows)
          {

              while (reader.Read())
              {
                  onlineIp.Add(reader["last_login_ip"].ToString());
              }
          }

          return onlineIp;
      }
     

    }
}