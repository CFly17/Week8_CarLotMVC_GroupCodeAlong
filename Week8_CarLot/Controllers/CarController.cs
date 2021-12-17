using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8_CarLot.Models;

namespace Week8_CarLot.Controllers
{
    public class CarController : Controller
    {

        CarDAL cdal = new CarDAL();
        public IActionResult Index()
        {
            List<Car> cars = cdal.GetCars();
            return View(cars);
        }

        public IActionResult CreateCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCar(Car c)
        {
            cdal.CreateCar(c);
            return RedirectToAction("Index", "Car");
        }

        public IActionResult DeleteCar(int id)
        {
            cdal.DeleteCar(id);
            return RedirectToAction("Index", "Car");
        }

        public IActionResult UpdateCar(int id)
        {
            Car c = cdal.GetCar(id);
            return View(c);
        }

        [HttpPost]
        public IActionResult UpdateCar(Car c)
        {
            cdal.UpdateCar(c);
            return RedirectToAction("Index", "Car");
        }

    }
}
