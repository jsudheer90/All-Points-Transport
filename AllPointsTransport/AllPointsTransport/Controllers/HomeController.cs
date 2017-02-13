using AllPointsTransport.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AllPointsTransport.Controllers
{
    [AuthActionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RateQuotes()
        {
            return View();
        }

        public ActionResult Accounting()
        {
            return View();
        }

        public ActionResult CSRScreen()
        {
            return View();
        }

        public ActionResult Scheduler()
        {
            return View();
        }

        public ActionResult Dispatch()
        {
            return View();
        }

        public ActionResult Inventory()
        {
            return View();
        }


    }
}