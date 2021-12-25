using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaskMvcProductOrder.Models
{
    public class ProductOrder
    {
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int OrderId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}