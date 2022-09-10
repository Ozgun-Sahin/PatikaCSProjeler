using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_ToDo.Entities
{
    public class Board
    {
        public List<Kart>? Yapilacak { get; set; }
        public List<Kart>? Yapiliyor { get; set; }
        public List<Kart>? Yapildi { get; set; }
    }
}
