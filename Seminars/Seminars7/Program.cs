// int InputInteger(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.Readline()); // 
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int minValue, int maxValue)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue + 1);
//         }
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             System.Console.WriteLine($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = InputInteger("Введите количество строк: ");
// int columns = InputInteger("Введите количество столбцов: ");
// int min = InputInteger("Введите минимальное значение: ");
// int max = InputInteger("Введите максимальное значение: ");
// int[,] array = Create2DArray(rows, columns);
// Fill2DArray(array, min, max);
// Print2DArray(arr);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// int InputInteger(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             System.Console.WriteLine($"{array[i, j]}\t ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = InputInteger("Введите количество строк: ");
// int columns = InputInteger("Введите количество столбцов: ");
// int[,] array = Create2DArray(rows, columns);
// Fill2DArray(array);
// Print2DArray(array);



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// int InputInteger(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine()); // 
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int minValue, int maxValue)
// { 
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue + 1);
//         }
//     }
// }

// void ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] *= array[i, j];
//             }
//         }
//     }
// }




// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             System.Console.WriteLine($"{array[i, j]}\t ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = InputInteger("Введите количество строк: ");
// int columns = InputInteger("Введите количество столбцов: ");
// int min = InputInteger("Введите минимальное значение: ");
// int max = InputInteger("Введите максимальное значение: ");
// int[,] array = Create2DArray(rows, columns);
// Fill2DArray(array, min, max);
// Print2DArray(array);
// System.Console.WriteLine();
// ChangeArray(array);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



