using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KyadondoSportsClub.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            return View();
        }
      public  ActionResult Heathens()
        {
            return View();
        }
        //Buffaloes
       public ActionResult Buffaloes()
        {
            return View();

        }
        //ThunderBirds
        public ActionResult ThunderBirds()
        {
            return View();

        }
        //Stallions 
        public  ActionResult Stallions()
        {
            return View();

        }
        //Tigers 
        public ActionResult Tigers()
        {
            return View();
        }
        //Eagles 
        public ActionResult Eagles()
        {
            return View();

        }
        //development 
        public ActionResult Development()

        {
            return View();
        }

    }
}