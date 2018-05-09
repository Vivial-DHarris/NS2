using System.Web.Mvc;
using NS2.Models;
using Services.Operators;

namespace NS2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            LocalPostOperator postOperator = new LocalPostOperator();

            // By using a constructor that converts the DataModel into our ViewModel
            //   We've controlled what actually gets sent to the Client.
            LocalPostSimple viewModel = new LocalPostSimple(postOperator.Read("example1"));

            return View(viewModel);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}