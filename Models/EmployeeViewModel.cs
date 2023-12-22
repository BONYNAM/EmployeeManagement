using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDapplication.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("E-mail")]
        public  string Email { get; set; }
        [DisplayName("Address")]
        public  string Address { get; set; }
        public int Phone { get; set; }
    }
}
