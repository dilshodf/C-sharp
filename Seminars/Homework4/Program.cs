// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int PowerOf(int A, int B)
// {
//     int result = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         result *= A;
//     }
//     return result;
// }


// System.Console.Write("Input A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"{A}, {B} -> {PowerOf(A, B)}");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int DigitCount(int num)
// {
//     int result = 0;
//     for (int i = 0; num > 0; i++)
//     {
//         result += num % 10;
//         num /= 10;
//     }
//     return result;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{num} -> {DigitCount(num)}");