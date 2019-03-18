using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker 
    {
        Random rand = new Random();
        public Er(Bolge Koord) : base(Koord)
        {

        }

        public override void HaraketEt(Ermeydani ermeydani)
        {
            
            int secim = rand.Next(101);

            if(secim < 50) //yukari veya sola haraket et
            {
                if (Koordinat.Y >= 1) //yukari
                {
                    int x = Koordinat.X;
                    int y = Koordinat.Y;
                    Koordinat = ermeydani.Harita[x, (y - 1)];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
                else if (Koordinat.X >= 1) //sola
                {
                    int x = Koordinat.X;
                    int y = Koordinat.Y;
                    Koordinat = ermeydani.Harita[(x - 1), y];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
            else //asagi veya saga haraket et
            {
                if (Koordinat.Y <= 14) //asagi haraket et
                {
                    int x = Koordinat.X;
                    int y = Koordinat.Y;
                    Koordinat = ermeydani.Harita[x, (y + 1)];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
                else if (Koordinat.X <= 14) //saga haraket et
                {
                    int x = Koordinat.X;
                    int y = Koordinat.Y;
                    Koordinat = ermeydani.Harita[(x + 1), y];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
        }

        public override void Bekle() {

        }

        public override void AtesEt(Takim takim)
        {
            for (int i = 0; i < 7; i++)
            {
                if (Math.Abs(Koordinat.X - takim.Birlik[i].Koordinat.X) <= 1 &&
                    Math.Abs(Koordinat.Y - takim.Birlik[i].Koordinat.Y) <= 1)
                {
                    int rs = rand.Next(101);
                    if (rs < 40)
                    {
                        takim.Birlik[i].can -= 5;
                        Console.WriteLine($"{takim.Birlik[i].can}");
                    }
                    else if (rs < 75) { takim.Birlik[i].can -= 10; Console.WriteLine($"{takim.Birlik[i].can}"); }
                    else { takim.Birlik[i].can -= 15; Console.WriteLine($"{takim.Birlik[i].can}"); }
                        if (takim.Birlik[i].can <= 0) takim.Birlik[i].hayattaMi = false;
                }
            }
        }

        
        // ..... //
    }
}
