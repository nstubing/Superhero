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
            return View(db.Superheroes);
        }

        public ActionResult Create()
        { 
            return View();
        }
        public ActionResult Delete(int ID)
        {
            var thisSuper = db.Superheroes.Where(s => s.ID == ID).FirstOrDefault();
            return View(thisSuper);
        }
        public ActionResult Edit(int ID)
        {
            var thisSuper = db.Superheroes.Where(s => s.ID == ID).FirstOrDefault();
            return View(thisSuper);
        }
        public ActionResult List()
        {
            ViewBag.SuperHeroID = new SelectList(db.Superheroes, "Name", "alterEgo", "superHeroAbility", "secondSuperHeroAbility", "catchphrase");
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Name,alterEgo,superHeroAbility,secondSuperHeroAbility,catchphrase")]Superheroes superhero)
        {
            db.Superheroes.Add(superhero);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteThis(int ID)
        {
            var superDelete = db.Superheroes.Where(s => s.ID == ID).FirstOrDefault();
            db.Superheroes.Remove(superDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Name,alterEgo,superHeroAbility,secondSuperHeroAbility,catchphrase")]Superheroes superhero)
        {
            var thisSuper = db.Superheroes.Where(s => s.ID == superhero.ID).FirstOrDefault();
            thisSuper.Name = superhero.Name;
            thisSuper.alterEgo = superhero.alterEgo;
            thisSuper.superHeroAbility = superhero.superHeroAbility;
            thisSuper.secondSuperHeroAbility = superhero.secondSuperHeroAbility;
            thisSuper.catchphrase = superhero.catchphrase;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}