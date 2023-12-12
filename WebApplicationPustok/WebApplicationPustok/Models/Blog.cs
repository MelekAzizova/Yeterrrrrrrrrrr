namespace WebApplicationPustok.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatAt { get; set; } 
        public DateTime UpdatAt { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<BlogAuthor>? BlogAuthor { get; set;}
        public ICollection<BlogTag>? BlogTags { get; set;}
        
    }
}
