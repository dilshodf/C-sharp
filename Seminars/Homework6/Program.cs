// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Prompt(string message)
// {
//     System.Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[] InputArray(int length)
// {
//     int[] InputArray = new int[length];
//     for (int i = 0; i < InputArray.Length; i++)
//     {
//         InputArray[i] = Prompt($"Input {i + 1} element");
//     }
//     return InputArray;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine(($"a[{i}] = {array[i]}"));
//     }
// }

// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int length = Prompt("Input number of elements >");
// int[] array;
// array = InputArray(length);
// PrintArray(array);
// System.Console.WriteLine($"Number of positive numbers -> {CountPositiveNumbers(array)}");


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// const int coefficient = 0;
// const int constant = 1;
// const int x_coord = 0;
// const int y_coord = 1;
// const int line1 = 1;
// const int line2 = 1;

// double[] lineData1 = InputLineData(line1);
// double[] lineData2 = InputLineData(line2);

// if (ValidateLines(lineData1, lineData2))
// {
//     double[] coord = FindCoords(lineData1, lineData2);
//     System.Console.Write($"Точка пересечения уравнений y= {lineData1[coefficient]}*x + {lineData1[constant]} и y= {lineData2[coefficient]}*x + {lineData2[constant]} ");
//     System.Console.Write($" имеет координаты ({coord[x_coord]}, {coord[y_coord]})");
// }

// double Prompt(string message)
// {
//     System.Console.WriteLine(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToDouble(value);
//     return result;
// }

// double[] InputLineData(int numberOfLine)
// {
//     double[] lineData = new double[2];
//     lineData[coefficient] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
//     lineData[constant] = Prompt($"Введите константу для {numberOfLine} прямой >");
//     return lineData;
// }

// double[] FindCoords(double[] lineData1, double[] lineData2)
// {
//     double[] coord = new double[2];
//     coord[x_coord] = (lineData1[constant] - lineData2[constant]) / (lineData2[coefficient] - lineData1[coefficient]);
//     coord[y_coord] = lineData1[constant] * coord[x_coord] + lineData1[constant];
//     return coord;
// }

// bool ValidateLines(double[] lineData1, double[] lineData2)
// {
//     if (lineData1[coefficient] == lineData2[coefficient])
//     {
//         if (lineData1[constant] == lineData2[constant])
//         {
//             System.Console.WriteLine("Прямые не совпадают");
//             return false;
//         }
//         else
//         {
//             System.Console.WriteLine("Прямые параллельны");
//         }
//     }
//     return true;
// }