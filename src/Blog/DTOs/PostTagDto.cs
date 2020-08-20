using System.Collections.Generic;

namespace Mark.Donile.Blog
{
    public class PostTagDto
    {
        public int Id { get; set; }
        public ISet<BlogPostDto> BlogPosts { get; set; } = new HashSet<BlogPostDto>();
    }
}