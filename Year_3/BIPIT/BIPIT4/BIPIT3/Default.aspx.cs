﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPIT3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Equipment
            SqlConnection _connection;
            String connectString = @"Data Source = EquipmentFFS.mssql.somee.com ; Initial Catalog = EquipmentFFS;User ID = dungeonMaster_SQLLogin_1; password = rcct57h98i; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();
            String query = ("SELECT * FROM Equipment");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            string res = "<table>";
            while (dataReader.Read())
            {
                res += "<tr>";
                res += "<td> <input type='checkbox' id='CB>" + dataReader.GetValue(0) + "'> </td>";
                res += "<td>" + dataReader.GetValue(0) + "</td>";
                res += "<td>" + dataReader.GetValue(1) + "</td>";
                res += "</tr>";
            }
            res += "</table>";
            if (res != "<table></table>")
            {
                table.InnerHtml = res;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            vals.Add(name.Value);
            vals.Add(price.Value);
            List<string> cols = new List<string>() {"Name", "price"};
            Controller.NewRec(vals, cols, "Equipment");
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(Control ctl in this.Controls)
            {
                if(ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked)
                    {
                        list.Add(ctl.ID.Split(new string[] { "CB" }, StringSplitOptions.None)[0]);
                    }
                }
            }
            Controller.RemoveRec(list, "name", "Equipment");
        }
    }
}