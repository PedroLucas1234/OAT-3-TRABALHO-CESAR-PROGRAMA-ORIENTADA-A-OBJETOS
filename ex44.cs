using System;
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 == Conversão de Graus Celsius em Graus Fahrenheit");
            Console.WriteLine("2 == Conversão de Graus Fahrenheit em Graus Celsius");
            Console.WriteLine("3 == Peso ideal do homem");
            Console.WriteLine("4 == Peso ideal da mulher");
            Console.WriteLine("S == Encerrar o programa");

            string opc = Console.ReadLine().ToUpper();
            if (opc == "S")
            {
                Console.WriteLine("ENCERRANDO...");
                break;
            }

            switch (opc)
            {
                case "1":
                    Console.Write("Informe a temperatura em graus Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2}");
                    break;
                case "2":
                    Console.Write("Informe a temperatura em graus Fahrenheit: ");
                    double fahrenheit2 = double.Parse(Console.ReadLine());
                    double celsius2 = (fahrenheit2 - 32) * 5 / 9;
                    Console.WriteLine($"Temperatura em Celsius: {celsius2:F2}");
                    break;
                case "3":
                    Console.Write("Informe a altura em metros: ");
                    double alturaH = double.Parse(Console.ReadLine());
                    double pesoIdealH = 72.7 * alturaH - 58;
                    Console.WriteLine($"Peso ideal: {pesoIdealH:F2} kg");
                    Console.Write("Informe o peso atual em kg: ");
                    double pesoAtualHomem = double.Parse(Console.ReadLine());
                    if (pesoAtualHomem > pesoIdealH)
                    {
                        Console.WriteLine("Acima do peso ideal");
                    }
                    else if (pesoAtualHomem < pesoIdealH)
                    {
                        Console.WriteLine("Abaixo do peso ideal");
                    }
                    else
                    {
                        Console.WriteLine("Peso ideal");
                    }
                    break;
                case "4":
                    Console.Write("Informe a altura em metros: ");
                    
                    double alturaM = double.Parse(Console.ReadLine());
                    
                    double pesoIdealM = 62.1 * alturaM - 44.7;
                    
                    Console.WriteLine($"Peso ideal: {pesoIdealM:F2} kg");
                    Console.Write("Informe o peso atual em kg: ");
                    
                    double pesoAtualMulher = double.Parse(Console.ReadLine());
                    if (pesoAtualMulher > pesoIdealM)
                    {
                        Console.WriteLine("Acima do peso ideal");
                    }
                    else if (pesoAtualMulher < pesoIdealM)
                    {
                        Console.WriteLine("Abaixo do peso ideal");
                    }
                    else
                    {
                        Console.WriteLine("Peso ideal");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}