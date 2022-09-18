using AlanHesaplama.GeometrikSekiller;
using System;
using System.Collections;

namespace AlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir geometrik şekil seçiniz");
            Console.WriteLine("***********************");
            Console.WriteLine("(1) Dikdörtgen");
            Console.WriteLine("(2) Kare");
            Console.WriteLine("(3) Üçgen");
            Console.WriteLine("(4) Daire");

            secim:
            try
            {
                int secim = int.Parse(Console.ReadLine());

                if (secim >4)
                {
                    Console.WriteLine("Lütfen 1-4 arası bir rakam giriniz");
                    goto secim;
                }

                switch (secim)
                {
                    case 1:

                        Console.WriteLine("Kısa kenarı giriniz (cm)");
                        int kk = int.Parse(Console.ReadLine());
                        Console.WriteLine("Uzun kenarı giriniz (cm)");
                        int uk = int.Parse(Console.ReadLine());

                        Dikdortgen dik = new Dikdortgen(kk, uk);

                        dik.AlanHesapla();
                        dik.CevreHesapla();

                        break;

                    case 2:

                        Console.WriteLine("Kenar uzunluğu girini (cm)");
                        int k = int.Parse(Console.ReadLine());

                        Kare kare = new Kare(k);

                        kare.AlanHesapla();
                        kare.CevreHesapla();
                        break;

                    case 3:

                        Console.WriteLine("Taban uzunluğu giriniz (cm)");
                        int taban = int.Parse(Console.ReadLine());
                        Console.WriteLine("Yükseklik giriniz (cm)");
                        int yukseklik = int.Parse(Console.ReadLine());

                        Ucgen ucgen = new Ucgen(taban, yukseklik);

                        ucgen.AlanHesapla();
                        ucgen.CevreHesapla();
                        break;

                    case 4:
                        Console.WriteLine("Yarıçap giriniz (cm)");
                        int r = int.Parse(Console.ReadLine());

                        Daire daire = new Daire(r);

                        daire.AlanHesapla();
                        daire.CevreHesapla();
                        break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen 1-4 arası bir rakam giriniz");
                goto secim;
            }

        }
    }
}
