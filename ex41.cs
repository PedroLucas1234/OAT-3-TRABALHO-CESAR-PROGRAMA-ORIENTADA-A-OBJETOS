using System;

public class Program
{
    public static void Main()
    {
        int idade;

        while (true)
        {
            Console.Write("Informe a idade do nadador [DIGITE << S >> PARA SAIR]: ");
            string entrada = Console.ReadLine();
            if (entrada.ToUpper() == "S") break;

            if (int.TryParse(entrada, out idade))
            {
                string categoria;

                if (idade >= 5 && idade <= 7)
                {
                    categoria = "Infantil A";
                }
                else if (idade >= 8 && idade <= 11)
                {
                    categoria = "Infantil B";
                }
                else if (idade >= 12 && idade <= 13)
                {
                    categoria = "Juvenil A";
                }
                else if (idade >= 14 && idade <= 17)
                {
                    categoria = "Juvenil B";
                }
                else if (idade >= 18)
                {
                    categoria = "ADULTOS";
                }
                else
                {
                    categoria = "Idade inválida!";
                }

                Console.WriteLine("CATEGORIA: {0}", categoria);
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}