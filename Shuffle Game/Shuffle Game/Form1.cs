using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private bool have=false;

        private int click1, click2, click3, click4, click5, click6, click7, click8, click9, click10;
        private int time1, time2, time3, time4, time5, time6, time7, time8, time9, time10;

        private string namec1, namec2, namec3, namec4, namec5, namec6, namec7, namec8, namec9, namec10;


        private string namet1, namet2, namet3, namet4, namet5, namet6, namet7, namet8, namet9, namet10;

        private int count = 0, seconds, secunit, secten, minunit,minten=0,minutes,time=0;
        private int countsave, timesave;
        public Form1(int click11, int click22, int click33, int click44, int click55, int click66, int click77, int click88, int click99, int click100
            , int time11, int time22, int time33, int time44, int time55, int time66, int time77, int time88, int time99, int time100
            , string namec11, string namec22, string namec33, string namec44, string namec55, string namec66, string namec77, string namec88, string namec99, string namec100
            , string namet11, string namet22, string namet33, string namet44, string namet55, string namet66, string namet77, string namet88, string namet99, string namet100
            ,bool have1)
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

            have = have1;

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Checkbutton(button1, button2);
            Checkbutton(button1, button5);

            CheckSolve();
            ShowClick();
        }

        private void Checkbutton(Button butt1, Button butt2)
        {
            if (butt2.Text == "")
            {
                butt2.Text = butt1.Text;
                butt1.Text = "";
                count++;
            }
        }
        private void CheckSolve()
        {
            if(button1.Text=="1"&& button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == ""&&count>0)
            {
                MessageBox.Show("Wow "+textBox1.Text+",You did it in : "+count+" Clicks"+Environment.NewLine + "Check in the leaderboard if you are in the top 10");
                countsave = count;
                timesave = time;
                count = 0;
                time = 0;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Checkbutton(button3, button2);
            Checkbutton(button3, button4);
            Checkbutton(button3, button7);

            CheckSolve();
            ShowClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Checkbutton(button2, button1);
            Checkbutton(button2, button3);
            Checkbutton(button2, button6);

            CheckSolve();
            ShowClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Checkbutton(button4, button8);
            Checkbutton(button4, button3);

            CheckSolve();
            ShowClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Checkbutton(button5, button1);
            Checkbutton(button5, button6);
            Checkbutton(button5, button9);

            CheckSolve();
            ShowClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Checkbutton(button6, button5);
            Checkbutton(button6, button7);
            Checkbutton(button6, button2);
            Checkbutton(button6, button10);

            CheckSolve();
            ShowClick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Checkbutton(button7, button3);
            Checkbutton(button7, button11);
            Checkbutton(button7, button6);
            Checkbutton(button7, button8);

            CheckSolve();
            ShowClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Checkbutton(button8, button4);
            Checkbutton(button8, button7);
            Checkbutton(button8, button12);

            CheckSolve();
            ShowClick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Checkbutton(button9, button5);
            Checkbutton(button9, button10);
            Checkbutton(button9, button13);

            CheckSolve();
            ShowClick();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Checkbutton(button10, button6);
            Checkbutton(button10, button9);
            Checkbutton(button10, button11);
            Checkbutton(button10, button14);

            CheckSolve();
            ShowClick();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Checkbutton(button11, button7);
            Checkbutton(button11, button10);
            Checkbutton(button11, button12);
            Checkbutton(button11, button15);

            CheckSolve();
            ShowClick();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Checkbutton(button12, button8);
            Checkbutton(button12, button11);
            Checkbutton(button12, button16);

            CheckSolve();
            ShowClick();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Checkbutton(button13, button9);
            Checkbutton(button13, button14);

            CheckSolve();
            ShowClick();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Checkbutton(button14, button10);
            Checkbutton(button14, button13);
            Checkbutton(button14, button15);

            CheckSolve();
            ShowClick();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Checkbutton(button15, button11);
            Checkbutton(button15, button14);
            Checkbutton(button15, button16);

            CheckSolve();
            ShowClick();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if ((timesave != 0 && countsave != 0)||have)
            {
                if(timesave==0||countsave==0)
                {
                    timesave = 100000000;
                    countsave=100000000;
                }
                Form2 f2 = new Form2(textBox1.Text, countsave, timesave, click1, click2, click3, click4, click5, click6, click7, click8, click9, click10
                , time1, time2, time3, time4, time5, time6, time7, time8, time9, time10
                , namec1, namec2, namec3, namec4, namec5, namec6, namec7, namec8, namec9, namec10
                , namet1, namet2, namet3, namet4, namet5, namet6, namet7, namet8, namet9, namet10);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("First set the first record");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("If you don't write your name,so you could not be in the leaderboard"+Environment.NewLine+"And click leaderboard after you finish to save your record");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Checkbutton(button16, button15);
            Checkbutton(button16, button12);

            CheckSolve();
            ShowClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Shuffle();
            count = 0;
            ShowClick();
            time = 0;
        }
        private void Shuffle()
        {
            int[] a = new int[15];
            int i = 0;
            int j = 0;
            int RN = 0;
            bool flag = false;
            Random rnd = new Random();
            flag = false;
            i = 1;
            a[j] = 1;
            while (i < 15)
            {
                RN = rnd.Next(1, 16);
                for (j = 0; j <= i; j++)
                {
                    if (a[j] == RN)
                    {
                        flag = true;
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    a[i] = RN;
                    i = i + 1;
                }
            }
            string[] newa =new string[15];
            for(int e=0;e<15;e++)
            {
                int num = a[e];
                string snum = "" + num;
                newa[e] = snum;
            }
            button1.Text = newa[0];
            button2.Text = newa[1];
            button3.Text = newa[2];
            button4.Text = newa[3];
            button5.Text = newa[4];
            button6.Text = newa[5];
            button7.Text = newa[6];
            button8.Text = newa[7];
            button9.Text = newa[8];
            button10.Text = newa[9];
            button11.Text = newa[10];
            button12.Text = newa[11];
            button13.Text = newa[12];
            button14.Text = newa[13];
            button15.Text = newa[14];
            button16.Text = "";
        }

        private void ShowClick()
        {
            toolStripLabel1.Text = "Shuffle : " + count + " Clicks";
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            minutes = time / 60;
            seconds = time % 60;
            secunit = seconds % 10;
            secten = seconds / 10;
            minunit = minutes % 10;
            minten = minutes / 10;
            toolStripLabel2.Text = minten + minunit + ":" + secten + secunit;
        }
    }
}
