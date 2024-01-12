namespace Twitter.Core.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int PostId { get; set; }
        public int? ParentCommetId { get; set; }
        public List<Comment>? Comments { get; set;}
    }
}