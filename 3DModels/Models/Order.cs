using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DModels.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        [ForeignKey("ProductName")]
        public string ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        //public string UserEmail { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }


    }
}

