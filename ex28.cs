using System;

namespace NumerosImpares
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Números ímpares entre 100 e 200:");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}