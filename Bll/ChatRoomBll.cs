using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Model;
using Util;
using SqlDal;

namespace Bll
{
   public  class ChatRoomBll
    {
       private ChatRoomDal chatRoomDal=new ChatRoomDal();
       //创建新群

       public bool createNewsRoom(Chatroom chatRoom){
           if (chatRoomDal.createNewsRoom(chatRoom))
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
