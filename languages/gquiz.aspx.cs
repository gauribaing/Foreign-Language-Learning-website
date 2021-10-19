﻿using System;
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
    public partial class gquiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("userlogin.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\goodday.wav");
            player.Play();

            Button2.BackColor = System.Drawing.Color.Red;
            Button3.BackColor = System.Drawing.Color.Green;

            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\goodmorning.wav");
            player.Play();

            Button3.BackColor = System.Drawing.Color.Green;

            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\goodnight.wav");
            player.Play();

            Button4.BackColor = System.Drawing.Color.Red;
            Button3.BackColor = System.Drawing.Color.Green;

            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\boy.wav");
            player.Play();

            Button5.BackColor = System.Drawing.Color.Red;
            Button7.BackColor = System.Drawing.Color.Green;

            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\time.wav");
            player.Play();

            Button6.BackColor = System.Drawing.Color.Red;
            Button7.BackColor = System.Drawing.Color.Green;

            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\girl.wav");
            player.Play();

            Button7.BackColor = System.Drawing.Color.Green;

            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\thankyou.wav");
            player.Play();

            Button8.BackColor = System.Drawing.Color.Red;
            Button9.BackColor = System.Drawing.Color.Green;

            Button8.Enabled = false;
            Button9.Enabled = false;
            Button10.Enabled = false;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\please.wav");
            player.Play();

            Button9.BackColor = System.Drawing.Color.Green;

            Button8.Enabled = false;
            Button9.Enabled = false;
            Button10.Enabled = false;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\sorry.wav");
            player.Play();

            Button10.BackColor = System.Drawing.Color.Red;
            Button9.BackColor = System.Drawing.Color.Green;

            Button8.Enabled = false;
            Button9.Enabled = false;
            Button10.Enabled = false;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Button11.BackColor = System.Drawing.Color.Red;
            Button13.BackColor = System.Drawing.Color.Green;

            Button11.Enabled = false;
            Button12.Enabled = false;
            Button13.Enabled = false;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Button12.BackColor = System.Drawing.Color.Red;
            Button13.BackColor = System.Drawing.Color.Green;

            Button11.Enabled = false;
            Button12.Enabled = false;
            Button13.Enabled = false;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Button13.BackColor = System.Drawing.Color.Green;

            Button11.Enabled = false;
            Button12.Enabled = false;
            Button13.Enabled = false;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Button14.BackColor = System.Drawing.Color.Green;

            Button14.Enabled = false;
            Button15.Enabled = false;
            Button16.Enabled = false;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Button15.BackColor = System.Drawing.Color.Red;
            Button14.BackColor = System.Drawing.Color.Green;

            Button14.Enabled = false;
            Button15.Enabled = false;
            Button16.Enabled = false;
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Button16.BackColor = System.Drawing.Color.Red;
            Button14.BackColor = System.Drawing.Color.Green;

            Button14.Enabled = false;
            Button15.Enabled = false;
            Button16.Enabled = false;
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Button17.BackColor = System.Drawing.Color.Green;

            Button17.Enabled = false;
            Button18.Enabled = false;
            Button19.Enabled = false;
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Button18.BackColor = System.Drawing.Color.Red;
            Button17.BackColor = System.Drawing.Color.Green;

            Button17.Enabled = false;
            Button18.Enabled = false;
            Button19.Enabled = false;
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Button19.BackColor = System.Drawing.Color.Red;
            Button17.BackColor = System.Drawing.Color.Green;

            Button17.Enabled = false;
            Button18.Enabled = false;
            Button19.Enabled = false;
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\gc15.wav");
            player.Play();

            Button20.BackColor = System.Drawing.Color.Red;
            Button22.BackColor = System.Drawing.Color.Green;

            Button20.Enabled = false;
            Button21.Enabled = false;
            Button22.Enabled = false;
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\student.wav");
            player.Play();

            Button21.BackColor = System.Drawing.Color.Red;
            Button22.BackColor = System.Drawing.Color.Green;

            Button20.Enabled = false;
            Button21.Enabled = false;
            Button22.Enabled = false;
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\meet.wav");
            player.Play();

            Button22.BackColor = System.Drawing.Color.Green;

            Button20.Enabled = false;
            Button21.Enabled = false;
            Button22.Enabled = false;
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\gc22.wav");
            player.Play();

            Button23.BackColor = System.Drawing.Color.Red;
            Button24.BackColor = System.Drawing.Color.Green;

            Button23.Enabled = false;
            Button24.Enabled = false;
            Button25.Enabled = false;
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\music.wav");
            player.Play();

            Button24.BackColor = System.Drawing.Color.Green;

            Button23.Enabled = false;
            Button24.Enabled = false;
            Button25.Enabled = false;
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\gc25.wav");
            player.Play();

            Button25.BackColor = System.Drawing.Color.Red;
            Button24.BackColor = System.Drawing.Color.Green;

            Button23.Enabled = false;
            Button24.Enabled = false;
            Button25.Enabled = false;
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            Button26.BackColor = System.Drawing.Color.Red;
            Button28.BackColor = System.Drawing.Color.Green;

            Button26.Enabled = false;
            Button27.Enabled = false;
            Button28.Enabled = false;
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            Button27.BackColor = System.Drawing.Color.Red;
            Button28.BackColor = System.Drawing.Color.Green;

            Button26.Enabled = false;
            Button27.Enabled = false;
            Button28.Enabled = false;
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            Button28.BackColor = System.Drawing.Color.Green;

            Button26.Enabled = false;
            Button27.Enabled = false;
            Button28.Enabled = false;
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\sorry.wav");
            player.Play();
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\Visual Studio 2010\Projects\languages\languages\gaudio\gc15.wav");
            player.Play();
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            Button31.BackColor = System.Drawing.Color.Red;
            Button32.BackColor = System.Drawing.Color.Green;

            Button31.Enabled = false;
            Button32.Enabled = false;
            Button33.Enabled = false;
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            Button32.BackColor = System.Drawing.Color.Green;

            Button31.Enabled = false;
            Button32.Enabled = false;
            Button33.Enabled = false;
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            Button33.BackColor = System.Drawing.Color.Red;
            Button32.BackColor = System.Drawing.Color.Green;

            Button31.Enabled = false;
            Button32.Enabled = false;
            Button33.Enabled = false;
        }     
    }
}