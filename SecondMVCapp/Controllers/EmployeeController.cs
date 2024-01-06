using SecondMVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SecondMVCapp.Controllers
{
   
    public class EmployeeController:Controller
    {
        List<Employee> employee;
        List<Product> product;
        public EmployeeController()
        {
            employee = new List<Employee>
            {
                new Employee {empId=1,empName="Saurabh Sakharkar",address="Pune",phone=4755249 },
                new Employee {empId=2,empName="Sakshi Rajurkar",address="Warora",phone=7248321},
                new Employee {empId=3,empName="Rani Pawar",address="Nagpur",phone=792412},
                new Employee {empId=4,empName="Ajit Rana",address="Delhi",phone=9234143}
            };
            product = new List<Product>
            {
              new Product{prodId=1,propName="Shoes",prodCompany="Nike",shippingDate="12/12/2023",address="Yatra ward, pune"},
              new Product{prodId=2,propName="Mobile",prodCompany="Samsung",shippingDate="12/01/2024",address="Gandhi Chowk, Warora"},
              new Product{prodId=3,propName="Bags",prodCompany="Skybags",shippingDate="11/10/2023",address="Chattrapati Chowk,Nagpur"},
              new Product{prodId=4,propName="Watch",prodCompany="Boats",shippingDate="14/11/2023",address="Tukum, Chandrapur"},
              new Product{prodId=5,propName="Sunglasses",prodCompany="Lenskart", shippingDate="19/2/2024",address="Patil chowk, Solapur"}
            };


        }
       
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            ViewData["PageTitle"] = "Welcome To Customers List!";
            ViewData["PageSubTitle"] = "Customers Of Synechron Pvt. Ltd. From Globe!";
            ViewData["Product"] = product;
            return View(employee);
        }
    }
}