using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class AppController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.FirstName = "Ashley";
            ViewBag.LastName = "MacWhirter";
            return View();
        }
        public ActionResult About()
		{
            ViewBag.AppName = "First MVC .NET app... Woohoo!";
			return View();
		}
        public ActionResult Contact()
		{
			return View();
		}
    }
}
