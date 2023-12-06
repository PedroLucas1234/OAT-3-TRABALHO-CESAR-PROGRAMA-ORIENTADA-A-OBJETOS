using System;

public class Program
{
    public static void Main()
    {
        int[] idades = { 18, 19, 20, 21, 22, 18, 19, 20, 23, 24, 18, 19, 20, 25, 26, 18, 19, 20, 27, 28 };

        string[] nomes = { "Ana", "Bia", "Clara", "Duda", "Eva", "Flávia", "Gabriela", "Helena", "Isabela", "Julia", "Kamila", "Larissa", "Mariana", "Natalia", "Olivia", "Paula", "Quezia", "Rita", "Sofia", "Tatiana" };

        string[] candidatasAptas = new string[20];
        int contador = 0;

        Console.Write("Informe a idade mínima das candidatas: ");
        int idadeMinima = int.Parse(Console.ReadLine());

        Console.Write("Informe a idade máxima das candidatas: ");
        int idadeMaxima = int.Parse(Console.ReadLine());

        for (int i = 0; i < idades.Length; i++)
        {
            if (idades[i] >= idadeMinima && idades[i] <= idadeMaxima)
            {
                candidatasAptas[contador] = nomes[i];
                contador++;
            }
        }

        Console.WriteLine("\nCandidatas aptas para a campanha publicitária:");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(candidatasAptas[i]);
        }
    }
}
