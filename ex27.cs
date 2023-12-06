using System;

namespace Fatorial
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Informe a qtd de números que deseja processar: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                int numero = int.Parse(Console.ReadLine());

                int fatorial = 1;
                for (int j = 1; j <= numero; j++)
                {
                    fatorial *= j;
                }

                Console.WriteLine($"O fatorial de {numero} é {fatorial}");
            }

            Console.ReadLine();
        }
    }
}