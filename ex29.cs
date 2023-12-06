using System;

namespace ExibirNumeros
{
    public class Program
    {
        public static void Main()
        {
            ExibirNumeros();
        }

        public static void ExibirNumeros()
        {
            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}