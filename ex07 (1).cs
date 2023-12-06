using System;
public class Program {
  public static void Main() {
    
    Console.Write("Digite a temperatura em graus Fahrenheit: ");
    double faren = double.Parse(Console.ReadLine());
    double cel = (faren - 32) * 5/9;
    Console.WriteLine("A temperatura em graus Celsius é: " + cel);
  }
}