using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vehicle_Test.Models;
using Vehicle_Test.Models.ViewModel;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Vehicle_Test.Controllers
{    [Authorize]
    public class RentalsController : Controller
    {
        // GET: Rentals
        private ApplicationDbContext _context;
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var Customers = _context.Customers.ToList();
            var availableVehicles = _context.Vehicles.Where(c => c.IsAvailable == true).ToList();
            var passToView = new RentalViewModel()
            {
                Customers=Customers,
                Vehicles=availableVehicles
            };
            return View(passToView);
        }
       [HttpPost]
        public ActionResult Rent(RentalValidation rentalValidation)
      
        {

          
            var passToView = new RentalViewModel()
            {
                SelectedCustomer= rentalValidation.SelectedCustomer,
                SelectedVehicle= rentalValidation.SelectedVehicle,
                Vehicles= _context.Vehicles.Where(c => c.IsAvailable == true).ToList(),
                Customers = _context.Customers.ToList()
            };
            if (!ModelState.IsValid)
            {
                return View("Index", passToView);
            }
            var activeRentalObject = new ActiveRental();
            var vehicle = _context.Vehicles.Include(c=>c.VehicleType).SingleOrDefault(c => c.Id == rentalValidation.SelectedVehicle);
            var customer = _context.Customers.Include(c => c.Gender).SingleOrDefault(c => c.Id == rentalValidation.SelectedCustomer);
            vehicle.IsAvailable = false;
            customer.IsActive = true;
            activeRentalObject.CustomerName = customer.Name;
            activeRentalObject.VehicleNumber = vehicle.Number;
            activeRentalObject.VehicleName = vehicle.Name;
            activeRentalObject.IssueTime = DateTime.Now;
            activeRentalObject.VehicleId = vehicle.Id;
            activeRentalObject.CustomerId = customer.Id;
            activeRentalObject.VehicleTypeId = vehicle.VehicleTypeId;
            _context.ActiveRentals.Add(activeRentalObject);
           
           
                _context.SaveChanges();

          return RedirectToAction("ActiveRentals");
        
        }

        public ActionResult ActiveRentals()
        {
           
            var RentalsList = new ActiveRentalsList()
            {
                ActiveRentals = _context.ActiveRentals.ToList()
            };
            return View(RentalsList);
        }

        public ActionResult Remove(int id,int vehicleId,DateTime issueTime,int customerId)
        {
            var vehicle = _context.Vehicles.Include(c => c.VehicleType).SingleOrDefault(c => c.Id == vehicleId);
            var customer = _context.Customers.Include(c => c.Gender).SingleOrDefault(c => c.Id == customerId);

            var vehicleTypeId = vehicle.VehicleTypeId;
            vehicle.IsAvailable = true;
            var activeCustomerInstances = _context.ActiveRentals.Where(a => a.CustomerId == customer.Id).ToList().Count();
            if (activeCustomerInstances == 1)
            {
                customer.IsActive = false;

            }


            var removeRentalObject = _context.ActiveRentals.SingleOrDefault(c => c.Id == id);
            _context.ActiveRentals.Remove(removeRentalObject);
            _context.SaveChanges();
           
            var returnTime = DateTime.Now;
            var diff = returnTime.Subtract(issueTime);
            var billingObject = new Billing();
            switch (vehicleTypeId)
            {
                case 1:billingObject.rentalBill = (diff.Hours + 1) * 50;
                    billingObject.TotalBill = Math.Ceiling((billingObject.rentalBill * billingObject.TaxRate*0.01)+(billingObject.rentalBill));
                       break;

                case 2:
                    billingObject.rentalBill = (diff.Hours + 1) * 70;
                    billingObject.TotalBill = Math.Ceiling((billingObject.rentalBill * billingObject.TaxRate * 0.01) + (billingObject.rentalBill));
                    break;

                case 3:
                    billingObject.rentalBill = (diff.Hours + 1) * 200;
                    billingObject.TotalBill = Math.Ceiling((billingObject.rentalBill * billingObject.TaxRate * 0.01) + (billingObject.rentalBill));
                    break;

                case 4:
                    billingObject.rentalBill = (diff.Hours + 1) * 500;
                    billingObject.TotalBill = Math.Ceiling((billingObject.rentalBill * billingObject.TaxRate * 0.01) + (billingObject.rentalBill));
                    break;
            }

            var passToView = new BillingViewModel()
            {   CustomerName=customer.Name,
                Billing=billingObject

            };
           
             return View(passToView);
        }
    }
}