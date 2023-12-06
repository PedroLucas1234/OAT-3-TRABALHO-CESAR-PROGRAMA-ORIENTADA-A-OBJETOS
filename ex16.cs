using System;

public class Mainpublic class {
  public static void Main () {
    Console.Write("Informe o primeiro número: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Informe o segundo número: ");
    int n2 = int.Parse(Console.ReadLine());
    
    if(n1 > n2){
      Console.WriteLine("Maior número: " + n1);
      Console.WriteLine("Menor número: " + n2);
    } else if(n2 > n1){
      Console.WriteLine("Maior número: " + n2);
      Console.WriteLine("Menor número: " + n1);
    } else {
      Console.WriteLine("Os dois números são iguais: " + n1);
    }
  }
}
