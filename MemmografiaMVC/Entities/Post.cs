using System.ComponentModel.DataAnnotations;

namespace MemmografiaMVC.Entities
{
    public enum PostStatus { Awaiting, MainPage, Deleted, Blocked, AdultOnly }

    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public bool IsLikedByCurrentUser { get; set; }
        public PostStatus PostStatus { get; set; } = 0;
        public DateTime DateTimeAdded { get; set; }
        public DateTime DateTimeModified { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int PostImageId { get; set; }
        public virtual PostImage PostImage { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
