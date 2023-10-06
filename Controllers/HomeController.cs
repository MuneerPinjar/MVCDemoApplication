using MVCDemoApplication.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoApplication.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        //Action Methods


        //public ActionResult Index()
        //{
        //    // call GetAllCustomers

        //    //return RedirectToAction("GetAllCustomers", "Customer");
        //    //return View();
        //}


        //[OutputCache(Duration =15)]
        public string Index() {

            return "This is Demo MVC Application";
        }


        [OutputCache(Duration = 30)]
        public string GetCurrentTime()
        {
            
            return DateTime.Now.ToString("T");
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