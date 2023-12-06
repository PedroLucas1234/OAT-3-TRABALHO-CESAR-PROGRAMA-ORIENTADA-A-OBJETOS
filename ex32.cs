using System;

namespace Ex
{
    public class Program
    {
        public static void Main()
        {
            int num;

            do
            {
                Console.Write("Informe um número entre 1 e 9: ");
                num = int.Parse(Console.ReadLine());

                if (num < 1 || num > 9)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }
            } while (num < 1 || num > 9);

            int somaQuadrados = SomaQuadradosnumsImpares(num);

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números inteiros ímpares a partir do número {num} é {somaQuadrados}.");

        }

        public static int SomaQuadradosnumsImpares(int num)
        {
            int soma = 0;
            int contador = 0;
            int numAtual = num;

            while (contador < 20)
            {
                if (numAtual % 2 != 0)
                {
                    soma += (int)Math.Pow(numAtual, 2);
                    contador++;
                }
                numAtual++;
            }

            return soma;
        }
    }
}