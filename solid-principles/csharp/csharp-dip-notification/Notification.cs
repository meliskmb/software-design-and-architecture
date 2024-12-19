using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_haber
{
    public class Notification : Communication
    {
        public void SendInfo(User user, string message){
            this.SendNotification(user.GetIp(), message);
        }

        public void SendNotification(int ip, string message){
            Console.WriteLine("The message (" + message + ") has been sent to the adress: " + ip);
        }
    }    
}