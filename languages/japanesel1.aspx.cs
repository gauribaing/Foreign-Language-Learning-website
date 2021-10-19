using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Media;

namespace languages
{
    public partial class japanesel1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("userlogin.aspx");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\a.wav");
            player.Play();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\i.wav");
            player.Play();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\u.wav");
            player.Play();
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\e.wav");
            player.Play();
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\o.wav");
            player.Play();
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ka.wav");
            player.Play();
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ki.wav");
            player.Play();
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ku.wav");
            player.Play();
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ke.wav");
            player.Play();
        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ko.wav");
            player.Play();
        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\sa.wav");
            player.Play();
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\shi.wav");
            player.Play();
        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\su.wav");
            player.Play();
        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\se.wav");
            player.Play();
        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\so.wav");
            player.Play();
        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ta.wav");
            player.Play();
        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\chi.wav");
            player.Play();
        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\tsu.wav");
            player.Play();
        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\te.wav");
            player.Play();
        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\to.wav");
            player.Play();
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\na.wav");
            player.Play();
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ni.wav");
            player.Play();
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\nu.wav");
            player.Play();
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ne.wav");
            player.Play();
        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\no.wav");
            player.Play();
        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ha.wav");
            player.Play();
        }

        protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\hi.wav");
            player.Play();
        }

        protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\fu.wav");
            player.Play();
        }

        protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\he.wav");
            player.Play();
        }

        protected void ImageButton30_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ho.wav");
            player.Play();
        }

        protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ma.wav");
            player.Play();
        }

        protected void ImageButton32_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\mi.wav");
            player.Play();
        }

        protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\mu.wav");
            player.Play();
        }

        protected void ImageButton34_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\me.wav");
            player.Play();
        }

        protected void ImageButton35_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\mo.wav");
            player.Play();
        }

        protected void ImageButton36_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ya.wav");
            player.Play();
        }

        protected void ImageButton38_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\yu.wav");
            player.Play();
        }

        protected void ImageButton40_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\yo.wav");
            player.Play();
        }

        protected void ImageButton41_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ra.wav");
            player.Play();
        }

        protected void ImageButton42_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ri.wav");
            player.Play();
        }

        protected void ImageButton43_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ru.wav");
            player.Play();
        }

        protected void ImageButton44_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\re.wav");
            player.Play();
        }

        protected void ImageButton45_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\ro.wav");
            player.Play();
        }

        protected void ImageButton46_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\wa.wav");
            player.Play();
        }

        protected void ImageButton50_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\wo.wav");
            player.Play();
        }

        protected void ImageButton37_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\jaudio\n.wav");
            player.Play();
        }
    }
}