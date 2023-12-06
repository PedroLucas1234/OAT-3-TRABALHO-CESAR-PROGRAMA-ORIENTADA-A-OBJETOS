using System;

namespace Tabuada
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Informe um número para gerar a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do " + numero + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }

            Console.ReadKey();
        }
    }
}
