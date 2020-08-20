using System.Collections.Generic;

namespace Mark.Donile.Blog
{
    public class BlogPost
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual ICollection<Author> Authors { get; set; } = new HashSet<Author>();
        public virtual ISet<PostTag> PostTags { get; set; } = new HashSet<PostTag>();
    }
}