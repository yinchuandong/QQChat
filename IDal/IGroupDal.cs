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
    public interface GroupDal
    {
        public DataTable getGroupList(int uId); //获得好友分组列表 
        public int addGroup(Model.Group group);//添加好友分组
        public int getMax_g_ID(int uId);         //添加用户到对应的分组,获得到用户最大的groupID                                         
        public int get_g_ID(int uId,string name);//获得g_ID
        public bool isGroupByName(int uId,string name);    //判断分组是否存在
       
        
    }
}
