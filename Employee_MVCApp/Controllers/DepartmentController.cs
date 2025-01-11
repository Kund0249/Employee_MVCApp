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
        public ActionResult Index(int PageNo = 1)
        {
            int PageSize = 3;
            
            List<DepartmentModel> models = (from department in processor.GetDepartments(PageNo, PageSize,out int TotalCount)
                                            select DepartmentModel.Convert(department))
                                            .ToList();

            

            PagerModel pager = new PagerModel();
            pager.TotalCount = TotalCount;
            pager.PageSize = PageSize;
            pager.TotalPage = TotalCount / PageSize;
            pager.LastPage = TotalCount / PageSize;
            pager.CurrentPage = PageNo;

            if(PageNo > pager.LastPage)
            {
                return RedirectToAction(nameof(Index), new { PageNo = 1 });
            }

            DepartmentWrapper wrapper = new DepartmentWrapper()
            {
                Departments = models,
                Pager = pager
            };

            return View(wrapper);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DepartmentModel model)
        {
            if (ModelState.IsValid)
            {
                processor.Add(DepartmentModel.Convert(model));
                TempData["Message"] = $"New Department with Code - {model.DepartmentCode}, created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
           
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