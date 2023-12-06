using System;


namespace ex23
{
    public class Program
    {
        public static void Main()
        {
            double resultado;

            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"O resultado da adição é: {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"O resultado da subtração é: {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"O resultado da divisão é: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero!");
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
