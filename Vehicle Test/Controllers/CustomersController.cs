using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vehicle_Test.Models;
using Vehicle_Test.Models.ViewModel;
using System.Data.Entity;

namespace Vehicle_Test.Controllers
{   [Authorize]
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var customerList = new CustomerList()
            {
                ListOfCustomers = _context.Customers.ToList()

            };
            return View(customerList);
        }

        public ActionResult New()
        {
            var genderList = _context.Genders.ToList();
            var passToView = new CustomerViewModel()
            {
                Customer = new Customer(),
                Gender = genderList

            };
            return View(passToView);
        }

        public ActionResult Delete(int id)
        {
            var customerInDb = _context.Customers.Include(c=>c.Gender).SingleOrDefault(c => c.Id == id);
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            var genderList = _context.Genders.ToList();
            var fetchcustomer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var passToView = new CustomerViewModel()
            {
                Customer = fetchcustomer,
                Gender = genderList

            };
            return View("New", passToView);
            //return Content(fetchVehicle.Name);
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {

            if (!ModelState.IsValid)
            {
                var passToView = new CustomerViewModel()
                {
                    Customer = customer,
                    Gender = _context.Genders.ToList()

            };
                return View("New", passToView);
            }
            if (customer.Id == 0)
            {
                customer.IsActive = false;
                _context.Customers.Add(customer);


            }
            else
            {
                var temp = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);
                temp.Name = customer.Name;
                temp.BirthDate = customer.BirthDate;
                temp.GenderId = customer.GenderId;
                temp.LicenseNumber = customer.LicenseNumber;
                temp.MobileNumber = customer.MobileNumber;


            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
    }
}



