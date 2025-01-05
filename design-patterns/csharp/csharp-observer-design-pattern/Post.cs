using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_observer_design_pattern
{
    public class Post
    {
        private Followed followed;
        private string content;

        public Post(Followed followed, string content)
        {
            this.followed = followed;
            this.content = content;
        }

        public Followed Followed
        {
            get { return followed; }
            set { followed = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public override string ToString()
        {
            return this.followed.Name;
        }
    }
}