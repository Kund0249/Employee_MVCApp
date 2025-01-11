
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_MVCApp.DataAccess.Repository;
using Employee_MVCApp.DataAccess.Entity;
using System.Runtime.Remoting.Contexts;

namespace Employee_MVCApp.Processing
{
    public class DepartmentProcessor
    {
        private readonly DepartmentRepository departmentRepository;

        public DepartmentProcessor()
        {
            departmentRepository = new DepartmentRepository();
        }
        public void Add(Department department)
        {
            try
            {
                departmentRepository.Add(department);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Department> GetDepartments(int PageNo,int PageSize,out int TotalCount)
        {
            try
            {
                return departmentRepository.GetDepartments(PageNo, PageSize,out TotalCount);
                
            }
            catch (Exception ex)
            {
                TotalCount = 0;
                return new List<Department>();
            }

        }

        public Department GetDepartment(int id)
        {
            try
            {
                return departmentRepository.GetDepartment(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Update(Department department)
        {
            try
            {
                departmentRepository.Update(department);
            }
            catch (Exception)
            {

            }
        }

        public void Remove(int DepartmentId)
        {
            try
            {
                departmentRepository.Remove(DepartmentId);
            }
            catch (Exception)
            {

            }
        }
    }
}
