// 9. Напишите программу, которая  
// выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 10, 99 +1

// Третий метод но при 11 или 22 и т.д. будет ошибка решения

//Console.WriteLine($"Случайное число из диапозога 10 - 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// Это один вариант .

// if (firstDigit == secondDigit) Console.WriteLine ("Цифры рывны");
// else if (firstDigit  > secondDigit ) Console.WriteLine ($"Наибольшее цифрой числа {number} => {firstDigit} ");
// else Console.WriteLine ($"Наибольшее цифрой числа {number} => {secondDigit} ");

// Второй вариант 

// string result = firstDigit == secondDigit ? "Цифры равны" :
// firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
// Console.WriteLine ($"Наибольшее цифрой числа {number} => {result} ");

//Четвертый вариант.

int MaxDigit(int num)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
    
}

int result = MaxDigit(number);
string res = result == 0 ? " Цифры равны" : result.ToString();
Console.WriteLine($"Наибольшее цифрой числа {number} -> {res} ");