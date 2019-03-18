using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Yuzbasi : Asker
    {
        Random rand = new Random();
        // ..... //
        public Yuzbasi(Bolge Koord) : base(Koord)
        {

        }


        public override void HaraketEt(Ermeydani ermeydani)
        {
            int secim = rand.Next(201);
            int x = Koordinat.X;
            int y = Koordinat.Y;

            if (secim < 25) //yukari haraket et
            {
                if (Koordinat.Y >= 1)
                {
                    Koordinat = ermeydani.Harita[x, (y - 1)];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
            else if (secim < 50) //asagi haraket et
            {
                if (Koordinat.Y <= 14)
                {
                    Koordinat = ermeydani.Harita[x, (y + 1)];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
            else if (secim < 75) //saga haraket et
            {
                if (Koordinat.X <= 14)
                {
                    Koordinat = ermeydani.Harita[(x + 1), y];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
            else if (secim < 100) //sola haraket et
            {
                if (Koordinat.X >= 1)
                {
                    Koordinat = ermeydani.Harita[(x - 1), y];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
            else if (secim < 125) //yukari sag
            {
                if (Koordinat.Y <= 14 && Koordinat.X <= 14) 
                {
                    Koordinat = ermeydani.Harita[(x + 1), (y + 1)];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
            else if (secim < 150) //asagi sag
            {
                if (Koordinat.Y >= 1 && Koordinat.X <= 14)
                {
                    Koordinat = ermeydani.Harita[(x + 1), (y - 1)];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
            else if (secim < 175) //yukari sol
            {
                if (Koordinat.Y <= 14 && Koordinat.X >= 1)
                {
                    Koordinat = ermeydani.Harita[(x - 1), (y + 1)];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
            else
            {
                if (Koordinat.Y >= 1 && Koordinat.X >= 1) //asagi sol
                {
                    Koordinat = ermeydani.Harita[(x - 1), (y - 1)];
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
        }

        public override void Bekle()
        {

        }

        public override void AtesEt(Takim takim)
        {
            for (int i = 0; i < 7; i++)
            {
                if (Math.Abs(Koordinat.X - takim.Birlik[i].Koordinat.X) <= 3 &&
                    Math.Abs(Koordinat.Y - takim.Birlik[i].Koordinat.Y) <= 3)
                {
                    int rs = rand.Next(101);
                    if (rs < 40) { takim.Birlik[i].can -= 15; Console.WriteLine($"{takim.Birlik[i].can}"); }
                    else if (rs < 75) { takim.Birlik[i].can -= 25; Console.WriteLine($"{takim.Birlik[i].can}"); }
                    else { takim.Birlik[i].can -= 40; Console.WriteLine($"{takim.Birlik[i].can}"); }
                        if (takim.Birlik[i].can <= 0) takim.Birlik[i].hayattaMi = false;
                }
            }
        }

       
    }
}
