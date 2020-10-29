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
            for(int i = 0; i < Table1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)Table1.Rows[i].FindControl("ch");
                deb.InnerHtml += Table1.Rows[i].Cells[5].Text;
                if (cb.Checked)
                {
                    string id = Table1.Rows[i].Cells[5].Text;
                    Controller.RemoveRec(id, "id", "Issues");
                }
            }
            Page_Load(sender, e);
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