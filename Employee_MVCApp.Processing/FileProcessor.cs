using Employee_MVCApp.DataAccess.Entity;
using Employee_MVCApp.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_MVCApp.Processing
{
    public class FileProcessor
    {
        private readonly FileRepository fileRepository;
        public FileProcessor()
        {
            fileRepository = new FileRepository();
        }

        public void Save(FileUpload fileUpload)
        {
            try
            {
                fileRepository.Save(fileUpload);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
