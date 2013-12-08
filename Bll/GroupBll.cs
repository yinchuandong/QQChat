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
    public class GroupBll
    {
        private GroupDal groupDal = new GroupDal();
        //获得好友分组列表
        public IList<Model.Group> getGroupList(int uId)
        {
            DataTable result = groupDal.getGroupList(uId);
            IList<Model.Group> list = ModelConvertUtil<Model.Group>.ConvertToModel(result);
            return list;
        }

        //添加好友分组
        public bool addGroup(Model.Group group)
        {
            int result = groupDal.addGroup(group);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //获得到最大的groupID，返回最大+1作为新groupID
        public int getMaxGroupID(int uId) 
        {
         int i = groupDal.getMax_g_ID(uId);
            return i+1;
        }
        //获得groupID
        public int getGroupID(int uId,string name)
        {
            return groupDal.get_g_ID(uId,name);
        }
        //判断分组是否存在
        public bool isGroupByName(int uId,string groupName) 
        {
            return groupDal.isGroupByName(uId, groupName);
        }

    }
}
