using System.Collections.Generic;

namespace Mark.Donile.Blog
{
    public class BlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ISet<AuthorDto> Authors { get; set; } = new HashSet<AuthorDto>();
        public ISet<PostTagDto> PostTags { get; set; } = new HashSet<PostTagDto>();
    }
}