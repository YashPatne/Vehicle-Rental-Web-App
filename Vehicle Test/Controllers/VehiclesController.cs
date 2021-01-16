using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vehicle_Test.Models;
using Vehicle_Test.Models.ViewModel;

namespace Vehicle_Test.Controllers
{  [Authorize]
    public class VehiclesController : Controller
    {
        // GET: Vehicles
        private ApplicationDbContext _context;

        public VehiclesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()

        {
            
            var vehicleList = new VehicleList() { 
            ListOfVehicles= _context.Vehicles.Include(c=>c.VehicleType).ToList(),

        };
            

            return View(vehicleList);
        }

        public ActionResult Delete(int id)
        {
            var vehicleInDb = _context.Vehicles.Include(c=>c.VehicleType).SingleOrDefault(c => c.Id == id);
            _context.Vehicles.Remove(vehicleInDb);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult New()
        {
            var vehicleTypeList = _context.VehicleTypes.ToList();
            var passToView = new VehicleViewModel()
            {   Vehicle= new Vehicle(),
                VehicleType=vehicleTypeList

            };
            return View(passToView);
        }

        public ActionResult Edit(int id)
        {
            var vehicleTypeList = _context.VehicleTypes.ToList();
            var fetchVehicle = _context.Vehicles.SingleOrDefault(c => c.Id == id);
            var passToView = new VehicleViewModel()
            {
                Vehicle = fetchVehicle,
                VehicleType = vehicleTypeList

            };
            return View("New",passToView);
            //return Content(fetchVehicle.Name);
        }
        [HttpPost]
        public ActionResult Save(Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                var passToView = new VehicleViewModel()
                {
                    Vehicle = vehicle,
                    VehicleType = _context.VehicleTypes.ToList()

                };
                return View("New", passToView);
            }
            if (vehicle.Id == 0)
            {
                vehicle.IsAvailable = true;
                _context.Vehicles.Add(vehicle);
               

            }
            else
            {
                var temp = _context.Vehicles.SingleOrDefault(c=>c.Id==vehicle.Id);
                temp.Name = vehicle.Name;
                temp.Number = vehicle.Number;
                temp.VehicleTypeId = vehicle.VehicleTypeId;
                
                

            }

            _context.SaveChanges();
            return RedirectToAction("Index","Vehicles");
        }
    }
}