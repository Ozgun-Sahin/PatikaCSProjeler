using Project_1_Phone_Book.Islemler;
using System;

namespace Project_1_Phone_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":

                    NumaraEkleme numaraEkleme = new NumaraEkleme();
                    numaraEkleme.Kaydet();
                    break;

                case "2":

                    NumaraSilme numaraSilme = new NumaraSilme();
                    numaraSilme.Sil();
                    break;

                case "3":
                    NumaraGuncelle numaraGuncelle = new NumaraGuncelle();
                    numaraGuncelle.Guncelle();
                    break;

                case "4":
                    Listeleme listeleme = new Listeleme();
                    listeleme.Listele();
                    break;
                case "5":
                    NumaraArama numaraArama = new NumaraArama();
                    numaraArama.Arama();
                    break;

            }


        }
    }
}
