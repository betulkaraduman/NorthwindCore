using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp2.Domain
{
  public  class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Title { get; set; }
        public DateTime BDay { get; set; }
        public DateTime HireDay { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
      //  public string Region { get; set; }
        public string PostalCode { get; set; }
        //public Employee employee { get; set; }
        //public virtual ICollection<Employee> GetEmployees { get; set; }
        //public int RepostTo  { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}
