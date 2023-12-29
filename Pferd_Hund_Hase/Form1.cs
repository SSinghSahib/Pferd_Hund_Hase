using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms; 

namespace Pferd_Hund_Hase
{
    public partial class Form1 : Form
    {
        int LeftHund, LeftHase, LeftPferd;
        public bool start;

        //Zufallsgenerator
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            LeftHund = pictureBox1.Left;
            LeftHase = pictureBox2.Left;
            LeftPferd = pictureBox3.Left;
        }
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }        
         private void button1_Click(object sender, EventArgs e)
         {
             timer1.Enabled = false;
             start = true;
             timer1.Start();
             pictureBox1.Enabled = true;
             pictureBox2.Enabled = true;
             pictureBox3.Enabled = true;
         }

         private void timer1_Elapsed(object sender, ElapsedEventArgs e)
         {
             int widthHund = pictureBox1.Width;
             int widthHase = pictureBox2.Width;
             int widthPferd = pictureBox3.Width;
             int start = label5.Left;
             pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 16);
             pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 16);
             pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 16);
             
             if (pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox3.Left+5)
             {
                 label6.Text = "Der Hund führt";
             }
             if (pictureBox2.Left>pictureBox1.Left+5 && pictureBox2.Left>pictureBox3.Left+5)
             {
                 label6.Text = "Der Hase führt";
             }
             if (pictureBox3.Left>pictureBox1.Left+5 && pictureBox3.Left>pictureBox2.Left+5)
             {
                 label6.Text = "Das Pferd führt";
             }
            //Wenn der Hund gewinnt
            if (widthHund+pictureBox1.Left>=start)
             {
                 timer1.Enabled = false;
                 label6.Text = "Der Hund hat gewonnen";
                 pictureBox1.Enabled = false;
                 pictureBox2.Enabled = false;
                 pictureBox3.Enabled = false;
            }
            //Wenn der Hase gewinnt
            if (widthHase+pictureBox2.Left>=start)
             {
                 timer1.Enabled = false;
                 label6.Text = "Der Hase hat gewonnen";
                 pictureBox1.Enabled = false;
                 pictureBox2.Enabled = false;
                 pictureBox3.Enabled = false;
            }
            //Wenn das Pferd gewinnt
            if (widthPferd+pictureBox3.Left>=start)
             {
                 timer1.Enabled = false;
                 label6.Text = "Das Pferd hat gewonnen";
                 pictureBox1.Enabled = false;
                 pictureBox2.Enabled = false;
                 pictureBox3.Enabled = false;
            }         
         }      
    }
}
