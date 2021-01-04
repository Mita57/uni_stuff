using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cool_front
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var service = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
                string[][] data = service.GetData("Employees");
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            vals.Add(name.Value);
            vals.Add(bd.Value);
            vals.Add(DateTime.Now.ToString());
            List<string> cols = new List<string>() { "Name", "Birth_Date", "Added" };
            var service = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            service.NewRec(vals.ToArray(), cols.ToArray(), "Employees");
            name.Value = "";
            bd.Value = "";
            Server.TransferRequest(Request.Url.AbsolutePath, false);
            Page_Load(sender, e);
        }
    }
}