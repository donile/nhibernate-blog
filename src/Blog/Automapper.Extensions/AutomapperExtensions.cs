using Microsoft.Extensions.DependencyInjection;

using AutoMapper;

namespace Mark.Donile.Blog
{
    public static class AutomapperExtensions
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            MapperConfiguration mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new BlogPostProfile());
                cfg.AddProfile(new PostTagProfile());
                cfg.AddProfile(new AuthorProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}