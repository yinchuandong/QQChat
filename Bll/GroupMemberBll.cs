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
    public class GroupMemberBll
    {
        private GroupMemberDal groupMemberDal=new GroupMemberDal();
        public bool insertMember(GroupMember groupMember) 
        {
            bool isInsert=groupMemberDal.insertGroupMember(groupMember);
            if (isInsert)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public int getGroupID(int UId,string name) 
        {
            return groupMemberDal.get_g_ID(UId, name);
        }

    }
}
