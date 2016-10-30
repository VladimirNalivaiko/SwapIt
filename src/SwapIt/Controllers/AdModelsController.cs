using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SwapIt.Models;

namespace SwapIt.Controllers
{
    public class AdModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AdModels
        public ActionResult Index()
        {
            return View(db.AdModels.ToList());
        }

        // GET: AdModels/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdModel adModel = db.AdModels.Find(id);
            if (adModel == null)
            {
                return HttpNotFound();
            }
            return View(adModel);
        }

        // GET: AdModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdId,Name,Description,Owner")] AdModel adModel)
        {
            if (ModelState.IsValid)
            {
                adModel.Owner = User.Identity.Name.ToString();
                db.AdModels.Add(adModel);
                db.SaveChanges();
                return RedirectToAction("Index", "Manage");
            }

            return View(adModel);
        }

        // GET: AdModels/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {   
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdModel adModel = db.AdModels.Find(id);
            if (adModel == null)
            {
                return HttpNotFound();
            }
            return View(adModel);
        }

        // POST: AdModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdId,Name,Description,Owner")] AdModel adModel)
        {
            if (ModelState.IsValid)
            {
                adModel.Owner = User.Identity.Name.ToString();
                db.Entry(adModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Manage");
            }
            return View(adModel);
        }

        // GET: AdModels/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdModel adModel = db.AdModels.Find(id);
            if (adModel == null)
            {
                return HttpNotFound();
            }
            return View(adModel);
        }

        // POST: AdModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            AdModel adModel = db.AdModels.Find(id);
            db.AdModels.Remove(adModel);
            db.SaveChanges();
            return RedirectToAction("Index", "Manage");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
