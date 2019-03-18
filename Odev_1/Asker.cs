using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        public Bolge Koordinat { get { return koordinat; } set { koordinat = value; } }
        public bool hayattaMi = true;
        public uint can = 100;

        public Asker(Bolge Koord) {
            koordinat = Koord;
        }

        // ..... //

        //Abstract sınıfların implementasyonları çoçuk sınıflarda gerçekleştirilmelidir.
        public abstract void HaraketEt(Ermeydani ermeydani);

        public abstract void Bekle();

        public abstract void AtesEt(Takim takim);
        

        // ..... //

    }
}
