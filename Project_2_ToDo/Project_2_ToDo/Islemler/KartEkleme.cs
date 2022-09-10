using Project_2_ToDo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_ToDo.Islemler
{
    public class KartEkleme
    {
        enum Buyuklukler
        {
            XS=1,
            S,
            M,
            L,
            XL
        }


        public void Ekle()
        {
            Kart eklenecekKart = new Kart();
       
            Console.WriteLine("Kart Ekleme");
            Console.WriteLine("****************************");
            Console.WriteLine("Başlık Giriniz:");
            eklenecekKart.Baslik = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz:");
            eklenecekKart.Icerik = Console.ReadLine();

            BuyuklukSecimi:
            Console.WriteLine("Büyüklük Seçiniz");
            Console.WriteLine("XS = 1");
            Console.WriteLine("S = 2");
            Console.WriteLine("M = 3");
            Console.WriteLine("L = 4");
            Console.WriteLine("XL = 5");

            string buyukluk = Console.ReadLine();

            if (buyukluk == "")
            {
                Console.WriteLine("Geçersiz bir karakter girdiniz, tekrar deneyiniz");
                goto BuyuklukSecimi;
            }
            else
            {
                int i = Convert.ToInt32(buyukluk);

                if (buyukluk != null && i < 6 && i > 0)
                {
                    string olcu = Enum.GetName(typeof(Buyuklukler), buyukluk);
                    eklenecekKart.Buyukluk = olcu;
                }
                else
                {
                    Console.WriteLine("Geçersiz bir karakter girdiniz, tekrar deneyiniz");
                    goto BuyuklukSecimi;
                }
            }

            Console.WriteLine("Kişi Seiçiz:");
            eklenecekKart.Kisi= Console.ReadLine();
            KisiKontrolveEkle(eklenecekKart);

        }

        public void KisiKontrolveEkle(Kart eklenecekKart)
        {
            ID:
            Console.WriteLine("Kişi ID'nizi giriniz");
            int ID = int.Parse(Console.ReadLine());
            var kisi = Kart_KisiDB.Kisiler.FirstOrDefault(x=> x.ID == ID);

            if (kisi != null)
            {
                Kart_KisiDB.Kartlar.Add(eklenecekKart);
                Console.WriteLine("Bu kart " + kisi.Isim + " tarafından oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Hatalı bir ID girdiniz!");
                Secim:
                Console.WriteLine("Tekrar etmek için 1'e, çıkış yapmak için 2'ye basınız");

                int secim = int.Parse(Console.ReadLine());
                if (secim ==1)
                {
                    goto ID;
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
