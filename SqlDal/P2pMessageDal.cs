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
   public class P2pMessageDal
    {
       //添加P2p消息
       public bool addP2pMessage(Model.P2pMessage Message)
       {

           string sql = "insert into [p2p_message](host_id ,guest_id ,contents ,time ,face ,image ) values(@host_id,@guest_id,@contents,@time,@face,@image);";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter host_id = new SqlParameter("@host_id", SqlDbType.Int);
            SqlParameter guest_id = new SqlParameter("@guest_id", SqlDbType.Int);
            SqlParameter contents = new SqlParameter("@contents", SqlDbType.Text);
            SqlParameter time = new SqlParameter("@time", SqlDbType.DateTime);
            SqlParameter face = new SqlParameter("@face", SqlDbType.Text);
            SqlParameter image = new SqlParameter("@image", SqlDbType.Text);
            host_id.Value = Message.HostId;
            guest_id.Value = Message.GuestId;
            contents.Value = Message.Contents;
            time.Value = Message.Time;
            face.Value = Message.Face;
            image.Value = Message.image;

            parameters.Add(host_id);
            parameters.Add(guest_id);
            parameters.Add(contents);
            parameters.Add(time);
            parameters.Add(face);
            parameters.Add(image);
            int result = SqlDbHelper.ExecuteNoQuery(sql,CommandType.Text, parameters); 
           if (result == 1)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       //查询离线的信息 
       public Dictionary<int, ArrayList> getP2pMessage(int Uid)
       {
           String sqlStr = "select * from (select * from [p2p_message] where [guest_id]=@uId) as t where [HOST_ID] =5";
           return null;
       }
    }
}
