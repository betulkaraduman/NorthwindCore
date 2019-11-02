using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp2.Domain
{
   public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ShipperId { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStcok { get; set; }
        public int UnitOnOrder { get; set; }
        public bool DisContinued{ get; set; }
        public int ReorderLevel { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<OrdersDetail> OrdersDetails{ get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
