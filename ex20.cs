using System;

public class Program {
    public static void Main() {

        int a, b, c;

        Console.WriteLine("Informe três valores int maiores que zero:");

        do {
            Console.Write("Valor de A: ");
            a = int.Parse(Console.ReadLine());
        } while (a <= 0);

        do {
            Console.Write("Valor de B: ");
            b = int.Parse(Console.ReadLine());
        } while (b <= 0);

        do {
            Console.Write("Valor de C: ");
            c = int.Parse(Console.ReadLine());
        } while (c <= 0);

        int maior = Math.Max(a, Math.Max(b, c));
        int menor = Math.Min(a, Math.Min(b, c));

        Console.WriteLine("Menor valor multiplicado pelo maior valor: " + (maior * menor));
        Console.WriteLine("Maior valor dividido pelo menor valor: " + ((double)maior / menor));
    }
}
