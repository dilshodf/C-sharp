﻿
string[,] table = new string[2, 5];
// String.Empty - по умолчанию для строк инициализация происходит такой константой
// table[0, 0]      table[0, 1]     table[0, 2]     table[0, 3]     table[0, 4]
// table[1, 0]      table[1, 1]     table[1, 2]     table[1, 3]     table[1, 4]

table[1, 2] = "слово"; // обратились к нужному элементу

for (int rows = 0; rows < 2; rows++)    // цикл для строк
{
    for (int columns = 0; columns < 5; columns++) // цикл для стобцов
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");  // поставили "-" (минусы) с двух сторон чтоб было наглядно видно что все строки и столбцы выводятся (так как по умлочанию строки инициализируются пустыми String.Empty)
    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Метод который отдельно будет печатать двумерную матрицу
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

//  Метод который будет заполнять нашу матрицу случайными числами
void FIllArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //[1; 10)
        }
    }
}

int[,] matrix = new int[3, 4]; // старая матрица с нулями
PrintArray(matrix); // выводит старую матрицу с нулями
FIllArray(matrix);  // заполняет новую матрицу
System.Console.WriteLine(); // делает отступ между двумя матрицами
PrintArray(matrix); // выводит новую заполненную матрицу


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int[,] pic = new int[,]  // необязательно указывать количество строк и столбцов если у вас есть фиксированные данные
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            // System.Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) System.Console.Write($" ");
            else System.Console.Write($"+");
        }
        System.Console.WriteLine();
    }
}

void FillImage(int row, int col)    // метод который будет закрашивать нашу картинку
{
    if (pic[row, col] == 0)         // если текущий пиксель не закрашен
    {
        pic[row, col] = 1;          // будем красить единичками
        FillImage(row - 1, col);    // после закраски идем вверх и проверяем закрашено там или нет, если нет, то закрашиваем
        FillImage(row, col - 1);    // после закраски идем влево и проверяем закрашено там или нет, если нет, то закрашиваем
        FillImage(row + 1, col);    // после закраски идем вниз и проверяем закрашено там или нет, если нет, то закрашиваем
        FillImage(row, col + 1);    // после закраски идем вправо и проверяем закрашено там или нет, если нет, то закрашиваем
        // здесь мы использовали РЕКУРСИЮ - метод который вызывает самого себя
    }
}

PrintImage(pic);        // выводит первоначальное незакрашенное изображение
FillImage(13, 13);      // выбрали случайную точку (13,13) которая должна быть внутри нашего изображения
PrintImage(pic);        // выводит закрашенное изображение


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Вычислим факториал

// int Factorial(int n)        // с типом данных int компьютер останавливается на 16!
double Factorial(int n)
{
    // 1! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Числв Фибоначчи
// f(1) = 1
// f(2) = 1
// f(3) = 2
// f(4) = 3
// f(n) = f(n-1) + f (n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)        // начиная с 40 комп начинает медленно считать
{
    System.Console.WriteLine($"f{i} = {Fibonacci(i)}");
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


