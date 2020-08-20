using System.Collections.Generic;

namespace Mark.Donile.Blog
{
    public class PostTag
    {
        public virtual int Id { get; set; }
        public virtual string TagValue { get; set; }
        public virtual ISet<BlogPost> BlogPosts { get; set; } = new HashSet<BlogPost>();
    }
}