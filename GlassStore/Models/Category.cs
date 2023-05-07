﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GlassStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="choose a value between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
