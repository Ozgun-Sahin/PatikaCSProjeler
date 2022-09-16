using System;
using System.Collections;
using System.Linq;

namespace KarakterTerstenYazma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız:");

            string cumle = Console.ReadLine();

            ArrayList yeniCumle = new ArrayList();

            foreach (var item in cumle)
            {
                yeniCumle.Add(item);
            }

            int index = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                string karakter = Convert.ToString(cumle[i]);
                int cumleSonu = cumle.Length - 1;

                if (karakter == " ")
                {
                    object ilk = yeniCumle[index];
                    object son = yeniCumle[i - 1];

                    yeniCumle[index] = son;
                    yeniCumle[i - 1] = ilk;

                    index = i + 1;
                }

                else if (i == cumleSonu)
                {
                    object ilk = yeniCumle[index];
                    object cSon = yeniCumle[i];

                    yeniCumle[index] = cSon;
                    yeniCumle[i] = ilk;

                }
            }

            string sonuc = "";
            
            for (int i = 0; i < yeniCumle.Count; i++)
            {
                sonuc = String.Concat(sonuc, yeniCumle[i]);
            }

            Console.WriteLine(sonuc);











            //int i1 = 0;
            //int i2 = 0;

            //ArrayList cumle = new ArrayList();

            //string girilenCumle = Console.ReadLine();

            //foreach (var item in girilenCumle)
            //{
            //    cumle.Add(item);
            //}

            //foreach (var item in cumle)
            //{
            //    int charIndex = cumle.IndexOf(item);

            //    string s = Convert.ToString(cumle[charIndex]);

            //    if (s == " ")
            //    {
            //        cumle[i1] = cumle[charIndex-1];
            //        cumle[charIndex - 1] = cumle[i1];
            //        i1 = charIndex + 1;
            //    }
            //}

            //foreach (var item in cumle)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
