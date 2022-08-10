// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите число от 1 до 7 , соответствующее дню неделе ");
int numberDay = Convert.ToInt32(Console.ReadLine());

switch (numberDay)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;

    case 2:
        Console.WriteLine("Вторник");
        break;

    case 3:
        Console.WriteLine("Среда");
        break;

    case 4:
        Console.WriteLine("Четверг");
        break;

    case 5:
        Console.WriteLine("Пятница");
        break;

    case 6:
        Console.WriteLine("Суббота");
        break;

    case 7:
        Console.WriteLine("Воскресенье");
        break;
}

void DayWeek(int day)
{
    if (day == 6)
    {
        Console.WriteLine("Этот день является выходным!");
        return;
    }
    if (day == 7)
    {
        Console.WriteLine("Этот день является выходным!");
    }
    else
    {
        if (day > 7)
        {
            Console.WriteLine("Ты чё?! В неделе всего семь дней!");
            return;
        }
        if (day < 1)
        {
            Console.WriteLine("Ты чё?! Вводи положительные числа!");
            return;
        }
    }
}
DayWeek(numberDay);