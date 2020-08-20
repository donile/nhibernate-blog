using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Mark.Donile.Blog
{
    [ApiController]
    [Route("/api/blog-post")]
    public class BlogPostController : Controller
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly IMapper _mapper;
         
        public BlogPostController(IBlogPostRepository blogPostRepository, IMapper mapper)
        {
            _blogPostRepository = blogPostRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult GetBlogPost(int id)
        {
            BlogPost bp = _blogPostRepository.GetBlogPost(id);
            
            BlogPostDto dto = _mapper.Map<BlogPostDto>(bp);

            return Ok(dto);
        }
    }
}