using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_haber
{
    public class User
    {
        private string name;
        private string mail;
        private int ip;
        private int phoneNum;

        public User(string name, string mail, int ip, int phoneNum){
            this.name = name;
            this.mail = mail;
            this.ip = ip;
            this.phoneNum = phoneNum;
        }

        public void SetName(string name){this.name = name;}
        public void SetMail(string mail){this.mail = mail;}
        public void SetIp(int ip){this.ip = ip;}
        public void SetPhoneNum(int phoneNum){this.phoneNum = phoneNum;}

        public string GetName(){return this.name;}
        public string GetMail(){return this.mail;}
        public int GetIp(){return this.ip;}
        public int GetPhoneNum(){return this.phoneNum;}
    }
}