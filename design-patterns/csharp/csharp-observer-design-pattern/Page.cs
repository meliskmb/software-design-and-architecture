using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_observer_design_pattern
{
    public class Page : Followed
    {
        public Page(string name) : base(name){
        }

        public void Share(Post post){
            this.NotifyAll(post);
        }    
    }
}