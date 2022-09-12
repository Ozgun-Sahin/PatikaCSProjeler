using System;
using System.Collections;

namespace FibonacciOrtalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int toplam = 0;

            ArrayList fibo = new ArrayList();

            Console.WriteLine("Kaç elemanlı bir seri olmalı ?");
            int entry = int.Parse(Console.ReadLine());

            for (int i = 0; i < entry; i++)
            {
                c = a + b;
                a = b;
                b = c;

                toplam = toplam + c;

                fibo.Add(c);
            }

            Console.WriteLine("serinin elemanları");
            foreach (var item in fibo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("serinin ortalaması:");

            int ortlama = toplam / entry + 1;

            Console.WriteLine(ortlama); 
           
        }
    }
}
