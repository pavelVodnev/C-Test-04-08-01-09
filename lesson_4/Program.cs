// string[,] table = new string[2, 5];
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] - первая цифра столб,вторая строка
// table[0,0] table[1,1] table[1,2] table[1,3] table[1,4] - у нас массив до 5


// .............................................1 вид будет выводиться пустые строки,как пример  (-{}-) через черточку
// table[1, 2] = "слово";//1-строка 2-столбец,"слово" обычная переменная

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


// ...................................................................0000
//....................................................................0000
// ...................................................................0000

// ...................................................................8782
// ...................................................................8276
// ...................................................................2675  вот так выгледит
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// .......................................рисуем пале в верх, и закрушывае внутреннию полость
//             ++
//            +  +
//            +  +
//           +   +
//           +   +
//          +   +
//        ++    +
//      ++     +
//   +++      ++++++++++    
//   +                  +   
//   +                  +   
//   +             +++++    
//   +                  +   
//   +                  +   
//   +             +++++    
//   +                 +    
//   +                 +    
//   +            +++++     
//   +++++            +     
//        ++++       +      
//            +++++++       


//             ++
//            ++++
//            ++++
//           +++++
//           +++++
//          +++++
//        +++++++
//      ++++++++
//   +++++++++++++++++++    
//   ++++++++++++++++++++   
//   ++++++++++++++++++++   
//   +++++++++++++++++++    
//   ++++++++++++++++++++
//   ++++++++++++++++++++
//   +++++++++++++++++++
//   +++++++++++++++++++
//   +++++++++++++++++++
//   ++++++++++++++++++
//   ++++++++++++++++++
//        ++++++++++++
//            +++++++


// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             // Console.Write($"{image[i, j]}");
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }
// void FillImage(int row, int col)//row-столбец col-строка,сокращение
// {
//     if (pic[row, col] == 0)// если row и col равен 0 то
//     {
//         pic[row, col] = 1; // мы его будем красит цифро 1
//         FillImage(row - 1, col); // FillImage вызывает сам себя
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13,13);//(13,13) случайное чило,которое в нутри нашего изображения примерно
// PrintImage(pic);

// ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,Факториал 

// double Factorial(int n)//double возрощающейся степень
// {
//     // 1!=1 И 0!=1
//     if (n == 1) return 1; //если n = 1 то возрощаем 1
//     else return n * Factorial(n - 1); // в противном случае берем текущее значения и умножаем на ! предыдущего числа
// }
// // Console.WriteLine(Factorial(3));  //1*2*3=6, 3 как пример
// for (int i = 1; i < 40; i++)
// {
//     // Console.WriteLine(Factorial(i));// будут минусовые числа и нули
//     Console.WriteLine($"{i}!={Factorial(i)}");
// }

// ...............................................Фибоначи

// f(1)=1
// f(2)=1
// f(n)=f(n-1)+f(n-2) формула


// int Fibonacci(int n)// int целые чила
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }

// double Fibonacci(int n)// doouble возрощаюет
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }