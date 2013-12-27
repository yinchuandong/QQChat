using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

using SqlDal;
using Model;
using Util;
namespace Bll
{
    public class UserBll
    {
        private UserDal userDal = new UserDal();

        //检查登陆时，邮箱密码是否正确
        public bool checkLogin(string email, string password)
        {
            return userDal.checkLogin(email, password);
        }

        public User getUser(string email)
        {
            DataTable result =  userDal.getUserByEmail(email);
            IList<User> list = ModelConvertUtil<User>.ConvertToModel(result);
            return list[0];
        }

        public User getUser(int uId)
        {
            DataTable result = userDal.getUserById(uId);
            IList<User> list = ModelConvertUtil<User>.ConvertToModel(result);
            return list[0];
        }

        //注册用户
        public bool register(User user)
        {
            bool isOk=userDal.register(user);
            return isOk;
        }

        //检查邮箱是否唯一
        public bool checkUniqueEmail(String email)
        {
            return userDal.checkUniqueEmail(email);
        }

        //更新用户信息
        public bool update(User user, int uId)
        {
            return userDal.update(user, uId);
        }

        //检查邮箱格式是否合法
        public bool IsValidatedEmail(string email){
            Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@([\\w-]+\\.)+\\w{2,10})\\s*$");
            Match match = r.Match(email);
            if(match.Success)
            {
                return true;
            }else{
                return false;
            }
        }

        //检查用户名长度是否合法
        public bool IsValidatedUserName(string username)
        {
            if (username.Length >=10 || username.Length<=1)
            {
                return false;
            }else
            {
                return true;
            }
        }

        //检查密码格式是否合法
        public bool IsValidatedPassword(string password)
        {
            bool r = Regex.IsMatch(password, "^([a-zA-Z0-9]|[_]){6,16}$");
            return r;
        }
         //设置statue
        public bool updateOutStatue(int uId)
        {
            if (userDal.updateOutStatue(uId))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        
    }
}
