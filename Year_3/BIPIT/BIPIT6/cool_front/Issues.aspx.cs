using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cool_front
{
    public partial class Issues : System.Web.UI.Page
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[][] data = service.GetData("Issues");
                string res = "<table>";

                for (int i = 0; i < data.Length; i++)
                {
                    res += "<tr>";
                    for (int j = 0; j < data[i].Length; j++)
                    {
                        res += "<td>" + data[i][j] + "</td>";
                    }
                    res += "</tr>";
                }

                res += "</table>";
                this.table.InnerHtml = res;

                data = service.GetData("Equipment");
                for(int i = 0; i < data.Length; i++)
                {
                    equipments.Items.Add(data[i][0]);
                }

                data = service.GetData("Employees");
                for (int i = 0; i < data.Length; i++)
                {
                    employees.Items.Add(data[i][0]);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            vals.Add(issued.Value);
            vals.Add(equipments.SelectedValue);
            vals.Add(employees.SelectedValue);
            vals.Add(DateTime.Now.ToString());
            List<string> cols = new List<string>() { "issued_at", "equipment", "employee", "Added" };
            service.NewRec(vals.ToArray(), cols.ToArray(), "Issues");
            Server.TransferRequest(Request.Url.AbsolutePath, false);
            Page_Load(sender, e);
        }
    }
}