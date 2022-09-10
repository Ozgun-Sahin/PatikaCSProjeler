using Project_2_ToDo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_ToDo.Islemler
{
    public class BoardListeleme
    {
        private static Board _Board;

        public void Line()
        {
            var yapilacak = Kart_KisiDB.Kartlar.Where(x=> x.KartTipi == "Yapilacak").ToList();
            var yapiliyor = Kart_KisiDB.Kartlar.Where(x => x.KartTipi == "Yapiliyor").ToList();
            var yapildi = Kart_KisiDB.Kartlar.Where(x => x.KartTipi == "Yapildi").ToList();

            _Board = new Board();
            _Board.Yapilacak = yapilacak;
            _Board.Yapiliyor = yapiliyor;
            _Board.Yapildi = yapildi;   
        }

        public void KartBas(string kartTipi, List<Kart>? Liste)
        {
            
            Console.WriteLine(kartTipi);
            Console.WriteLine("************************************");

            foreach (var item in Liste)
            {
                Console.WriteLine("Başlık      :  {0}", item.Baslik);
                Console.WriteLine("İçerik      :  {0}", item.Icerik);
                Console.WriteLine("Atanan Kişi :  {0}", item.Kisi);
                Console.WriteLine("Büyüklük    :  {0}", item.Buyukluk);
                Console.WriteLine("");
            }

        }


        public void Listele()
        {
            Line();
            KartBas("Yapılacaklar", _Board.Yapilacak);
            KartBas("Yapılmakta olanlar", _Board.Yapiliyor);
            KartBas("Yapılanlar", _Board.Yapildi);
        }



    }
}
