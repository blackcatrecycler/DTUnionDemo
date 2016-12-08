using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using God_admin;

public partial class demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string strblog = "SELECT * From blog ";
            string strphoto = "SELECT * From photo ";
            string strtalk = "SELECT * From talk ";
            DataTable blogdt = admin.DataT(strblog);
            DataTable photodt = admin.DataT(strphoto);
            DataTable talkdt = admin.DataT(strtalk);

            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("mark", Type.GetType("System.String"));
            DataColumn dc2 = new DataColumn("id", Type.GetType("System.String"));
            DataColumn dc3 = new DataColumn("title", Type.GetType("System.String"));
            DataColumn dc4 = new DataColumn("body", Type.GetType("System.String"));
            DataColumn dc5 = new DataColumn("imgpath", Type.GetType("System.String"));
            DataColumn dc6 = new DataColumn("talkbody", Type.GetType("System.String"));
            DataColumn dc7 = new DataColumn("createtime", Type.GetType("System.String"));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            for(int i = 0; i < blogdt.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["mark"] = "0";
                dr["id"] = blogdt.Rows[i][0].ToString();
                dr["title"] = blogdt.Rows[i][1].ToString();
                dr["body"] = blogdt.Rows[i][2].ToString();
                dr["imgpath"] = "0";
                dr["talkbody"] = "0";
                dr["createtime"] = blogdt.Rows[i][3].ToString();
                dt.Rows.Add(dr);
            }
            for (int i = 0; i < photodt.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["mark"] = "1";
                dr["id"] = photodt.Rows[i][0].ToString();
                dr["title"] = "0";
                dr["body"] = "0";
                dr["imgpath"] = photodt.Rows[i][1].ToString();
                dr["talkbody"] = "0";
                dr["createtime"] = photodt.Rows[i][2].ToString();
                dt.Rows.Add(dr);
            }
            for (int i = 0; i < talkdt.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["mark"] = "2";
                dr["id"] = talkdt.Rows[i][0].ToString();
                dr["title"] = "0";
                dr["body"] = "0";
                dr["imgpath"] = "0";
                dr["talkbody"] = talkdt.Rows[i][1].ToString();
                dr["createtime"] = talkdt.Rows[i][2].ToString();
                dt.Rows.Add(dr);
            }
            dt.DefaultView.Sort="createtime DESC";
            Repeater1.DataSource = dt;
            Repeater1.DataBind();


        }
    }
}