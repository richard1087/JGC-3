using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CORE.JGC.Controllers;

namespace JGC.Controllers
{
    public class WebLoginController : Controller
    {
        // GET: WebLogin
        public ActionResult Index()
        {
            var ctrl = new LoginController();
            ctrl.ControllerContext = ControllerContext;
            return View();
        }
    }
}