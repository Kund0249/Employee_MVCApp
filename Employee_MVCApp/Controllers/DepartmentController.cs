using Employee_MVCApp.DataAccess.Entity;
using Employee_MVCApp.Models;
using Employee_MVCApp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_MVCApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentProcessor processor;
        public DepartmentController()
        {
            processor = new DepartmentProcessor();
        }

        [HttpGet]
        public ActionResult Index()
        {
            //List<Department> departments = processor.GetDepartments;
            //List<DepartmentModel> models = new List<DepartmentModel>();

            //foreach (Department item in processor.GetDepartments)
            //{
            //    models.Add(DepartmentModel.Convert(item));
            //}

            //List<DepartmentModel> models = (from department in processor.GetDepartments
            //                                select new DepartmentModel()
            //                                {
            //                                    DepartmentCode = department.DepartmentCode,
            //                                    DepartmentName = department.DepartmentName,
            //                                }).ToList();

            List<DepartmentModel> models = (from department in processor.GetDepartments
                                            select DepartmentModel.Convert(department))
                                            .ToList();

            return View(models);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DepartmentModel model)
        {
            processor.Add(DepartmentModel.Convert(model));
            TempData["Message"] = $"New Department with Code - {model.DepartmentCode}, created successfully";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Department department = processor.GetDepartment(id);
            if(department != null)
            {
                return View(DepartmentModel.Convert(department));
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(DepartmentModel model)
        {
            Department department = processor.GetDepartment(model.Id);
            if (department != null)
            {
                processor.Update(DepartmentModel.Convert(model));
                TempData["Message"] = $"Department {department.DepartmentCode}, updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            processor.Remove(id);
            TempData["Message"] = $"Department with id - {id}, removed successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}