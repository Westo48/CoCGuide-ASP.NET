using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoC.Controllers
{
    public class BldgsController : Controller
    {
        // GET: Bldgs
        public ActionResult BuildingsIndex()
        {
            ViewBag.Title = "Buildings";

            return View();
        }
    }
}