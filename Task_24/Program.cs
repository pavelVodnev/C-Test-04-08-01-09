// Задача 24: Напишите программу, которая
// принимает на вход число (А) и
//  выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// 1 Вариант

// Console.WriteLine("ВВедите  целое положительное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;//"default" можно использовать место 0.

// for (int i = 1; i <= num; i++)//"i = 1" счетчик, "i < legth" условия, "i++"изменения оператора.
// {
//     sum = sum + i; //действие
//  // sum += i; можно так написать
// }
// Console.WriteLine($"сумму чисел от 1 до {num} = {sum}");

// 2 Вариант через метод 

Console.WriteLine("ВВедите  целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)// "SumNumbers" имя для использования

{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
if (num > 0) //добавили "if"  для того чтобы если ввидут отрицательные число
{
    int result = SumNumbers(num);
    Console.WriteLine($"сумму чисел от 1 до {num} = {result}");
}// скобки будут не нужны при else
else Console.WriteLine("Некоректный ввод!");//добавили "else"  для того чтобы если ввидут отрицательные число

