using Employee_MVCApp.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_MVCApp.Models
{
    public class DepartmentModel
    {
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }


        public static Department Convert(DepartmentModel model)
        {
            return new Department()
            {
                DepartmentCode = model.DepartmentCode,
                DepartmentName = model.DepartmentName,
                Description = ""
            };
        }

        public static DepartmentModel Convert(Department model)
        {
            return new DepartmentModel()
            {
                DepartmentCode = model.DepartmentCode,
                DepartmentName = model.DepartmentName
            };
        }
    }
}