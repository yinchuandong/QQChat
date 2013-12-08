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
    public class ChatRoomMemberBll
    {
        private ChatRoomMemberDal chatRoomMemberDal = new ChatRoomMemberDal();
        public IList<Chatroom> getChatRoomDetail(int uId)//获得每个群组列表信息
        {
            DataTable result = chatRoomMemberDal.getChatRoomDetail(uId);
            IList<Chatroom> list = ModelConvertUtil<Chatroom>.ConvertToModel(result);
            return list;
        }
    }
}
