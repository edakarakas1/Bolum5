using AND.And.Eticaret.Core.Model;
using AND.And.Eticaret.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AND.And.Eticaret.UI.WEB.Controllers
{
    public class HomeController : Controller
    {
        AndDB db = new AndDB();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Ürüns.OrderByDescending(x => x.OlusturmaTarih).Take(5).ToList();
            return View(data);
        }
        public PartialViewResult GetMenü()
        {
            
            var menüs = db.Kategoris.Where(x => x.AltÜtsKategoriID == 0).ToList();
            return PartialView(menüs);
        }
        [Route("Pazarlamacı-Giris")]
        public ActionResult Giris()
        {
           
            return View();
        }

        [HttpPost]
        [Route("Pazarlamacı-Giris")]
        public ActionResult Giris(string Email, string KullanıcıAdı, string Password)
        {
           
            var Kullanicis = db.Kullanicis.Where(x => x.Email == Email
              &&x.KullanıcıAdı==KullanıcıAdı
              &&x.Şifre==Password
              &&x.Aktif==true
              &&x.Admin==false).ToList();
            if (Kullanicis.Count == 1)
            {
                //giriş yapıldı
                Session["KullaniciGiris"] = Kullanicis.FirstOrDefault();
                return Redirect("/");
            }
            else {
                ViewBag.Error = "Hatalı Kullanıcı Veya Şifre!!!";
            return View();
            }
        }

        [Route("Pazarlamacı-Kayit")]
        public ActionResult KullanıcıOlustur()
        {
            return View();
        }
        [HttpPost]
        [Route("Pazarlamacı-Kayit")]
        public ActionResult KullanıcıOlustur( Kullanici entity)
        {
            try
            {
                entity.OlusturmaTarih = DateTime.Now;
                entity.OlusturKullaniciID = 1;
                entity.Aktif = true;
                entity.Admin = false;

                db.Kullanicis.Add(entity);
                db.SaveChanges();
                return Redirect("/");

               
            }
            catch(Exception ex)
            {
                return View();

            }
           
        }
    }
}