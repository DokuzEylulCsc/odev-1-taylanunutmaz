using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Ermeydani
    {
        Bolge[,] harita = new Bolge[16, 16];

        public void FillIn()
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    harita[i, j] = new Bolge(i, j);
                }
            }
        }

        public Bolge[,] Harita { get { return harita; } set { harita = value; } }

        // ..... //
    }
}
