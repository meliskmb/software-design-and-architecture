using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_factory
{
    public abstract class DBYonetici
    {
        public abstract IDatabase GetDatabase();      
    }
}