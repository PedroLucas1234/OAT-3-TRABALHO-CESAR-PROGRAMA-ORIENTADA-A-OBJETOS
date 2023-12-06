using System;

public class Program {
    public static void Main() {
        int a = 5;
        int b = 10;
        Console.WriteLine($"Antes da troca: a = {a}, b = {b}");
        Troca(ref a, ref b);
        Console.WriteLine($"Depois da troca: a = {a}, b = {b}");
    }

    public static void Troca(ref int x, ref int y) {
        int temp = x;
        x = y;
        y = temp;
    }
}