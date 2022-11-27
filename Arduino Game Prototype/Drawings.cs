using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Game_Prototype
{
    internal class Drawings
    {
        Color[] carray = new Color[2000];

        private Random rnd = new Random();
        public void Fabian_Cube_1(Panel PANEL)
        {

            int Factor = 20;

            for (int i = 0; i < 2000;  i++) {
                carray[i] = Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            }

            using (Graphics g = PANEL.CreateGraphics())
            {
                g.Clear(Color.Black);
                int y = 0;
                int x = 0;

                for ( int i = 0; i < 2000; i++)
                {
                    x++;
                    Rectangle rec = new Rectangle(x* Factor, y* Factor, Factor, Factor);
                    if (x*Factor > PANEL.Width)
                    {
                        y++;
                        x = 0;
                    }
                    g.DrawRectangle(new Pen(carray[i], 1), rec);
                    
                }


            }
        }

    }
}
