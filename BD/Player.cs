using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;

namespace BD
{
    internal class Player : pohyblive
    {
        public Player(int s, int r) : base(s, r)
        {
            ctverec.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Grid.SetZIndex(ctverec,250);
            Hrac = this;
        }


        public static Player Hrac { get; private set; }
       

        public void Move(int x, int y)
        {
            //if (mapa.jePrekazka(radek+x, sloupec+y))
            //{
            //    return;
            //}
            if (!mapa.muzuVstoupit(radek + x, sloupec + y))
            {
                return;
            }

            Grid.SetColumn(ctverec, sloupec+y);
            Grid.SetRow(ctverec, radek+x);
            sloupec += y;
            radek += x;
        }


    }
}
