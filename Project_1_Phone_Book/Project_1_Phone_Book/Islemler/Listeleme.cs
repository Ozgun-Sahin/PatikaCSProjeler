using Project_1_Phone_Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public class Listeleme
    {
        public void Listele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            foreach (Kisi kisi in RehberDB.KisiListesi)
            {
                Console.WriteLine("İsim: " + kisi.Isim);
                Console.WriteLine("Soyisim: " + kisi.Soyisim);
                Console.WriteLine("Telefon Numarası: " + kisi.Numara);
                Console.WriteLine("-");
            }
        }
    }
}
