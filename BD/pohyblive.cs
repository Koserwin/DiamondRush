using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BD
{
    abstract internal class pohyblive : Pole
    {
        protected int radek, sloupec;
        public pohyblive(int s, int r) : base(s, r)
        {
            radek = r;
            sloupec = s;
        }
    }
}
