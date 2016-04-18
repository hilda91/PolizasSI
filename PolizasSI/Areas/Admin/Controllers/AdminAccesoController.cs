using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolizasSI.Areas.Admin.Controllers
{
    public class AdminAccesoController : Controller
    {
        // GET: Admin/AdminAcceso
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormIndex()
        {
            return View();
        }
        public ActionResult Logout()
        {
           return Index();
            
        }

    }
}