using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8_CarLot.Models;

namespace Week8_CarLot.Controllers
{
    public class CarownerController : Controller
    {
        CarownerDAL coDAL = new CarownerDAL();
        public IActionResult Index()
        {
            List<Carowner> carowners = coDAL.GetCarowners();
            return View(carowners);
        }
    }
}
