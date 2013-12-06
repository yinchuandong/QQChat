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

        public Friend getOneFriend(int friendId)
        {
            DataTable result = friendDal.getOneFriend(friendId);
            IList<Friend> list = ModelConvertUtil<Friend>.ConvertToModel(result);
            return list[0];
        }

        public int addFriend(Friend friend)
        {
            int result = friendDal.InsertFriend(friend);
            return result;
        }
    }
}
