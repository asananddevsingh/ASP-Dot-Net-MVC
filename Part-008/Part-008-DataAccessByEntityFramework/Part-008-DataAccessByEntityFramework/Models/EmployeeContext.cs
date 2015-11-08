using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Part_008_DataAccessByEntityFramework.Models
{
    public class EmployeeContext  : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}