using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIPIT10.Models;

namespace BIPIT10.Controllers
{
    public class EditController : Controller
    {

        public ActionResult Issue(int id)
        {
            using(EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                
            }
            return Redirect(Url.Action("Issues", "Home"));
        }

        public ActionResult Employee(int id)
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {

            }
            return Redirect(Url.Action("Employees", "Home"));
        }

        public ActionResult Equipment(int id)
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {

            }
            return Redirect(Url.Action("Equipment", "Home"));
        }
    }
}