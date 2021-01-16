using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIPIT10.Models;

namespace BIPIT10.Controllers
{
    public class AddController : Controller
    {
        public ActionResult Issue()
        {
            string emp = Request.Form["chooseEmp"];
            string eq = Request.Form["chooseEq"];
            string issued = Request.Form["addIssued"];

            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var issues = db.Issues;
                Issue e = new Issue
                {
                    issued_at = Convert.ToDateTime(issued),
                    employee = emp,
                    equipment = eq,
                    Added = DateTime.Now
                };
                issues.Add(e);
                db.SaveChanges();
            }
            return Redirect(Url.Action("Issues", "Home"));
        }

        public ActionResult Employee()
        {
            string name = Request.Form["addName"];
            string bd = Request.Form["addBd"];

            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var emps = db.Employees;
                Employee e = new Employee
                {
                    Name = name,
                    Birth_date = Convert.ToDateTime(bd),
                    Added = DateTime.Now
                };
                emps.Add(e);
                db.SaveChanges();
            }
            return Redirect(Url.Action("Employees", "Home"));
        }

        public ActionResult Equipment()
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                string name = Request.Form["addName"];
                int price = int.Parse(Request.Form["addPrice"]);
                var eqs = db.Equipments;

                Equipment e = new Equipment
                {
                    Name = name,
                    price = price,
                    Added = DateTime.Now
                };
                eqs.Add(e);
                db.SaveChanges();
            }
            return Redirect(Url.Action("Equipment", "Home"));
        }
    }
}