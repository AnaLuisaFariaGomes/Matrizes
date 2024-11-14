using System;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio10
{
    static void Main()
    {
        int R, C;

        Console.WriteLine("Digite o número de regiões (linhas): ");
        R = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de cidades por região (colunas): ");
        C = int.Parse(Console.ReadLine());
        int[,] matrix = new int[R, C];
        Matriz.gera(matrix);

        Console.WriteLine("\nMatriz das Tropas (Quantidade de Tropas por Cidade):");
        for (int i = 0; i < R; i++)
        {
            Console.Write("Região " + (i + 1) + ": ");
            for (int j = 0; j < C; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine(); 
        }
        
        Console.WriteLine("\nForça Total das Regiões:");
        for (int i = 0; i < R; i++)
        {
            int soma = 0;
            for (int j = 0; j < C; j++)
            {
                soma += matrix[i, j]; 
            }
            Console.WriteLine($"Região {i + 1}: {soma} tropas");
        }
    }
}