// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void TransformNumber(int num)
// {
//     int dec = num / 10;
//     int hundred = num / 100;
//     System.Console.WriteLine($"{num} -> {dec - hundred * 10}");
// }

// System.Console.Write("Input three-digit number: ");
// int num= Convert.ToInt32(Console.ReadLine());

// TransformNumber(num);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void TransformNumber(int num)
// {
//     if (num < 100)
//     {
//         System.Console.WriteLine($"{num} -> третьей цифры нет");
//     }
//     else if (num < 1000)
//     { 
//         System.Console.WriteLine($"{num} -> {num % 10}");
//     }
//     else if (num < 10000)
//     { 
//         System.Console.WriteLine($"{num} -> {(num /10) % 10}");
//     }
//     else if (num < 100000)
//     { 
//         System.Console.WriteLine($"{num} -> {(num /100) % 10}");
//     }
//     else if (num < 1000000)
//     { 
//         System.Console.WriteLine($"{num} -> {(num /1000) % 10}");
//     }
//     else if (num < 10000000)
//     { 
//         System.Console.WriteLine($"{num} -> {(num /10000) % 10}");
//     }
//     else if (num < 100000000)
//     { 
//         System.Console.WriteLine($"{num} -> {(num /100000) % 10}");
//     }
//     else if (num < 1000000000)
//     { 
//         System.Console.WriteLine($"{num} -> {(num /1000000) % 10}");
//     }
// }

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// TransformNumber(num);





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void CheckDay(int num)
// {
//     if (num >= 1 && num <= 5)
//     {
//         System.Console.WriteLine($"{num} -> no");
//     }
//     else if (num >= 6 && num <= 7)
//     {
//         System.Console.WriteLine($"{num} -> yes");
//     }
//     else
//     {
//         System.Console.WriteLine("error");
//     }
// }

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// CheckDay(num);
