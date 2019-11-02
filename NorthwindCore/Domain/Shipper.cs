using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp2.Domain
{
  public  class Shipper
    {
        [Key]
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        //public virtual ICollection<Product> Products{ get; set; } 
        public virtual ICollection<Orders> Orders{ get; set; }

    }
}
