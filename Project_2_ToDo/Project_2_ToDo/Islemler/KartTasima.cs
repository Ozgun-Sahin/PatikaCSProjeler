using Project_2_ToDo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_ToDo.Islemler
{
    public class KartTasima
    {
        public void Tasi()
        {
            KartTasi:
            Console.WriteLine("Lütfen Kart başlığı giriniz");

            string girdi = Console.ReadLine();

            Kart tasinacakKart = Kart_KisiDB.Kartlar.FirstOrDefault(x => x.Baslik == girdi);

            if (tasinacakKart != null)
            {
                Console.WriteLine("Girdiğiniz kart :");
                Console.WriteLine("*******************************************");

                Console.WriteLine("Başlık      :  {0}", tasinacakKart.Baslik);
                Console.WriteLine("İçerik      :  {0}", tasinacakKart.Icerik);
                Console.WriteLine("Atanan Kişi :  {0}", tasinacakKart.Kisi);
                Console.WriteLine("Büyüklük    :  {0}", tasinacakKart.Buyukluk);
                Console.WriteLine("Line        :  {0}\n", tasinacakKart.KartTipi);

                Console.WriteLine("Lütfen taşımak istediğiniz Durum'u seçiniz");
                Console.WriteLine("(0) Yapilacak");
                Console.WriteLine("(1) Yapiliyor");
                Console.WriteLine("(2) Yapildi");

                int secim = int.Parse(Console.ReadLine());

                if (secim == 0)
                {
                    tasinacakKart.KartTipi = "Yapilacak";
                }
                else if (secim == 1)
                {
                    tasinacakKart.KartTipi = "Yapiliyor";
                }
                else if (secim == 2)
                {
                    tasinacakKart.KartTipi = "Yapildi";
                }

            }
            else
            {
                Console.WriteLine("Kart bulunamadı");

            Secim:

                Console.WriteLine("Tekrar etmek için 1'e, çıkış yapmak için 2'ye basınız");

                int secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    goto KartTasi;
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Çıkış yapıldı");
                }
                else
                {
                    Console.WriteLine("Geçersiz bir karakter girdiniz, tekrar deneyiniz");
                    goto Secim;
                }

            }


        }
    }
}
