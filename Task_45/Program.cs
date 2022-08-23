// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

// ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,1 не доделоно

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write(array[i]);
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// int [] arr=CreateArrayRndInt(5,1,9);
// PrintArray(arr);

// int[]CreateArrayCopiArr(int []array)
// {
//     int[] newArray =new int [array.Length]; 
//     for (int i = 0; i < array.length; i++)
//     {
//         if(i < array.length)
//         newArray[i]=array[i];

//     }
// }

// ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,2 вариант полный надо подправить

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] ReturnArray(int[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

int[] arr1 = CreateArray(10, 1, 20);
PrintArray(arr1);
int[] arr2 = ReturnArray(arr1);
PrintArray(arr2);

Console.WriteLine("Изменим втрое значение в массиве, чтобы определить скопированный массив");

arr1[1] = 30;
PrintArray(arr1);
PrintArray(arr2);

