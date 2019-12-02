using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        string tekst;
        int x, y;
        bool klik = false;
        public Form1()
        {
           
            InitializeComponent();
         
         



            label1.Parent=pictureBox2;
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;
            label4.Parent = pictureBox2;
            pictureBox1.Parent = pictureBox2;
            pictureBox3.Parent = pictureBox2;
            pictureBox4.Parent = pictureBox2;
            pictureBox5.Parent = pictureBox2;
            pictureBox6.Parent = pictureBox2;
            pictureBox7.Parent = pictureBox2;
            pictureBox8.Parent = pictureBox2;
            pictureBox9.Parent = pictureBox2;
            pictureBox10.Parent = pictureBox2;
            pictureBox11.Parent = pictureBox2;
            pictureBox12.Parent = pictureBox2;
            pictureBox13.Parent = pictureBox2;
            pictureBox14.Parent = pictureBox2;
            pictureBox15.Parent = pictureBox2;
            pictureBox16.Parent = pictureBox2;
            pictureBox17.Parent = pictureBox2;
            pictureBox18.Parent = pictureBox2;
            pictureBox19.Parent = pictureBox2;
            pictureBox20.Parent = pictureBox2;
            pictureBox21.Parent = pictureBox2;
            pictureBox22.Parent = pictureBox2;
            pictureBox23.Parent = pictureBox2;
            pictureBox24.Parent = pictureBox2;
            pictureBox25.Parent = pictureBox2;
            pictureBox26.Parent = pictureBox2;
            pictureBox27.Parent = pictureBox2;
            pictureBox28.Parent = pictureBox2;
            pictureBox29.Parent = pictureBox2;
            pictureBox30.Parent = pictureBox2;
            pictureBox31.Parent = pictureBox2;
            pictureBox32.Parent = pictureBox2;
            pictureBox33.Parent = pictureBox2;
            pictureBox34.Parent = pictureBox2;
            pictureBox35.Parent = pictureBox2;
            pictureBox36.Parent = pictureBox2;
            pictureBox37.Parent = pictureBox2;
            pictureBox38.Parent = pictureBox2;
            pictureBox39.Parent = pictureBox2;
            pictureBox40.Parent = pictureBox2;
            pictureBox41.Parent = pictureBox2;
            pictureBox42.Parent = pictureBox2;
            pictureBox43.Parent = pictureBox2;
            pictureBox44.Parent = pictureBox2;
            pictureBox45.Parent = pictureBox2;
            pictureBox46.Parent = pictureBox2;
            pictureBox47.Parent = pictureBox2;
            pictureBox48.Parent = pictureBox2;
            pictureBox49.Parent = pictureBox2;
            pictureBox50.Parent = pictureBox2;
            pictureBox51.Parent = pictureBox2;
            pictureBox52.Parent = pictureBox2;
            pictureBox53.Parent = pictureBox2;
            pictureBox54.Parent = pictureBox2;
            pictureBox55.Parent = pictureBox2;
           




            x = pictureBox4.Location.X;
            y = pictureBox4.Location.Y;
            
     
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
       int br=0;
        
        double ugao;

        double v0 = 1, vx0, vy0, vx, vy, g = 8, t = 0.015;
        int municija = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {



            if (pictureBox4.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X-20, pictureBox4.Location.Y-20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
              
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox17.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox19.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox21.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox22.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox23.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox24.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox25.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox26.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox27.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox28.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox29.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox30.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox31.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox32.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox33.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox34.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox35.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox36.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox37.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox38.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox39.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox40.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox41.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox42.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox43.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox44.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox45.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox46.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox47.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox48.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox49.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox50.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox51.Bounds))
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                
                klik = false;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox55.Bounds) && brojac==1)
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
               
                klik = false;
                timer3.Stop();
                //************************************************************************************************************************************************************
                kraj = true;
                tekst = "Zeleni tenk je pobedio!!!";
                MessageBox.Show("Zeleni tenk je pobedio!!!"); 
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox3.Bounds) && brojac==1)
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
                tekst = "Zeleni tenk je dobio jos 3 munucije!";
                MessageBox.Show("Zeleni tenk je dobio jos 3 munucije!");
                municija += 3;
                label2.Text = Convert.ToString(municija);
                label4.Text = Convert.ToString(municija2);
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox3.Bounds) && brojac == 2)
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                klik = false;
                tekst = "Crveni tenk je dobio jos 3 munucije!";
                MessageBox.Show("Crveni tenk je dobio jos 3 munucije!");
                municija2 += 3;
                label2.Text = Convert.ToString(municija);
                label4.Text = Convert.ToString(municija2);
            }
           if (pictureBox4.Bounds.IntersectsWith(pictureBox1.Bounds) && brojac==2)
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y - 20);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
               
                klik = false;
                timer3.Stop();
                //************************************************************************************************************************************************************
                kraj = true;
                tekst = "Crveni tenk je pobedio!!!";
                MessageBox.Show("Crveni tenk je pobedio!!!");

            }











            vy = vy0 - g * t;
            vx = vx0;
            if(brojac==1)
            pictureBox4.Location = new Point(pictureBox4.Location.X + Convert.ToInt32(vx), pictureBox4.Location.Y - Convert.ToInt32(vy));
            else
            pictureBox4.Location = new Point(pictureBox4.Location.X - Convert.ToInt32(vx), pictureBox4.Location.Y - Convert.ToInt32(vy));

            t += 0.015;
           
            if (pictureBox4.Location.X >= 1227 || pictureBox4.Location.Y >= 659 || pictureBox4.Location.X <= 0)
            {
                pictureBox54.Visible = true;
                pictureBox54.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                timer2.Start();
                timer1.Stop();
                t = 0.015;
                pictureBox4.Visible = false;
                pictureBox4.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
                klik = false;
               
            }







        }
        bool kraj = false;
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kraj = false;
            timer1.Stop();
            timer3.Stop();
            t = 0.015;
            pictureBox4.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
            klik = false;
            municija = 5;
            municija2 = 5;
            label4.Text = Convert.ToString(5);
            label2.Text = Convert.ToString(5);
            djuleleti = false;
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (br == 3)
            {
                pictureBox54.Visible = false;
                br = 0;
                djuleleti = false;
                timer2.Stop();
                if (kraj == false)
                {
                    if (brojac == 1)
                    {
                        brojac = 2;
                        MessageBox.Show("Crveni tenk je na potezu.");
                        pictureBox4.Location = new Point(1180, 346);

                    }
                    else
                    {
                        brojac = 1;
                        MessageBox.Show("Zeleni tenk je na potezu.");
                        pictureBox4.Location=new Point(66,348);

                        }
                }
            }
            else
                br++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
                    }

        int municija2 = 5;

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (brojac == 1)
           {
               
                if (kraj == false && klik == false && !djuleleti)
                {

                    if (municija > 0)
                    {
                        klik = true;
                        municija--;
                        timer3.Start();
                    }
                    else
                    {
                        kraj = true;
                        tekst = "GAME OVER.";
                    }
                    
                }   
                if (kraj == true)
                {
                    timer1.Stop();
                    timer3.Stop();
                    MessageBox.Show(tekst);

               }

               
           }

           if (brojac == 2)
            {
                if (kraj == false && klik == false && !djuleleti)
                {

                    if (municija2 > 0)
                    {
                        klik = true;
                        municija2--;
                        timer3.Start();
                    }
                    else
                    {
                        kraj = true;
                        tekst = "GAME OVER.";
                    }

                }
                if (kraj == true)
                {
                    timer1.Stop();
                    timer3.Stop();
                    MessageBox.Show(tekst);

                }

                

           }




        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        bool djuleleti = false;
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if(!djuleleti)
            {
                label2.Text = Convert.ToString(municija);
                label4.Text = Convert.ToString(municija2);
                timer3.Stop();
                pictureBox4.Visible = true;
                timer1.Start();
                if(brojac==1)
                    ugao = Math.Atan((Convert.ToDouble(pictureBox1.Location.Y + this.Location.Y - (Cursor.Position.Y - this.Location.Y)) / Convert.ToDouble(Math.Abs(pictureBox1.Location.X + this.Location.X - (Cursor.Position.X - this.Location.X)))));
                else
                    ugao = Math.Atan(((Convert.ToDouble(pictureBox55.Location.Y + this.Location.Y - (Cursor.Position.Y - this.Location.Y))) / Convert.ToDouble((pictureBox55.Location.X + this.Location.X - (Cursor.Position.X - this.Location.X)))));
            

                

                
             
                 
                vx0 = v0 * Math.Cos(ugao);
                vy0 = v0 * Math.Sin(ugao);

                v0 = 1;
                
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                djuleleti = true;
                
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (v0 <= 15)
            {
                v0++;
                if(brojac==1)
                 progressBar1.Increment(7);
                else
                    progressBar2.Increment(7);
            }
            
            


        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

//*****************************************************************************************************************************************************



        int brojac = 1;

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        



















    }
}