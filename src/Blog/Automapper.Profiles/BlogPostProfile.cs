using AutoMapper;
using System.Collections.Generic;

namespace Mark.Donile.Blog
{
    public class BlogPostProfile : Profile
    {
        public BlogPostProfile()
        {
            CreateMap<BlogPost, BlogPostDto>()
                .AfterMap((src, dest) => 
                {
                    foreach(PostTagDto pt in dest.PostTags)
                    {
                        pt.BlogPosts = new HashSet<BlogPostDto>();
                    }
                });
        }
    }
}