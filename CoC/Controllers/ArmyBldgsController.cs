using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoC.Controllers
{
    public class ArmyBldgsController : Controller
    {
        // GET: ArmyBldgs
        public ActionResult ArmyBldgsIndex()
        {
            ViewBag.Title = "Army Buildings";

            return View();
        }
        public ActionResult ClanCastle()
        {
            ViewBag.Title = "Clan Castle";
            ViewBag.Description = "The Clan Castle houses your Treasury and any reinforcement troops or spells sent by your clanmates.";

            return View();
        }
        public ActionResult Barracks()
        {
            ViewBag.Title = "Barracks";
            ViewBag.Description = "The Barracks allow you to train troops to attack your enemies. Upgrade the Barracks to unlock advanced units that can win epic battles.";

            return View();
        }
        public ActionResult DarkBarracks()
        {
            ViewBag.Title = "Dark Barracks";
            ViewBag.Description = "The Dark Barracks will open doors for creatures born out of Dark Elixir. Upgrade the barracks to unlock more troops with unique battle skills.";

            return View();
        }
        public ActionResult SpellFactory()
        {
            ViewBag.Title = "Spell Factory";
            ViewBag.Description = "The Spell Factory is home to veteran Wizards who are better suited to creating magical weapons than front-line combat. Use their powerful Attack Spells to turn the tide of battle in your favor!";

            return View();
        }
        public ActionResult DarkSpellFactory()
        {
            ViewBag.Title = "Dark Spell Factory";
            ViewBag.Description = "Only the most brilliant or reckless Master Wizards dabble in Dark Elixir brewery. Their compact Dark Spells require keen insight to master, but provide unique tactical advantages.";

            return View();
        }
        public ActionResult Laboratory()
        {
            ViewBag.Title = "Laboratory";
            ViewBag.Description = "What dark secrets do these Wizards hide inside their Laboratory? Nobody has dared to look. All we know is that their research makes our spells and troops harder, better, faster and stronger!";

            return View();
        }
        public ActionResult ArmyCamp()
        {
            ViewBag.Title = "Army Camp";
            ViewBag.Description = "Your troops are stationed in Army Camps. Build more camps and upgrade them to muster a powerful army.";

            return View();
        }
        public ActionResult BarbarianKingAltar()
        {
            ViewBag.Title = "Barbarian King Altar";
            ViewBag.Description = "The Barbarian King is the toughest and meanest barbarian in all the realm, whose appetite for Dark Elixir has caused him to grow to a giant size. He can attack enemy villages or guard your village.";

            return View();
        }
        public ActionResult ArcherQueenAltar()
        {
            ViewBag.Title = "Archer Queen Altar";
            ViewBag.Description = "The Archer Queen is an eagle-eyed warrior, whose weapon of choice is a modified X-Bow that few men could dream of wielding. She can attack enemy villages or guard your village.";

            return View();
        }
        public ActionResult Workshop()
        {
            ViewBag.Title = "Workshop";
            ViewBag.Description = "The Workshop is where Siege Machines are built. Upgrade the Workshop to unlock different Siege Machines!";

            return View();
        }
    }
}