using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoC.Controllers
{
    public class ResourceBldgsController : Controller
    {
        // GET: ResourceBldgs
        public ActionResult ResourceBldgsIndex()
        {
            ViewBag.Title = "Resource Buildings";

            return View();
        }
        public ActionResult DarkElixirStorage()
        {
            ViewBag.Title = "Dark Elixir Storage";
            ViewBag.Description = "The power of Dark Elixir could not be contained in a regularly shaped Elixir vat. As it's three times as powerful, we had to invent a cubical form of storage!";

            return View();
        }
        public ActionResult DarkElixirDrill()
        {
            ViewBag.Title = "Dark Elixir Drill";
            ViewBag.Description = "Our Builders have finally figured a way to extract pure Dark Elixir, the rarest form of the magical substance.";

            return View();
        }
        public ActionResult ElixirStorage()
        {
            ViewBag.Title = "Elixir Storage";
            ViewBag.Description = "These storages contain the elixir pumped from underground. Upgrade them to increase the maximum amount of elixir you can store.";

            return View();
        }
        public ActionResult ElixirCollector()
        {
            ViewBag.Title = "Elixir Collector";
            ViewBag.Description = "Elixir is pumped from Ley Lines coursing underneath your village. Upgrade your Elixir Collectors to maximize elixir production.";

            return View();
        }
        public ActionResult GoldStorage()
        {
            ViewBag.Title = "Gold Storage";
            ViewBag.Description = "All your precious gold is stored here. Don't let sneaky goblins anywhere near! Upgrade the storage to increase its capacity and durability against attack.";

            return View();
        }
        public ActionResult GoldMine()
        {
            ViewBag.Title = "Gold Mine";
            ViewBag.Description = "The Gold Mine produces gold. Upgrade it to boost its production and gold storage capacity.";

            return View();
        }
    }
}