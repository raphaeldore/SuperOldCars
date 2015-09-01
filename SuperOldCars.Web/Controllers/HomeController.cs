using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperOldCars.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Le site avec la plus grande sélection de voitures d'antan au monde!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nous n'avons rien à partager.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pour mieux vous servir!";

            return View();
        }

        //
        // POST: /Home/Contact

        [HttpPost]
        public ActionResult Contact(FormCollection collection)
        {
            try
            {
                ViewBag.MessageConfirmation = "Votre message a bien été reçu!";

                //return RedirectToAction("Contact");
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
