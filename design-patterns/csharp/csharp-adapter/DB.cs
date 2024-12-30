using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_adapter
{
    public interface DB
    {
        User SelectUserById(int id);
        void InsertUser(User user);
    }
}