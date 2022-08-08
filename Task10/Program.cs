// Напишите программу, которая выводит случайное
// трёхзначное число
//  и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(10, 1000);
Console.WriteLine ("выводит случайное трёхзначное число: ");

int firstDigit = a / 100;
int secondDigit = a % 10;

Console.WriteLine($"Наибольшее цифрой числа {a} -> {firstDigit}{secondDigit} ");