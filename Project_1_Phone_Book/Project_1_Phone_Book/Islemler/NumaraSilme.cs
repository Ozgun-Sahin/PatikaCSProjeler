using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class NumaraSilme :IIslemler
    {
        public bool KisiMevcutMu(string girdi)
        {
            bool mevcut = RehberDB.KisiListesi.Any(x => x.Isim == girdi || x.Soyisim == girdi);
            return mevcut;
        }

        public int KisiMevcutDegil()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            int secim;

            while (true)
            {
                Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("*Yeniden denemek için      : (2)");

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
                }
            }
        }

        public bool EvetHayir(Kisi girdi)
        {
            while(true)
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


        public void Sil()
        {
            while (true)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");

                string girdi = Console.ReadLine();

                bool mevcutMu = KisiMevcutMu(girdi);

                if (mevcutMu)
                {
                    Kisi silinecekKisi = RehberDB.KisiListesi.FirstOrDefault(x => x.Isim == girdi || x.Soyisim == girdi);

                    bool onay = EvetHayir(silinecekKisi);

                    if (onay)
                    {
                        RehberDB.KisiListesi.Remove(silinecekKisi);
                        Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi iptal edildi");
                        break;
                    }
                }

                else
                {
                    int secim = KisiMevcutDegil();

                    if (secim ==1)
                    {
                        Console.WriteLine("Silme işlemi sonlandırıldı.");
                        break;
                    }
                    else if (secim == 2)
                    {
                        Console.WriteLine("***");
                    }

                }

            }
        }

        
    }
}
