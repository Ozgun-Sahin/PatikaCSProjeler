using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Data
{
    public class RehberDB
    {
        private static List<Kisi> _kisiListesi;


        static RehberDB()
        {
            _kisiListesi = new List<Kisi>()
            {
                new Kisi{Isim = "Özgün", Soyisim ="Şahin", Numara ="1234567"},
                new Kisi{Isim = "Damla Naz", Soyisim ="Şahin", Numara ="9012345"},
                new Kisi{Isim = "Mehmet", Soyisim ="Şahin", Numara ="6789012"},
                new Kisi{Isim = "Esma", Soyisim ="Şahin", Numara ="3456789"},
                new Kisi{Isim = "Bilge Kağan", Soyisim ="Şahin", Numara ="0123456"}
            };
        }

        public static List<Kisi> KisiListesi
        {
            get { return _kisiListesi; }
        }

        

        



    }
}
