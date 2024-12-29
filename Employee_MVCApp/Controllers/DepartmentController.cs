using Employee_MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Employee_MVCApp.Processing;

namespace Employee_MVCApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentProcessor processor;

        public DepartmentController()
        {
            processor  = new DepartmentProcessor();
        }

        [HttpGet]
        public ViewResult Index()
        {
            List<DepartmentModel> departmentList = new List<DepartmentModel>()
           {
            new DepartmentModel()
            {
                DepartmentCode = "IT",
                DepartmentName = "Information Technology"
            },
             new DepartmentModel()
            {
                DepartmentCode = "CS",
                DepartmentName = "Computer Science"
            },
              new DepartmentModel()
            {
                DepartmentCode = "F&A",
                DepartmentName = "Finance & Account"
            }
           };

            List<EmployeeModel> employeeList = new List<EmployeeModel>()
            {
                new EmployeeModel(){Id = 1, Name = "A",Gender = "M"},
                new EmployeeModel(){Id = 2, Name = "B",Gender = "M"},
                new EmployeeModel(){Id = 3, Name = "C",Gender = "F"},
                new EmployeeModel(){Id = 4, Name = "D",Gender = "F"},
            };

            //ViewBag.Employees = employeeList;
            //ViewBag.Departments = departmentList;

            //ViewData["Employees"] = employeeList;
            //ViewData["Departments"] = departmentList;

            EmployeeDepartmentWrapper wrapper = new EmployeeDepartmentWrapper()
            {
                employees = employeeList,
                departments = departmentList
            };

            return View(wrapper);
            //return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ViewResult Create(string txtDepartmentCode,string txtDepartmentName)
        //{
        //    return View();
        //}

        [HttpPost]
        public ViewResult Create(DepartmentModel model)
        {
            //Department department = new Department()
            //{
            //    DepartmentCode = model.DepartmentCode,
            //    DepartmentName = model.DepartmentName
            //};
            processor.Add(DepartmentModel.Convert(model));
            return View();
        }
    }
}