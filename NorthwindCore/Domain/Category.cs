using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace ConsoleApp2.Domain
{
   public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string image { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
