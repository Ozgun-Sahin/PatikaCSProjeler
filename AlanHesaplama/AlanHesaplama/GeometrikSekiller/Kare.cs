using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama.GeometrikSekiller
{
    public class Kare : IHesaplamalar
    {
        public int _kenar;

        public Kare(int kenar)
        {
            _kenar = kenar;
        }

        public void AlanHesapla()
        {
            int sonuc = _kenar * _kenar;
            Console.WriteLine("Girdiğiniz karenin alanı: " + sonuc + " cm2");
        }

        public void CevreHesapla()
        {
            int sonuc = _kenar * 4;
            Console.WriteLine("Girdiğiniz karenin çevresi : " + sonuc + " cm");
        }
    }
}
