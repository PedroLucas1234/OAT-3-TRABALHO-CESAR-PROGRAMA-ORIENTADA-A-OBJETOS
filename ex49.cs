using System;

public class Program {
    public static void Main() {
        const int MAX = 50;
        int[] v1 = new int[MAX];
        int[] v2 = new int[MAX];
        int i, count = 0;
        
        Console.Write("Informe o tamanho dos vetores (no máximo 50): ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe os elementos do vetor V1:");
        for (i = 0; i < n; i++) {
            Console.Write("V1[" + i + "]: ");
            v1[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Informe os elementos do vetor V2:");
        for (i = 0; i < n; i++) {
            Console.Write("V2[" + i + "]: ");
            v2[i] = int.Parse(Console.ReadLine());
        }
        
        for (i = 0; i < n; i++) {
            if (v1[i] == v2[i]) {
                count++;
            }
        }
        
        Console.WriteLine("Número de valores idênticos nas mesmas posições: " + count);
    }
}