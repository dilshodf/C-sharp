// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int DigitCount(int num)
// {
//     int count = 1;
//     for (int i = 0; num > 10; i++)
//     {
//         num /= 10;
//         count++;
//     }
//     return count;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));

// int DigitCount(int num)
// {
//     int count = 0;
//     for (int i = 1; Math.Abs(num) > 0; i++)  // для отрицательных чисел
//     {
//         num /= 10;
//         count = i;
//     }
//     return count;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));


// int GetDigigtsCount(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result++;
//         number /= 10;
//     }
//     return result;
// }

// Console.WriteLine(GetDigigtsCount(1024));




// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] (решим для любого количества элементов)

// int[] // будет возвращать массив целых чисел

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size]; // выделяем память на массив размера size (инициализируем массив)
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); // Обратились к каждому элементу массива и заполинили их рандомными числами
//     }
//     return array;
// }

// void PrintArray(int[] array) // теперь нужно вывести
// {
//     for (int i =0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// System.Console.Write(CreateRandomArray(size, min, max));




// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetSumNumbers (int num)
// {
//     int sum = 0;
//     for (int i=1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetSumNumbers(num));

// int n = int.Parse(Console.ReadLine());  // некий другой способ

//     int result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result *= i;
//     }
    
//     Console.WriteLine("Product of numbers from 1 to " + n + " is " + result);
// }

// int FindSum(int n)
// {
//     int sum = 0;
//     for(int i = 1; i <= n; i++)
//     {
//         sum +=1;
//     }
//     return sum;
// }

// System.Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindSum(num));



// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

// int FindFactorial(int n)
// {
//     int fact = 1;
//     for(int i = 1; i <= n; i++)
//     {
//         fact *=1;
//     }
//     return fact;
// }

// System.Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindFactorial(num));



