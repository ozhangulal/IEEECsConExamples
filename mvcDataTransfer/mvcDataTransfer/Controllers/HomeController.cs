using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Messages1"] = "this is viewdata message";
            ViewBag.Messages2 = "this is viewbag message";


            return View();
        }
    }
}