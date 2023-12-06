using System;

public class Program {
    public static void Main() {
        Console.Write("Informe o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        
        Console.Write("Informe o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        
        int dif = Math.Abs(n1 - n2);
        
        if (n1 > n2) {
            Console.WriteLine($"A diferença entre {n1} e {n2} é {dif}.");
        }
        else {
            Console.WriteLine($"A diferença entre {n2} e {n1} é {dif}.");
        }
    }
}