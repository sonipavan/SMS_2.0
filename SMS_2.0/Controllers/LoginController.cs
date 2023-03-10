using SMS_OBJ.Login_;
using SMS_2_0;
using SMS_MGR.Login;
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
        readonly ILogin_Mgr Login_Mgr1;

        public LoginController(ILogin_Mgr Login_Mgr1)
        {
            this.Login_Mgr1 = Login_Mgr1;
        }

        Login_ login = new Login_();
        //SMS_DatabaseEntities SMS = new SMS_DatabaseEntities();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login_ sMS)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    Login_ data = Login_Mgr1.GetLogin(sMS.Login_UserName, sMS.User_Password);
                   
                    if (data.Flag == "True")
                    {

                        FormsAuthentication.SetAuthCookie(data.Login_UserName, false);
                        //FormsAuthentication.SetAuthCookie("pavan", false);
                        Session["UserName"] = data.Login_UserName;
                        //Session["UserName"] = "pavan";
                        Session["Role"] = data.Role_Name;
                        return RedirectToAction("Index", "Home");

                    }
                    ModelState.AddModelError("", "Invalid user name or passworld");
                }
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}