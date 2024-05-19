using FormAuthDemo1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace FormAuthDemo1.Data
{
    public class EmployeeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EmployeeContext() : base("name=EmployeeContext")
        {
        }


        public System.Data.Entity.DbSet<FormAuthDemo1.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<FormAuthDemo1.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<FormAuthDemo1.Models.Reservation> Reservation { get; set; }

    }
}
