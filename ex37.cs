using System;

public class Program {
    public static void Main() {
        int opc;
        do {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 == Adição");
            Console.WriteLine("2 == Subtração");
            Console.WriteLine("3 == Multiplicação");
            Console.WriteLine("4 == Divisão");
            Console.WriteLine("5 == Sair");
            Console.Write("Opção: ");
            opc = int.Parse(Console.ReadLine());
            switch (opc) {
                case 1:
                    Console.Write("Informe o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double resultado = num1 + num2;
                    Console.WriteLine("O resultado da adição é: " + resultado);
                    break;
                case 2:
                    Console.Write("Informe o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;
                case 3:
                    Console.Write("Informe o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;
                case 4:
                    Console.Write("Informe o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado da divisão é: " + resultado);
                    break;
                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        } while (opc != 5);
    }
}