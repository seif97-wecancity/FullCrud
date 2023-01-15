using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Student
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? phoneNumber { get; set; }
    }
}
