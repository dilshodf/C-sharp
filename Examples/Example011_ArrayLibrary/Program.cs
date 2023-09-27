// использование генератора случайных чисел и методов

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;     // -1 ставим по умолчанию, чтобы при поиске неопрделенного элемента выдавало ошибку
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];          // создали новый массиd в котором будет 10 элементов (будет заполнен 0)

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);