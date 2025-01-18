using Employee_MVCApp.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_MVCApp.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }

        public string EmailAddress { get; set; }

        public string Mobile { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Password and Confirm Password does not match!")]
        public string cnfPassword { get; set; }

        public static UserEntity Convert(UserModel model)
        {
            return new UserEntity()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                EmailAddress = model.EmailAddress,
                Mobile = model.Mobile,
                Password = model.Password
            };
        }
    }
}