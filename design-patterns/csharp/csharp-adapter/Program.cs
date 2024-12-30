using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_adapter
{
    public class Program
    {
        public static void Main(string[] args){

            MssqlAdapter mssqlAdapter = new MssqlAdapter();
            Service service = new Service(mssqlAdapter);

            service.AddUser(new User("User1"));
            User user1 = service.GetUser(0);
            service.AddUser(new User("User2"));
            User user2 = service.GetUser(1);
            service.AddUser(new User("User3"));
            User user3 = service.GetUser(2);

            Console.WriteLine(user1.Name);
            Console.WriteLine(user2.Name);
            Console.WriteLine(user3.Name);
        }
    }
}