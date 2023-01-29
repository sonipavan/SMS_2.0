using SMS_2_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SMS_2_0.Controllers
{
    public class LoginController : Controller
    {
        
        SMS_DatabaseEntities SMS = new SMS_DatabaseEntities();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(SMS_Tbl_Login sMS)
        {
            if(ModelState.IsValid)
            {
                bool IsValidUser = SMS.SMS_Tbl_Login.
                    Any(u => u.Login_UserName.ToLower()
                    == sMS.Login_UserName.ToLower() && 
                    sMS.User_Password == u.User_Password);
                
                if(IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(sMS.Login_UserName, false);
                    Session["UserName"] = sMS.Login_UserName;
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid user name or passworld");
            }
            return View();
        
        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}