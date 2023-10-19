// Задайте двусерный массив размером MxN, заполненный случайными целыми числами.
// m=3, n=4.
// 1 4 8 9 
// 5 -2 33 -2
// 77 3 8 1

int InputInteger(string message) // функция запроса числа от пользователя (кол-во строк, столбцов и прочего)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();   // создаем класс Рандом, чтоб каждую итерацию цикла не создавать новый объект
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество столбцов: ");
int min = InputInteger("Введите минимальное значение: ");
int max = InputInteger("Введите максимальное значение: ");
int[,] arr = Create2DArray(rows, columns);    // создаем наш массив
Fill2DArray(arr, min, max);
Print2DArray(arr);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Нужно адать двумерный массив роазмера MxN  каждый элемент массива находится по фомруле a(m,n) = m+n, 
// если элмента стоит в строке 2 и столбце 3, то значение индекса будет равно 5

int InputInteger(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество столбцов: ");
int[,] arr = Create2DArray(rows, columns);
Fill2DArray(arr);
Print2DArray(arr);



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Нужно задать двумерный массив, найти элементы у которых оба индекса четные, и заменить эти элементы на их квадраты

int InputInteger(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()); // 
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}


void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество столбцов: ");
int min = InputInteger("Введите минимальное значение: ");
int max = InputInteger("Введите максимальное значение: ");
int[,] array = Create2DArray(rows, columns);
Fill2DArray(array, min, max);
Print2DArray(array);
ChangeArray(array);
System.Console.WriteLine("Измененный массив: ");
Print2DArray(array);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Нужно задать двумерный массив и найти сумму элементов находящихся на главной диагонали

int InputInteger(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

// int FindMinimum(int rows, int columns)
// {
//     if (rows < columns)
//         return rows;
//     else
//         return columns;
// }

// int GetMinSize(int[,] ints)    // Тернарный оператор
// {
//     return ints.GetLength(0) < ints.GetLength(1) ? ints.GetLength(0) : ints.GetLength(1);
// }

int FindMinimum(int[,] array)
{
    if (array.GetLength(0) < array.GetLength(1))
        return array.GetLength(0);
    else
        return array.GetLength(1);
}

// int GetSumMainDiagonal(int[,] array, int rows, int columns)
// {
//     int minSize = FindMinimum(rows, columns);
//     int sum = 0;
//     for (int i = 0; i < minSize; i++)
//     {
//         sum += array[i, i];
//     }
//     return sum;
// }

int GetSumMainDiagonal(int[,] array)
{
    int minSize = FindMinimum(array);
    int sum = 0;
    for (int i = 0; i < minSize; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int rows = InputInteger("Введите количество строк: ");
int columns = InputInteger("Введите количество столбцов: ");
int min = InputInteger("Введите минимальное значение: ");
int max = InputInteger("Введите максимальное значение: ");
int[,] array = Create2DArray(rows, columns);
Fill2DArray(array, min, max);
Print2DArray(array);
System.Console.WriteLine($"Сумма по оглавной диагонали: {GetSumMainDiagonal(array)}");
