using System.ComponentModel.DataAnnotations;

namespace MemmografiaMVC.Entities
{
    public class PostLike
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
