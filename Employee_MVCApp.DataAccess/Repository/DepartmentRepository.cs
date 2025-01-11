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

        public List<Department> GetDepartments(int PageNo,int Pagesize,out int TotalCont)
        {
            TotalCont = context.Departments.ToList().Count;
            return context.Departments.OrderBy(x => x.SystemNumber).Skip((PageNo-1)* Pagesize).Take(Pagesize).ToList();

        }

        public Department GetDepartment(int DepartmentId)
        {
            return context.Departments.SingleOrDefault(x => x.SystemNumber == DepartmentId);
        }

        public void Update(Department department)
        {
            var Department = context.Departments.SingleOrDefault(x => x.SystemNumber == department.SystemNumber);
            if (Department != null)
            {
                Department.DepartmentName = department.DepartmentName;
                Department.DepartmentCode = department.DepartmentCode;

                context.SaveChanges();
            }
        }

        public void Remove(int DepartmentId)
        {
            var department = context.Departments.SingleOrDefault(x => x.SystemNumber == DepartmentId);
            if (department != null)
            {
                context.Departments.Remove(department);
                context.SaveChanges();
            }
        }

    }
}
