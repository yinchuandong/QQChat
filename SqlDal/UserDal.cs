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
    public class UserDal
    {
        public bool checkLogin(string email, string password)
        {
            string sql = "select count(*) from [user] where email=@Email and password=@Password";
            SqlParameter[] parameters  = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            parameters[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            parameters[0].Value = email;
            parameters[1].Value = AppUtil.Encrypt(password);

            int result = (int)SqlDbHelper.ExecuteScalar(sql, CommandType.Text, parameters);
            if (result == 1)
                return true;
            else
                return false;
        }

        public bool register(User  user)
        {
            string sql = "insert into [user] (username,email,password,last_login_time) values (@Username,@Email, @Password, @Time)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Username",SqlDbType.VarChar,50),
                new SqlParameter("@Email", SqlDbType.VarChar, 50),
                new SqlParameter("@Password", SqlDbType.VarChar, 50),
                new SqlParameter("@Time",SqlDbType.DateTime)
            };
            parameters[0].Value = user.Username;
            parameters[1].Value = user.Email;
            parameters[2].Value = AppUtil.Encrypt(user.Password);
            parameters[3].Value = DateTime.Now;
            int row = SqlDbHelper.ExecuteNoQuery(sql,CommandType.Text, parameters);
            if (row == 1)
                return true;
            else
                return false;
        }

        public bool checkUniqueEmail(String email)
        {
            string sql = "select count(*) from [user] where email=@Email";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email",SqlDbType.VarChar, 50)
            };
            parameters[0].Value = email;
            int row = (int)SqlDbHelper.ExecuteScalar(sql,CommandType.Text,parameters);
            if (row >= 1)
                return false;
            else
                return true;
        }

        public bool update(User user,int uId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username",SqlDbType.VarChar,50),
                new SqlParameter("@Password", SqlDbType.VarChar, 50),
                new SqlParameter("@Age", SqlDbType.Int,3),
                new SqlParameter("@Sex", SqlDbType.Int,1),
                new SqlParameter("@Sign", SqlDbType.VarChar, 200),
                new SqlParameter("@photo", SqlDbType.VarChar,50),
                new SqlParameter("@LastLoginTime",SqlDbType.DateTime),
                new SqlParameter("@LastLoginIp",SqlDbType.VarChar, 50),
                new SqlParameter("@Status", SqlDbType.Int,1),
                new SqlParameter("@Uid", SqlDbType.Int,10)
            };
            parameters[0].Value = user.Username;
            parameters[1].Value = user.Password;
            parameters[2].Value = user.Age;
            parameters[3].Value = user.Sex;
            parameters[4].Value = user.Sign;
            parameters[5].Value = user.Photo;
            parameters[6].Value = DateTime.Now;
            parameters[7].Value = user.LastLoginIp;
            parameters[8].Value = user.Status;
            StringBuilder sql = new StringBuilder();
            sql.Append("update [user] set");
            if (!user.Username.Equals("")) 
            {
                sql.Append(" username=@Username,");
            }
            if (!user.Password.Equals(""))
            {
                sql.Append(" password=@Password,");  
            }
            if(user.Age != -1)
            {
                sql.Append(" age=@Age,");

            }
            if (user.Sex != -1)
            {
                sql.Append(" sex=@Sex,");

            }
            if (!user.Sign.Equals(""))
            {
                sql.Append(" sign=@Sign,");
                
            }
            if (!user.Photo.Equals(""))
            {
                sql.Append(" photo=@Photo,");
                
            }
            if (!user.LastLoginIp.Equals(""))
            {
                sql.Append(" last_login_ip=@LastLoginIp,");
                
            }
            if (!user.LastLoginTime.Equals(""))
            {
                sql.Append(" last_login_time=@LastLoginTime,");
                
            }
            if(user.Status != -1 )
            {
                sql.Append(" status=@Status,");
                
            }
            string sqlStr = sql.ToString();
            sqlStr = sqlStr.Substring(0, sqlStr.Length - 1);
            sqlStr += " where u_id=@Uid";
            parameters[9].Value = uId;

            int row = SqlDbHelper.ExecuteNoQuery(sqlStr, CommandType.Text, parameters);
            if (row >= 1)
                return false;
            else
                return false;
        }

    }

   
}
