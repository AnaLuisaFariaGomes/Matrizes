using System;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio_7
{
    static void SomaMatrizes(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        double[,] resultado = new double[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        Console.WriteLine("\nResultado da soma das matrizes:\n");
        Matriz.mostra(resultado);
    }

    static void SubtracaoMatrizes(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        double[,] resultado = new double[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = matriz1[i, j] - matriz2[i, j];
            }
        }

        Console.WriteLine("\nResultado da subtração das matrizes:\n");
        Matriz.mostra(resultado);
    }

    static void AdicionaConstante(double[,] matriz, double constante)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] += constante;
            }
        }
    }

    static void Main()
    {
        int N, M;

        Console.WriteLine("*** Matrizes ***");
        Console.WriteLine("Quantidade de linhas e colunas da 1ª Matriz: ");
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());
        double[,] matrix = new double[N, M];
        Matriz.gera(matrix);

        Console.WriteLine("\nQuantidade de linhas e colunas da 2ª Matriz: ");
        int N1 = int.Parse(Console.ReadLine());
        int M1 = int.Parse(Console.ReadLine());
        double[,] matrix1 = new double[N1, M1];
        Matriz.gera(matrix1);

        if (N == N1 && M == M1)
        {
            int operacao;
            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Somar as duas matrizes;");
                Console.WriteLine("2 - Subtrair a primeira matriz da segunda;");
                Console.WriteLine("3 - Adicionar uma constante às duas matrizes;");
                Console.WriteLine("4 - Imprimir as matrizes;");
                Console.WriteLine("0 - Sair");
                operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    SomaMatrizes(matrix, matrix1);
                }
                else if (operacao == 2)
                {
                    SubtracaoMatrizes(matrix, matrix1);
                }
                else if (operacao == 3)
                {
                    Console.WriteLine("Informe o valor da constante:");
                    double constante = double.Parse(Console.ReadLine());
                    AdicionaConstante(matrix, constante);
                    AdicionaConstante(matrix1, constante);
                    Console.WriteLine("\nConstante adicionada às duas matrizes.\n");
                }
                else if (operacao == 4)
                {
                    Console.WriteLine("\nDados da 1ª matriz:\n");
                    Matriz.mostra(matrix);
                    Console.WriteLine("\nDados da 2ª matriz:\n");
                    Matriz.mostra(matrix1);
                }
                else if (operacao == 0)
                {
                    Console.WriteLine("Fim do programa.");
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }

            } while (operacao != 0);
        }
        else
        {
            Console.WriteLine("\nNÃO é possível operar com as matrizes, pois têm dimensões diferentes. Tente novamente.\n");
        }
    }
}
