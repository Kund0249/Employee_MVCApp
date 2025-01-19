using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_MVCApp.DataAccess.Entity
{
    [Table("TEMPLOYEE")]
    public class Employee
    {
        [Key]
        public int Empid { get; set; }

        public string EmpName { get; set; }
        public string Gender { get; set; }

        [Column("EmailId")]
        public string EmailAddress { get; set; }

        public string MobNo { get; set; }
    }
}
