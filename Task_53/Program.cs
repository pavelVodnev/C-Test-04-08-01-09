﻿// Задача 53: 
// Задайте двумерный массив. 
// Напишите программу,которая поменяет местами первую и последнюю строку массива.

// ...............................................1 вариант.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // строки - row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы- col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4},");
            // else Console.Write($"{matrix[i,j], 4}");

            Console.Write(j < matrix.GetLength(1) - 1 ? //можно вместо if,else
            $"{matrix[i, j],4}," : $"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}


void ChangeColMatrix (int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
}

int[,] array2d = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(array2d);
ChangeColMatrix(array2d);
Console.WriteLine();
PrintMatrix(array2d);
