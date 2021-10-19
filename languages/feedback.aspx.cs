using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace languages
{
    public partial class feedback : System.Web.UI.Page
    {   SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("userlogin.aspx");
            }
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = " select top 1 userID  from feedback order by userID desc";
            cmd1.ExecuteNonQuery();
            con.Close();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
            da2.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                count = Convert.ToInt32(dr["userID"].ToString());
            }
            count = count + 1;
           
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into feedback values('" + count.ToString() + "','" + TextBox1.Text + "','" + DropDownList1.Text + "','" + TextBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Feedback submitted');</script>");
        }
    }
}