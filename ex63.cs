using System;

public class Program {
    public static void Main() {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        string resultado = Verifica(numero);

        Console.WriteLine(resultado);
    }

    public static string Verifica(int n) {
        if (n % 2 == 0) {
            return "PAR";
        } else {
            return "ÍMPAR";
        }
    }
}