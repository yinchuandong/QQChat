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
            List<SqlParameter> parameters  = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50));
            parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
            parameters[0].Value = email;
            parameters[1].Value = AppUtil.Encrypt(password);

            int result = (int)SqlDbHelper.ExecuteScalar(sql, CommandType.Text, parameters);
            if (result == 1)
                return true;
            else
                return false;
        }

        public DataTable getUserByEmail(string email)
        {
            string sql = "select [u_id] as [UId], [username] as [Username], [email] as [Email], [password] as [Password], " +
                        "[regTime] as [RegTime], [age] as [Age], [sex] as [Sex], [sign] as [Sign], [photo] as [Photo], " +
                        "[last_login_time] as [LastLoginTime], [last_login_ip] as [LastLoginIp], [status] as [Status] from [user] "+
                        "where [email]=@Email";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter Email = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            Email.Value = email.Trim();
            parameters.Add(Email);

            DataTable result = SqlDbHelper.ExecueteDataTable(sql, CommandType.Text, parameters);
            return result;
        }

        public DataTable getUserById(int uId)
        {
            string sql = "select [u_id] as [UId], [username] as [Username], [email] as [Email], [password] as [Password], " +
                        "[regTime] as [RegTime], [age] as [Age], [sex] as [Sex], [sign] as [Sign], [photo] as [Photo], " +
                        "[last_login_time] as [LastLoginTime], [last_login_ip] as [LastLoginIp], [status] as [Status] from [user] " +
                        "where [u_id]=@UId";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter UId = new SqlParameter("@UId", SqlDbType.VarChar, 50);
            UId.Value = uId;
            parameters.Add(UId);

            DataTable result = SqlDbHelper.ExecueteDataTable(sql, CommandType.Text, parameters);
            return result;
        }

        public bool register(User  user)
        {
            string sql = "insert into [user] (username,email,password,regTime,age,sex,sign,photo) values (@Username,@Email, @Password, @Time,@Age,@Sex,@Sign,@Photo)";
 
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Username",SqlDbType.VarChar,50));
            parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50));
            parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
            parameters.Add(new SqlParameter("@Time",SqlDbType.DateTime));

            parameters.Add(new SqlParameter("@Age", SqlDbType.Int, 50));
            parameters.Add(new SqlParameter("@Sex", SqlDbType.Int));
            parameters.Add(new SqlParameter("@Sign", SqlDbType.VarChar, 50));
            parameters.Add(new SqlParameter("@Photo", SqlDbType.Image));

            parameters[0].Value = user.Username;
            parameters[1].Value = user.Email;
            parameters[2].Value = AppUtil.Encrypt(user.Password);
            parameters[3].Value = DateTime.Now;

            parameters[4].Value = user.Age;
            parameters[5].Value = user.Sex;
            parameters[6].Value = user.Sign;
            parameters[7].Value = user.Photo;

            int row = SqlDbHelper.ExecuteNoQuery(sql,CommandType.Text, parameters);
            if (row == 1){
                
                return true;
            }else{
               
                return false;
            }
                
            
        }

        public bool checkUniqueEmail(String email)
        {
            string sql = "select count(*) from [user] where email=@Email";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50));
            parameters[0].Value = email;
            int row = (int)SqlDbHelper.ExecuteScalar(sql,CommandType.Text,parameters);
            if (row >= 1)
                return false;
            else
                return true;
        }

        public bool update(User user,int uId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            StringBuilder sql = new StringBuilder();
            sql.Append("update [user] set");

            if (!user.Username.Equals("")) 
            {
                sql.Append(" username=@Username,");
                SqlParameter Username =  new SqlParameter("@Username",SqlDbType.VarChar,50);
                Username.Value = user.Username;
                parameters.Add(Username);
            }
            if (!user.Password.Equals(""))
            {
                sql.Append(" password=@Password,");  
                SqlParameter Password =  new SqlParameter("@Password", SqlDbType.VarChar, 50);
                Password.Value = user.Password;
                parameters.Add(Password);
            }
            if(user.Age != -1)
            {
                sql.Append(" age=@Age,");
                SqlParameter Age = new SqlParameter("@Age", SqlDbType.Int,3);
                Age.Value = user.Age;
                parameters.Add(Age);
            }
            if (user.Sex != -1)
            {
                sql.Append(" sex=@Sex,");
                SqlParameter Sex =  new SqlParameter("@Sex", SqlDbType.Int,1);
                Sex.Value = user.Sex;
                parameters.Add(Sex);
            }
            if (!user.Sign.Equals(""))
            {
                sql.Append(" sign=@Sign,");
                SqlParameter Sign = new SqlParameter("@Sign", SqlDbType.VarChar, 200);
                Sign.Value = user.Sign;
                parameters.Add(Sign);
            }
            if (user.Photo!=null)
            {
                sql.Append(" photo=@Photo,");
                SqlParameter Photo =  new SqlParameter("@photo", SqlDbType.Image);
                Photo.Value = user.Photo;
                parameters.Add(Photo);
            }
            if (!user.LastLoginIp.Equals(""))
            {
                sql.Append(" last_login_ip=@LastLoginIp,");
                SqlParameter LastLoginIp = new SqlParameter("@LastLoginIp",SqlDbType.VarChar, 50);
                LastLoginIp.Value = user.LastLoginIp;
                parameters.Add(LastLoginIp);
            }
            if (user.LastLoginTime != null)
            {
                sql.Append(" last_login_time=@LastLoginTime,");
                SqlParameter LastLoginTime =  new SqlParameter("@LastLoginTime",SqlDbType.VarChar,50);
                LastLoginTime.Value = user.LastLoginTime;
                parameters.Add(LastLoginTime);
            }
            if(user.Status != -1 )
            {
                sql.Append(" status=@Status,");
                SqlParameter Status = new SqlParameter("@Status", SqlDbType.Int,1);
                Status.Value = user.Status;
                parameters.Add(Status);
            }
                
            
            string sqlStr = sql.ToString();
            sqlStr = sqlStr.Substring(0, sqlStr.Length - 1);
            sqlStr += " where u_id=@Uid";
            SqlParameter UId = new SqlParameter("@Uid", SqlDbType.Int, 10);
            UId.Value = uId;
            parameters.Add(UId);

            Console.WriteLine("查询语句。。。。。。。。。。。。。。。"+sqlStr);
            int row = SqlDbHelper.ExecuteNoQuery(sqlStr, CommandType.Text, parameters);
            if (row >= 1)
                return true;
            else
                return false;
        }
    }

   
}
