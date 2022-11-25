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


        private Random rnd = new Random();
        public void Fabian_Cube_1(Panel PANEL)
        {
            using (Graphics g = PANEL.CreateGraphics())
            {
                g.Clear(Color.Black);


                int X1 = 200;
                int X2 = 200;


                int X3 = 400;
                int X4 = 400;

                int X5 = 360;
                int X6 = 360;

                int X7 = 110;
                int X8 = 110;
                for ( int i = 0; i < 400; i++)
                {

                    g.Clear(Color.Black);
                    if (i != 0)
                    {

                        X2 = X1 - ((100 / i) * 10);
                        X4 = X3 - ((100 / i) * 10);
                        X6 = X5 - ((100 / i) * 10);
                        X8 = X7 - ((100 / i) * 10);

                    }
                    Debug.WriteLine(X2);


                    Color CLR = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    g.DrawLine(
                        new Pen(CLR, 2),
                        new Point(X1, 200),
                        new Point(X2, 200)
                    );


                    CLR = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    g.DrawLine(
                        new Pen(CLR, 2),
                        new Point(X3, 240),
                        new Point(X4, 240)
                    );


                    CLR = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    g.DrawLine(
                        new Pen(CLR, 2),
                        new Point(X5, 180),
                        new Point(X6, 180)
                    );


                    CLR = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    g.DrawLine(
                        new Pen(CLR, 2),
                        new Point(X7, 220),
                        new Point(X8, 220)
                    );



                    System.Threading.Thread.Sleep(25);

                }


            }
        }

    }
}
