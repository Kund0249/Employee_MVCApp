using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Employee_MVCApp.DataAccess.Entity;

namespace Employee_MVCApp.DataAccess.Repository
{
    internal class DataContext : DbContext
    {
        public DataContext():base("name=DbCon")
        {
            
        }

        public DbSet<Department> Departments { get; set; }
    }
}
