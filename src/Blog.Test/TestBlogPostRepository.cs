using Mark.Donile.Blog;
using NHibernate;
using NUnit.Framework;
using System.Linq;

namespace Blog.Test
{
    public class TestBlogPostRepository
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnAuthorWithBlogPostId()
        {
            // arrange
            string connectionString = "Server=127.0.0.1;Database=blog;User Id=blog_admin;Password=xk3yyNR6bpzSwmV;";
            ISessionFactory sessionFactory = NHibernateSessionFactoryFactory.Create(connectionString);
            ISession dbSession = sessionFactory.OpenSession();
            int id = 1;

            // act
            BlogPost bp;
            using (ITransaction tx = dbSession.BeginTransaction())
            {
                bp = dbSession.Get<BlogPost>(id);
                Assert.AreEqual(1, bp.Authors.Any(a => a.BlogPostId == 1));
                tx.Commit();
            }
        }
    }
}