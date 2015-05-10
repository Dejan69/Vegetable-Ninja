using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegetableNinja
{
    public partial class Igra : Form
    {
        List<Vegetables> veg = new List<Vegetables>();
        bool isPressed = false;
        public int score = 0;
        static Random r = new Random();

        public Igra()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            StartScreen scrn = new StartScreen();
            scrn.ShowDialog();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Igra_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            vreme.Start();
            SpawnTimer.Start();
            MoveTimer.Start();
            ReduceSpeed.Start();
            
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            foreach (Vegetables v in veg)
            {
                if (!v.isAlive)
                {
                    veg.Remove(v);
                    break;
                }
                canvas.Invalidate();
                if (v.y < canvas.Height * 0.05)
                    v.speed--;             // decrement speed when too near to Top wall
                if (v.x >= canvas.Width - 50)
                    v.speedleft *= -1;    // change direction if side wall is hit
                if (v.x <= 50)
                    v.speedleft *= -1;   // change direction if side wall is hit
                if (v.direction)             //
                {                            //
                    v.x -= v.speedleft;      //
                    v.y -= v.speed;          //
                }                            //
                else                         //         move picture
                {                            //
                    v.x += v.speedleft;      //
                    v.y -= v.speed;          //
                }                            //
                if (v.y == canvas.Height)
                {
                    v.isAlive = false;         // delete if it reaches the bottom
                    veg.Remove(v);
                    break;
                }
                canvas.Invalidate();
            }
        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            SpawnTimer.Interval = 2500;
            int rand = r.Next(1, 5);           // random number of vegetables thrown each tick

            for (int i = 0; i < rand; i++)
            {
                int rdveg = r.Next(0, 10);
                Vegetables v = new Vegetables(rdveg);

                veg.Add(v);

                if (!v.isAlive)
                {
                    v.y = canvas.Height;
                    v.x = r.Next(200, canvas.Width - 200);      //randomize spawn area, direction and speed
                    v.isAlive = true;
                    v.speed = r.Next(11, 15);
                    v.direction = v.x > canvas.Width / 2;
                    v.speedleft = r.Next(1, 4);
                }
            }
            canvas.Invalidate();
        }

        private void ReduceSpeed_Tick(object sender, EventArgs e)
        {
            foreach (Vegetables v in veg)
            {
                v.speed--;
            }
        }

        private void vreme_Tick(object sender, EventArgs e)
        {
            int i = 0;
            int.TryParse(lbTime.Text, out i);
            i--;
            lbTime.Text = "" + i;
            if (i == 0)
            {
                Gameover();
            }
            progress.Value = i;
        }

        private void Gameover()
        {
            vreme.Stop();
            SpawnTimer.Stop();
            MoveTimer.Stop();
            ReduceSpeed.Stop();
            GameOver go = new GameOver(lbScore.Text);
            DialogResult res = go.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.Retry)
            {
                veg.Clear();
                score = 0;
                lbTime.Text = "60";
                lbScore.Text = "0";
                vreme.Start();
                SpawnTimer.Start();
                MoveTimer.Start();
                pb1.Visible = true;
                pb2.Visible = true;
                pb3.Visible = true;
                canvas.Invalidate();
                SpawnTimer.Interval = 10;
                progress.Value = 60;
                isPressed = false;
                ReduceSpeed.Start();
            }

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Detect what is cut, react to it and remove from screen

            Rectangle mousePoint = new Rectangle(canvas.PointToClient(Cursor.Position), new Size(1, 1));
            foreach (Vegetables v in veg)
            {
                Rectangle veget = new Rectangle(v.x, v.y + 10, 25, 25);
                if (isPressed)
                {
                    if (mousePoint.IntersectsWith(veget))
                    {
                        v.isAlive = false;
                        if (v.vid == Vid.rakija)
                        {
                            Gameover();
                        }
                        if (v.kind == Kind.ovosje)
                        {
                            if (pb1.Visible)
                                pb1.Visible = false;
                            else if (!pb1.Visible && pb2.Visible)
                                pb2.Visible = false;
                            else if (!pb2.Visible && !pb1.Visible && pb3.Visible)
                            {
                                pb3.Visible = false;
                                Gameover();
                            }
                        }
                        if (v.kind == Kind.zelencuk)
                            score++;
                        lbScore.Text = "" + score;
                        veg.Remove(v);
                        canvas.Invalidate();
                        SoundPlayer kill = new SoundPlayer(Properties.Resources.Knife);
                        kill.Load();
                        kill.Play();
                        break;
                    }
                }
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (Vegetables v in veg)
            {
                v.Draw(e.Graphics);
            }
        }

    }
}
