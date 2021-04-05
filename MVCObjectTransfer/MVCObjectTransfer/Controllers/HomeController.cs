using MVCObjectTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCObjectTransfer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Student st = new Student();
            //st.Id = 1;
            //st.Name = "Ozhan";
            //st.Surname = "GULAL";

            //ViewBag.Ogrenci = st;
            //return View();


            List<Student> csConList = new List<Student>();
            Student st = new Student();
            st.Id = 1;
            st.Name = "Ozhan";
            st.Surname = "GULAL";
            csConList.Add(st);

            Student st1 = new Student();
            st1.Id = 2;
            st1.Name = "Ensar";
            st1.Surname = "Makas";
            csConList.Add(st1);

            Student st2 = new Student();
            st2.Id = 3;
            st2.Name = "Berna";
            st2.Surname = "Yildiran";
            csConList.Add(st2);

            ViewBag.ogrenciler = csConList;
            return View();

        }
    }
}