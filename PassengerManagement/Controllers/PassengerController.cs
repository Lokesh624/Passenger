using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Passenger.Entities.Interfaces;

namespace PassengerManagement.Controllers
{
    public class PassengerController : Controller
    {
        private readonly IPassengerDetailsService _passengerDetailsService;
        public PassengerController(IPassengerDetailsService passengerDetailsService)
        {
            _passengerDetailsService = passengerDetailsService;
        }
        // GET: PassengerController
        public async Task<IActionResult> GetPassenger()
        {
            var result = await _passengerDetailsService.ViewPassenger();
            return View(result);
        }

        // GET: PassengerController/Details/5
        public ActionResult GetPassengerByID(int id)
        {
            return View();
        }

        // GET: PassengerController/Create
        public ActionResult RegisterPassenger()
        {
            return View();
        }

        // POST: PassengerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterPassenger(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PassengerController/Edit/5
        public ActionResult UpdatePassenger(int id)
        {
            return View();
        }

        // POST: PassengerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdatePassenger(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PassengerController/Delete/5
        public ActionResult DeletePassenger(int id)
        {
            return View();
        }

        // POST: PassengerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePassenger(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
