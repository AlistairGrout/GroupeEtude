using Forum.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            Util.Instance.GenerateDB();
            return View();
        }
    }
}