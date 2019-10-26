using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoC.Controllers
{
    public class TrapBldgsController : Controller
    {
        // GET: TrapBldgs
        public ActionResult TrapBldgsIndex()
        {
            ViewBag.Title = "Traps";
            
            return View();
        }
        public ActionResult Bomb()
        {
            ViewBag.Title = "Bomb";
            ViewBag.Description = "Nothing says 'STAY OUT' quite like a good old-fashioned hidden bomb.";

            return View();
        }
        public ActionResult SpringTrap()
        {
            ViewBag.Title = "Spring Trap";
            ViewBag.Description = "This bouncy little number will toss unwanted visitors right off your property!";

            return View();
        }
        public ActionResult AirBomb()
        {
            ViewBag.Title = "Air Bomb";
            ViewBag.Description = "Latest invention in the field of flying pest control. This trap can blast multiple air units in a small area.";

            return View();
        }
        public ActionResult GiantBomb()
        {
            ViewBag.Title = "Giant Bomb";
            ViewBag.Description = "When you're looking for a Big Boom, you need the Giant Bomb.";

            return View();
        }
        public ActionResult SeekingAirMine()
        {
            ViewBag.Title = "Seeking Air Mine";
            ViewBag.Description = "Is it a bird? Is it a plane? Well it makes no difference as the Seeking Air Mine will blow it sky high. This trap does devastating damage to a single air unit.";

            return View();
        }
        public ActionResult SkeletonTrap()
        {
            ViewBag.Title = "Skeleton Trap";
            ViewBag.Description = "Ambush and distract unsuspecting foes with a surprise skirmish of short-lived, but sneaky skeleton troops! Skeleton Traps can be configured to pursue either ground or air troops.";

            return View();
        }
        public ActionResult TornadoTrap()
        {
            ViewBag.Title = "Tornado Trap";
            ViewBag.Description = "Wind and stones may break some bones, but this trap will definitely confound you. Just place one of these traps down and the released vortex will draw the enemy troops in, hindering their progress.";

            return View();
        }
    }
}