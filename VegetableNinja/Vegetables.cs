using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableNinja
{
    public enum Vid
    {
        domat, krastavica, piperka, sirenje, morkov, rakija, banana, ananas, jagoda, kromid
    }

    public enum Kind
    {
        ovosje, zelencuk, rakija
    }

    public class Vegetables
    {
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }
        public bool direction { get; set; }
        public bool isAlive { get; set; }
        public int speedleft { get; set; }
        public int width = 50, height = 50;
        public Image img;
        public Vid vid;
        public Kind kind;

        public Vegetables(int n)
        {
            vid = Proveri(n);
            kind = Check(n);
            makeImg();
            this.speed = 0;
            this.isAlive = false;
            this.direction = false;
            this.speedleft = 0;
        }

        private Kind Check(int n)
        {
            if (n == 0 || n == 1 || n == 2 || n == 3 || n == 6)
                return Kind.zelencuk;
            else if (n == 5)
                return Kind.rakija;
            else
                return Kind.ovosje;
        }

        private void makeImg()
        {
            if (vid == Vid.domat)
            {
                img = VegetableNinja.Properties.Resources.dumata;
            }
            if (vid == Vid.krastavica)
            {
                img = VegetableNinja.Properties.Resources.krastavica;
            }
            if (vid == Vid.sirenje)
            {
                img = VegetableNinja.Properties.Resources.Feta_Cheeese;
            }
            if (vid == Vid.piperka)
            {
                img = VegetableNinja.Properties.Resources.piperka;
            }
            if (vid == Vid.morkov)
            {
                img = VegetableNinja.Properties.Resources.morkav;
            }
            if (vid == Vid.rakija)
            {
                img = VegetableNinja.Properties.Resources.rakijuBombu;
            }
            if (vid == Vid.kromid)
            {
                img = VegetableNinja.Properties.Resources.krumid;
            }
            if (vid == Vid.jagoda)
            {
                img = VegetableNinja.Properties.Resources.jagoda;
            }
            if (vid == Vid.ananas)
            {
                img = VegetableNinja.Properties.Resources.ananas;
            }
            if (vid == Vid.banana)
            {
                img = VegetableNinja.Properties.Resources.banana;
            }

        }

        private Vid Proveri(int n)
        {
            if (n == 0)
            {
                return Vid.domat;
            }
            else if (n == 1)
            {
                return Vid.krastavica;
            }
            else if (n == 2)
            {
                return Vid.piperka;
            }
            else if (n == 3)
            {
                return Vid.sirenje;
            }
            else if (n == 4)
            {
                return Vid.morkov;
            }
            else if (n == 5)
            {
                return Vid.rakija;
            }
            else if (n == 6)
            {
                return Vid.kromid;
            }
            else if (n == 7)
            {
                return Vid.jagoda;
            }
            else if (n == 8)
            {
                return Vid.ananas;
            }
            else
            {
                return Vid.banana;
            }
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(img, x, y, width, height);
        }
    }
}
