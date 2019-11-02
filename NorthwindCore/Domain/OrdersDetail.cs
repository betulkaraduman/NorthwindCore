using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace ConsoleApp2.Domain
{
   public class OrdersDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Product Product { get; set; }
    }
}
