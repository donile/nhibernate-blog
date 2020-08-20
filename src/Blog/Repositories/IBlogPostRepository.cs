namespace Mark.Donile.Blog
{
    public interface IBlogPostRepository
    {
        BlogPost GetBlogPost(int id);
    }
}