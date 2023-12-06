using System;

public class Program {
    public static void Main() {

        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit.ToString("F1"));
    }
}