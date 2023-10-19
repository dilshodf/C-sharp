// Собрать строку с числами от a до b, a <= b

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;   // условие окончания, если условие не выполнилось
}

System.Console.WriteLine(NumbersFor(1, 10));
System.Console.WriteLine(NumbersRec(1, 10));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Собрать строку с числами от a до b, b <= a

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;   // условие окончания, если условие не выполнилось
}

System.Console.WriteLine(NumbersFor(1, 10));
System.Console.WriteLine(NumbersRec(1, 10));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Сумма чисел от 1 до N

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

System.Console.WriteLine(SumFor(10));
System.Console.WriteLine(SumRec(10));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Факториал N

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

System.Console.WriteLine(FactorialFor(10));
System.Console.WriteLine(FactorialRec(10));



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Число A в наструальной степени N

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n-1) * a;  // тернарный оператор (запись в одну строчку)
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);     // четные степени можем делить на 2 дял быстроты
    else return PowerRecMath(a, n - 1) * a;                     // нечетные степени ерашем обычным способом
}

System.Console.WriteLine(PowerFor(2, 10));
System.Console.WriteLine(PowerRec(2, 10));
System.Console.WriteLine(PowerRecMath(2, 10));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Алфавит состоящий из 4 букв "a" "b" "c" "d". Покажите все слова состоящие из T букв, которые можно построить из букв этого алфалвита

char[] s = { 'a', 'b', 'c', 'd' };  // алфавит хранится в массиве символов
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)     // если считать 1-буквенные слова
{
    for (int j = 0; j < count; j++)     // если считать 2-буквенные слова
    {
        for (int k = 0; k < count; k++)     // если считать 3-буквенные слова
        {
            for (int l = 0; l < count; l++)     // если считать 4-буквенные слова
            {
                for (int m = 0; m < count; m++)     // если считать 5-буквенные слова
                {
                    System.Console.WriteLine(($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}"));
                }
            }
        }
    }
}


int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
// string alphabet -метод принимающий алфавит
// char[] word - массив из букв который будет создавать новое слово
// int length = 0 - на текущей итерации будет собираться длина этого слова
{
    if (length == word.Length)  // описываем условие выхода рекурсии
    {
        System.Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("abcd", new char[5]);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Есть 5 игроков. Нужно показать разбиение игроков на две команды
// 0 - игрок попадает в первую команду
// 1 - игрок попадает во вторую команду


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Алгоритм обхода директории ( всех папок в папках)

string path = @"D:\GB\C #";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine((di.CreationTime));
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}



void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine(($"{indent}{catalogs[i].Name}"));
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"D:\GB\C #\Examples\Lecture_5";
CatalogInfo(path);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Игра в пирамидки (3 блина и 3 шпильки)

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// with = "1" - шпиль откуда мы берем текущие блин
// on = "3" - шпиль на котором пирамидка должна оказаться
// some = "2" - промежуточный шпиль
// count = 3 - можем поставить нужное количество блинов (4, 5, 6)
{
    if (count > 1) Towers(with, some, on, count - 1);
    System.Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Обход разных структур
// ((4 - 2) * (1 + 3)) / 10
//                     /        1 операция
//          *            10     2 и 3
//     -         +              4 и 5
//   4   2     1   3            8 и 9 и 10 и 11


string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)  // метод который будет делать обход, в качестве аргумента позиция с которой мы начнем обход
{
    if (pos < tree.Length)  // условие рподолжения
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        System.Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);

    }
}


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


