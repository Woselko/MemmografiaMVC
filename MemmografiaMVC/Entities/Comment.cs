using System.ComponentModel.DataAnnotations;

namespace MemmografiaMVC.Entities
{
    public enum CommentStatus { Ok, Edited, Deleted, Blocked, AdultOnly }

    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public bool IsLikedByCurrentUser { get; set; }
        public CommentStatus CommentStatus { get; set; }
        public DateTime DateTimeAdded { get; set; }
        public DateTime DateTimeModified { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int CommentImageId { get; set; }
        public virtual CommentImage CommentImage { get; set; }
    }
}
