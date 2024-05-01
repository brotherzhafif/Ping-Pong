using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Ping_Pong
{
    public partial class ball : Form
    {
        public ball()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Start();

            var player2 = new Player_2();
            player2.Show();

            this.Focus();

            bool goup; // boolean to be used to detect player up position
            bool godown; // boolean to be used to detect player down position
            int speed = 5; // integer called speed holding value of 5
            int ballx = 5; // horizontal X speed value for the ball object 
            int bally = 5; // vertical Y speed value for the ball object
            int score = 0; // score for the player
            int cpuPoint = 0; // score for the CPU
        }

        string k = "";
       

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var form = new ball();
            if (e.KeyChar == 'w')
            {
                k = "w";
            }
            else if (e.KeyChar == 'a')
            {
                k = "a";
            }
            else if (e.KeyChar == 's')
            {
                k = "s";
            }
            else if (e.KeyChar == 'd')
            {
                k = "d";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k == "w")
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 5);
                
            }
            if (k == "a")
            {
                this.Location = new System.Drawing.Point(this.Location.X - 5, this.Location.Y);
               
            }
            if (k == "s")
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 5);
               
               
            }
            if (k == "d")
            {
                this.Location = new System.Drawing.Point(this.Location.X + 5, this.Location.Y);
              
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            k = "";
        }
    }
}
