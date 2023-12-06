using System;


public class Program

    public static int[] vetor = new int[10];
    public static int tamanho = 0;

    public static void Main()
    {
        int opcao = 0;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 == Carregar Vetor");
            Console.WriteLine("2 == Listar Vetor");
            Console.WriteLine("3 == Exibir apenas os números pares do vetor");
            Console.WriteLine("4 == Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 == Exibir a qtd de números pares existem nas posições ímpares do vetor");
            Console.WriteLine("6 == Exibir a qtd de números ímpares existem nas posições pares do vetor");
            Console.WriteLine("7 == Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CarregarVetor();
                    break;
                case 2:
                    ListarVetor();
                    break;
                case 3:
                    ExibirPares();
                    break;
                case 4:
                    ExibirImpares();
                    break;
                case 5:
                    qtdParesPosicoesImpares();
                    break;
                case 6:
                    qtdImparesPosicoesPares();
                    break;
                case 7:
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 7);
    }

    public static void CarregarVetor()
    {
        Console.WriteLine("Digite os elementos do vetor (máximo 10):");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Elemento {i+1}: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor == 0)
            {
                break;
            }

            vetor[i] = valor;
            tamanho++;
        }
    }

    public static void ListarVetor()
    {
        if (tamanho == 0)
        {
            Console.WriteLine("Vetor vazio.");
        }
        else
        {
            Console.WriteLine("Elementos do vetor:");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"{vetor[i]} ");
            }

            Console.WriteLine();
        }
    }

    public static void ExibirPares()
    {
        Console.Write("Números pares: ");
        for (int i = 0; i < tamanho; i++) {
            if (vetor[i] % 2 == 0) {
                Console.Write(vetor[i] + " ");
            }
        }
        Console.WriteLine();
    }
    
    public static void ExibirImpares()
    {
        Console.Write("Números impares: ");
        for (int i = 0; i < tamanho; i++) {
            if (vetor[i] % 2 != 0) {
                Console.Write(vetor[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public static void qtdParesPosicoesImpares()
    {
        int qtd = 0;
        for (int i = 1; i < tamanho; i += 2) {
            if (vetor[i] % 2 == 0) {
                qtd++;
            }
        }
        Console.WriteLine("qtd de números pares nas posições ímpares: " + qtd);
    
    }

    public static void qtdImparesPosicoesPares()
    {
        int qtd = 0;
        for (int i = 1; i < tamanho; i += 2) {
            if (vetor[i] % 2 != 0) {
                qtd++;
            }
        }
        Console.WriteLine("qtd de números pares nas posições ímpares: " + qtd);
    
    }