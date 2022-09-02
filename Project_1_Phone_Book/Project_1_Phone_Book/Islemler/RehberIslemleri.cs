using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class RehberIslemleri
    {
        public bool KisiMevcutMu(string girdi)
        {
            bool mevcut = RehberDB.KisiListesi.Any(x => x.Isim == girdi || x.Soyisim == girdi);
            return mevcut;
        }

        public void KisiGoster(Kisi kisi)
        {
            Console.WriteLine("İsim: " + kisi.Isim);
            Console.WriteLine("Soyisim: " + kisi.Soyisim);
            Console.WriteLine("Telefon Numarası: " + kisi.Numara);

        }

        public bool EvetHayir(Kisi girdi)
        {
            while (true)
            {
                Console.WriteLine(girdi.Isim + " " + girdi.Soyisim + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? Y/N");

                string secim = Console.ReadLine().ToUpper();

                if (secim == "Y")
                {
                    return true;
                    //break;
                }
                else if (secim == "N")
                {
                    return false;
                    //break;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir karakter giriniz (Y/N)");
                }
            }
        }

        public int Secim()
        {
            Secim:
            int secim;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out secim))
                {
                    if (secim == 1)
                    {
                        return 1;
                    }
                    else if (secim == 2)
                    {
                        return 2;
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz ");
                    goto Secim;
                }
            }
        }


    }
}
