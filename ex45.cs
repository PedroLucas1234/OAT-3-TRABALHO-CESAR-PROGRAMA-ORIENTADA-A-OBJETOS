using System;

public class Program {
    public static void Main() {
        Console.Write("Informe o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());
        
        int[] vetor = new int[tamanho];
        
        for (int i = 0; i < tamanho; i++) {
            Console.Write($"Informe o {i + 1} número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Vetor na ordem inversa:");
        
        for (int i = tamanho - 1; i >= 0; i--) {
            Console.Write(vetor[i] + " ");
        }
    }
}