using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
//using SMS_MGR.Dashboard_Mgr;
//using SMS_DA.DashBoard_DA;

namespace SMS_2._0.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //private IDashboard_DA 
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}