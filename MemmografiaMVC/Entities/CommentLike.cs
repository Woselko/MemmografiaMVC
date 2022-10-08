using System.ComponentModel.DataAnnotations;

namespace MemmografiaMVC.Entities
{
    public class CommentLike
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
