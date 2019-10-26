using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoC.Controllers
{
    public class ArmyController : Controller
    {
        // GET: Army
        public ActionResult ArmyIndex()
        {
            ViewBag.Title = "Army";

            return View();
        }
    }
}