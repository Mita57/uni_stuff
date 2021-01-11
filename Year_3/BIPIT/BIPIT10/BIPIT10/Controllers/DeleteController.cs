using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIPIT10.Models;

namespace BIPIT10.Controllers
{
    public class DeleteController : Controller
    {
        public ActionResult Issue(int id)
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var issue = db.Issues.Where(x => x.id == id).FirstOrDefault();
                db.Issues.Remove(issue);
                db.SaveChanges();
            }
            return Redirect(Url.Action("Issues", "Home"));
        }

        public ActionResult Employee(string id)
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var employee = db.Employees.Where(x => x.Name == id).FirstOrDefault();
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
            return Redirect(Url.Action("Employees", "Home"));
        }

        public ActionResult Equipment(string id)
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var eq = db.Equipments.Where(x => x.Name == id).FirstOrDefault();
                db.Equipments.Remove(eq);
                db.SaveChanges();
            }
            return Redirect(Url.Action("Equipment", "Home"));
        }
    }
}