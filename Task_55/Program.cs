// Задача 55: 
// Задайте двумерный массив. 
// Напишите программу,которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для
// пользователя.

// ..................................1 вариант
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


void ChangeColMatrix(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                if (i < j)
                {
                    Console.WriteLine($"Меняем местами столбец {i} строка {j}->строка {j} столбец {i} значения {array[j,i]}");
                    temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
            }
        }
    }
    else Console.WriteLine("Строки со столбцом поменять нельзя!");

}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);

ChangeColMatrix(array2d);
Console.WriteLine();
PrintMatrix(array2d);


// ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,2 вариант

// int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
// {
    
//     int[,] matrix = new int[row, col];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) // строки
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(j < matrix.GetLength(1) - 1 ? 
//             $"{matrix[i,j], 4}," : $"{matrix[i,j], 4} ");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine();
// }

// int[,] ReplacementString(int[,] matrix)
// {
//     int[,] matrixOne =  new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrixOne[i, j] = matrix[j, i];
//         }
//     }
//     return matrixOne;
// }

// int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
// PrintMatrix(matrix);
// int[,] matrixTwo = ReplacementString(matrix);
// PrintMatrix(matrixTwo);

// ................................3 вариант

// void ReplacementString(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int replacement = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = replacement;
//         }
//     }
// }

