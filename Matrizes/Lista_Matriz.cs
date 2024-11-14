using System;
using System.IO;

namespace Biblioteca_Matriz
{
    class Matriz
    {
        public static void leia(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($" [{i}, {j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }//fim for j  
            }//fim for i
        }//fim leia

        public static void mostra (int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{mat[i,j],3} |");
                }//fim for j  
                Console.WriteLine("\n");
            }//fim for i
        }//fim mostra

        public static void gera (int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            Random random = new Random(); //gerador aleatório

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = random.Next(0, 100);
                }//fim for j  
            }//fim for i
        }//fim gera 

        //--------------------------------*** DOUBLE ***--------------------------------
        public static void leia(double[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($" [{i}, {j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }//fim for j  
            }//fim for i
        }//fim leia

        public static void mostra(double[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{mat[i, j],3} |");
                }//fim for j  
                Console.WriteLine("\n");
            }//fim for i
        }//fim mostra
        public static void gera(double[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            Random random = new Random(); //gerador aleatório

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = random.Next(0, 100);
                }//fim for j  
            }//fim for i
        }//fim gera 
    }
}
