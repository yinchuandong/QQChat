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
    public class FriendsDal
    {
       

        //返回用户的全部信息
        public SqlDataReader searchFriendByName(string name) 
        {
            string sqlStr = "select * from [user] where username like '%" + name + "%'";              
            SqlDataReader result = SqlDbHelper.ExecuteReader(sqlStr, CommandType.Text, null);
            return result;
        }
        //添加好友
        public bool addFriend(int u_id, int friend_id, string nickname, int g_id)
        {
            string sqlStr = "insert into [friend](u_id,friend_id,time,nickname,g_id) values (@u_id,@friend_id,@time,@nickname,@g_id)";
            List<SqlParameter> parameters = new List<SqlParameter>();

            SqlParameter u_ID = new SqlParameter("@u_id", SqlDbType.Int);
            SqlParameter f_ID = new SqlParameter("@friend_id", SqlDbType.Int);
            SqlParameter time = new SqlParameter("@time", SqlDbType.DateTime);
            SqlParameter nickName = new SqlParameter("@nickname", SqlDbType.VarChar);
            SqlParameter g_ID = new SqlParameter("@g_id", SqlDbType.Int);

            u_ID.Value = u_id;
            f_ID.Value = friend_id;
            time.Value = System.DateTime.Now;
            nickName.Value = nickname;
            g_ID.Value = g_id;

            parameters.Add(u_ID);
            parameters.Add(f_ID);
            parameters.Add(time);
            parameters.Add(nickName);
            parameters.Add(g_ID);

           int n = SqlDbHelper.ExecuteNoQuery(sqlStr, CommandType.Text, parameters);
           if (n > 0)
           {
               return true;
           }
           else 
           {
               return false;
           }        
        }

        //判断好友关系
        public bool IsFriend(int curr_ID,int search_ID ) 
        {
            string sql = "select count(*) from [friend] where u_id=@curr_ID and friend_id=@search_ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@curr_ID", SqlDbType.Int));
            parameters.Add(new SqlParameter("@search_ID", SqlDbType.Int));
            parameters[0].Value = curr_ID;
            parameters[1].Value = search_ID;
            int result = (int)SqlDbHelper.ExecuteScalar(sql, CommandType.Text, parameters);
            if (result == 1)
                return true;
            else
                return false;      
        }



    }
}
