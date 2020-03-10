using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{

    public class DBEFDataContext : DbContext
    {
        public DBEFDataContext(DbContextOptions<DBEFDataContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
    }

 
}
