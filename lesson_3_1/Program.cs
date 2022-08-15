                                            // Цикол и нетолько Whiel но и for

// string Method4(int count, string text) // "string"=="char" 
// {
//     // int i = 0; при использовании "for" можно все собрать в одну строчку
//     string result = String.Empty;//будем класть конечный результат. ""==String.Empty перевод пустая строка
//     for (int i = 0; i < count; i++)// "int i = 0;" инициализация счетчика,"i < count" проверка условия "i++;"увеличения счетчика
//     // while (i < count)при использовании "for" можно все собрать в одну строчку
//     {
//         result = result + text;
//         // i++;при использовании "for" можно все собрать в одну строчку
//     }
//     return result; // указываем ту переменную которую хотим получить из метода
// }
// string res = Method4(3, "показавем в терминале!"); // "string res = " вызов нужного метода
// Console.WriteLine(res);

                                                // Цикол в Цикле
// Таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)//опратор ,метод цикла
    {
        Console.WriteLine($"{i}*{j}={i * j}");
    }
    Console.WriteLine();// будет промежуток между циклами
}