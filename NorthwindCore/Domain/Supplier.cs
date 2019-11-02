using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp2.Domain
{
  public  class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        //  public string Region { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public string PostalCode { get; set; }
    }
}
