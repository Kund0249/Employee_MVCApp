using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee_MVCApp.DataAccess.Entity;

namespace Employee_MVCApp.Models
{
    public class FileUploadModel
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public string FileName { get; set; } 
        public HttpPostedFileBase File { get; set; }

        public static FileUpload Convert(FileUploadModel model)
        {
            return new FileUpload()
            {
                FileName = model.FileName,
                ContentName = model.Content,
                FilePath = model.FileName
            };
        }
    }
}