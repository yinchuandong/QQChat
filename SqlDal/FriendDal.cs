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
    }
}
