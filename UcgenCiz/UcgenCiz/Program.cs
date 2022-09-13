using System;

namespace UcgenCiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir yükseklik giriniz");
            int yukseklik = int.Parse(Console.ReadLine());



            for (int i = 1; i <= yukseklik; i++)
            {
                for (int j = 0; j < yukseklik - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
