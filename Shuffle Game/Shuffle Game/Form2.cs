using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuffle_Game
{
    public partial class Form2 : Form
    {

        private int click1, click2, click3, click4, click5, click6, click7, click8, click9, click10;
        private int time1, time2, time3, time4, time5, time6, time7, time8, time9, time10;

        private string namec1, namec2, namec3, namec4, namec5, namec6, namec7, namec8, namec9, namec10;


        private string namet1, namet2, namet3, namet4, namet5, namet6, namet7, namet8, namet9, namet10;

        private int currentclicks;
        private int currenttime;

        private string currentname;
             
        public Form2(string name,int clicks,int time, int click11, int click22,  int click33,  int click44, int click55, int click66, int click77, int click88, int click99, int click100
            ,int time11, int time22, int time33, int time44, int time55, int time66, int time77, int time88, int time99, int time100
            , string namec11, string namec22, string namec33, string namec44, string namec55, string namec66, string namec77, string namec88, string namec99, string namec100
            , string namet11, string namet22, string namet33, string namet44, string namet55, string namet66, string namet77, string namet88, string namet99, string namet100)
        {
            click1 = click11;
            click2 = click22;
            click3 = click33;
            click4 = click44;
            click5 = click55;
            click6 = click66;
            click7 = click77;
            click8 = click88;
            click9 = click99;
            click10 = click100;

            time1 = time11;
            time2 = time22;
            time3 = time33;
            time4 = time44;
            time5 = time55;
            time6 = time66;
            time7 = time77;
            time8 = time88;
            time9 = time99;
            time10 = time100;

            namec1 = namec11;
            namec2 = namec22;
            namec3 = namec33;
            namec4 = namec44;
            namec5 = namec55;
            namec6 = namec66;
            namec7 = namec77;
            namec8 = namec88;
            namec9 = namec99;
            namec10 = namec100;

            namet1 = namet11;
            namet2 = namet22;
            namet3 = namet33;
            namet4 = namet44;
            namet5 = namet55;
            namet6 = namet66;
            namet7 = namet77;
            namet8 = namet88;
            namet9 = namet99;
            namet10 = namet100;

            currentclicks = clicks;
            currentname = name;
            currenttime = time;
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            checkplaceclicks();
            checkplacetime();
            replace();
        }
        private void replace()
        {
            label12.Text = namec1;
            label13.Text = namec2;
            label14.Text = namec3;
            label15.Text = namec4;
            label16.Text = namec5;
            label17.Text = namec6;
            label18.Text = namec7;
            label19.Text = namec8;
            label20.Text = namec9;
            label21.Text = namec10;

            label22.Text = "" + click1;
            label23.Text = "" + click2;
            label24.Text = "" + click3;
            label25.Text = "" + click4;
            label26.Text = "" + click5;
            label27.Text = "" + click6;
            label28.Text = "" + click7;
            label29.Text = "" + click8;
            label30.Text = "" + click9;
            label31.Text = "" + click10;

            label42.Text = namet10;
            label43.Text = namet9;
            label44.Text = namet8;
            label45.Text = namet7;
            label46.Text = namet6;
            label47.Text = namet5;
            label48.Text = namet4;
            label49.Text = namet3;
            label50.Text = namet2;
            label51.Text = namet1;

            label41.Text = changetostring(time1);
            label40.Text = changetostring(time2);
            label39.Text = changetostring(time3);
            label38.Text = changetostring(time4);
            label37.Text = changetostring(time5);
            label36.Text = changetostring(time6);
            label35.Text = changetostring(time7);
            label34.Text = changetostring(time8);
            label33.Text = changetostring(time9);
            label32.Text = changetostring(time10);



        }
        private string changetostring(int time)
        {
            string thetime;

            int minutes, seconds, secunit, secten, minten, minunit;

            minutes = time / 60;
            seconds = time % 60;
            secunit = seconds % 10;
            secten = seconds / 10;
            minunit = minutes % 10;
            minten = minutes / 10;
            thetime = minten + minunit + ":" + secten + secunit;

            return thetime;
        }
        private void checkplacetime()
        {
            if (currenttime < time1)
            {
                time10 = time9;
                time9 = time8;
                time8 = time7;
                time7 = time6;
                time6 = time5;
                time5 = time4;
                time4 = time3;
                time3 = time2;
                time2 = time1;

                namet10 = namet9;
                namet9 = namet8;
                namet8 = namet7;
                namet7 = namet6;
                namet6 = namet5;
                namet5 = namet4;
                namet4 = namet3;
                namet3 = namet2;
                namet2 = namet1;


                time1 = currenttime;
                namet1 = currentname;
            }
            else
                if (currenttime < time2)
            {
                time10 = time9;
                time9 = time8;
                time8 = time7;
                time7 = time6;
                time6 = time5;
                time5 = time4;
                time4 = time3;
                time3 = time2;

                namet10 = namet9;
                namet9 = namet8;
                namet8 = namet7;
                namet7 = namet6;
                namet6 = namet5;
                namet5 = namet4;
                namet4 = namet3;
                namet3 = namet2;

                time2 = currenttime;
                namet2 = currentname;
            }
            else
                if (currenttime < time3)
            {
                time10 = time9;
                time9 = time8;
                time8 = time7;
                time7 = time6;
                time6 = time5;
                time5 = time4;
                time4 = time3;

                namet10 = namet9;
                namet9 = namet8;
                namet8 = namet7;
                namet7 = namet6;
                namet6 = namet5;
                namet5 = namet4;
                namet4 = namet3;

                time3 = currenttime;
                namet3 = currentname;
            }
            else
                if (currenttime < time4)
            {
                time10 = time9;
                time9 = time8;
                time8 = time7;
                time7 = time6;
                time6 = time5;
                time5 = time4;

                namet10 = namet9;
                namet9 = namet8;
                namet8 = namet7;
                namet7 = namet6;
                namet6 = namet5;
                namet5 = namet4;

                time4 = currenttime;
                namet4 = currentname;
            }
            else
                if (currenttime < time5)
            {
                time10 = time9;
                time9 = time8;
                time8 = time7;
                time7 = time6;
                time6 = time5;

                namet10 = namet9;
                namet9 = namet8;
                namet8 = namet7;
                namet7 = namet6;
                namet6 = namet5;

                time5 = currenttime;
                namet5 = currentname;
            }
            else
                if (currenttime < time6)
            {
                time10 = time9;
                time9 = time8;
                time8 = time7;
                time7 = time6;

                namet10 = namet9;
                namet9 = namet8;
                namet8 = namet7;
                namet7 = namet6;

                time6 = currenttime;
                namet6 = currentname;
            }
            else
                if (currenttime < time7)
            {
                time10 = time9;
                time9 = time8;
                time8 = time7;

                namet10 = namet9;
                namet9 = namet8;
                namet8 = namet7;

                time7 = currenttime;
                namet7 = currentname;
            }
            else
                if (currenttime < time8)
            {
                time10 = time9;
                time9 = time8;

                namet10 = namet9;
                namet9 = namet8;

                time8 = currenttime;
                namet8 = currentname;
            }
            else
                if (currenttime < time9)
            {
                time10 = time9;

                namet10 = namet9;

                time9 = currenttime;
                namet9 = currentname;
            }
            else
                if (currenttime < time10)
            {
                time10 = currenttime;
                namet10 = currentname;
            }
        }
        private void checkplaceclicks()
        {
            if(currentclicks<click1)
            {
                click10 = click9;
                click9 = click8;
                click8 = click7;
                click7 = click6;
                click6 = click5;
                click5 = click4;
                click4 = click3;
                click3 = click2;
                click2 = click1;

                namec10 = namec9;
                namec9 = namec8;
                namec8 = namec7;
                namec7 = namec6;
                namec6 = namec5;
                namec5 = namec4;
                namec4 = namec3;
                namec3 = namec2;
                namec2 = namec1;

                click1 = currentclicks;
                namec1 = currentname;
            }
            else
                if (currentclicks < click2)
            {
                click10 = click9;
                click9 = click8;
                click8 = click7;
                click7 = click6;
                click6 = click5;
                click5 = click4;
                click4 = click3;
                click3 = click2;

                namec10 = namec9;
                namec9 = namec8;
                namec8 = namec7;
                namec7 = namec6;
                namec6 = namec5;
                namec5 = namec4;
                namec4 = namec3;
                namec3 = namec2;

                click2 = currentclicks;
                namec2 = currentname;
            }
            else
                if (currentclicks < click3)
            {
                click10 = click9;
                click9 = click8;
                click8 = click7;
                click7 = click6;
                click6 = click5;
                click5 = click4;
                click4 = click3;

                namec10 = namec9;
                namec9 = namec8;
                namec8 = namec7;
                namec7 = namec6;
                namec6 = namec5;
                namec5 = namec4;
                namec4 = namec3;


                click3 = currentclicks;
                namec3 = currentname;
            }
            else
                if (currentclicks < click4)
            {
                click10 = click9;
                click9 = click8;
                click8 = click7;
                click7 = click6;
                click6 = click5;
                click5 = click4;

                namec10 = namec9;
                namec9 = namec8;
                namec8 = namec7;
                namec7 = namec6;
                namec6 = namec5;
                namec5 = namec4;

                click4 = currentclicks;
                namec4 = currentname;
            }
            else
                if (currentclicks < click5)
            {
                click10 = click9;
                click9 = click8;
                click8 = click7;
                click7 = click6;
                click6 = click5;

                namec10 = namec9;
                namec9 = namec8;
                namec8 = namec7;
                namec7 = namec6;
                namec6 = namec5;

                click5 = currentclicks;
                namec5 = currentname;
            }
            else
                if (currentclicks < click6)
            {
                click10 = click9;
                click9 = click8;
                click8 = click7;
                click7 = click6;

                namec10 = namec9;
                namec9 = namec8;
                namec8 = namec7;
                namec7 = namec6;

                click6 = currentclicks;
                namec6 = currentname;
            }
            else
                if (currentclicks < click7)
            {
                click10 = click9;
                click9 = click8;
                click8 = click7;

                namec10 = namec9;
                namec9 = namec8;
                namec8 = namec7;

                click7 = currentclicks;
                namec7 = currentname;
            }
            else
                if (currentclicks < click8)
            {
                click10 = click9;
                click9 = click8;

                namec10 = namec9;
                namec9 = namec8;

                click8 = currentclicks;
                namec8 = currentname;
            }
            else
                if (currentclicks < click9)
            {
                click10 = click9;

                namec10 = namec9;

                click9 = currentclicks;
                namec9 = currentname;
            }
            else
                if (currentclicks < click10)
            {
                click10 = currentclicks;
                namec10 = currentname;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1(click1, click2, click3, click4, click5, click6, click7, click8, click9, click10
            , time1, time2, time3, time4, time5, time6, time7, time8, time9, time10
            , namec1, namec2, namec3, namec4, namec5, namec6, namec7, namec8, namec9, namec10
            , namet1, namet2, namet3, namet4, namet5, namet6, namet7, namet8, namet9, namet10
            ,true);
            fm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            replace();
        }
    }
}
