using Employee_MVCApp.Models;
using Employee_MVCApp.Processing;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee_MVCApp.DataAccess.Repository;
using System.Web.Security;

namespace Employee_MVCApp.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager userManager = new UserManager();
        private readonly DataContext db = new DataContext();
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var data = db.user.SingleOrDefault(x =>
                x.EmailAddress.ToLower() == model.UserId.ToLower()
                || x.Mobile == model.UserId);

                if (data == null)
                    return RedirectToAction(nameof(Register));

                if(data.Password == model.Password)
                {
                    FormsAuthentication.RedirectFromLoginPage(model.UserId, false);
                }
                else
                {
                    ShowMessage("Incorrect userId or password!", "Invalid Credentials", MessageType.error);
                }
            }
            return View();
        }



        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                userManager.Add(UserModel.Convert(userModel));
                return RedirectToAction(nameof(Login));
            }
            return View();
        }
    }
}