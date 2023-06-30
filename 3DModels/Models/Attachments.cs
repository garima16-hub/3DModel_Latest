using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _3DModels.Models
{
    public class Attachments
    {
        [Key]
        public int product_id { get; set; }

        public string Filepath { get; set; }
        [Required]
        [MaxLength(50)]
        public string Accessories { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
