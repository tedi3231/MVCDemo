using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Name = "tedi";
            return View("DebugData", new Domain.Model.Product() { Id = 1, ProductName = "IPAD2", Remark = "test", ProcessId = "MDM20023232", Price = 2000.00M });
        }

    }
}
