using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoC.Models;

namespace CoC.Controllers
{
    public class DefenseBldgsController : Controller
    {
        // GET: DefenseBldgs
        public ActionResult DefenseBldgsIndex()
        {
            ViewBag.Title = "Defense";

            return View();
        }
        /*
        private List<DefenseBldg> CannonList()
        {
            List<DefenseBldg> CannonLvls = new List<DefenseBldg>();
            CannonLvls.Add(new DefenseBldg { Lvl=1, HP=420, Cost=250, UpTime="10 s", XP=3, DPS=9, DPH=7.2, TH=1 });
            return CannonLvls;
        }*/
        public ActionResult Cannon()
        {
            ViewBag.Title = "Cannon";
            ViewBag.Description = "Cannons are great for point defense. Upgrade cannons to increase their firepower, but beware that your defensive turrets cannot shoot while being upgraded!";

            List<DefenseBldg> CannonList = new List<DefenseBldg>
            {
                new DefenseBldg()
                { Lvl=1, HP="420", Cost="250", UpTime="10 s", XP="3", DPS=9, DPH=7.2, TH=1 },
                new DefenseBldg()
                { Lvl=2, HP="470", Cost="1,000", UpTime="15 m", XP="30", DPS=11, DPH=8.8, TH=1 },
                new DefenseBldg()
                { Lvl=3, HP="520", Cost="4,000", UpTime="45 m", XP="51", DPS=15, DPH=12, TH=2 },
                new DefenseBldg()
                { Lvl=4, HP="570", Cost="16,000", UpTime="1 h", XP="60", DPS=19, DPH=15.2, TH=3 },
                new DefenseBldg()
                { Lvl=5, HP="620", Cost="50,000", UpTime="4 h", XP="120", DPS=25, DPH=20, TH=4 },
                new DefenseBldg()
                { Lvl=6, HP="670", Cost="100,000", UpTime="8 h", XP="169", DPS=31, DPH=24.8, TH=5 },
                new DefenseBldg()
                { Lvl=7, HP="730", Cost="200,000", UpTime="8 h", XP="169", DPS=40, DPH=32, TH=6 },
                new DefenseBldg()
                { Lvl=8, HP="800", Cost="400,000", UpTime="12 h", XP="207", DPS=48, DPH=38.4, TH=7 },
                new DefenseBldg()
                { Lvl=9, HP="880", Cost="800,000", UpTime="12 h", XP="207", DPS=56, DPH=44.8, TH=8 },
                new DefenseBldg()
                { Lvl=10, HP="960", Cost="1,000,000", UpTime="1 d", XP="293", DPS=64, DPH=51.2, TH=8 },
                new DefenseBldg()
                { Lvl=11, HP="1,060", Cost="2,000,000", UpTime="1 d 12 h", XP="360", DPS=74, DPH=59.2, TH=9 },
                new DefenseBldg()
                { Lvl=12, HP="1,160", Cost="3,000,000", UpTime="2 d", XP="415", DPS=87, DPH=69.6, TH=10 },
                new DefenseBldg()
                { Lvl=13, HP="1,260", Cost="4,000,000", UpTime="3 d", XP="509", DPS=100, DPH=80, TH=10 },
                new DefenseBldg()
                { Lvl=14, HP="1,380", Cost="5,500,000", UpTime="5 d", XP="567", DPS=110, DPH=88, TH=11 },
                new DefenseBldg()
                { Lvl=15, HP="1,500", Cost="7,000,000", UpTime="6 d", XP="720", DPS=118, DPH=94.4, TH=11 },
                new DefenseBldg()
                { Lvl=16, HP="1,620", Cost="10,000,000", UpTime="9 d", XP="881", DPS=125, DPH=100, TH=12 },
                new DefenseBldg()
                { Lvl=17, HP="1,740", Cost="12,000,000", UpTime="12 d", XP="1,018", DPS=132, DPH=105.6, TH=12 }
            };
            ViewBag.Levels = CannonList;

            return View();
        }
        public ActionResult ArcherTower()
        {
            ViewBag.Title = "Archer Tower";
            ViewBag.Description = "Archer Towers have longer range than cannons, and unlike cannons they can attack flying enemies.";
            List<DefenseBldg> ArcherTowerList = new List<DefenseBldg>
            {
                new DefenseBldg()
                { Lvl=1, HP="380", Cost="1000", UpTime="1 m", XP="7", DPS=11, DPH=5.5, TH=2 },
                new DefenseBldg()
                { Lvl=2, HP="420", Cost="2000", UpTime="30 m", XP="42", DPS=15, DPH=7.5, TH=2 },
                new DefenseBldg()
                { Lvl=3, HP="460", Cost="5000", UpTime="45 m", XP="51", DPS=19, DPH=9.5, TH=3 },
                new DefenseBldg()
                { Lvl=4, HP="500", Cost="20000", UpTime="3 h", XP="103", DPS=25, DPH=12.5, TH=4 },
                new DefenseBldg()
                { Lvl=5, HP="540", Cost="80000", UpTime="8 h", XP="169", DPS=30, DPH=15, TH=5 },
                new DefenseBldg()
                { Lvl=6, HP="580", Cost="180000", UpTime="8 h", XP="169", DPS=35, DPH=17.5, TH=5 },
                new DefenseBldg()
                { Lvl=7, HP="630", Cost="360000", UpTime="8 h", XP="207", DPS=42, DPH=21, TH=6 },
                new DefenseBldg()
                { Lvl=8, HP="690", Cost="720000", UpTime="12 h", XP="207", DPS=48, DPH=24, TH=7 },
                new DefenseBldg()
                { Lvl=9, HP="750", Cost="1000000", UpTime="12 h", XP="240", DPS=56, DPH=28, TH=8 },
                new DefenseBldg()
                { Lvl=10, HP="810", Cost="1500000", UpTime="1 d", XP="293", DPS=63, DPH=31.5, TH=8 },
                new DefenseBldg()
                { Lvl=11, HP="890", Cost="2000000", UpTime="1 d 12 h", XP="360", DPS=70, DPH=35, TH=9 },
                new DefenseBldg()
                { Lvl=12, HP="970", Cost="3000000", UpTime="2 d", XP="415", DPS=75, DPH=37.5, TH=10 },
                new DefenseBldg()
                { Lvl=13, HP="1,050", Cost="4000000", UpTime="3 d", XP="509", DPS=80, DPH=40, TH=10 },
                new DefenseBldg()
                { Lvl=14, HP="1,130", Cost="5500000", UpTime="6 d", XP="720", DPS=92, DPH=46, TH=11 },
                new DefenseBldg()
                { Lvl=15, HP="1,230", Cost="7000000", UpTime="8 d", XP="831", DPS=104, DPH=52, TH=11 },
                new DefenseBldg()
                { Lvl=16, HP="1,330", Cost="10000000", UpTime="10 d", XP="929", DPS=116, DPH=58, TH=12 },
                new DefenseBldg()
                { Lvl=17, HP="1,410", Cost="12000000", UpTime="12 d", XP="1,018", DPS=122, DPH=61, TH=12 }
            };
            ViewBag.Levels = ArcherTowerList;

            return View();
        }
        public ActionResult Mortar()
        {
            ViewBag.Title = "Mortar";
            ViewBag.Description = "The Mortar can mow down hordes of enemies by the splash damage from its shell. Don't let enemies get too close to it!";

            List<DefenseBldg> MortarList = new List<DefenseBldg>
            {
                new DefenseBldg()
                { Lvl=1, HP="400", Cost="8,000", UpTime="3 h", XP="103", DPS=4, DPH=20, TH=3 },
                new DefenseBldg()
                { Lvl=2, HP="450", Cost="32,000", UpTime="8 h", XP="169", DPS=5, DPH=25, TH=4 },
                new DefenseBldg()
                { Lvl=3, HP="500", Cost="120,000", UpTime="16 h", XP="240", DPS=6, DPH=30, TH=5 },
                new DefenseBldg()
                { Lvl=4, HP="550", Cost="400,000", UpTime="1 d 12 h", XP="360", DPS=7, DPH=35, TH=6 },
                new DefenseBldg()
                { Lvl=5, HP="600", Cost="800,000", UpTime="2 d 12 h", XP="464", DPS=9, DPH=45, TH=7 },
                new DefenseBldg()
                { Lvl=6, HP="650", Cost="1,600,000", UpTime="3 d", XP="509", DPS=11, DPH=55, TH=8 },
                new DefenseBldg()
                { Lvl=7, HP="700", Cost="3,200,000", UpTime="4 d", XP="587", DPS=15, DPH=75, TH=9 },
                new DefenseBldg()
                { Lvl=8, HP="750", Cost="5,000,000", UpTime="5 d", XP="657", DPS=20, DPH=100, TH=10 },
                new DefenseBldg()
                { Lvl=9, HP="800", Cost="70,000,000", UpTime="6 d", XP="720", DPS=25, DPH=125, TH=11 },
                new DefenseBldg()
                { Lvl=10, HP="850", Cost="9,000,000", UpTime="10 d", XP="929", DPS=30, DPH=150, TH=11 },
                new DefenseBldg()
                { Lvl=11, HP="900", Cost="11,000,000", UpTime="12 d", XP="1,018", DPS=35, DPH=175, TH=12 },
                new DefenseBldg()
                { Lvl=12, HP="980", Cost="12,000,000", UpTime="14 d", XP="1,099", DPS=38, DPH=190, TH=12 },
            };
            ViewBag.Levels = MortarList;

            return View();
        }
        public ActionResult AirDefense()
        {
            ViewBag.Title = "Air Defense";
            ViewBag.Description = "This anti-air tower is deadly against flying enemies, but can't target foes on the ground. Place it wisely to cover as much airspace as possible.";

            return View();
        }
        public ActionResult WizardTower()
        {
            ViewBag.Title = "Wizard Tower";
            ViewBag.Description = "The Ultimate Arcane Defense! Tower Wizards cast powerful area effect spells that target both flying and ground troops.";

            return View();
        }
        public ActionResult AirSweeper()
        {
            ViewBag.Title = "Air Sweeper";
            ViewBag.Description = "Air Sweepers control the sky with strong blasts of air that push back flying enemies. Air Sweepers can only face one direction, so rotate them to maximize their effectiveness.";

            return View();
        }
        public ActionResult HiddenTesla()
        {
            ViewBag.Title = "Hidden Tesla";
            ViewBag.Description = "Lay a deadly trap with the Hidden Tesla! Our Wizards have trapped a storm cloud into each of these sneaky towers. When an enemy walks or flies close enough, the tower springs up and fries it using the power of Electrickery!";

            return View();
        }
        public ActionResult BombTower()
        {
            ViewBag.Title = "Bomb Tower";
            ViewBag.Description = "Bomb Towers bombard nearby ground troops and go up in a big BOOM when destroyed! Melee units best stand clear!";

            return View();
        }
        public ActionResult XBow()
        {
            ViewBag.Title = "X-Bow";
            ViewBag.Description = "The X-Bow shoots mystical bolts with terrifying power. Load it with Elixir and the X-Bow works automagically. You can set it to target ground units at long ranges, or all targets at reduced range.";

            return View();
        }
        public ActionResult InfernoTower()
        {
            ViewBag.Title = "Inferno Tower";
            ViewBag.Description = "Set the Inferno Tower's Dark Elixir fueled flame to build up unbelievable damage to single targets, or to constantly roast multiple targets at once.";

            return View();
        }
        public ActionResult EagleArtillery()
        {
            ViewBag.Title = "Eagle Artillery";
            ViewBag.Description = "The Eagle Artillery has nearly unlimited range and targets tough enemies with exploding shells. However, it won't activate until a large amount of troops have been deployed.";

            return View();
        }
        public ActionResult GrandWardenTower()
        {
            ViewBag.Title = "Grand Warden";
            ViewBag.Description = "This veteran battle-scholar follows groups of friendly troops and boosts them with his Life Aura. Attacking he can walk over walls or fly high. On defense he turns into a tower. Unlock his Eternal Tome ability to make nearby troops immune to damage!";

            return View();
        }
        public ActionResult GigaTesla()
        {
            ViewBag.Title = "Giga Tesla";
            ViewBag.Description = "Your enemies are in for a big surprise with the Giga Tesla, the foul-tempered big brother of the Tesla family. When an enemy so much as scratches the paint on your Town Hall, sizzling Electrickery will blast them away leaving the air tasting faintly like coconut... and metal.";

            return View();
        }
        public ActionResult Wall()
        {
            ViewBag.Title = "Wall";
            ViewBag.Description = "Walls are great for keeping your village safe and your enemies in the line of fire.";

            return View();
        }
    }
}