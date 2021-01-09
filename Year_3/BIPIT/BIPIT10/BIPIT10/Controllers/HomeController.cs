using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIPIT10.Models;

namespace BIPIT9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect(Url.Action("Issues", "Home"));
        }

        public ActionResult Issues()
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                ViewBag.Issues = db.Issues.ToList();
                return View();
            }
        }

        public ActionResult Employees()
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                ViewBag.Employees = db.Employees.ToList();
                return View();
            }
        }

        public ActionResult Equipment()
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                ViewBag.Equipment = db.Equipments.ToList();
                return View();
            }
        }

    }
}