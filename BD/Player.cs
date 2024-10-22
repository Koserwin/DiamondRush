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
        private Player(int s, int r) : base(s, r)
        {
            ctverec.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Grid.SetZIndex(ctverec,250);
            Hrac = this;
        }



        private static Player Hrac;
       
        public static Player GetHrac(int s, int r)
        {
            if (Hrac == null) 
                Hrac = new Player(s, r);
            return Hrac;
        }
        public static Player GetHrac()
        {
            if (Hrac == null)
                Hrac = new Player(0, 0);
            return Hrac;
        }

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
