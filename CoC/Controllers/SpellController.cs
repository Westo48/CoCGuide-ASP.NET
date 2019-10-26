using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoC.Controllers
{
    public class SpellController : Controller
    {
        // GET: Spell
        public ActionResult SpellIndex()
        {
            ViewBag.Title = "Spells";
            
            return View();
        }
        public ActionResult Lightning()
        {
            ViewBag.Title = "Lightning Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Healing()
        {
            ViewBag.Title = "Healing Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Rage()
        {
            ViewBag.Title = "Rage Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Jump()
        {
            ViewBag.Title = "Jump Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Freeze()
        {
            ViewBag.Title = "Freeze Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Clone()
        {
            ViewBag.Title = "Clone Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Poison()
        {
            ViewBag.Title = "Poison Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Earthquake()
        {
            ViewBag.Title = "Earthquake Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Haste()
        {
            ViewBag.Title = "Haste Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Skeleton()
        {
            ViewBag.Title = "Skeleton Spell";
            ViewBag.Description = "";

            return View();
        }
        public ActionResult Bat()
        {
            ViewBag.Title = "Bat Spell";
            ViewBag.Description = "";

            return View();
        }
    }
}