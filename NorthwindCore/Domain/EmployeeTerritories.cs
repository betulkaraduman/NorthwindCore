using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Domain
{
   public class EmployeeTerritories
    {
        public int EmployeeId { get; set; }

        public int TerritoriesId { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual Territories Territories { get; set; }

    }
}
