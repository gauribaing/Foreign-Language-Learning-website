using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Media;

namespace languages
{
    public partial class germanl1 : System.Web.UI.Page
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
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\a.wav");
            player.Play();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\b.wav");
            player.Play();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\c.wav");
            player.Play();
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\d.wav");
            player.Play();
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\e.wav");
            player.Play();
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\f.wav");
            player.Play();
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\g.wav");
            player.Play();
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\h.wav");
            player.Play();
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\i.wav");
            player.Play();
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\j.wav");
            player.Play();
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\k.wav");
            player.Play();
        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\l.wav");
            player.Play();
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\m.wav");
            player.Play();
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\n.wav");
            player.Play();
        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\o.wav");
            player.Play();
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\p.wav");
            player.Play();
        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\q.wav");
            player.Play();
        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\r.wav");
            player.Play();
        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\s.wav");
            player.Play();
        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\t.wav");
            player.Play();
        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\u.wav");
            player.Play();
        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\v.wav");
            player.Play();
        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\w.wav");
            player.Play();
        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\x.wav");
            player.Play();
        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\y.wav");
            player.Play();
        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\z.wav");
            player.Play();
        }
    }
}