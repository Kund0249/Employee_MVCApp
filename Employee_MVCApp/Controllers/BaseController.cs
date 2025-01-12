using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Employee_MVCApp.Controllers
{
    public enum MessageType
    {
        success,info,warning,error
    }
    public class BaseController : Controller
    {
        // GET: Base
        public void ShowMessage(string message,string title,MessageType messageType)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            TempData["Content"] = serializer.Serialize(new
            {
                Message = message,
                Title = title,
                AlertType = messageType.ToString()
            });
        }
    }
}