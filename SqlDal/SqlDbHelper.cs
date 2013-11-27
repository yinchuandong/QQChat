using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace SqlDal
{
    public class SqlDbHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        //连接字符串
        public static string ConnectString{
            get{return connString;}
            set{connString = value;}
        }

        //对数据库进行非连接的查询方法
        public static DataTable ExecueteDataTable(string commandText, CommandType commandType, SqlParameter[] parameters){
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectString)){
                using(SqlCommand command = new SqlCommand(commandText, conn)){
                    command.CommandType = commandType;
                    if(parameters != null){
                        foreach (SqlParameter p in parameters)
                        {
                            command.Parameters.Add(p);
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
            }
            return data;
        }

        //overload
        public static DataTable ExecueteDataTable(string commandText){
            return ExecueteDataTable(commandText, CommandType.Text, null);
        }

        //overload
        public static DataTable ExecueteDataTable(string commandText, CommandType commandType){
            return ExecueteDataTable(commandText, commandType, null);
        }

        //有链接的查询
        public static SqlDataReader ExecuteReader(String commandText, CommandType commandType, SqlParameter[] parameters){
            SqlConnection conn = new SqlConnection(ConnectString);
            SqlCommand command = new SqlCommand(commandText, conn);
            command.CommandType = commandType;
            if(parameters != null){
                foreach (SqlParameter p in parameters)
                {
                    command.Parameters.Add(p);
                }
            }
            conn.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        //overload
        public static SqlDataReader ExecuteReader(string commandText){
            return ExecuteReader(commandText, CommandType.Text, null);
        }

        //overload
        public static SqlDataReader ExecuteReader(string commandText, CommandType commandType){
            return ExecuteReader(commandText, commandType, null);
        }

        //从数据库中获得单条记录
        public static Object ExecuteScalar(string commandText, CommandType commandType, SqlParameter[] parameters){
            Object result = null;
            using(SqlConnection conn = new SqlConnection(ConnectString)){
                using(SqlCommand command = new SqlCommand(commandText, conn)){
                    command.CommandType = commandType;
                    if(parameters != null){
                        foreach (SqlParameter p in parameters)
                        {
                            command.Parameters.Add(p);
                        }
                    }
                    conn.Open();
                    result = command.ExecuteScalar();
                }
            }
            return result;
        }


        //overload
        public static Object ExecuteScalar(string commandText){
            return ExecuteScalar(commandText, CommandType.Text, null);
        }

        //overload
        public static Object ExecuteScalar(string commandText, CommandType commandType){
            return ExecuteScalar(commandText, commandType);
        }

        public static int ExecuteNoQuery(string commandText, CommandType commandType, SqlParameter[] parameters){
            int count = 0;
            using(SqlConnection conn = new SqlConnection(ConnectString)){
                using(SqlCommand command  = new SqlCommand(commandText, conn)){
                    command.CommandType = commandType;
                    if(parameters != null){
                        foreach (SqlParameter p in parameters)
                        {
                            command.Parameters.Add(command);
                        }
                    }
                    conn.Open();
                    count = command.ExecuteNonQuery();
                }
            }
            return count;
        }

        //overload
        public static int ExecuteNoQuery(string commandText){
            return ExecuteNoQuery(commandText, CommandType.Text, null);
        }

        //overload
        public static int ExecuteNoQuery(string commandText, CommandType commandType){
            return ExecuteNoQuery(commandText, commandType);
        }
    }
}
