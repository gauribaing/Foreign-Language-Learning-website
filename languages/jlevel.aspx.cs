using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace languages
{
    public partial class jlevel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("userlogin.aspx");
            }
            else
            {
                Label1.Text = Session["username"].ToString();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //int userid= Convert.ToInt32(Session["ID"].ToString());
            //int count = 0;
            //con.Open();
            //SqlCommand cmd1 = con.CreateCommand();
            //cmd1.CommandType = CommandType.Text;
            //cmd1.CommandText = " select top 1 ID  from score order by ID desc";
            //cmd1.ExecuteNonQuery();
            //con.Close();
            //DataTable dt2 = new DataTable();
            //SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
            //da2.Fill(dt2);
            //foreach (DataRow dr in dt2.Rows)
            //{
            //    count = Convert.ToInt32(dr["ID"].ToString());
            //}
            //count = count + 1;
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into score values('" + count.ToString() + "','"+userid.ToString()+"','0','0','0')";
            //cmd.ExecuteNonQuery();
            //con.Close();
           
        }
    }
}