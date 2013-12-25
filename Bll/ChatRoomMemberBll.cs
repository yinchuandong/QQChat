using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

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

        public string addChatRoom(Model.Chatroom chatroom, string key)//添加群
        {
            string msg = null;
          
            if (this.isExist(key))
            {
                msg = "当前群已经存在，请换个名字！";
                return msg;
            }
            else {
                int result = chatRoomMemberDal.addChatRoom(chatroom);
                if (result == 1)
                {
                    msg = null;
                    return msg;
                }
                else
                {
                    msg = "错误！";
                    return msg;
                }
            }
           
        }
        //判断是否存在当前群
        public bool isExist(string key) 
        {
            return chatRoomMemberDal.isExist(key);
        }
        //查找群
        public ArrayList searchChatRoom(string key)
        {         
            ArrayList result = new ArrayList();
            result = chatRoomMemberDal.searchChatRoom(key);
            return result;         
        }
        //查找当前的聊天室人数
        public int searchNum(int id)
        {
            int num = chatRoomMemberDal.searchNum(id);
            return num;
        }
        //查找群主信息
        public User searchLeader(int uId)
        {
            DataTable result = chatRoomMemberDal.searchLeader(uId);
            IList<User> list = ModelConvertUtil<User>.ConvertToModel(result);
            return list[0];
        }

        //申请加入群
        public String addMember(int Uid,int c_id)
        {
            string msg = null;
            //1.判断当前用户是否已经存在该群
            if (!isMember(Uid, c_id))
            {
                if (chatRoomMemberDal.addMember(Uid, c_id))
                {
                    msg = null;
                }
                else
                {
                    msg = "申请发送失败！";
                }
            }
            else
            {
                msg = "你已经群成员了！";
            }
            return msg;
        }
        //判断是否属于群成员
        public bool isMember(int UId,int c_id) 
        {
            if (chatRoomMemberDal.isMember(UId,c_id))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        //发起群组聊天，查找群内成员在线人员IP
        public ArrayList searchIp(int Cid)
        {
            if (chatRoomMemberDal.searchIp(Cid) != null)
            {
                ArrayList result = new ArrayList();
                result = chatRoomMemberDal.searchIp(Cid);
                return result;
            }
            else
            {
                ArrayList noIp = new ArrayList();
                return noIp;
            }
        }

    } 
}