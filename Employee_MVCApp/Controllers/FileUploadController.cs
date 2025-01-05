using Employee_MVCApp.Models;
using Employee_MVCApp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_MVCApp.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly FileProcessor fileProcessor;

        public FileUploadController()
        {
            fileProcessor = new FileProcessor();
        }
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(FileUploadModel model)
        {
            string ext = Path.GetExtension(model.File?.FileName).ToLower();

            List<string> supportedFileType = new List<string>() {".png",".jpg",".jpeg"};

            if(supportedFileType.Any(x => x == ext))
            {
                string folderName = "~/UploadedFile";
                string fileName = Path.GetFileNameWithoutExtension(model.File?.FileName) 
                    +"_G" + Guid.NewGuid().ToString() + Path.GetExtension(model.File?.FileName);
                string filePath = Path.Combine(Server.MapPath(folderName),fileName);

                model.File.SaveAs(filePath);
                model.FileName = fileName;

                fileProcessor.Save(FileUploadModel.Convert(model));
            }
            else
            {
                ViewBag.Message = "Supported files type are - '\".png\",\".jpg\",\".jpeg\"'";
            }

            return View();
        }
    }
}