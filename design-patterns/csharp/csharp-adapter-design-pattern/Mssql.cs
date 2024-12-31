using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_adapter
{
    public class Mssql
    {
        private readonly List<User> userList;
        private int idCounter;

        public Mssql(){
            idCounter = 0;
            userList = new List<User>();
        } 

        // Methods that do not comply with the DB interface 
        public void user(User user){
            user.Id = idCounter++;
            userList.Add(user);
        }
        public User UserById(int id){
            foreach(User user in userList){
                if(user.Id == id){
                    return user;
                }
            }
            return null;
        }
    }
}