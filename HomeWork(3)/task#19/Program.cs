/*
   Задача 19 Напишите программу, которая принимает на вход пятизначное число
   и проверяет, является ли оно палиндромом.
*/
try
{
    Console.WriteLine("Введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());
    string numberStr = Convert.ToString(number);

    if (numberStr.Length == 5)
    {
        Checking(numberStr);
    }
    else
    {
        Console.WriteLine("Я не знаю что с этим делать... Введено не пятизначное число!");
    }
}
catch (Exception)
{
    Console.WriteLine("Ошибка ввода!");
}

void Checking(string num)
{
    if (num[0] == num[4] & num[1] == num[3])
    {
        Console.WriteLine("Это число палиндром.");
    }
    else
    {
        Console.WriteLine("Это число не палиндром.");
    }
}