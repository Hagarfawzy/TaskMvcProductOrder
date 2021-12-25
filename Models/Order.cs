using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaskMvcProductOrder.Models
{
    public class Order
    {
        [Key]
        public int Orderid { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTime Date { get; set; }


        public Order()
        {
            Date = DateTime.Now;
        }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual User User { get; set; }


    }
}