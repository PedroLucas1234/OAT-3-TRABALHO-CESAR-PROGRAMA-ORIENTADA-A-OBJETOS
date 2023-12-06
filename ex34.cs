using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe uma sequência de números positivos [INFORME UM NÚMERO NEGATIVO PARE ENCERRAR!]:");

        int num = 0;
        int menor = int.MaxValue;
        int maior = int.MinValue;

        while (true)
        {
            num = int.Parse(Console.ReadLine());

            if (num < 0)
                break;

            if (num < menor)
                menor = num;

            if (num > maior)
                maior = num;
        }

        Console.WriteLine($"Menor número: {menor}");
        Console.WriteLine($"Maior número: {maior}");
    }
}