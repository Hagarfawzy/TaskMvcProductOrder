using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaskMvcProductOrder.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }

        public Product()
        {
            Date = DateTime.Now;
        }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual User User { get; set; }

    }
}