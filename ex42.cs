using System;

public class Program
{
    public static void Main()
    {

        int maior = int.MinValue;
        int menor = int.MaxValue;

        do
        {
            Console.Write("Digite um número [DIGITE 0 PARA SAIR]: ");
            int num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                if (num > maior)
                {
                    maior = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }

        } while (num != 0);

        Console.WriteLine("MAIOR NUM: " + maior);
        Console.WriteLine("MENOR NUM: " + menor);
    }
}