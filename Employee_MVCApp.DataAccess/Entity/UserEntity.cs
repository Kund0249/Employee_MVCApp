﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_MVCApp.DataAccess.Entity
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }

        public string EmailAddress { get; set; }

        public string Mobile { get; set; }
        
        public string Password { get; set; }
    }
}
