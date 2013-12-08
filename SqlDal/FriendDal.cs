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
    public class FriendDal
    {
        public FriendDal()
        {

        }

        public DataTable getOneFriend(int uId, int friendId)
        {
            string sql = "select f.friend_id as FriendId, f.g_id as GId, f.time as Time, f.nick_name as NickName, "
                + " u.[username] as FriendName" 
                + " from [friend] as f,[user] as u"
                + " where u.[u_id]=f.[friend_id] and f.friend_id=@FriendId and f.u_id=@UId";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter FriendId = new SqlParameter("@FriendId", SqlDbType.Int);
            FriendId.Value = friendId;
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            UId.Value = uId;
            parameters.Add(FriendId);
            parameters.Add(UId);

            DataTable result = SqlDbHelper.ExecueteDataTable(sql, CommandType.Text, parameters);
            return result;
        }

        public DataTable getFriendByGroup(int uId, int groupId)
        {
            string sql = "select f.friend_id as FriendId, f.g_id as GId, f.time as Time, f.nick_name as NickName, "
                + " u.[username] as FriendName"
                + " from [friend] as f,[user] as u"
                + " where u.[u_id]=f.[friend_id] and f.g_id=@GroupId and f.u_id=@UId";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter GroupId = new SqlParameter("@GroupId",SqlDbType.Int);
            GroupId.Value = groupId;
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            UId.Value = uId;
            parameters.Add(GroupId);
            parameters.Add(UId);
            DataTable result = SqlDbHelper.ExecueteDataTable(sql, CommandType.Text,parameters);
            return result;
        }

        public DataTable getAllFriend(int uId)
        {
            string sql = "select f.friend_id as FriendId, f.g_id as GId, f.time as Time, f.nick_name as NickName, "
               + " u.[username] as FriendName"
               + " from [friend] as f,[user] as u"
               + " where u.[u_id]=f.[friend_id] and f.u_id=@UId";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            UId.Value = uId;
            parameters.Add(UId);
            DataTable result = SqlDbHelper.ExecueteDataTable(sql, CommandType.Text, parameters);
            return result;
        }

        public int InsertFriend(Model.Friend friend)
        {
            String sql = "insert into friend (u_id,friend_id,g_id,time,nick_name) values"
                +" (@UId,@FriendId,@GId,@Time,@NickName)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            SqlParameter FriendId = new SqlParameter("@FriendId", SqlDbType.Int);
            SqlParameter GId = new SqlParameter("@GId", SqlDbType.Int);
            SqlParameter Time = new SqlParameter("@Time", SqlDbType.DateTime);
            SqlParameter NickName = new SqlParameter("@NickName", SqlDbType.VarChar, 50);
            UId.Value = friend.UId;
            FriendId.Value = friend.FriendId;
            GId.Value = friend.GId;
            Time.Value = friend.Time;
            NickName.Value = friend.NickName;
            parameters.Add(UId);
            parameters.Add(FriendId);
            parameters.Add(GId);
            parameters.Add(Time);
            parameters.Add(NickName);

            int result = SqlDbHelper.ExecuteNoQuery(sql, CommandType.Text, parameters);
            return result;
        }

        //判断好友关系
        public bool IsFriend(int curr_ID, int search_ID)
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

        //根据用户名查找用户
        public SqlDataReader searchFriendByName(string name)
        {
            string sqlStr = "select * from [user] where username like '%" + name + "%'";
            SqlDataReader result = SqlDbHelper.ExecuteReader(sqlStr, CommandType.Text, null);
            return result;
        }

        //查找用户
        public ArrayList searchUser(int currenID,string key)
        {
            ArrayList userList = new ArrayList();
            SqlDataReader reader = searchFriendByName(key);
            if (reader.HasRows)
            {
                User user;
                while (reader.Read())
                {
                    user = new User();
                    if (!(reader["u_id"] is System.DBNull))
                    {
                        user.UId = Convert.ToInt32(reader["u_id"].ToString().Trim());
                    }
                    if (!(reader["username"] is System.DBNull))
                    {
                        user.Username = reader["username"].ToString().Trim();
                    }
                    if (!(reader["age"] is System.DBNull))
                    {
                        user.Age = Convert.ToInt32(reader["age"].ToString().Trim());
                    }
                    if (!(reader["regTime"] is System.DBNull))
                    {
                        user.RegTime = Convert.ToDateTime(reader["regTime"].ToString());
                    }
                    if (!(reader["sex"] is System.DBNull))
                    {
                        user.Sex = Convert.ToInt32(reader["sex"].ToString().Trim());
                    }
                    if (!(reader["sign"] is System.DBNull))
                    {
                        user.Sign = reader["sign"].ToString();
                    }
                    if (!(reader["photo"] is System.DBNull))
                    {
                        user.Photo = reader["photo"].ToString();
                    }
                    if (!(reader["last_login_ip"] is System.DBNull))
                    {
                        user.LastLoginIp = reader["last_login_ip"].ToString();
                    }
                    if (!(reader["last_login_time"] is System.DBNull))
                    {
                        user.LastLoginTime = Convert.ToDateTime(reader["last_login_time"].ToString());
                    }
                    if (!(reader["status"] is System.DBNull))
                    {
                        user.Status = Convert.ToInt32(reader["status"].ToString());
                    }
                    if (user.UId != currenID)
                    {
                     userList.Add(user);
                    }
                   
                }
            }

            reader.Close();
            return userList;
        }

        
    }
}
