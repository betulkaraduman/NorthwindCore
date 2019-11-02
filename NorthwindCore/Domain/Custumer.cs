using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace ConsoleApp2.Domain
{
  public  class Custumer
    {
        [Key]
        public int CostumerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }

        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string Phone { get; set; }
        public string Fax { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }

    }
}
