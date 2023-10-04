// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int DigitCount(int num)
// {
//     int count = 1;
//     for (int i = 0; num >= 10; i++) // пока число больше или равно 10 будем делить на 10 и считать количество раз (смысл for теряется, i никак не задействовано)
//     {
//         num /= 10;  // num = num / 10
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
//     for (int i = 1; Math.Abs(num) > 0; i++)  // для отрицательных чисел (чтобы использовать i решаем этим способом)
//     {
//         num /= 10;
//         count = i;
//     }
//     return count;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));


// int GetDigigtsCount(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result++;
//         num /= 10;
//     }
//     return result;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetDigigtsCount(num));




// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] (решим для любого количества элементов)

// В данном примере мы выведем массив из скольки угодно элементов заполненный рандомными значениями в указанном диапазоне

// int[] // будет возвращать массив целых чисел

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size]; // мы хотим создать массив целых чисел и выделяем память на массив размера size (инициализируем массив)
//     for (int i = 0; i < size; i++) // если работаем с массивом, то всегда используем цикл
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

// PrintArray(CreateRandomArray(size, min, max));




// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120
// Решим разом 2 задачи


// int FindSum(int n)
// {
//     int sum = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// int FindFactorial(int n)
// {
//     int fact = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         fact *= i;
//     }
//     return fact;
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindSum(n));
// System.Console.WriteLine(FindFactorial(n));



