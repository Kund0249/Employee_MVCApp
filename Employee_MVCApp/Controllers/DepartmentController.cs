using Employee_MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Employee_MVCApp.Controllers
{
    public class DepartmentController : Controller
    {

        [HttpGet]
        public ViewResult Index()
        {
            List<DepartmentModel> list = new List<DepartmentModel>()
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

            return View(list);
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
            return View();
        }
    }
}