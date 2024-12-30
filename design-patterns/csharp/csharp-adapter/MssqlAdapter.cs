using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The MssqlAdapter class adapts the Mssql class to the DB interface.
namespace csharp_adapter
{
    public class MssqlAdapter : DB
    {
        private Mssql mssql;

        public MssqlAdapter(){
            mssql = new Mssql();
        }
        public void InsertUser(User user)
        {
            mssql.user(user);
        }

        public User SelectUserById(int id)
        {
            return mssql.UserById(id);
        }
    }
}