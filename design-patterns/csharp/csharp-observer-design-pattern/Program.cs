using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_observer_design_pattern
{
    public class Program
    {
        public static void Main(string[] args){
            User user1 = new User("user1");
            User user2 = new User("user2");

            Group group = new Group("group");

            Page page = new Page("page");

            user1.AddFollower(user2);
            user1.AddFollower(group);
            page.AddFollower(group);

            Post post1 = new Post(user1, "post1");
            Post post2 = new Post(page, "post2");

            user1.Share(post1);
            page.Share(post2);
        }
    }
}
