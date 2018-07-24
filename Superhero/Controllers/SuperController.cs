using Superhero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superhero.Controllers
{
    public class SuperController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Super
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.SuperHeroID = new SelectList(db.Superheroes, "Name", "alterEgo", "superHeroAbility", "secondSuperHeroAbility", "catchphrase");
            return View();
        }
        public ActionResult Delete()
        {
            ViewBag.SuperHeroID = new SelectList(db.Superheroes);
            return View();
        }
        public ActionResult Edit()
        {
            ViewBag.SuperHeroID = new SelectList(db.Superheroes, "Name","alterEgo", "superHeroAbility", "secondSuperHeroAbility", "catchphrase");
            return View();
        }
        public ActionLIst List()
    }
}