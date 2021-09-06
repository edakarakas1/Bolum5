using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AND.And.Eticaret.UI.WEB.Areas.Admin
{
    public class AdminControllerBase : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            var Giris = false;
            if (requestContext.HttpContext.Session["AdminKullaniciGiris"] == null)
            {
                //Admin Girişi Yapılmamış

                requestContext.HttpContext.Response.Redirect("/Admin/AdminLogin");
            }
            else
            {
                //Sorun yok admin içeride
                //Sayfayı Çalıştır
                base.Initialize(requestContext);
            }
        }
        }
}