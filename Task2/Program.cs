// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("ВВедите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)  Console.WriteLine("Mondey");

if (day == 2)  Console.WriteLine("Tuesday");

if (day == 3) Console.WriteLine("Wednesday");

if (day == 4)  Console.WriteLine("Thursday");

if (day == 5)  Console.WriteLine("Friday");

if (day == 6)  Console.WriteLine("Satuday");

if (day == 7)  Console.WriteLine("Sunday");

else Console.WriteLine("Число не соответствует диапозону от 7 до ...N ! ");

Console.WriteLine();