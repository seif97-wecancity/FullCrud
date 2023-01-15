﻿using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Nationality{ get; set; }
     
    }
}
