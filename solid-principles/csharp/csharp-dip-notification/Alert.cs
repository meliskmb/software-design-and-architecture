using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_haber
{
    public class Alert
    {
        private Mail mail;
        private Notification notification;
        private List<Communication> comList;

        public Alert(){
            comList = new List<Communication>();
            mail = new Mail();
            notification = new Notification();
            comList.Add(mail);
            comList.Add(notification);

        }

        public void Notify(User user, String message){
            foreach (Communication communication in comList){
                communication.SendInfo(user, message);
            }
        }
    }
}