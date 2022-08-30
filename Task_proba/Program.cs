// помощь в решении задачa 47

double[,] CreateMatrixRndDouble(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // строки - row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы- col
        {
            double rand = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(rand, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4},");
            // else Console.Write($"{matrix[i,j], 4}");

            Console.Write(j < matrix.GetLength(1) - 1 ? //можно вместо if,else
            $"{matrix[i, j],6} ;" : $"{matrix[i, j],6}"); // , 6}"); отступы на консоле
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = CreateMatrixRndDouble(3, 4, 10, 40);
PrintMatrix(array2D);
