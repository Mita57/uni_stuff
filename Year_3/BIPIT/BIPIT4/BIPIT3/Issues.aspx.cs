using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPIT3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection _connection;
            String connectString = @"Data Source = EquipmentFFS.mssql.somee.com ; Initial Catalog = EquipmentFFS;User ID = dungeonMaster_SQLLogin_1; password = rcct57h98i; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();
            String query = ("SELECT * FROM Issues");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            string res = "<table>";
            while (dataReader.Read())
            {
                res += "<tr>";
                res += "<td>" + dataReader.GetValue(0).ToString().Split(' ')[0] + "</td>";
                res += "<td> " + dataReader.GetValue(1) + "</td>";
                res += "<td> " + dataReader.GetValue(2) + "</td>";
                res += "</tr>";
            }
            res += "</table>";
            if (res != "<table></table>")
            {
                table.InnerHtml = res;
            }

            query = ("SELECT * FROM Employees");
            command = new SqlCommand(query, _connection);
            dataReader = command.ExecuteReader();
            res = "";
            while (dataReader.Read())
            {
                res += "<option value='" + dataReader.GetValue(0) + "'>" + dataReader.GetValue(0) + "</option>";
            }
            if (res != "")
            {
                employee.InnerHtml = res;
            }

            query = ("SELECT * FROM Equipment");
            command = new SqlCommand(query, _connection);
            dataReader = command.ExecuteReader();
            res = "";
            while (dataReader.Read())
            {
                res += "<option value='" + dataReader.GetValue(0) + "'>" + dataReader.GetValue(0) + "</option>";
            }
            if (res != "")
            {
                equipment.InnerHtml = res;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            vals.Add(employee.Value);
            vals.Add(equipment.Value);
            List<string> cols = new List<string>() { "Name", "price" };
            Controller.NewRec(vals, cols, "Equipment");
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (Control ctl in this.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked)
                    {
                        list.Add(ctl.ID.Split(new string[] { "CB" }, StringSplitOptions.None)[0]);
                    }
                }
            }
            Controller.RemoveRec(list, "name", "Equipment");
        }

        protected void sortBtn_Click(object sender, EventArgs e)
        {
            List<string> results = Controller.GetData(dateLeft.Value, dateRight.Value, "Equipment");
            string newTable = "<table>";
            foreach (string res in results)
            {
                string[] parts = res.Split(new string[] { "~/~" }, StringSplitOptions.None);
                newTable += "<tr>";
                newTable += "<td>" + parts[0] + "</td>";
                newTable += "<td>" + parts[1] + "</td>";
                newTable += "</tr>";
            }

            table.InnerHtml = newTable;
        }
    }
}