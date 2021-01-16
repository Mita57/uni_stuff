using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIPIT10.Models;

namespace BIPIT10.Controllers
{
    public class EditController : Controller
    {

        static SqlConnection _connection;

        private static void Connect()
        {
            String connectString = @"workstation id=EquipmentFFS.mssql.somee.com;packet size=4096;user id=dungeonMaster_SQLLogin_1;pwd=rcct57h98i;data source=EquipmentFFS.mssql.somee.com;persist security info=False;initial catalog=EquipmentFFS";
            _connection = new SqlConnection(connectString);
            _connection.Open();
        }


        public ActionResult Issue(int id)
        {
            using(EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var issue = db.Issues.Where(x => x.id == id).FirstOrDefault();

                var month = issue.issued_at.Value.Month.ToString();
                if(int.Parse(month) < 10)
                {
                    month = "0" + month;
                }

                var day = issue.issued_at.Value.Day.ToString();
                if(int.Parse(day) < 10)
                {
                    day = "0" + day;
                }

                ViewBag.issuedAt = issue.issued_at.Value.Year + "-" + 
                    month + "-" + day;
                ViewBag.equipment = issue.equipment;
                ViewBag.employee = issue.employee;
                ViewBag.added = issue.Added;
                ViewBag.id = issue.id;
                ViewBag.eqList = db.Equipments.ToList();
                ViewBag.empList = db.Employees.ToList();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Issue(FormCollection form)
        {
            int id = int.Parse(form["id"]);
            DateTime issuedAt = Convert.ToDateTime(form["issuedDate"]);
            string newEq = form["newEquipment"];
            string newEmp = form["newEmployee"];

            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var issue = db.Issues.Where(e => e.id == id).FirstOrDefault();
                issue.issued_at = issuedAt;
                issue.employee = newEmp;
                issue.equipment = newEq;
                db.SaveChanges();
            }

            return Redirect(Url.Action("Issues", "Home"));
        }


        public ActionResult Employee(string name)
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var emp = db.Employees.Where(x => x.Name == name).FirstOrDefault();
                var month = emp.Birth_date.Value.Month.ToString();
                if(int.Parse(month) < 10)
                {
                    month = "0" + month;
                }

                var day = emp.Birth_date.Value.Day.ToString();
                if (int.Parse(day) < 10)
                {
                    day = "0" + day;
                }

                ViewBag.name = emp.Name;
                ViewBag.birthDay = emp.Birth_date.Value.Year + "-" + month + "-" + day;

            }
            return View();
        }

        [HttpPost]
        public ActionResult Employee(FormCollection form)
        {
            string name = form["newName"];
            string prevName = form["id"];
            DateTime newBd = Convert.ToDateTime(form["newBd"]);

            Connect();

            String query = String.Format("UPDATE Employees SET name = '{0}', Birth_date = '{1}' WHERE Name = '{2}'", name, newBd, prevName);

            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            // screw u entity franework for not allowing to mess up PK's >:|

            return Redirect(Url.Action("Employees", "Home"));
        }

        public ActionResult Equipment(string name)
        {
            using (EquipmentFFSEntities db = new EquipmentFFSEntities())
            {
                var eq = db.Equipments.Where(x => x.Name == name).FirstOrDefault();
                ViewBag.name = eq.Name;
                ViewBag.Added = eq.Added;
                ViewBag.price = eq.price;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Equipment(FormCollection form)
        {
            string name = form["newName"];
            string prevName = form["id"];
            int price = int.Parse(form["price"]);

            Connect();

            String query = String.Format("UPDATE Equipment SET Name = '{0}', price = '{1}' WHERE Name = '{2}'", name, price, prevName);

            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            // screw u entity franework for not allowing to mess up PK's >:|

            return Redirect(Url.Action("Equipment", "Home"));
        }
    }
}