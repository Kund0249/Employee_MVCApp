using Employee_MVCApp.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_MVCApp.DataAccess.Repository
{
    public class DepartmentRepository
    {
        private readonly DataContext context;
        public DepartmentRepository()
        {
            context = new DataContext();
        }
        public void Add(Department department)
        {
            //code
            context.Departments.Add(department);
            context.SaveChanges();
        }
    }
}
