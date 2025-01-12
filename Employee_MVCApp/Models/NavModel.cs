using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_MVCApp.Models
{
    public class NavModel
    {
        public string NavText { get; set; }
        public string actionName { get; set; }
        public string controllerName { get; set; }

        public bool isActive { get; set; }
    }
}