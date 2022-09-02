using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Phone_Book.Islemler
{
    public interface IIslemler
    {
        public void Kaydet() { } 
        public void Sil() { } 
        public void Guncelle() { } 
        public void Listele () { } 
        public void Arama() { } 
    }
}
