int[] array = { 31, 12, 23, 45, 15, 26, 17, 15 };

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;                          // если в массиве несколько одинаковых значений, останавливаем при первом же
    }
    index++;
}
