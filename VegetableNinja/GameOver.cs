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
    public partial class GameOver : Form
    {
        public GameOver(string score)
        {
            InitializeComponent();
            lblPoen.Text = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Close();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            SoundPlayer game = new SoundPlayer(Properties.Resources.GameOver1);
            game.Load();
            game.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
