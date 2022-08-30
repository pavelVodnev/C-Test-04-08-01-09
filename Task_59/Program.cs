// Задача 59: 
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// .....................................1 Вариант н е доделон выходит за пределы

// int[,] CreateMatrixRndInt(int row, int col, int min, int max)
// {
//     int[,] matrix = new int[row, col];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) // строки - row
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // столбцы- col
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
//             // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4},");
//             // else Console.Write($"{matrix[i,j], 4}");

//             Console.Write(j < matrix.GetLength(1) - 1 ? //можно вместо if,else
//             $"{matrix[i, j],4}," : $"{matrix[i, j],4}");
//         }
//         Console.WriteLine("]");
//     }
// }

// int[] FindIndexMinInMatrix(int[,] array)
// {
//     int min = array[0, 0];
//     int[] result = new int[2];
//     int rowIndex = 0;
//     int colIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min) ;
//             {
//                 min = array[i, j];
//                 rowIndex = i;
//                 colIndex = j;
//             }
//         }
//     }
//     result[0] = rowIndex;
//     result[1] = colIndex;
//     return result;
// }

// int[,] CreateMatrixDelMinRowCol(int[,] matrix, int row, int col)
// {
//     int[,] matrixDel = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];


//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (row != i || col != j)
//                 matrixDel[i, j] = matrix[i, j];
//         }
//     }
//     return matrixDel;
// }

// int[,] array2D = CreateMatrixRndInt(5, 4, 0, 9);
// PrintMatrix(array2D);
// int[] minIdex = FindIndexMinInMatrix(array2D);
// int[,] newArray2D = CreateMatrixDelMinRowCol(array2D, minIdex[0], minIdex[1]);
// PrintMatrix(newArray2D);


// .............................2 вариант рабочий