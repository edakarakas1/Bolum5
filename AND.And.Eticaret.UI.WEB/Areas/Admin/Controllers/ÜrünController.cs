using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AND.And.Eticaret.Core.Model;
using AND.And.Eticaret.Core.Model.Entity;

namespace AND.And.Eticaret.UI.WEB.Areas.Admin.Controllers
{
    public class ÜrünController : Controller
    {
        private AndDB db = new AndDB();

        // GET: Admin/Ürün
        public ActionResult Index()
        {
            var Ürüns = db.Ürüns.Include(p => p.Kategori);
            return View(db.Ürüns.ToList());
        }

        // GET: Admin/Ürün/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ürün ürün = db.Ürüns.Find(id);
            if (ürün == null)
            {
                return HttpNotFound();
            }
            return View(ürün);
        }

        // GET: Admin/Ürün/Create
        public ActionResult Create()
        {
            ViewBag.ÜrünKategoriID = new SelectList(db.Kategoris, "ÜrünKoduID", "ÜrünAdı");
            return View();
        }

        // POST: Admin/Ürün/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ÜrünKoduID,ÜrünAdı,ÜrünTedarikci,ÜrünKategoriID,Model,ResimUrl,Aciklama,AlısFiyat,SatısFiyat,KDV,İndirim,Stok,Aktif,OlusturmaTarih,OlusturKullaniciID,GüncellemeTarih,KullaniciGüncelleID")] Ürün ürün)
        {
            if (ModelState.IsValid)
            {
                db.Ürüns.Add(ürün);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ürün);
        }

        // GET: Admin/Ürün/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ürün ürün = db.Ürüns.Find(id);
            if (ürün == null)
            {
                return HttpNotFound();
            }
            return View(ürün);
        }

        // POST: Admin/Ürün/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ÜrünKoduID,ÜrünAdı,ÜrünTedarikci,ÜrünKategoriID,Model,ResimUrl,Aciklama,AlısFiyat,SatısFiyat,KDV,İndirim,Stok,Aktif,OlusturmaTarih,OlusturKullaniciID,GüncellemeTarih,KullaniciGüncelleID")] Ürün ürün)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ürün).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ürün);
        }

        // GET: Admin/Ürün/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ürün ürün = db.Ürüns.Find(id);
            if (ürün == null)
            {
                return HttpNotFound();
            }
            return View(ürün);
        }

        // POST: Admin/Ürün/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ürün ürün = db.Ürüns.Find(id);
            db.Ürüns.Remove(ürün);
            db.SaveChanges();
            return RedirectToAction("Index");
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
