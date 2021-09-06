using AND.And.Eticaret.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AND.And.Eticaret.UI.WEB.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Admin/AdminLogin
        AndDB db = new AndDB();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Email, string KullaniciAdı,  string Password)

        {
            var data = db.Kullanicis.Where(x => x.Email == Email
            && x.KullanıcıAdı == KullaniciAdı
            && x.Şifre == Password
            && x.Aktif == true
            && x.Admin == true).ToList();
            if (data.Count == 1)
            {
                //Doğru Giriş
                Session["AdminKullaniciGiris"] = data.FirstOrDefault();
                return Redirect("/admin");
            }
            else
            {
                //Hatalı Giriş
                return View();
            }
        }
        }
}