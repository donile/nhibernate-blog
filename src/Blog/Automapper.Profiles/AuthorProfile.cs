using AutoMapper;

namespace Mark.Donile.Blog
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>();
        }
    }
}