using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoApplication.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public string GetAllCustomers()
        {

            //Fetch data from db 

            return @"<ul>
                <li> Drake</li>
                <li> Drake</li>
                <li> Drake</li>
                <li> Drake</li>
                <li> Drake</li>
  
            ";

        }


    }
}