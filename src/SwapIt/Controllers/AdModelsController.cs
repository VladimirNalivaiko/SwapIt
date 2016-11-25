using System.Linq;
using System.Net;
using System.Web.Mvc;
using SwapIt.Models;

namespace SwapIt.Controllers
{
    public class AdModelsController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: AdModels
        public ActionResult Index()
        {
            return View(db.AdModels.ToList());
        }

        // GET: AdModels/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var adModel = db.AdModels.Find(id);
            if (adModel == null)
                return HttpNotFound();
            return View(adModel);
        }

        // GET: AdModels/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var adModel = db.AdModels.Find(id);
            if (adModel == null)
                return HttpNotFound();
            return View(adModel);
        }

        // POST: AdModels/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            var adModel = db.AdModels.Find(id);
            db.AdModels.Remove(adModel);
            db.SaveChanges();
            return RedirectToAction("Index", "AdModels");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}