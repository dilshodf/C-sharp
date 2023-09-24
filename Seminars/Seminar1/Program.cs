// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Your number -> {num} ");




// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Quad of {num} -> {num * num}");




// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает **последнюю** цифру этого числа.

    // 456 -> 6
    // 782 -> 2
    // 918 -> 8

// System.Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num < 1000)
// {
//     System.Console.WriteLine($"Last digit of {num} -> {num % 10}");
// }

// else
// {
//     System.Console.WriteLine("You input not three-digit number");
// }




// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

// System.Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = n * (-1);

// System.Console.Write($"{n} -> \"");

// while (m < n)
// {  
//     System.Console.Write($"{m++}, ");
// }

// System.Console.Write($"{n}\"");




// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

System.Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    System.Console.Write($"a = {a}, b = {b} -> yes");
}
else
{
    System.Console.Write($"a = {a}, b = {b} -> no");
}