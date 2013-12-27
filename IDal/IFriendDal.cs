using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

using Model;
using Util;

namespace SqlDal
{
    public interface FriendDal
    {
        public FriendDal();
        public DataTable getOneFriend(int uId, int friendId);

        public DataTable getFriendByGroup(int uId, int groupId); //按组查找好友


        public DataTable getAllFriend(int uId);

        public int InsertFriend(Model.Friend friend);


        public bool IsFriend(int curr_ID, int search_ID);//判断好友关系

        public SqlDataReader searchFriendByName(string name);  //根据用户名查找用户

        public ArrayList searchUser(int currenID, string key);  //查找用户
    }
}
