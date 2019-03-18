using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            /*
             Örnek olması açısında iskelet kod hazır olarak verilmiştir. İmplementasyonunuz bunun üzerinden gerçekleştiriniz.
            */

            Takim A = new Takim();
            Takim B = new Takim();
            Ermeydani ermeydani = new Ermeydani();
            ermeydani.FillIn();

            YelestirA();
            YelestirB();

            void YelestirA()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        int rs = rand.Next(101);
                        if (rs < 50)
                            A.Birlik[i] = new Er(ermeydani.Harita[0, 0]);
                        else
                            A.Birlik[i] = new Yuzbasi(ermeydani.Harita[0, 0]);
                    }
                    else if (i == 1)
                    {
                        A.Birlik[i] = new Tegmen(ermeydani.Harita[0, 1]);
                    }
                    else if (i == 2)
                    {
                        int rs = rand.Next(101);
                        if (rs < 50)
                            A.Birlik[i] = new Er(ermeydani.Harita[0, 2]);
                        else
                            A.Birlik[i] = new Tegmen(ermeydani.Harita[0, 2]);
                    }
                    A.Birlik[3] = new Er(ermeydani.Harita[0, 3]);
                    A.Birlik[4] = new Er(ermeydani.Harita[1, 0]);
                    A.Birlik[5] = new Er(ermeydani.Harita[1, 1]);
                    A.Birlik[6] = new Er(ermeydani.Harita[1, 2]);
                }
            }
            void YelestirB()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        int rs = rand.Next(101);
                        if (rs < 50)
                            B.Birlik[i] = new Er(ermeydani.Harita[15, 15]);
                        else
                            B.Birlik[i] = new Yuzbasi(ermeydani.Harita[15, 15]);
                    }
                    else if (i == 1)
                    {
                        B.Birlik[i] = new Tegmen(ermeydani.Harita[15, 14]);
                    }
                    else if (i == 2)
                    {
                        int rs = rand.Next(101);
                        if (rs < 50)
                            B.Birlik[i] = new Er(ermeydani.Harita[15, 13]);
                        else
                            B.Birlik[i] = new Tegmen(ermeydani.Harita[15, 13]);
                    }
                    B.Birlik[3] = new Er(ermeydani.Harita[15, 12]);
                    B.Birlik[4] = new Er(ermeydani.Harita[14, 15]);
                    B.Birlik[5] = new Er(ermeydani.Harita[14, 14]);
                    B.Birlik[6] = new Er(ermeydani.Harita[14, 13]);
                }
            }

            while (true)
            {
                ActionA();
                if (OyunBittiMi() == true) break;

                ActionB();
                if (OyunBittiMi() == true) break;
            }

            void ActionA()
            {
                int secim = rand.Next(101);
                int indis = rand.Next(0, 7);
                if (secim < 30) A.Birlik[indis].Bekle();
                else if (secim < 30) A.Birlik[indis].AtesEt(B);
                else A.Birlik[indis].HaraketEt(ermeydani);
            }

            void ActionB()
            {
                int secim = rand.Next(101);
                int indis = rand.Next(0, 7);
                if (secim < 30) B.Birlik[indis].Bekle();
                else if (secim < 30) B.Birlik[indis].AtesEt(B);
                else B.Birlik[indis].HaraketEt(ermeydani);
            }

            bool OyunBittiMi()
            {
                for (int i = 0; i < 7; i++)
                {
                    if (A.Birlik[i].hayattaMi == true) return false;
                    else if (B.Birlik[i].hayattaMi == true) return false;
                    else { Console.WriteLine("oyun bitti");  return true; }
                }
                return false;
            }
            Console.ReadKey();
        }
    }
}
