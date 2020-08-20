namespace Mark.Donile.Blog
{
    public class Author
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual int BlogPostId { get; set; }
        public virtual BlogPost BlogPost { get; set; }
    }
}