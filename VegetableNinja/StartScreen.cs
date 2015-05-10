using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegetableNinja
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(label4.Image, 0, 0, label4.Width, label4.Height);

            SizeF textSize = e.Graphics.MeasureString(label4.Text, label4.Font);

            e.Graphics.DrawString(label4.Text, label4.Font, Brushes.Black,
                (label4.Width - textSize.Width) / 2,
                (label4.Height - textSize.Height) / 2);
        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(label3.Image, 0, 0, label3.Width, label3.Height);

            SizeF textSize = e.Graphics.MeasureString(label3.Text, label3.Font);

            e.Graphics.DrawString(label3.Text, label3.Font, Brushes.Black,
                (label3.Width - textSize.Width) / 2,
                (label3.Height - textSize.Height) / 2);
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(label2.Image, 0, 0, label2.Width, label2.Height);

            SizeF textSize = e.Graphics.MeasureString(label2.Text, label2.Font);

            e.Graphics.DrawString(label2.Text, label2.Font, Brushes.Black,
                (label2.Width - textSize.Width) / 2,
                (label2.Height - textSize.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
