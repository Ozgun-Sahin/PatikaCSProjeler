using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_ToDo.Entities
{
    public class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Kisi { get; set; }
        public string Buyukluk { get; set; }
        public string KartTipi { get; set; } = "Yapilacak";
    }
}
