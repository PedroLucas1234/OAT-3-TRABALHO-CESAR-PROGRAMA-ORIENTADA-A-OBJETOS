using System;

public class Program {
  public static void Main() {
    Console.Write("Informe um número inteiro: ");
    int num = int.Parse(Console.ReadLine());
    
    int mod;
    if (num >= 0) {
        mod = num;
    } else {
        mod = num * (-1);
    }
    
    Console.WriteLine("O módulo do número digitado é: " + mod);
  }
}