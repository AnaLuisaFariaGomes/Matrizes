using System;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio_6
{
    static void SomaMatrizes(int[,] matriz1, int[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        int[,] resultado = new int[linhas, colunas];

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

    static void Main()
    {
        int N, M;

        Console.WriteLine("*** Matrizes ***");
        Console.WriteLine("Quantidade de linhas e colunas da 1ª Matriz: ");
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, M]; 
        Matriz.gera(matrix);
        Console.WriteLine("\nDados da 1ª matriz:\n");
        Matriz.mostra(matrix);

        int N1, M1;

        Console.WriteLine("\nQuantidade de linhas e colunas da 2ª Matriz: ");
        N1 = int.Parse(Console.ReadLine());
        M1 = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[N1, M1]; 
        Matriz.gera(matrix1);
        Console.WriteLine("\nDados da 2ª matriz:\n");
        Matriz.mostra(matrix1);

        if (N == N1 && M == M1)
        {
            SomaMatrizes(matrix, matrix1); 
        }
        else
        {
            Console.WriteLine("\nNÃO é possível somar as duas matrizes, pois têm dimensões diferentes. Tente novamente.\n");
        }
    }
}
