using System;

namespace Salario
{
    public class Program
    {
        public static void Main()
        {
            double salarioTotal, salarioExcedente = 0;

            char continuar = 'N';

            do
            {
                Console.Write("Informe o código do operário: ");
                int cod = int.Parse(Console.ReadLine());

                Console.Write("Informe o número de horas trabalhadas: ");
                int hTrabalhadas = int.Parse(Console.ReadLine());

                if (hTrabalhadas > 50)
                {
                    salarioExcedente = (hTrabalhadas - 50) * 20.0;
                    salarioTotal = 50 * 10.0 + salarioExcedente;
                }
                else
                {
                    salarioTotal = hTrabalhadas * 10.0;
                }

                Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");
                Console.WriteLine($"Salário excedente: R$ {salarioExcedente:F2}");

                Console.Write("Deseja encerrar o programa? (S/N): ");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar != 'S' && continuar != 's');
        }
    }
}