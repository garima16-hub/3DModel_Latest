using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _3DModels.Models
{
    public class Product
    {
        [Key]
        public int ModelId { get; set; }

        [Required]
        public string ModelName{ get; set; }

        [Required]
        public string Description { get; set; }
    }
}
