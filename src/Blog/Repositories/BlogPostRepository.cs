using NHibernate;
using System.Linq;

namespace Mark.Donile.Blog
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ISession _dbSession;
        
        public BlogPostRepository(ISession dbSession)
        {
            _dbSession = dbSession;
        }

        public BlogPost GetBlogPost(int id)
        {
            BlogPost blogPost;

            using (ITransaction tx = _dbSession.BeginTransaction())
            {
                blogPost = _dbSession.Get<BlogPost>(id);
                tx.Commit();
            }
            
            return blogPost;
        }
    }
}