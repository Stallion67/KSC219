using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KyadondoSportsClub.Controllers
{
    public class TeamSquadController : Controller
    {
        // GET: TeamSquad
        public ActionResult Index()
        {
            return View();
        }
        //Heathens Team Squad
        public ActionResult Heathens()
        {
            return View();
        }
        //Buffaloes Team Squard
        public  ActionResult Buffaloes()
        {
            return View();
        }

        public  ActionResult ThunderBirds()
        {
            return View();
        }
    }
}