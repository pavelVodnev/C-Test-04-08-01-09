// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторонами


// .......................................1 вариант решения
// Console.WriteLine("Введите первую сторону треугольника ab: ");
// int ab = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую сторону треугольника bc: ");
// int bc = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третью сторону треугольника ca: ");
// int ca = Convert.ToInt32(Console.ReadLine());

// if (ab > 0 && bc > 0 && ca > 0)
// {
//     if (DoersTriangleExists(ab, bc, ca)) Console.WriteLine("треугольник с такими сторонами существует");
//     else Console.WriteLine("Треугольник не существует");
// }
// else Console.WriteLine("Треугольник с отрицательно сторонойне существует");
// bool DoersTriangleExists(int ab, int bc, int ca)
// {
//     if (ab + bc > ca && ca + ab > bc && bc + ca > ab) return true;
//     else return false;
// }

// ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,2 вариант

Console.Write("Введите сторону A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону C: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}
bool result = Triangle(num1, num2, num3);
Console.WriteLine(result?"Является треугольником":"Не является треугольником");
