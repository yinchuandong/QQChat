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
    public class GroupMemberDal
    {
        //插入组成员
         public bool insertGroupMember(GroupMember groupMember)
        {
            string sqlStr = "insert into [group_member](group_id,time,u_id) values(@G_ID,@Time,@UId)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter G_ID = new SqlParameter("@G_ID", SqlDbType.Int);
            SqlParameter Time = new SqlParameter("@Time", SqlDbType.DateTime);
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            G_ID.Value = groupMember.GroupId;
            Time.Value = groupMember.Time;
            UId.Value = groupMember.UId;
            parameters.Add(G_ID);
            parameters.Add(Time);
            parameters.Add(UId);

            int row = SqlDbHelper.ExecuteNoQuery(sqlStr, CommandType.Text, parameters);
            if (row >= 1)
                return false;
            else
                return false;
        }
   


        //获得到用户组别的g_ID
        public int get_g_ID(int uId,string name)
        {
            int g_id = 0;
            string sqlStr = "select g_id from [group] where u_id=@UId and name=@Name";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar);
            UId.Value = uId;
            Name.Value = name;
            parameters.Add(UId);
            parameters.Add(Name);

            SqlDataReader reader = SqlDbHelper.ExecuteReader(sqlStr, CommandType.Text, parameters);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (!(reader["g_id"] is System.DBNull))
                    {
                        g_id = Convert.ToInt32(reader["g_id"].ToString().Trim());
                    }
                }
            }
            return g_id;
        }
    }
}
