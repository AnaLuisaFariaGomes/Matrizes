using System;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio_1
{
    static int maior(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int maior_valor = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz [i,j] > maior_valor)
                {
                    maior_valor = matriz [i,j];
                }
            }//fim for j  
        }//fim for i

        return maior_valor;
    }
    static void Main()
    {
        int N, M;
        Console.WriteLine("*** Matrizes ***");
        Console.WriteLine("Quantidade de linhas e colunas: ");
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M]; //criando

        Matriz.gera(matrix);
        Console.WriteLine("\nDados da matriz: \n");
        Matriz.mostra(matrix);

        Console.Write(Exercicio_1.maior(matrix));

        Console.ReadKey();
    }
}
