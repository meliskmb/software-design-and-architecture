using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_observer_design_pattern
{
    public class Followed
    {
        protected List<Follower> followerList;
        protected string name;

        public Followed(string name){
            this.name = name;
            followerList = new List<Follower>();
        }

        public void AddFollower(Follower follower){
            followerList.Add(follower);
        }

        public void RemoveFollower(Follower follower){
            followerList.Remove(follower);
        }

        public void NotifyAll(Post post){
            foreach (Follower follower in followerList){
                follower.Notify(post);
            }
        }

        public string Name{
            get { return name; }
        }
        
    }
}