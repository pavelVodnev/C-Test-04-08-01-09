// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое чисто: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());


if (A > B)
{
    Console.WriteLine("{0} наибольшее число", A);
    Console.WriteLine("{0} наименьшее число", B);
}
else
{
    Console.WriteLine ("{0} наибольшее число", B );
    Console.WriteLine("{0} наименьшее число", A);
}