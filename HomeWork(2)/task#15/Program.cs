// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число от 1 до 7 , соответствующее дню недели ");
int numberDay = Convert.ToInt32(Console.ReadLine());

switch (numberDay)
{
    case 1:
        Console.Write("Понедельник");
        break;

    case 2:
        Console.Write("Вторник");
        break;

    case 3:
        Console.Write("Среда");
        break;

    case 4:
        Console.Write("Четверг");
        break;

    case 5:
        Console.Write("Пятница");
        break;

    case 6:
        Console.Write("Суббота");
        break;

    case 7:
        Console.Write("Воскресенье");
        break;
}

void DayWeek(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine(" - этот день является выходным.");
        return;
    }
    if (day > 7 || day < 1)
    {
        Console.WriteLine($"{day} - это не день недели.");
    }
    else
    {
        Console.WriteLine(" - это будний день.");
    }
}

DayWeek(numberDay);