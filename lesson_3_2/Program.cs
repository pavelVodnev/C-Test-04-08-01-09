// // Дан текст. В тексте нужно все пробелы заменить черточками,
// // маленькие буквы "к" заменить большими"К",
// // а большие "С" заменить маленькими"с".

// string text = "-Я думаю, -князь, улыбаясь,-что"
//                 + "ежеде бы вас послали вместо нашего милого Винцегероде,"
//                 + "вы бы взяли приступом согласия прусского короля."
//                 + "Вы так красноречивы. Вы дадите мне чаю?";

// // strins s = "qwerty" если будет строка то для этой строки есть вспомогательный функционал.
// //            [012345]
// // s[3] // "r" получаеться третий символ
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;// "result = String.Empty;" инециализация строки
//     int length = text.Length;// чтобы получить длинну строки,показывает символы в строке.
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, '|');
// Console.WriteLine = (newText);