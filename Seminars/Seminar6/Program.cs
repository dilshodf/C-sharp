// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    // System.Console.WriteLine();  // закомментировали чтобы вывести результат как надо
}

int[] ReverseArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

System.Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
System.Console.Write("[");
PrintArray(myArray);    // сначала выводим старый массив
System.Console.Write("] -> [");
myArray = ReverseArray(myArray);    // возвращает метод ReverseArray, который перевернет массив
PrintArray(myArray);    //выводим новый перевернутый массив
System.Console.Write("]");


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string DecimalToBinary(int num)
{
    string result = string.Empty;      // присвоили значение (пустое)
    while (num > 0)
    {
        // result = result + num % 2;  // записывает справа
        result = num % 2 + result;     // записывает слева
        num /= 2;
    }
    return result;
}

System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DecimalToBinary(num));



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool CheckTriangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b)
    {
        System.Console.WriteLine("Такой треугольник сущетсвует. ");
        return true;
    }
    else
    {
        System.Console.WriteLine("Такой треугольник не существует. ");
        return false;
    }
}

System.Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());

CheckTriangle(a, b, c);



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonacci(int n)
{
    int[] array = new int[n];   // инициализировали массив размера (n)
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintArray(Fibonacci(num));