﻿// Напишите программу, которая принимает на
// вход два числа и проверяет,
//  является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет



Console.WriteLine("Введите целое чисто №1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое чисто №2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a )
{
    Console.WriteLine("Одно число являеться квадаратом другого.");
}else {
    Console.WriteLine("Ни одно число не являеться квадаратом другого.");
}

