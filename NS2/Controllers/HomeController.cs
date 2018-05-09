using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Operators;

namespace NS2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            LocalPostOperator postOperator = new LocalPostOperator();

            return View(postOperator.Read("example1"));
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}