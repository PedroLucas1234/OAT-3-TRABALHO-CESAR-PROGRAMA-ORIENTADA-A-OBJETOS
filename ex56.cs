using System;

public class Program {
    public static void Main() {
        int[] num = new int[50];
        int countPares = 0, countMultiplosDe5 = 0;

        for (int i = 0; i < 50; i++) {
            Console.Write($"Digite o {i+1}º número: ");
            num[i] = int.Parse(Console.ReadLine());
            if (num[i] % 2 == 0) {
                countPares++;
            }
            if (num[i] % 5 == 0) {
                countMultiplosDe5++;
            }
        }

        Console.WriteLine($"Quantidade de números pares: {countPares}");
        Console.WriteLine($"Quantidade de múltiplos de 5: {countMultiplosDe5}");
    }
}
