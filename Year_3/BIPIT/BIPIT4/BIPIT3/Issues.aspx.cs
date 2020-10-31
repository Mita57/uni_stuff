using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIPIT3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataSet dataSet;

        protected void Page_Load(object sender, EventArgs e)
        {
            dataSet = Controller.GetData("", "", "Issues");
            DataTable table = dataSet.Tables["Issues"];
            Table1.DataSource = table;
            Table1.DataBind();
        }

        // add
        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            vals.Add(issued.Value);
            vals.Add(equipment.Value);
            vals.Add(employee.Value);
            List<string> cols = new List<string>() {"issued_at" , "equipment", "employee" };
            Controller.NewRec(vals, cols, "Issues");
            Server.TransferRequest(Request.Url.AbsolutePath, false);
            Page_Load(sender, e);
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in Table1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox cb = (row.Cells[0].FindControl("ch") as CheckBox);
                    if (cb.Checked)
                    {
                        try
                        {
                            Controller.RemoveRec(row.Cells[1].Text, "Id", "Issues");
                        }
                        catch
                        {
                            deb.InnerHtml += "The following stuff is still used: " + row.Cells[1].Text + "<br>";
                        }
                    }
                }
            }
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void sortBtn_Click(object sender, EventArgs e)
        {
            dataSet = Controller.GetData(dateLeft.Value, dateRight.Value, "Equipment");
            DataTable table = dataSet.Tables["Equipment"];
            Table1.DataSource = table;
            Table1.DataBind();
        }
    }
}