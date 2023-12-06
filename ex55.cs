using System;

public class Program {
    public static void Main() {
        Console.Write("Digite uma frase [50 CARACTERES]: ");
        string frase = Console.ReadLine();
        
        string fraseSemEspacos = frase.Replace(" ", "");
        
        int quantidadeEspacos = frase.Length - fraseSemEspacos.Length;
        
        Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);
        Console.WriteLine("Quantidade de espaços em branco: " + quantidadeEspacos);
    }
}
