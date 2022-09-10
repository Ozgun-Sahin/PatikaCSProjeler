using Project_2_ToDo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_ToDo.Islemler
{
    internal class KartSilme
    {
        public void KarSil()
        {
            KartSil:
            Console.WriteLine("Lütfen kart başlığını giriniz");
            string girdi = Console.ReadLine();

            Kart silinecenKart = Kart_KisiDB.Kartlar.FirstOrDefault(x => x.Baslik == girdi);

            if (silinecenKart != null)
            {
                Kart_KisiDB.Kartlar.Remove(silinecenKart);
            }
            else
            {
            Secim:
                Console.WriteLine("Kart bulunamadı");
                Console.WriteLine("Tekrar etmek için 1'e, çıkış yapmak için 2'ye basınız");

                int secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    goto KartSil;
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
