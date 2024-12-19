using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_haber
{
    public interface Communication
    {
        public void SendInfo(User user, string message);
    }
}