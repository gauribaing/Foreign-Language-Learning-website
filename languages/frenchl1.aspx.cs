﻿using System;
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
    public partial class frenchl1 : System.Web.UI.Page
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
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\a.wav");
            player.Play();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\b.wav");
            player.Play();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\c.wav");
            player.Play();
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\d.wav");
            player.Play();
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\e.wav");
            player.Play();
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\f.wav");
            player.Play();
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\g.wav");
            player.Play();
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\h.wav");
            player.Play();
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\i.wav");
            player.Play();
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\j.wav");
            player.Play();
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\k.wav");
            player.Play();
        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\l.wav");
            player.Play();
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\m.wav");
            player.Play();
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\n.wav");
            player.Play();
        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\o.wav");
            player.Play();
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\p.wav");
            player.Play();
        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\q.wav");
            player.Play();
        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\r.wav");
            player.Play();
        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\s.wav");
            player.Play();
        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\t.wav");
            player.Play();
        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\u.wav");
            player.Play();
        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\v.wav");
            player.Play();
        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\w.wav");
            player.Play();
        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\x.wav");
            player.Play();
        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\y.wav");
            player.Play();
        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\faudio\z.wav");
            player.Play();
        }
    }
}