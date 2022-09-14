using System;
using System.Linq;
using System.Xml;

namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime giriniz");
            string kelime = Console.ReadLine();

            int sinir = kelime.Length;

            Console.WriteLine("Lütfen 0 - " + sinir + " arası bir sayı giriniz");
        SayiGir:
            try
            {
                int sayi = int.Parse(Console.ReadLine());

                if (sayi < sinir)
                {
                    Console.WriteLine("input: " + kelime + "," + sayi);
                    Console.WriteLine("output: " + kelime.Remove(sayi, 1));
                }
                else
                {
                    Console.WriteLine("Lütfen belirtilen aralıkta bir sayı giriniz");
                    goto SayiGir;
                }
                
            }
            catch (Exception )
            {

                Console.WriteLine("lütfen bir sayı giriniz");
                goto SayiGir;
            }
            

            
        }
    }
}
