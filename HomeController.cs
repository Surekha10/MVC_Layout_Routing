using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Layout_Routing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Route("Pathfront")]
        public ActionResult AboutUs()
        {
            return View();
        }
        [Route("Message/{msg:maxlength(10)?}")]
        public ActionResult GetMessage(string msg="No Message")
        {
            ViewBag.msg = msg;
            return View();
        }
    }
}