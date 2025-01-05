using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_observer_design_pattern
{
    public class Group : Follower
    {
        private string name;

        public Group(string name)
        {
            this.name = name;
        }

        public void Notify(Post post)
        {
            Console.WriteLine($"{this.name} => the user/page you are following ({post.ToString()}) has shared: {post.Content}");
        }    
    }
}