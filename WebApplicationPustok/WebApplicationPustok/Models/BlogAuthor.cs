namespace WebApplicationPustok.Models
{
    public class BlogAuthor
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        public Blog? Blog { get; set; }
    }
}
