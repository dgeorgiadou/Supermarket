using Microsoft.PowerBI.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Supermarket.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            //using (PowerBIClient client = new PowerBIClient(new Uri(" "), ""))
            //{ 

            //}
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}