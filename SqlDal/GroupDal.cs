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
    public class GroupDal
    {
        //获得好友分组列表
        public DataTable getGroupList(int uId)
        {
            string sql = "select u_id as UId, g_id as GId, name as Name"
                +" from [group] where u_id=@UId";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId",SqlDbType.Int);
            UId.Value = uId;
            parameters.Add(UId);
            DataTable result = SqlDbHelper.ExecueteDataTable(sql, CommandType.Text, parameters);
            return result;
        }

        //添加好友分组
        public int addGroup(Model.Group group)
        {
            string sql = "insert into [group] ([u_id],[name]) values (@UId,@Name)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId",SqlDbType.Int);
            SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            UId.Value = group.UId;
            parameters.Add(UId);
            Name.Value = group.Name;
            parameters.Add(Name);
            int result = SqlDbHelper.ExecuteNoQuery(sql,CommandType.Text, parameters);
            return result;
        }
        //添加用户到对应的分组
        //获得到用户最大的groupID
        public int getMax_g_ID(int uId) 
        {
            int maxID=0;
            string sqlStr = "select MAX([g_id]) as g_max_id from [group] where u_id=@UId";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            UId.Value = uId;
            parameters.Add(UId);
            Console.WriteLine(parameters.ToString()+"------>"+uId);
            SqlDataReader reader = SqlDbHelper.ExecuteReader(sqlStr, CommandType.Text, parameters);
            if (reader.HasRows)
            {
                while(reader.Read()){
                    if (!(reader["g_max_id"] is System.DBNull))
                    {
                        maxID = Convert.ToInt32(reader["g_max_id"].ToString().Trim());
                    }
                }
            }
            return maxID;
        }

        //获得g_ID
        public int get_g_ID(int uId,string name)
        {
            int g_ID = 0;
            string sqlStr = "select [g_id] from [group] where u_id=@UId and name=@Name";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar);
            UId.Value = uId;
            Name.Value = name;
            parameters.Add(UId);
            parameters.Add(Name);
            Console.WriteLine(parameters.ToString() + "------>" + uId);
            SqlDataReader reader = SqlDbHelper.ExecuteReader(sqlStr, CommandType.Text, parameters);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (!(reader["g_id"] is System.DBNull))
                    {
                        g_ID = Convert.ToInt32(reader["g_id"].ToString().Trim());
                    }
                }
            }
            return g_ID;
        
        }
        //判断分组是否存在
        public bool isGroupByName(int uId,string name)
        {
            string sqlStr = "select count(*) from [group] where u_id=@UId and name=@Name";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.Int);
            SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar);
            UId.Value = uId;
            Name.Value = name;
            parameters.Add(UId);
            parameters.Add(Name);

            int result = (int)SqlDbHelper.ExecuteScalar(sqlStr, CommandType.Text, parameters);
            if (result == 1)
                return true;
            else
                return false;
        }
        
    }
}
