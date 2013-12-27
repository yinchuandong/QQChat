using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;   //要加上
using System.Configuration; //要加上
using IDaL;

namespace DALFactory
{
    sealed public class DataAccess
    {
        //读取配置文件中配置的程序集名称是SqlServer还是Access
        private static readonly string AssemblyName = ConfigurationManager.AppSettings["DAL"];

        public static IUserDal CreateUserDal()
        {
            //获得要访问的DAL层的类名称 
            string className = AssemblyName + ".UserDal";
            //创建对象，并进行类型转换                
            //利用反射机制动态创建对象，将对象实例化由编译时转为运行时，不需要用switch..case 来判断了。
            //反射技术动态创建对象的方法是：
            //Assemmbly.Load("程序集名称").CreateInstance("命名空间.类名称");
            //创建IUser对象
            return (UserDal)Assembly.Load(AssemblyName).CreateInstance(className);
            //利用反射机制，创建对象，并进行类型转换，把子类转换成父类接口类型；

        }

        public static IChatRoomMemberDal CreateChatRoomMemberDal()
        {
            //类名称
            string className = AssemblyName + ".ChatRoomMemberDal";
            //创建IContact对象，并进行类型转换
            return (IChatRoomMemberDal)Assembly.Load(AssemblyName).CreateInstance(className);
            //利用反射机制，创建对象，并进行类型转换，把子类转换成父类接口类型；
        }

        public static IFriendDal CreateFriendDal()
        {
            //类名称
            string className = AssemblyName + ".FriendDal";
            //创建IContactGroup对象，并进行类型转换
            return (IFriendDal)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IGroupDal CreateGroupDal()
        {
            //类名称
            string className = AssemblyName + ".GroupDal";
            //创建IBackupAndRestoreDb对象，并进行类型转换
            return (IGroupDal)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IGroupMemberDal CreateGroupMemberDal()
        {
            //类名称
            string className = AssemblyName + ".GroupMemberDal";
            //创建IBackupAndRestoreDb对象，并进行类型转换
            return (IGroupMemberDal)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IP2pMessageDal CreateP2pMessageDal()
        {
            //类名称
            string className = AssemblyName + ".P2pMessageDal";
            //创建IBackupAndRestoreDb对象，并进行类型转换
            return (IP2pMessageDal)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
