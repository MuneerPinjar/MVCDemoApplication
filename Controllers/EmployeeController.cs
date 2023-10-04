using MVCDemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDetail() { 


            //strong type binding
            Employee employee = new Employee();
            employee.Id = 101;
            employee.Name= "Test";
            employee.Age = 30;
            employee.Department = "Test Department";

           // ViewBag.Employee = employee;

            return View(employee);
        
        }
    }
}