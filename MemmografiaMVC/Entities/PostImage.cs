using System.ComponentModel.DataAnnotations;

namespace MemmografiaMVC.Entities
{
    public class PostImage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
