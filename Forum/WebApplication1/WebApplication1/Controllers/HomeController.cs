using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
<<<<<<< HEAD

=======
<<<<<<< HEAD

            ViewBag.Message = "Test";
=======
<<<<<<< HEAD
>>>>>>> 2c56a6417933fad07da2a51fd7a42e11b5e9d75b
            ViewBag.Message = "Test";

            ViewBag.Message = "Nouvelle application description !";
<<<<<<< HEAD

=======
>>>>>>> 95aeb3e71dd013b4b301e18e7905a6fbd554fef6
>>>>>>> a45aaeeb7bc9ce627da71aabe211d2cd85e978c1
>>>>>>> 2c56a6417933fad07da2a51fd7a42e11b5e9d75b

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}