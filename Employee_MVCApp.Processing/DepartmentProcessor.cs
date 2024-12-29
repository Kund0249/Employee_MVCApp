
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_MVCApp.DataAccess.Repository;
using Employee_MVCApp.DataAccess.Entity;

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
    }
}
