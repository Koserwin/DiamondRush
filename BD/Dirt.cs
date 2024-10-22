using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BD
{
    internal class Dirt : Pole
    {
        public Dirt(int s, int r) : base(s, r)
        {
            ctverec.Fill = new SolidColorBrush(Colors.Brown);
        }
        internal void Zmiz()
        {
            Setup.plocha.Children.Remove(ctverec);
        }
    }
}
