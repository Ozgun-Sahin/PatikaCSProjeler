using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama.GeometrikSekiller
{
    public class Dikdortgen : IHesaplamalar
    {
        public int _kısaKenar;
        public int _uzunKenar;

        public Dikdortgen(int kısaKenar, int uzunKenar)
        {
            _kısaKenar = kısaKenar;
            _uzunKenar = uzunKenar; 
        }

        public void AlanHesapla()
        {
            int sonuc = _kısaKenar * _uzunKenar;
            Console.WriteLine("Girdiğiniz dikdörtgenin alanı: " + sonuc + " cm2");
        }

        public void CevreHesapla()
        {
            int sonuc = 2 * (_kısaKenar + _uzunKenar);
            Console.WriteLine("Girdiğiniz dikdörtgenin çevresi: " + sonuc + " cm");
        }
    }
}
