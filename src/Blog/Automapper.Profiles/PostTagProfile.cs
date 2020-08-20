using AutoMapper;
using System.Collections.Generic;

namespace Mark.Donile.Blog
{
    public class PostTagProfile : Profile
    {
        public PostTagProfile()
        {
            CreateMap<PostTag, PostTagDto>()
                .AfterMap((src, dest) => {
                    foreach(BlogPostDto bp in dest.BlogPosts)
                    {
                        bp.PostTags = new HashSet<PostTagDto>();
                    }
                });
        }
    }
}