using System.ComponentModel.DataAnnotations;

namespace Billing.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

    }
}
