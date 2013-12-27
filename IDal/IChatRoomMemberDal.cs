using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

using Model;
using Util;


namespace SqlDal
{
   public interface ChatRoomMemberDal
    {

      public DataTable getChatRoomDetail(int uId);//获得所在的每个群组具体信息
      public int addChatRoom(Model.Chatroom chatroom); 
      public bool setPort();//设置chatPoomport
      public int getLasteID(); //查询最新插入的chatRoom的id
      public int getLastePort() ;     //查询最新插入的chatRoom的端口      
      public SqlDataReader searchChatRoomByName(string Name);//搜索群
      public ArrayList searchChatRoom(string key);      //查找聊天室
      public int searchNum(int id);   //查找当前聊天室的人数
      public DataTable searchLeader(int uId);  //查找群主信息
      public bool isMember(int UId,int c_id); //判断是否是群成员
      public bool addMember(int UId, int c_id); //加入已存在的群聊天室 
      public ArrayList searchIp(int Cid);//发起群组聊天，查找群内成员在线人员IP
   }
      