using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Country
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? CountryCode { get; set; }
    }
}
