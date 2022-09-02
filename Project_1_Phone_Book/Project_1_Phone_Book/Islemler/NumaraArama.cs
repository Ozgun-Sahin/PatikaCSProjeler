using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class NumaraArama  
    {
       
        RehberIslemleri rbi = new RehberIslemleri();

        public void Arama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("*********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            Kisi kisi = new Kisi();

            string girdi = Console.ReadLine();
            int secim = rbi.Secim();

            if (secim == 1)
            {
                Console.WriteLine("İsim veya soyisim giriniz : ");
                string girdi2 = Console.ReadLine();
                kisi = RehberDB.KisiListesi.FirstOrDefault(x => x.Isim == girdi2 || x.Soyisim == girdi2);
                rbi.KisiGoster(kisi);
            }
            else if (secim == 2)
            {
                Console.WriteLine("Telefon numarası giriniz : ");
                string girdi3 = Console.ReadLine();

                foreach (Kisi item in RehberDB.KisiListesi)
                {
                    if (item.Numara.Contains(girdi3))
                    {
                        rbi.KisiGoster(kisi);
                    }
                }

            }
            

        }
    }
}
