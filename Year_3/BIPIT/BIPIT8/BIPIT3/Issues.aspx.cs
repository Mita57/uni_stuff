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
            if (!IsPostBack)
            {
                dataSet = Controller.GetIssues("", "");
                DataTable table = dataSet.Tables["Issues"];
                Table1.DataSource = table;
                Table1.DataBind();

                employees.Items.Clear();
                foreach (string item in Controller.GetRawEmployees())
                {
                    employees.Items.Add(item);
                }

                equipments.Items.Clear();
                foreach (string item in Controller.GetRawEquipment())
                {
                    equipments.Items.Add(item);
                }
            }
        }

        // add
        protected void Button1_Click(object sender, EventArgs e)
        {
            Controller.NewIssues(Convert.ToDateTime(issued.Value), equipments.SelectedValue, employees.SelectedValue);
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
                            Controller.RemoveIssue(int.Parse(row.Cells[5].Text));
                        }
                        catch
                        {
                            errMsg += row.Cells[5].Text + "<br>";
                        }
                    }
                }
            }
            if (errMsg != "The following items are still in use: ")
            {
                deb.InnerHtml = errMsg;
            }
            else
            {
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
        }

        protected void sortBtn_Click(object sender, EventArgs e)
        {
            dataSet = Controller.GetIssues(dateLeft.Value, dateRight.Value);
            DataTable table = dataSet.Tables["Equipment"];
            Table1.DataSource = table;
            Table1.DataBind();
        }

        protected void resetBtn_Click(object sender, EventArgs e)
        {
            dataSet = Controller.GetIssues(dateLeft.Value, dateRight.Value);
            DataTable table = dataSet.Tables["Equipment"];
            Table1.DataSource = table;
            Table1.DataBind();
        }
    }
}