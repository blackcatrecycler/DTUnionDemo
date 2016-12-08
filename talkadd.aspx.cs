using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class talkadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSub_Click(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;

        string select = "INSERT INTO talk VALUES (N'" + TxtTitle.Text + "','" + dt.ToString() + "')";

        God_admin.admin.In(select);
        Response.Write("<script>alert('添加成功')</script>");
    }
}