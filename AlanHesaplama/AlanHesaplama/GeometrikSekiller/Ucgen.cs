using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama.GeometrikSekiller
{
    public class Ucgen : IHesaplamalar
    {
        public int _yukseklik;
        public int _taban;

        public Ucgen(int yukseklik, int taban)
        {
            _yukseklik = yukseklik;
            _taban = taban;
        }   

        public void AlanHesapla()
        {
            int sonuc = (_taban * _yukseklik)/2;
            Console.WriteLine("Girdiğiniz üçgenin alanı: " + sonuc + " cm2");
        }

        public void CevreHesapla()
        {
            int sonuc = 3 * _taban;
            Console.WriteLine("Girdiğiniz üçgenin çevresi: " + sonuc + " cm");
        }
    }
}
