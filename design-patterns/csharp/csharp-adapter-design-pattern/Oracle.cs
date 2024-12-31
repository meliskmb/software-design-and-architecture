using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_adapter
{
    public class Oracle : DB
    {
        private readonly List<User> userList;
        private int idCounter;

        public Oracle(){
            userList = new List<User>();
            idCounter = 0;
        }
        public void InsertUser(User user)
        {
            Count();
            user.Id = idCounter;
            userList.Add(user);
        }

        public void Count(){
            idCounter++;
        }

        public User SelectUserById(int id)
        {
            foreach(User user in userList){
                if(user.Id == id){
                    return user;
                }
            }
            return null;
        }
    }
}