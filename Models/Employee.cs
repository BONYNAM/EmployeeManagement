using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDapplication.Models
{
    public class Employee
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{  get; set; }
        [Column(TypeName ="varchar(50)")]
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Address { get; set; }
        public int Phone { get; set; }

    }

}
