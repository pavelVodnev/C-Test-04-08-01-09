﻿// Напишите программу, которая будет принимать на
// вход два числа 
// и выводить, является ли второе число
// кратным первому. 
// Если число 2 не кратно числу 1,
//  то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое чисто: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0 )
{
    Console.Write($"кратно {a},{b} ");
}
else 
{
    Console.Write($"{a},{b} не кратно,остаток {a % b}");
}