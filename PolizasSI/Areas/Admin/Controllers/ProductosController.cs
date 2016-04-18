using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolizasSI.Areas.Admin.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Admin/Productos
        public ActionResult Index()
        {
            return View();
        }
    }
}