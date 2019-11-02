using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp2.Domain
{
   public class Territories
    {
        [Key]
        public int TerritoryId { get; set; }
        public string Description { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}
