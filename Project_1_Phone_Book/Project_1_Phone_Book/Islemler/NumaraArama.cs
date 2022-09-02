using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class NumaraArama : IIslemler
    {
        public void KisiGoster(Kisi kisi)
        {
            Console.WriteLine("İsim: " + kisi.Isim);
            Console.WriteLine("Soyisim: " + kisi.Soyisim);
            Console.WriteLine("Telefon Numarası: " + kisi.Numara);
            
        }


        public void Arama()
        {
        Arama:

            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("*********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            Kisi kisi = new Kisi();

            string girdi = Console.ReadLine();

            if (girdi == "1")
            {
                Console.WriteLine("İsim veya soyisim giriniz : ");
                string girdi2 = Console.ReadLine();
                kisi = RehberDB.KisiListesi.FirstOrDefault(x => x.Isim == girdi2 || x.Soyisim == girdi2);
                KisiGoster(kisi);
            }
            else if (girdi == "2")
            {
                Console.WriteLine("Telefon numarası giriniz : ");
                string girdi3 = Console.ReadLine();

                foreach (Kisi item in RehberDB.KisiListesi)
                {
                    if (item.Numara.Contains(girdi3))
                    {
                        KisiGoster(item);
                    }
                }

            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz");
                goto Arama;

            }
            

        }
    }
}
