using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class NumaraEkleme :IIslemler
    {
        public void Kaydet()
        {
            Console.WriteLine("Lütfen İsim Giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen Soyisim Giriniz");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz");
            string numara = Console.ReadLine();

            Kisi kisi = new Kisi();
            kisi.Isim = isim;
            kisi.Soyisim = soyisim;
            kisi.Numara = numara;

            RehberDB.KisiListesi.Add(kisi);

            Console.WriteLine("Kişi Eklendi");
        }

    }
}
