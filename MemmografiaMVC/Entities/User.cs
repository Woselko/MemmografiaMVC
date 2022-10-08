using System.ComponentModel.DataAnnotations;

namespace MemmografiaMVC.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nick { get; set; }
        public string PasswordHash { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;
        public string EmailVerificationString { get; set; } = "123456";

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
