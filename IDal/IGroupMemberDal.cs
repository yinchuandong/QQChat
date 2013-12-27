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
    public interface GroupMemberDal
    {
        public bool insertGroupMember(GroupMember groupMember); //插入组成员
        public int get_g_ID(int uId, string name); //获得到用户组别的g_ID
    }
}
