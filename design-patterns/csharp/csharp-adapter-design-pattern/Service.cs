using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// A service layer to perform database operations using the DB interface.
namespace csharp_adapter
{
    public class Service
    {
        DB db;

        public Service(DB db){
            this.db = db;
        }

        public DB Db { get => db; set => db = value; }

        public User GetUser(int id){
            return db.SelectUserById(id);
        }
        public void AddUser(User user){
            db.InsertUser(user);
        }
        
    }
}