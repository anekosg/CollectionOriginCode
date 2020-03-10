
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Core.Model
{

    public class DBEFDataContext : DbContext
    {
        public DBEFDataContext():base("DBEFDataEntities")
        {
        }
        public DbSet<Employee> Employee { get; set; }
    }

 
}
