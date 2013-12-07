using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

using SqlDal;
using Model;
using Util;

namespace Bll
{
    //好友界面的的逻辑表现层
   public class FriendsBll
    {
        private FriendsDal friendDal = new FriendsDal();

        //查找用户
        public ArrayList searchUser(string  key) 
        {
            ArrayList userList = new ArrayList();
            SqlDataReader reader = friendDal.searchFriendByName(key);
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
                    userList.Add(user);                  
                }
            }
          
            reader.Close();
            return userList;
        }
        //添加好友
        public string addFriend(int curr_ID,int searck_ID,string nickName,int g_id)
        {
            string msg = "";
            bool isFriend = friendDal.IsFriend(curr_ID, searck_ID);
            if (isFriend)
            {
                bool isAdded=friendDal.addFriend(curr_ID, searck_ID, nickName, g_id);
                if (isAdded)
                {
                    msg = "添加好友成功！";
                }
                else 
                {
                    msg = "添加失败！";
                }
               
            }
            else {
                msg = "对方已是您好友，重复添加无效！";
            }
            return msg;
        }





        
    }
}
