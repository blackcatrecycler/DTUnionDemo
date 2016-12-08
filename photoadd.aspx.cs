using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class photoadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSub_Click(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;

        string select = "INSERT INTO photo VALUES ('/image/demo.jpg','" + dt.ToString() + "')";

        God_admin.admin.In(select);
        Response.Write("<script>alert('添加成功')</script>");
    }
}