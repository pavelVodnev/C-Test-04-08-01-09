// Задача 28: Напишите программу, которая
// принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

//  1 вариант

// Console.Write(" Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = 1;
// for (int i = 1; i <= num; i++)
// {
//     num1 = num1 * i;// num *=i можно так

// }
// Console.WriteLine($"произведение чисел {num1}");

// 2 вариант

Console.Write(" Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int composition = 1;
for (int i = 1; i <= num; i++)
{
    composition = composition * i;
}
Console.WriteLine($"Производное от 1 до {num}: {composition}");