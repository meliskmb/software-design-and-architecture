using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_haber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User("user1", "user1@gmail.com", 111, 0000);
            Alert alert = new Alert();
            alert.Notify(user, "test message");
        }
    }
}
