using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp2.Domain
{
  public  class Orders
    {
        [Key]
        public int OrdersId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }
        public DateTime ShipperDate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }

        public string ShippAdress { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateTime { get; set; }
        public string RowGuid { get; set; }
        public DateTime UpdateTime { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Custumer Custumer { get; set; }
        public virtual Shipper  Shipper{ get; set; }

        public virtual ICollection<OrdersDetail > OrdersDetails { get; set; }
    }
}
