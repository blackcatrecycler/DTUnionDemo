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

            //dt表结构
            //| 所属 | 列名 | 作用 |
            //| 共有 | mark | 标记 |
            //| 共有 | id | 动态的id |
            //| blog | title | 日志标题 |
            //| blog | body | 日志主体 |
            //| photo | imgpath | 照片的路径 |
            //| talk | talkbody | 说说的内容 |
            //| 共有 | createtime | 创建时间 |

            DataTable dt = new DataTable();//创建一个新表
            /*规定每列的列名，清楚地告诉dt你需要哪些内容*/
            DataColumn dc1 = new DataColumn("mark", Type.GetType("System.String"));//因为只需要判断是否显示，所以将列的类型都设为string即可
            DataColumn dc2 = new DataColumn("id", Type.GetType("System.String"));
            DataColumn dc3 = new DataColumn("title", Type.GetType("System.String"));
            DataColumn dc4 = new DataColumn("body", Type.GetType("System.String"));
            DataColumn dc5 = new DataColumn("imgpath", Type.GetType("System.String"));
            DataColumn dc6 = new DataColumn("talkbody", Type.GetType("System.String"));
            DataColumn dc7 = new DataColumn("createtime", Type.GetType("System.String"));
            /*将规定好的列填加进表中*/
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            /*到此就建好了一张完美的空表，下面开始填充数据*/
            /*将blog表中的数据填进dt*/
            for(int i = 0; i < blogdt.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["mark"] = "0";//日志标志位0
                dr["id"] = blogdt.Rows[i][0].ToString();
                dr["title"] = blogdt.Rows[i][1].ToString();
                dr["body"] = blogdt.Rows[i][2].ToString();
                dr["imgpath"] = "0";
                dr["talkbody"] = "0";
                dr["createtime"] = blogdt.Rows[i][3].ToString();
                dt.Rows.Add(dr);
            }
            /*将photo表中的数据填进dt*/
            for (int i = 0; i < photodt.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["mark"] = "1";//日志标志位1
                dr["id"] = photodt.Rows[i][0].ToString();
                dr["title"] = "0";
                dr["body"] = "0";
                dr["imgpath"] = photodt.Rows[i][1].ToString();
                dr["talkbody"] = "0";
                dr["createtime"] = photodt.Rows[i][2].ToString();
                dt.Rows.Add(dr);
            }
            /*将talk表中的数据填进dt*/
            for (int i = 0; i < talkdt.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["mark"] = "2";//日志标志位2
                dr["id"] = talkdt.Rows[i][0].ToString();
                dr["title"] = "0";
                dr["body"] = "0";
                dr["imgpath"] = "0";
                dr["talkbody"] = talkdt.Rows[i][1].ToString();
                dr["createtime"] = talkdt.Rows[i][2].ToString();
                dt.Rows.Add(dr);
            }
            dt.DefaultView.Sort="createtime DESC";//给dt排个序
            Repeater1.DataSource = dt;//将数据表作为repeater的数据源
            Repeater1.DataBind();


        }
    }
}