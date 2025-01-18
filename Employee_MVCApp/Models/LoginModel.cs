using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_MVCApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="User Id is mandatory")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set; }
    }
}