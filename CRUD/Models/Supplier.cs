using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Supplier
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Age{ get; set; }
    }
}
