using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Billing.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserID {  get; set; }

        [ForeignKey("UserID")] // Links to DepartmentId
        public virtual User User { get; set; }
    }
}
