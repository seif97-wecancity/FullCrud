﻿using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Category
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string? Name{ get; set; }
        [Required]
        public string? Grade{ get; set; }
    }
}
