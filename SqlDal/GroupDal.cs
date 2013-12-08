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

    }
}
