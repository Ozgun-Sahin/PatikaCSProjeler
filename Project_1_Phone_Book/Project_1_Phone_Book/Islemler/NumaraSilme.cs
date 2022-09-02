using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class NumaraSilme 
    {
        RehberIslemleri rbi = new RehberIslemleri();

        public void Sil()
        {
        Sil:
            while (true)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");

                string girdi = Console.ReadLine();

                bool mevcutMu = rbi.KisiMevcutMu(girdi);

                if (mevcutMu)
                {
                    Kisi silinecekKisi = RehberDB.KisiListesi.FirstOrDefault(x => x.Isim == girdi || x.Soyisim == girdi);

                    bool onay = rbi.EvetHayir(silinecekKisi);

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
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("*Yeniden denemek için      : (2)");

                    int secim = rbi.Secim();

                    if (secim ==1)
                    {
                        Console.WriteLine("Silme işlemi sonlandırıldı.");
                        break;
                    }
                    else if (secim == 2)
                    {
                        Console.WriteLine("***");
                        goto Sil;
                    }

                }

            }
        }

        
    }
}
