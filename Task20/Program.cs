// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// Один из способов 

// Console.Write("Введите координаты точки X для первой точки: ");
// int x1 = int.Parse(Console.ReadLine());

// Console.Write("Введите координаты точки y для первой точки: ");
// int y1 = int.Parse(Console.ReadLine());

// Console.Write("Введите координаты точки X для второй точки: ");
// int x2 = int.Parse(Console.ReadLine());

// Console.Write("Введите координаты точки y для второй точки: ");
// int y2 = int.Parse(Console.ReadLine());

// double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2)*(y1 - y2));
// Console.WriteLine("Расстояние между точками равно {0: #.##}", result);

// Второй пример
double Distance(int xc1, int yc1, int xc2, int yc2)
{
    // double dist = Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1)); // можно заменить одной строчкой
    // return dist;
    return Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1));
}
Console.WriteLine("1 точка ");
Console.Write("Введите координату X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 точка ");
Console.Write("Введите координату X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, y1, x2, y2);
Console.WriteLine(Math.Round(res, 5));

// Можно использовать для округления

// double d = 5.0995466;
// System.Console.WriteLine(Math.Round(d, 2, MidpointRounding.ToZero));
