﻿// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rndm = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rndm.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}| ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int SumElementsInRow(int [,] matrix,int i)
{
        int sum = 0;
        for (int j = 1; j <matrix.GetLength(1); j++)
        {
        sum = matrix[i,j] + sum ;
        }
    return sum;
}

int[,] array2D = CreateMatrixRandomInt(4, 4, 1, 10);
PrintMatrix(array2D);
int sumElementsInRow = SumElementsInRow(array2D, 0);
int minRow = default;
for (int i = 1; i < array2D.GetLength(0); i++)
{
    int temporaryMin = SumElementsInRow(array2D, i);
    if (sumElementsInRow > temporaryMin)
    {
        sumElementsInRow = temporaryMin;
        minRow = i;
    }
}
Console.WriteLine ($"Наименьшая сумма элементов в строке {minRow+1} ");












