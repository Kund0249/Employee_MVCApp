using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_MVCApp.Models
{
    public class EmployeeDepartmentWrapper
    {
        public List<EmployeeModel> employees { get; set; }
        public List<DepartmentModel> departments { get; set; }
    }
}