﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRandomInt (int rows, int columns, int min, int max) 
{
    int [,] matrix = new int [rows, columns];
    Random rndm = new Random();

    for(int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j] = rndm.Next( min, max+1 );
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1) 
            Console.Write($"{matrix[i,j], 4}| ");
            else Console.Write($"{matrix[i,j], 4}");
        }
    Console.WriteLine("|");
    }
}

int [,] OrganizeFromMinElements(int [,] matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            for (int k = 0; k <matrix.GetLength(1) -1; k++)
            {
                if (matrix [i,k] < matrix[i,k+1])
                {
                int temporary = matrix[i,k+1];
                matrix[i, k + 1] = matrix[i,k];
                matrix [i,k] = temporary;
                }
            }
        }
    }
    return matrix;
}

int [,] array2D = CreateMatrixRandomInt(5,5,1,10); 
PrintMatrix(array2D);
Console.WriteLine();
int [,] organizeMatrix = OrganizeFromMinElements(array2D);
PrintMatrix(organizeMatrix);










