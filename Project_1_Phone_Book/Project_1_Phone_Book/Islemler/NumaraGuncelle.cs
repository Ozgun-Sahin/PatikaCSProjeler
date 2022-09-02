using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class NumaraGuncelle : IIslemler
    {
        public void Guncelle()
        {

        Guncelle:
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz.");
            string girdi = Console.ReadLine();

            Kisi guncellenecekKisi = RehberDB.KisiListesi.FirstOrDefault(x => x.Isim == girdi || x.Soyisim == girdi);

            if (guncellenecekKisi !=null)
            {
                Console.WriteLine("Lütfen yeni numarasını giriniz: ");
                string yeniNumara = Console.ReadLine();
                guncellenecekKisi.Numara = yeniNumara;
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");

                while (true)
                {
                    Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");

                    string secim = Console.ReadLine();
                    if (secim =="1")
                    {
                        Console.WriteLine("Çıkış Yapıldı");
                        return;
                    }
                    else if (secim == "2")
                    {
                        goto Guncelle;
                    }
                    else
                    {
                        Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz");
                    }


                }
            }

            Console.WriteLine("Güncelleme başarıyla gerçekleştirilmiştir.");

        }
    }
}
