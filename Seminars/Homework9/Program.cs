// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNums(int n)
// {
//     if (n > 0)
//     {
//         System.Console.Write(n + " ");
//         ShowNums(n - 1);
//     }
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"N = {n} -> ");
// ShowNums(n);



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int n, int m)
// {
//     if (n != m)
//     {
//         if (m > n)
//         {
//             return FindSum(n, m - 1) + m;
//         }
//         else
//         {
//             return FindSum(n - 1, m) + n;
//         }

//     }
//     else return n;
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"M = {m}; N = {n} -> ");
// System.Console.WriteLine(FindSum(n, m));



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackerman(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return Ackerman(n - 1, 1);
//     }
//     else
//     {
//         return Ackerman(n - 1, Ackerman(n, m - 1));
//     }
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"m = {m}; n = {n} -> A ({m}, {n}) = ");
// System.Console.WriteLine(Ackerman(n, m));