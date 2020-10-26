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

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> vals = new List<string>();
            vals.Add(issued.Value);
            vals.Add(equipment.Value);
            vals.Add(employee.Value);
            List<string> cols = new List<string>() {"issued_at" , "equipment", "employee" };
            Controller.NewRec(vals, cols, "Issues");
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
            Controller.RemoveRec(list, "id", "Issues");
            Server.TransferRequest(Request.Url.AbsolutePath, false);
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