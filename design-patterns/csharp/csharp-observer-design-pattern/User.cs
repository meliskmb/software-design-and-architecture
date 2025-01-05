using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_observer_design_pattern
{
    public class User : Followed, Follower
    {
        public User(string name) : base(name){
        }

        public void Share(Post post){
            this.NotifyAll(post);
        }

        public void Notify(Post post){
            Console.WriteLine($"{this.Name} => the user/page you are following ({post.ToString()}) has shared: {post.Content}");
        }
    }
}