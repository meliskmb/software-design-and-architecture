using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_haber
{
    public class Mail : Communication
    {
        public void SendInfo(User user, string message){
            this.SendMail(user.GetMail(), message);
        }

        public void SendMail(string mail, string message){
            Console.WriteLine("The message (" + message + ") has been sent to the " + mail + " email address.");
        }
    }
}