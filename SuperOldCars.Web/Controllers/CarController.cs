using SuperOldCars.Web.Models;
using SuperOldCars.Web.Repositories;
using System;
using System.Globalization;
using System.Web.Mvc;

namespace SuperOldCars.Web.Controllers
{
    public class CarController : Controller
    {
        private static CarRepository _carRepository = new CarRepository();

        //
        // GET: /Car/

        public ActionResult Index()
        {
            ViewBag.TotalCarsSum = String.Format("{0:c}", _carRepository.GetCarsPriceSum());
            return View(_carRepository.GetAllCars());
        }

        //
        // GET: /Car/Details/5

        public ActionResult Details(int id)
        {
            Car car = _carRepository.GetCar(id);

            if (car == null) return RedirectToAction("Index");

            return View(car);
        }

        //
        // GET: /Car/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Car/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Car car = new Car();

                TryUpdateModel(car, collection);

                if (!ModelState.IsValid) return View();

                _carRepository.AddCar(car);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Car/Edit/5

        public ActionResult Edit(int id)
        {
            Car car = _carRepository.GetCar(id);

            if (car == null) return RedirectToAction("Index");

            return View(car);
        }

        //
        // POST: /Car/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {

                if (_carRepository.GetCar(id) == null) return RedirectToAction("Index");

                Car car = new Car();

                TryUpdateModel(car, collection);

                if (!ModelState.IsValid) return View(_carRepository.GetCar(id));

                _carRepository.UpdateCar(car);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Source + " - " + ex.Message);
                return View(_carRepository.GetCar(id));
            }
        }

        //
        // GET: /Car/Delete/5

        public ActionResult Delete(int id)
        {
            Car car = _carRepository.GetCar(id);

            if (car == null) return View("Index");

            return View(car);
        }

        //
        // POST: /Car/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _carRepository.DeleteCar(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}