using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

using Employee_MVCApp.DataAccess.Entity;

namespace Employee_MVCApp.DataAccess.Repository
{
    public class DataContext : DbContext
    {
        public DataContext():base("name=DbCon")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<FileUpload> FileUploads { get; set; }

        public DbSet<UserEntity> user { get; set; }
    }
}
