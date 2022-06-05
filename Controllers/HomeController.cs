using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentMVC.Models;

namespace StudentMVC.Controllers
{
    public class HomeController : Controller
    {
        LinqAssinmentEntities db = new LinqAssinmentEntities();

        public ActionResult Index()
        {
            var s = db.students;
            return View(s);
        }
    }
}