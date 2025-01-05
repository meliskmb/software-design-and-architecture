using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_observer_design_pattern
{
    public interface Follower
    {
        void Notify(Post post);
    }
}