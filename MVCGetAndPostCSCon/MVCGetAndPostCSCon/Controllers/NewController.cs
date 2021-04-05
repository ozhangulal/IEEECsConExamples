using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGetAndPostCSCon.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult login()
        {
            //post: son kullanıcının sayfadan dbye ya da bir dökümana veri göndermek ya da sayfa üzerinden girilen verileri yakalamak amacıyla kullanılır.

            //if (Request.HttpMethod == "POST")
            //{
            //    string userName = Request.Form.Get("txtKullaniciAdi");
            //    string userPassword = Request.Form.Get("txtSifre");
            //    ViewBag.Password = userPassword;
            //    ViewBag.userName = userName;
            //}

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult login(FormCollection frm)
        {
            string userName = frm.Get("txtKullaniciAdi");
            string userPassword = frm.Get("txtSifre");

            //Session Example
            if (!String.IsNullOrEmpty(userName) && (!String.IsNullOrEmpty(userPassword)))
            {
                //Session.Add("userName", userName);
                //Session.Add("userPassword", userPassword);
                //return RedirectToAction("getSession");

                HttpCookie userNameC = new HttpCookie("userName", userName);
                Response.Cookies.Add(userNameC);

                HttpCookie userPasswordC = new HttpCookie("userPassword", userPassword);
                Response.Cookies.Add(userPasswordC);
                return RedirectToAction("getCookie");
            }

            ViewBag.userName = userName;
            ViewBag.Password = userPassword;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetMethod(string ID)
        {
            ViewBag.GetId = ID;
            return View();
        }

        public ActionResult getSession()
        {
            string userName = Session["userName"].ToString();
            string userPassword = Session["userPassword"].ToString();
            ViewBag.Name = userName;
            ViewBag.Password = userPassword;
            return View();
        }

        public ActionResult getCookie()
        {
            HttpCookie kullaniciAdi = Request.Cookies.Get("userName");
            string userC = kullaniciAdi.Value;
            ViewBag.userV = userC;

            HttpCookie Sifre = Request.Cookies.Get("userPassword");
            string userPC = Sifre.Value;
            ViewBag.userVP = userPC;

            return View();
        }
    }
}