using System;
using System.Data.SqlClient;

namespace BIPIT3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection _connection;
            String connectString = @"Data Source = EquipmentFFS.mssql.somee.com ; Initial Catalog = EquipmentFFS;User ID = dungeonMaster_SQLLogin_1; password = rcct57h98i; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();
            String query = ("SELECT * FROM Employees");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            string res = "<table>";
            while (dataReader.Read())
            {
                res += "<tr>";
                res += "<td>" + dataReader.GetValue(0) + "</td>";
                res += "<td>" + dataReader.GetValue(1).ToString().Split(' ')[0] + "</td>";
                res += "</tr>";
            }
            res += "</table>";
            if (res != "<table></table>")
            {
                table.InnerHtml = res;
            }
        }
    }
}