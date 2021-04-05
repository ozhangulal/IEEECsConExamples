using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CsConLoginMembership.Models.Data.Context;
using CsConLoginMembership.Models.VM;
using System.Web.Security;
using CsConLoginMembership.Models.Entities;

namespace CsConLoginMembership.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                using (ProjectContext context = new ProjectContext())
                {
                    var user = context.User.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(user.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }

        public ActionResult YeniOlustur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(ApplicationUser user)
        {
            ProjectContext _db = new ProjectContext();
            ApplicationUser yeni = new ApplicationUser();
            yeni.Name = user.Name;
            yeni.Email = user.Email;
            yeni.Password = user.Password;

            _db.User.Add(yeni);
            _db.SaveChanges();
            return RedirectToAction("Login");
        }
    }
}