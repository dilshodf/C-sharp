// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно первому, то программа выводит остаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void CheckMultiplicity(int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> кратно");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");
//     }
// }

// System.Console.Write("Input first number: ");
// int num1= Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input second number: ");
// int num2= Convert.ToInt32(Console.ReadLine());

// CheckMultiplicity(num1, num2);




// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int BiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if( ed > dec)
//     {
//         return ed;
//     }
//     else
//     {
//         return dec;
//     }
// }

// int num = new Random().Next(10,100);
// System.Console.Write($"{num} -> ");
// // int result = BiggestDigit(num);
// // System.Console.WriteLine(result);
// System.Console.WriteLine(BiggestDigit(num));




// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

// void ThreeDigit(int num)
// {
//     int ed = num % 10;
//     int hundred = num / 100;
//     System.Console.WriteLine($"{num} -> {hundred * 10 + ed}");
// }

// int num = new Random().Next(10, 1000);
// System.Console.Write("Input number: ");

// ThreeDigit(num);





// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// bool CheckMultiplicity(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{num} -> {CheckMultiplicity(num)}");
