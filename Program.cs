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
