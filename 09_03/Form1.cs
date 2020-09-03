using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_03
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);

        int xv = rand.Next(-20, 21);
        int yv = rand.Next(-20, 21);

        int xy = rand.Next(-20, 21);
        int  yx= rand.Next(-20, 21);

        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);

            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            label2.Left += xv;
            label2.Top += yv;

            if (label2.Left < 0)
            {
                xv = Math.Abs(xv);
            }
            if (label2.Top < 0)
            {
                yv = Math.Abs(yv);
            }
            if (label2.Right > ClientSize.Width)
            {
                xv= -Math.Abs(xv);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                yv = -Math.Abs(yv);
            }

            label3.Left += xy;
            label3.Top += yx;

            if (label3.Left < 0)
            {
                xy = Math.Abs(xy);
            }
            if (label3.Top < 0)
            {
                yx = Math.Abs(yx);
            }
            if (label3.Right > ClientSize.Width)
            {
                xy = -Math.Abs(xy);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                yx = -Math.Abs(yx);
            }

            
            Point mp = PointToClient(MousePosition);
            if ((mp.X >= label1.Left)
                 && (mp.X < label1.Right)
                 && (mp.Y >= label1.Top)
                 && (mp.Y < label1.Bottom)
              ){
                timer1.Enabled = false;
                
            }
        }
    }
}
