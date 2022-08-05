// Напишите программу, которая на вход принимает число (N) 
// , а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введиет число: ");
int N = Convert.ToInt32(Console.ReadLine());
int res = 1;
while (res < N )
{
 Console.Write(res + 1);
 res += 2;
}