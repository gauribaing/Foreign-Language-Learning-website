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
    public partial class userlogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\App_Data\Database1.mdf;Integrated Security=True;User Instance=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String username = TextBox1.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from userlogin where username='"+TextBox1.Text+"' and password= '"+ TextBox2.Text+"'";
            cmd.ExecuteNonQuery();

            
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {

                Session["username"] = username;
                Response.Redirect("userpage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Incorrect username and password');</script>");

            }          
            con.Close();
        }
    }
}