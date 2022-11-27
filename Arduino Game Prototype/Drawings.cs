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
        // Erstelle Array. Anzahl der Einträge = Anzahl der Pixel im Panel, Inhalt der Array-Einträge = entsprechend einzusetzende Farben
        Color[] carray = new Color[2000];

        // Der Faktor, durch den die Auflösung später geteilt wird. So "verringern" wir die Pixelanzahl.
                    int Factor = 20;

        private Random rnd = new Random();
        public void Fabian_Cube_1(Panel PANEL)
        {

            

            // Loope durch alle Array-Einträge und generiere für jeden eine zufällige Farbe im RGB-Spektrum.
            for (int i = 0; i < 400;  i++) {
                carray[i] = Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            }

            DrawPixel(0, 0, Color.Red);

            DrawPixel(0, 1, Color.Red);

            using (Graphics g = PANEL.CreateGraphics())
            {
                g.Clear(Color.Black);               // Leere das Panel und färbe den Hintergrund schwarz
                int x = 0;                          // Deklariere die X-Koordinate als Integer und setze sie auf 0.
                int y = 0;                          // Deklariere die Y-Koordinate als Integer und setze sie auf 0.


                // Loope durch alle Array-Einträge und zeichne mit aufsteigender X-Koordinate für jeden Eintrag ein Rectangle.
                // Jede Koordinate wird dabei mit Factor multipliziert, damit pro Rectangle mehrere Pixel (bspw. 2x2 Pixel) die gleiche Farbe erhalten.
                // So wird optisch die Auflösung verringert und somit Rechenleistung eingespart.
                for ( int i = 0; i < carray.Length; i++)
                {
                    x++;
                    Rectangle rec = new Rectangle(x * Factor, y * Factor, Factor, Factor);
                    if (x * Factor > PANEL.Width)   // Sobald der rechte Rand des Panels erreicht ist, fange in der nächsten Zeile wieder bei X = 0 an.
                    {
                        y++;
                        x = 0;
                    }
                    g.DrawRectangle(new Pen(carray[i], 1), rec);
                    g.FillRectangle(new SolidBrush(carray[i]), rec);
                    
                }



            }
        }
        public void DrawPixel(int x, int y, Color color)
        {

            carray[(x * y / Factor) + 1 ] = color; // KRITISCHER FEHLER! X*Y IST FALSCH!!!
        }
    }
}