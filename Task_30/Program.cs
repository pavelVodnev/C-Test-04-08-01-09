// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// 1 Решение

// int[] NewArray()
// {
//     int[] array = new int[8];// создали новый массив
//     for (int i = 0; i <= 7; i++)
//     {
//         array[i] = new Random().Next(0, 2); // Random "(0.2)" потомучто берет 0 и 1
//     }
//     return array;
// }
// int[] array = NewArray();
// void PrintArray()
// {

//     for (int i = 0; i <= 7; i++)
//     {
//         Console.Write($" {array[i]}, ");
//     }
// }
// PrintArray();

// 2 Решение
void MasRandom(int[] array)
{
    Random md = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = md.Next(0, 2);
    }
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i < array.Length-1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

Console.WriteLine("Вывод массива:");
int[] mas = new int[8];
MasRandom(mas);
ShowArray(mas);
