using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace BIPIT3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataSet dataSet;

        protected void Page_Load(object sender, EventArgs e)
        {
            dataSet = Controller.GetData("", "", "Employees");
            DataTable table = dataSet.Tables["Employees"];
            Table1.DataSource = table;
            Table1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            vals.Add(name.Value);
            vals.Add(bd.Value);
            List<string> cols = new List<string>() { "Name", "Birth_Date" };
            Controller.NewRec(vals, cols, "Employees");
            name.Value = "";
            bd.Value = "";
            Server.TransferRequest(Request.Url.AbsolutePath, false);
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (Control ctl in this.Page.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked)
                    {
                        list.Add(ctl.ID.Split(new string[] { "CB" }, StringSplitOptions.None)[1]);
                    }
                }
            }
            Controller.RemoveRec(list, "name", "Employees");
            Server.TransferRequest(Request.Url.AbsolutePath, false);
        }

        protected void sortBtn_Click(object sender, EventArgs e)
        {
            dataSet = Controller.GetData(dateLeft.Value, dateRight.Value, "Employee");
            DataTable table = dataSet.Tables["Employee"];
            Table1.DataSource = table;
            Table1.DataBind();
        }
    }
}