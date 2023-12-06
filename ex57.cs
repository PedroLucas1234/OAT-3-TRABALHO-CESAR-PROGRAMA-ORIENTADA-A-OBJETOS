using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Escreva uma frase: ");
        string frase = Console.ReadLine();
        string vogais = "aeiouAEIOU";

        Console.WriteLine("Vogais na frase:");
        foreach (char letras in frase)
        {
            if (vogais.Contains(letras))
            {
                Console.Write(letras);
            }
        }
    }
}