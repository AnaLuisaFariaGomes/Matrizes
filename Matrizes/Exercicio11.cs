using System;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio11
{
    static void soma_diagonal_principal(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int soma = 0;

        for (int i = 0; i < linhas; i++)
        {
            soma = soma + matriz[i,i];
        }
        Console.Write(soma);
    }

    static void soma_diagonal_secun(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int j = linhas - 1;
        int soma2 = 0;

        for (int i = 0; i < linhas; i++, j--)
        {
            soma2 = soma2 + matriz[i, j];
        }
        Console.Write(soma2);
    }

    static void premio (int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int j = linhas - 1;
        int soma2 = 0;

        for (int i = 0; i < linhas; i++, j--)
        {
            soma2 = soma2 + matriz[i, j];
        }

        int soma = 0;

        for (int i = 0; i < linhas; i++)
        {
            soma = soma + matriz[i, i];
        }

        if (soma > soma2) 
        {
            Console.WriteLine("O maior tesouro está na diagonal principal, vamos para lá!");
        }
        else if (soma2 > soma)
        {
            Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
        }
        else
        {
            Console.WriteLine("O maior tesouro é igual em ambos as direçoes, escolha um lado!");
        }
    }

    static void Main()
    {
        int N, M;
        Console.WriteLine("*** Matrizes ***");
        Console.WriteLine("Quantidade de linhas e colunas: ");
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());

        if (N == M)
        {
            int[,] matrix = new int[N, M]; //criando
            Matriz.gera(matrix);
            Console.WriteLine("\nDados da matriz: \n");
            Matriz.mostra(matrix);
            Console.WriteLine("\nSoma da diagonal principal: \n");
            Exercicio11.soma_diagonal_principal(matrix);
            Console.WriteLine("\nSoma da diagonal secundaria: \n");
            Exercicio11.soma_diagonal_secun(matrix);
            Console.WriteLine("\n\n");
            Exercicio11.premio(matrix);
            
        }
        else
        {
            Console.WriteLine("\nNÃO é possivel apresentar dados para essa dimensão.\n");
        }

        Console.ReadKey();
    }
}