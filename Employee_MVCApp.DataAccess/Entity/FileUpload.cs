using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Employee_MVCApp.DataAccess.Entity
{
    [Table("TFILEINFO")]
    public class FileUpload
    {
        [Key]
        public int SystemNumber { get; set; }

        public string ContentName { get; set; }

        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
