using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BD
{
    internal class Pole
    {
       
        protected Rectangle ctverec;
        public Pole(int s, int r)
        {
            
            ctverec = new Rectangle()
            {
                Fill = new SolidColorBrush(Colors.Green),
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 1,

            };
            Setup.plocha.Children.Add(ctverec);
            Grid.SetColumn(ctverec, s);
            Grid.SetRow(ctverec, r);
        }
    }
}
