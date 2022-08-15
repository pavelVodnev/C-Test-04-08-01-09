// 1 Вид
// void Method1()
// {
//     Console.WriteLine(" Автор Воднев П.С.");
// }
// Method1();// вызывается метод!

// 2 Вид

// void Method2(string msg)//string кааоето количество аргументов
// {
//     Console.WriteLine(msg);//"msg" может быть аргументровано к какому значению хотим указать
// }
// Method2("Теkст сообщения");

// 2_1 Вид

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)

//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Теkст сообщения", 4);  // "4" сколько раз будет выводиться на консоле

// 2_2 Вид

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)

//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(count: 4, msg: "другой текст" );// "count""msg" не обезательно писать по порядку.К какому оргументу какое относиться!

// 3 Вид Метод который возрощает но ничего не принемает.

// int Method3()
// {
//     return DateTime.Now.Year;  //вызываем текущее время,год. Сдесь действие
// }
// int year = Method3();// индефикатор переменно.результат положенного метода.
// Console.WriteLine(year);

// 4 Вид Принимают и возрощают.

string Method4(int count, string text) // "string"=="char" 
{
    int i = 0;
    string result = String.Empty;//будем класть конечный результат. ""==String.Empty перевод пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result; // указываем ту переменную которую хотим получить из метода
}
string res = Method4(3, "показавем в терминале!"); // "string res = " вызов нужного метода
Console.WriteLine(res);




