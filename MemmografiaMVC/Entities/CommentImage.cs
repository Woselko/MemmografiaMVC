using System.ComponentModel.DataAnnotations;

namespace MemmografiaMVC.Entities
{
    public class CommentImage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
