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
    public class FriendBll
    {
        private FriendDal friendDal = new FriendDal();

        //获得某个特定好友的信息
        public Friend getOneFriend(int uId, int friendId)
        {
            DataTable result = friendDal.getOneFriend(uId, friendId);
            IList<Friend> list = ModelConvertUtil<Friend>.ConvertToModel(result);
            return list[0];
        }

        //获得某个分组下的好友列表
        public IList<Friend> getFriendByGroup(int uId, int groupId)
        {
            DataTable result = friendDal.getFriendByGroup(uId, groupId);
            IList<Friend> list = ModelConvertUtil<Friend>.ConvertToModel(result);
            return list;
        }

        //获得所有好友的信息
        public IList<Friend> getAllFriend(int uId)
        {
            DataTable result = friendDal.getAllFriend(uId);
            IList<Friend> list = ModelConvertUtil<Friend>.ConvertToModel(result);
            return list;
        }

        public bool addFriend(Friend friend)
        {
            int result = friendDal.InsertFriend(friend);
            if (result == 1)
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
