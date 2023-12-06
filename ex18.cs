using System;

public class Program {
    public static void Main() {
        Console.Write("Digite um número inteiro. [1] [2] [3]: ");
        int cod = int.Parse(Console.ReadLine());

        switch (cod) {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;
            default:
                Console.WriteLine("Código inválido");
                break;
        }

        Console.ReadLine();
    }
}