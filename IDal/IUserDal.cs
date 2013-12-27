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
        public bool checkLogin(string email, string password);      
        public DataTable getUserByEmail(string email);
        public DataTable getUserById(int uId);        
        public bool register(User  user);        
        public bool checkUniqueEmail(String email);
        public bool update(User user, int uId);
        public bool updateOutStatue(int uId); //设置statue
        
    }

   
}
