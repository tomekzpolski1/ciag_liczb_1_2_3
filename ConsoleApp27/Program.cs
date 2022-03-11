using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            int n = int.Parse(Console.ReadLine());
            int wynik =0;
            for (int i = 1; i <= n; i++)
            {
                wynik = (i % 2 == 1) ? wynik += i : wynik -= i;
            }
            Console.WriteLine(wynik);
        }
    }
}
