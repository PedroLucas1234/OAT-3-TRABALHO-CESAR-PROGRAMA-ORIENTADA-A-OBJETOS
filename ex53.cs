using System;

public class Program {
    public static void Main() {
        Console.Write("Digite o número de voltas: ");
        int numVoltas = int.Parse(Console.ReadLine());

        double[] tempos = new double[numVoltas];
        double melhorTempo = double.MaxValue;
        int voltaMelhorTempo = 0;
        double somaTempos = 0;

        for (int i = 0; i < numVoltas; i++) {
            Console.Write($"Digite o tempo da volta {i + 1}: ");
            tempos[i] = double.Parse(Console.ReadLine());

            if (tempos[i] < melhorTempo) {
                melhorTempo = tempos[i];
                voltaMelhorTempo = i + 1;
            }

            somaTempos += tempos[i];
        }

        Console.WriteLine($"Melhor tempo: {melhorTempo:F2}s (volta {voltaMelhorTempo})");
        Console.WriteLine($"Tempo médio: {somaTempos / numVoltas:F2}s");
    }
}