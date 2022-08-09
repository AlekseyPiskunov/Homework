// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(number);

void FindingTheThirdDigit(string number)
{
    if (number.Length > 2)
    {
        Console.WriteLine($"Третья цифра числа - {number[2]}");
    }
    else
    {
        Console.WriteLine("У числа нету третьей цифры!");
    }
}
FindingTheThirdDigit(stringNumber);