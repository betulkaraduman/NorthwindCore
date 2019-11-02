using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace ConsoleApp2.Domain
{
  public  class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
        public virtual ICollection<Territories> Territories { get; set; }

    }
}
