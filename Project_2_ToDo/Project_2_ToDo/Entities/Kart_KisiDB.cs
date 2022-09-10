using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_ToDo.Entities
{
    public class Kart_KisiDB
    {
        private static List<Kart> _Kartlar;
        private static List<Kisi> _Kisiler;

        static Kart_KisiDB()
        {
            _Kartlar = new List<Kart>()
            {
                new Kart{Baslik = "bok", Icerik="içerik1", Kisi="Özgün", Buyukluk="XL", KartTipi="Yapilacak"},
                new Kart{Baslik = "Başlık2", Icerik="içerik1", Kisi="Damla", Buyukluk="L", KartTipi="Yapiliyor"},
                new Kart{Baslik = "Başlık3", Icerik="içerik1", Kisi="Esma", Buyukluk="M", KartTipi="Yapildi"},
                new Kart{Baslik = "Başlık4", Icerik="içerik1", Kisi="Mehmet", Buyukluk="S", KartTipi="Yapiliyor"},
                new Kart{Baslik = "Başlık5", Icerik="içerik1", Kisi="Pamir", Buyukluk="XS", KartTipi="Yapilacak"}
            };

            _Kisiler = new List<Kisi>()
            {
                new Kisi { ID=1, Isim="Özgün", Takım="Çevre"},
                new Kisi { ID=2, Isim="Damla", Takım="IK"},
                new Kisi { ID=3, Isim="Esma", Takım="Çevre"},
                new Kisi { ID=4, Isim="Mehmet", Takım="Çevre"},
                new Kisi { ID=1, Isim="Pamir", Takım="IK"}
            };
        }

        public static List<Kisi> Kisiler
        {
            get { return _Kisiler; }
        }

        public static List<Kart> Kartlar
        {
            get { return _Kartlar; }
        }

    }
}
