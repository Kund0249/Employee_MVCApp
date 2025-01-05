using Employee_MVCApp.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_MVCApp.DataAccess.Repository
{
    public class FileRepository
    {
        private readonly DataContext context;
        public FileRepository()
        {
            context = new DataContext();
        }
        public void Save(FileUpload fileUpload)
        {
            context.FileUploads.Add(fileUpload);
            context.SaveChanges();
        }
    }
}
