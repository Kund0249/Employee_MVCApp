using Employee_MVCApp.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Employee_MVCApp.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Department Code is mandatory")]
        [StringLength(4,ErrorMessage ="Code can not be exceed more than 4 character")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "Department Name is mandatory")]
        [RegularExpression("[A-Za-z\\s]*",ErrorMessage ="Only aphabets are allowed")]
        public string DepartmentName { get; set; }


        public static Department Convert(DepartmentModel model)
        {
            return new Department()
            {
                SystemNumber = model.Id,
                DepartmentCode = model.DepartmentCode,
                DepartmentName = model.DepartmentName,
                Description = ""
            };
        }

        public static DepartmentModel Convert(Department model)
        {
            return new DepartmentModel()
            {
                Id = model.SystemNumber,
                DepartmentCode = model.DepartmentCode,
                DepartmentName = model.DepartmentName
            };
        }
    }

    public class DepartmentWrapper
    {
        public List<DepartmentModel> Departments { get; set; }

        public PagerModel Pager { get; set; }
    }
}