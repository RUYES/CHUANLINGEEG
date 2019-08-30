using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUANLING_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //  User user = new User("sb", "傻逼");
            Console.WriteLine(DBServices.AddTrainTable(DateTime.Now));
            //  user.Address = "放你妈的屁";
            //  Console.WriteLine(DBServices.UpdateUser(user));
            Console.ReadKey();
        }
    }
}
