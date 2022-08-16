// Задача 26: Напишите программу, которая принимает
// на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

//  1 Вариант

// Console.WriteLine("ВВедите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int x = num;
// int count = 0;
// if (x == 0)
// {
//     count = 1;
// }
// else

// while (x != 0)
// {
//     x = x / 10;
//     count++;
// }
// Console.WriteLine(count);

// 2 Вариант функцией

// Console.Write(" Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int Numbers(int number)
// {
// int x = number;
//  if (x == 0)
//     {
//         count = 1;
//     }
// else
// {
// while (x != 0)
//     {
//         x = x / 10;
//         count++;
//     }
// }  
// return count;
// }

// Console.WriteLine(Numbers(num));

// 3 Вариант решения
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int input = number;
if (number < 0)
{
    number = -number;
  
}

while (number > 0)
{
    number /= 10;
    i++;
}
Console.WriteLine($"Введено число {input} состоит из {i} чисел");



