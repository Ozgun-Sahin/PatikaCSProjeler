using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class NumaraGuncelle 
    {
        RehberIslemleri rbi = new RehberIslemleri();
        public void Guncelle()
        {
        Guncelle:
            while (true)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz.");
                string girdi = Console.ReadLine();

                bool mevcutMu = rbi.KisiMevcutMu(girdi);

                if (mevcutMu)
                {
                    Kisi guncellenecekKisi = RehberDB.KisiListesi.FirstOrDefault(x => x.Isim == girdi || x.Soyisim == girdi);
                    Console.WriteLine("Lütfen yeni numarasını giriniz: ");
                    string yeniNumara = Console.ReadLine();
                    guncellenecekKisi.Numara = yeniNumara;
                    break;

                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    int secim = rbi.Secim();

                    if (secim == 1)
                    {
                        Console.WriteLine("Güncelleme işlemi sonlandırıldı.");
                        break;
                    }
                    else if (secim == 2)
                    {
                        Console.WriteLine("***");
                        goto Guncelle;
                    }

                }
            }
            
        }
    }
}
