using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_MVCApp.Controllers
{
    public class TestController : Controller
    {

        //Action Method
        /*
           It should be public
           It can be not overload
           Its operate on Http Verbs
         */

        [HttpGet]
        public string GetMessage()
        {
            return "Hellow from Test Controller.";
        }

        [HttpPost]
        public string GetMessage(int id)
        {
            return "Hellow from Test 2 Controller.";
        }
    }
}