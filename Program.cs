Commands();
string[] array = new string[] {};

string User = ReadInput("Введите команду: ");
switch (User)
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{User} - Такой команды нет");
        break;
}


int NewArr = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) NewArr++;
}

string[] newArray = new string[NewArr];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);

// Функция вывода команд для работы с программой
void Commands()
{
    Console.WriteLine();
    Console.WriteLine("Команды:");
    Console.WriteLine("1 – Выбрать массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 – Выбрать массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 – Выбрать массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}

// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

//  Функция вывода массива в терминал
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}