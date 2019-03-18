using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Bolge
    {
        int x, y;
        public Asker asker;
        public Bolge(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        

        public int X { set { x = value; } get { return x; } }
        public int Y { set { y = value; } get { return y; } }
        // ..... //
    }
}
