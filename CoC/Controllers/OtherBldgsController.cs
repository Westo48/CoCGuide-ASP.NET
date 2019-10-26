using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoC.Controllers
{
    public class OtherBldgsController : Controller
    {
        // GET: OtherBldgs
        public ActionResult OtherBldgsIndex()
        {
            ViewBag.Title = "Other Buildings";

            return View();
        }
        public ActionResult TownHall()
        {
            ViewBag.Title = "Town Hall";
            ViewBag.Description = "This is the heart of your village. Upgrading your Town Hall unlocks new defenses, buildings, traps and much more.Destroying an opponent's Town Hall wins you the battle and you get one Star. Destroying 50% of enemy buildings gains you a second Star, while 100% annihilation awards full three Stars. Beware, your enemies will be trying to destroy your Town Hall too! For maximum protection, keep your Town Hall in the middle of your village and protect it with walls, traps and defensive buildings.Your enemies are sneaky and can attack from any side!";

            return View();
        }
        public ActionResult BuilderHut()
        {
            ViewBag.Title = "Builder's Hut";
            ViewBag.Description = "Nothing gets done around here without Builders! You can hire more builders to start multiple construction projects, or speed up their work by using green gems.";

            return View();
        }
        public ActionResult MasterBuilderHut()
        {
            ViewBag.Title = "Master Builder's Hut";
            ViewBag.Description = "Master Builder's home away from home. He is available as an additional builder while staying in the Home Village.";

            return View();
        }
    }
}