using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HW2_Brick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Gloable variable */
        int x, y, Vx, Vy;                                   // position and velocity of Ball
        int oldLeft, oldRight, oldTop, oldBottom;           // old position of Ball
        int sb_mdx, sb_x;                                   // x position of Slipping Board
        int speed, level, hit;

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Form1 */
            this.Width = 500 + this.Width - this.ClientSize.Width;
            this.BackColor = Color.Cyan;
            this.Location = new Point(100, 0);

            /* Slipping Board */
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Width = 130;
            pictureBox1.Location = new Point(150, 385);

            /* Ball */
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, 40, 40);
            ball.Region = new Region(gp);
            ball.BackColor = Color.Yellow;
            ball.Location = new Point(50, 250);
            ball.BackgroundImage = Image.FromFile(@"../../ballpictures/football.jpg");

            /* default value */
            speed = 4;
            level = 5;
            timer1.Enabled = false;
            timer1.Interval = 10;
        }

        private Label build_Brick(int x, int y)
        {
            Label Q = new Label();
            Q.Width = 99;
            Q.Height = 29;
            Q.BackColor = Color.LightSeaGreen;
            Q.Left = x;
            Q.Top = y;

            return Q;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            sb_mdx = e.X;                                                   // drag origin 拖曳起點
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                sb_x = pictureBox1.Left + (e.X - sb_mdx);

                if (sb_x < 0)                                               // left border 左邊界
                    sb_x = 0;
                if (sb_x > this.ClientSize.Width - pictureBox1.Width)       // right border 右邊界
                    sb_x = this.ClientSize.Width - pictureBox1.Width;
                pictureBox1.Left = sb_x;
            }
        }

        /* Restart button */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = level*100 + this.Width - this.ClientSize.Width;    // adjust Form size

            for (int i = this.Controls.Count-1; i >= 0; i--)                // clear remain bricks
                if (this.Controls[i] is Label)
                    this.Controls[i].Dispose();

            /* generate bricks */
            int index = 0;
            Label[] bricks = new Label[level*level];
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    bricks[index] = build_Brick(i * 100, j * 30);
                    this.Controls.Add(bricks[index]);
                    index++;
                }
            }

            /* some values need changing */
            timer1.Enabled = true;
            pictureBox1.Location = new Point(150, 385);                     // adjust board position
            Vx = speed;
            Vy = speed;
            x = 50;
            y = 250;
            hit = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oldLeft = ball.Left;
            oldRight = ball.Right;
            oldTop = ball.Top;
            oldBottom = ball.Bottom;

            /* Ball move... */
            x += Vx;
            y += Vy;
            ball.Location = new Point(x, y);
            Bounce();
            foreach (var c in this.Controls)
            {
                if (c is Label)
                {
                    Label Q = (Label)c;
                    if (Bounce_with_Bricks(Q))
                    {
                        hit++;
                        break;
                    }
                }
            }
            if (hit == level * level)                           // win
            {
                Vx = 0;
                Vy = 0;
                timer1.Enabled = false;
                MessageBox.Show("You Win!", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void Bounce()
        {
            if (ball.Left < 0)
                Vx = abs(Vx);
            if (ball.Right > this.ClientSize.Width)
                Vx = -abs(Vx);
            if (ball.Top < 0)
                Vy = abs(Vy);
            if (ball.Bottom > pictureBox1.Top &&
                ball.Left + 15 > pictureBox1.Left &&
                ball.Right - 15 < pictureBox1.Right)
                Vy = -abs(Vy);
            if (ball.Bottom > pictureBox1.Bottom + 15)          // lose
            {
                Vx = 0;
                Vy = 0;
                timer1.Enabled = false;
                MessageBox.Show("Game Over!", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private bool Bounce_with_Bricks(Label Q)
        {
            if (ball.Top > Q.Bottom) return false;
            if (ball.Right < Q.Left) return false;
            if (ball.Left > Q.Right) return false;
            if (ball.Bottom < Q.Top) return false;

            if (ball.Top <= Q.Bottom && oldTop > Q.Bottom)      // bottom of the bricks
            {
                Vy = abs(Vy);
                Q.Dispose();
                return true;
            }
            if (ball.Right >= Q.Left && oldRight < Q.Left)      // left of the brick
            {
                Vx = -abs(Vx);
                Q.Dispose();
                return true;
            }
            if (ball.Left <= Q.Right && oldLeft > Q.Right)      // right of the brcik
            {
                Vx = abs(Vx);
                Q.Dispose();
                return true;
            }
            if (ball.Bottom >= Q.Top && oldBottom < Q.Top)      // up of the brick
            {
                Vy = -abs(Vy);
                Q.Dispose();
                return true;
            }
            return false;
        }

        /* Speed */
        private void r1_slow_CheckedChanged(object sender, EventArgs e)
        {
            speed = 2;
        }

        private void r2_normal_CheckedChanged(object sender, EventArgs e)
        {
            speed = 4;
        }

        private void r3_fast_CheckedChanged(object sender, EventArgs e)
        {
            speed = 6;
        }
        
        /* Difficulty */
        private void r4_simple_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = 130;
        }

        private void r5_soso_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = 80;
        }

        private void r6_hard_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = 40;
        }

        /* Level */
        private void r7_low_CheckedChanged(object sender, EventArgs e)
        {
            level = 5;
        }
        private void r8_middle_CheckedChanged(object sender, EventArgs e)
        {
            level = 6;
        }

        private void r9_high_CheckedChanged(object sender, EventArgs e)
        {
            level = 8;
        }

        /* Ball's Style */
        private void r10_A_CheckedChanged(object sender, EventArgs e)
        {
            ball.BackgroundImage = Image.FromFile(@"../../ballpictures/football.jpg");
        }

        private void r11_B_CheckedChanged(object sender, EventArgs e)
        {
            ball.BackgroundImage = Image.FromFile(@"../../ballpictures/earth.jpg");
        }

        private void r12_C_CheckedChanged(object sender, EventArgs e)
        {
            ball.BackgroundImage = Image.FromFile(@"../../ballpictures/ncku.jpg");
        }

        private void r13_D_CheckedChanged(object sender, EventArgs e)
        {
            ball.BackgroundImage = Image.FromFile(@"../../ballpictures/trump.jpg");
        }

        private int abs(int x)
        {
            if (x >= 0) return x;
            else return -x;
        }
    }
}
