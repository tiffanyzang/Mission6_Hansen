﻿using System.ComponentModel.DataAnnotations;

namespace Mission6_Hansen.Models
{
    public class Category
    {

        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
