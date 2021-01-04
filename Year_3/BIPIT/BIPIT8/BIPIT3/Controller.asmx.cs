using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;
using System.IO;
using System.Web.UI.WebControls;

namespace BIPIT3
{
    /// <summary>
    /// Summary description for Contoller
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Controller : System.Web.Services.WebService
    {
        [WebMethod]
        public static DataSet GetEquipment(string left, string right)
        {
            DataSet dataSet = new DataSet();
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var equipment = eq.Equipments;

                var cols = new List<string>() { "Name", "price", "Added" };
                DataTable table = new DataTable("Equipment");

                foreach (string col in cols)
                {
                    table.Columns.Add(col);
                }

                foreach (var e in equipment)
                {
                    if (left == "" && right == "")
                    {
                        table.Rows.Add(
                            e.Name,
                            e.price,
                            e.Added);
                    }
                    else
                    {
                        if ((Convert.ToDateTime(left) <= e.Added) && (e.Added <= Convert.ToDateTime(right)))
                        {
                            table.Rows.Add(
                                e.Name,
                                e.price,
                                e.Added);
                        }
                    }

                }
                dataSet.Tables.Add(table);
            }
            return dataSet;
        }

        [WebMethod]
        public static DataSet GetIssues(string left, string right)
        {
            DataSet dataSet = new DataSet();
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var issues = eq.Issues;

                var cols = new List<string>() { "issued_at", "equipment", "employee", "Added" };
                DataTable table = new DataTable("Issues");

                foreach (string col in cols)
                {
                    table.Columns.Add(col);
                }

                foreach (var e in issues)
                {
                    if (left == "" && right == "")
                    {
                        table.Rows.Add(
                            e.issued_at,
                            e.equipment,
                            e.employee,
                            e.Added,
                            e.id);
                    }
                    else
                    {
                        if ((Convert.ToDateTime(left) <= e.Added) && (e.Added <= Convert.ToDateTime(right)))
                        {
                            table.Rows.Add(
                                e.issued_at,
                                e.equipment,
                                e.employee,
                                e.Added,
                                e.id);
                        }
                    }

                }
                dataSet.Tables.Add(table);
            }
            return dataSet;
        }

        [WebMethod]
        public static DataSet GetEmployees(string left, string right)
        {
            DataSet dataSet = new DataSet();
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var emps = eq.Employees;

                var cols = new List<string>() { "Name", "Birth_date", "Added" };
                DataTable table = new DataTable("Employees");

                foreach (string col in cols)
                {
                    table.Columns.Add(col);
                }

                foreach (var e in emps)
                {
                    if (left == "" && right == "")
                    {
                        table.Rows.Add(
                            e.Name,
                            e.Birth_date,
                            e.Added);
                    }
                    else
                    {
                        if ((Convert.ToDateTime(left) <= e.Added) && (e.Added <= Convert.ToDateTime(right)))
                        {
                            table.Rows.Add(
                                e.Name,
                                e.Birth_date,
                                e.Added);
                        }
                    }

                }
                dataSet.Tables.Add(table);
            }
            return dataSet;
        }

        [WebMethod]
        public static void NewEquipment(string name, int price)
        {
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var equipment = eq.Equipments;
                Equipment newEq = new Equipment
                {
                    Name = name,
                    price = price,
                    Added = DateTime.Now
                };
                equipment.Add(newEq);
                eq.SaveChanges();
            }
        }

        [WebMethod]
        public static void NewIssues(DateTime issued, string equipment, string emp)
        {
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var issues = eq.Issues;
                Issue newIs = new Issue
                {
                    issued_at = issued,
                    equipment = equipment,
                    employee = emp,
                    Added = DateTime.Now
                };
                issues.Add(newIs);
                eq.SaveChanges();
            }
        }

        [WebMethod]
        public static void NewEmployee(string name, DateTime bday)
        {
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var emps = eq.Employees;
                Employee newEmp = new Employee
                {
                    Name = name,
                    Birth_date = bday,
                    Added = DateTime.Now
                };
                emps.Add(newEmp);
                eq.SaveChanges();
            }
        }

        [WebMethod]
        public static void RemoveEquipment(string name)
        {
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var equipment = eq.Equipments;
                Equipment eqToDelete = eq.Equipments.Where(n => n.Name == name).FirstOrDefault();
                if (eqToDelete != null)
                {
                    eq.Equipments.Remove(eqToDelete);
                    eq.SaveChanges();
                }
            }
        }

        [WebMethod]
        public static void RemoveIssue(int id)
        {
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var issues = eq.Issues;
                Issue issueToDelete = eq.Issues.Where(n => n.id == id).FirstOrDefault();
                if (issueToDelete != null)
                {
                    eq.Issues.Remove(issueToDelete);
                    eq.SaveChanges();
                }
            }
        }

        [WebMethod]
        public static void RemoveEmployee(string name)
        {
            using (EquipmentEntities eq = new EquipmentEntities())
            {
                var issues = eq.Employees;
                Employee empToDelete = eq.Employees.Where(n => n.Name == name).FirstOrDefault();
                if (empToDelete != null)
                {
                    eq.Employees.Remove(empToDelete);
                    eq.SaveChanges();
                }
            }
        }

        //[WebMethod]
        //public static List<string> GetRawData(string table)
        //{

        //}
    }
}
