using System;

public class Program {
    public static void Main() {
        int[] vetor = new int[10];
        int numX, maioresX = 0, menoresX = 0, iguaisX = 0;

        Console.WriteLine("Informe 10 números inteiros positivos maiores que zero:");
        for (int i = 0; i < vetor.Length; i++) {
            Console.Write("Número {0}: ", i + 1);
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Informe um número inteiro positivo maior que zero: ");
        numX = int.Parse(Console.ReadLine());

        for (int i = 0; i < vetor.Length; i++) {
            if (vetor[i] > numX) {
                maioresX++;
            } else if (vetor[i] < numX) {
                menoresX++;
            } else {
                iguaisX++;
            }
        }

        Console.WriteLine("Números maiores que X: {0}", maioresX);
        Console.WriteLine("Números menores que X: {0}", menoresX);
        Console.WriteLine("Números iguais a X: {0}", iguaisX);

    }
}