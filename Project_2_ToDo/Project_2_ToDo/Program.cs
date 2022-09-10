using Project_2_ToDo.Islemler;
using System;

namespace Project_2_ToDo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
        Secim:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("****************************************");
            Console.WriteLine("(1) Board Listeleme");
            Console.WriteLine("(2) Board'a Kart Ekleme");
            Console.WriteLine("(3) Board'dan Kart Silme");
            Console.WriteLine("(4) Kart Taşıma");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    BoardListeleme boardListeleme = new BoardListeleme();
                    boardListeleme.Listele();
                    break;

                case 2:
                    KartEkleme kartEkleme = new KartEkleme();
                    kartEkleme.Ekle();
                    break;
                case 3:
                    KartSilme kartSilme = new KartSilme();
                    kartSilme.KarSil();
                    break;
                case 4:
                    KartTasima kartTasima = new KartTasima();
                    kartTasima.Tasi();
                    break;
            }

            Console.WriteLine("Başka işlem yapmak için herhangi bir tuşa basınız.");

            string input = Console.ReadLine();

            if (input != null) { goto Secim; }
        }
    }
}
