using System.ComponentModel.DataAnnotations;

namespace MemmografiaMVC.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
