using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoC.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero
        public ActionResult HeroIndex()
        {
            ViewBag.Title = "Heroes";

            return View();
        }
        public ActionResult BarbarianKing()
        {
            ViewBag.Title = "Barbarian King";
            ViewBag.Description = "This colossal menace soaks up huge amounts of damage and bashes anything in his path. He guards his territory fiercely when defending, and can launch into a devastating rage when attacking once his Iron Fist ability is unlocked!";
            ViewBag.SpecialName = "Iron Fist";
            ViewBag.SpecialDescription = "The king bursts into rage, recovering a large amount of health and getting a boost to his speed and attack power. A group of raged barbarians also appear to join in the brawl! ";

            return View();
        }
        public ActionResult ArcherQueen()
        {
            ViewBag.Title = "Archer Queen";
            ViewBag.Description = "This graceful huntress is a master of destructive force, though modest in health. She snipes targets in her territory when defending, and can summon stealth and terrifying damage when attacking once her Royal Cloak ability is unlocked!";
            ViewBag.SpecialName = "Royal Cloak";
            ViewBag.SpecialDescription = "The queen vanishes from sight to recover some health and unleash devastating volleys of high-damage ammunition. Defenses will lose her as their target, and a group of archers will appear to distract them!";

            return View();
        }
        public ActionResult GrandWarden()
        {
            ViewBag.Title = "Grand Warden";
            ViewBag.Description = "This veteran battle-scholar follows groups of friendly troops and boosts them with his Life Aura. Attacking he can walk over walls or fly high. On defense he turns into a tower. Unlock his Eternal Tome ability to make nearby troops immune to damage!";
            ViewBag.SpecialName = "Eternal Tome";
            ViewBag.SpecialDescription = "The warden unleashes the full power of his arcane Tome, making himself and all nearby friendly units completely immune to damage for a short amount of time!";

            return View();
        }
        public ActionResult BattleMachine()
        {
            ViewBag.Title = "Battle Machine";
            ViewBag.Description = "The Master Builder's prize invention smashes enemy buildings to bits. What better way is there to show who's the best builder around? Unlock the Electric Hammer ability to give opponents a real pounding!";
            ViewBag.SpecialName = "Electric Hammer";
            ViewBag.SpecialDescription = "The Battle Machine calls down an energizing bolt of lightning, recovering some health and making its next attacks do increased damage. After a time, this ability recharges and can be used again!";

            return View();
        }
    }
}