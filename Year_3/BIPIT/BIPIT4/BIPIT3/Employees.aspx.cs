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
            if (!IsPostBack)
            {
                dataSet = Controller.GetData("", "", "Employees");
                DataTable table = dataSet.Tables["Employees"];
                Table1.DataSource = table;
                Table1.DataBind();
            }
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
            Page_Load(sender, e);
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            string errMsg = "The following items are still in use: ";
            foreach (GridViewRow row in Table1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox cb = (row.Cells[0].FindControl("ch") as CheckBox);
                    if (cb.Checked)
                    {
                        try
                        {
                            Controller.RemoveRec(row.Cells[1].Text, "Name", "Employees");
                        }
                        catch
                        {
                            errMsg += row.Cells[1].Text + "<br>";
                        }
                    }
                }
            }
            if (errMsg != "The following items are still in use:")
            {
                deb.InnerHtml = errMsg;
            }
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void sortBtn_Click(object sender, EventArgs e)
        {
            dataSet = Controller.GetData(dateLeft.Value, dateRight.Value, "Employees");
            DataTable table = dataSet.Tables["Employee"];
            Table1.DataSource = table;
            Table1.DataBind();
        }
    }
}