// 17. 1)Напишите программу, которая принимает на вход
// координаты точки (X и Y),
//  2)причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

// ПЕРвый пример решения
// Console.WriteLine("Введите координаты точки: ");        // условия первой части задачи
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть ");         // Вторая часть задачи,
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть:");     //else в этом примере не обезателен,
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть:");      // можно без него.
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть:");
// else Console.WriteLine("Введены не корректные координаты:");

// Второй метод
Console.WriteLine("Введите координаты точки: ");        // условия первой части задачи
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());



string GetQuarter(int xc, int yc)                              // условия первой части задачи
{
    if (xc > 0 && yc > 0) return "Первая четверть ";         // Вторая часть задачи
    if (xc < 0 && yc > 0) return "Вторая четверть:";
    if (xc < 0 && yc < 0) return "Третья четверть:";
    if (xc > 0 && yc < 0) return "Четвертая четверть:";
    return "Введены не корректные координаты:";
}
string result = GetQuarter(x, y);
Console.WriteLine(result);