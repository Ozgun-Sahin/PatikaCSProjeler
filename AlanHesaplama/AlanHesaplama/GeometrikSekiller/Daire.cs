using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama.GeometrikSekiller
{
    public class Daire: IHesaplamalar
    {
        public int _yariCap;

        public double _pi = 3.14;

        public Daire(int yariCap)
        {
            _yariCap = yariCap;
        }

        public void AlanHesapla()
        {
            int sonuc = (int)(_yariCap * Math.Pow(_pi, _pi));
            Console.WriteLine("Girdiğiniz dairenin alanı: "+sonuc+" cm2");
        }

        public void CevreHesapla()
        {
            int sonuc = (int)(2 * _pi * _yariCap);
            Console.WriteLine("Girdiğiniz dairenin çevresi: " + sonuc + " cm");
        }
    }
}
