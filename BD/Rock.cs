﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BD
{
    internal class Rock : padajici
    {
        public Rock(int s, int r) : base(s, r)
        {
            ctverec.Fill = new SolidColorBrush(Colors.Gray);
        }

    }
}