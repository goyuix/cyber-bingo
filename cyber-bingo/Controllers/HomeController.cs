using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cyber_bingo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                var random = new Random();
                return RedirectToAction("Index", "Home", new { id = random.Next() });
            }

            ViewBag.Id = id;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
