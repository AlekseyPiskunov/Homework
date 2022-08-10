// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(number);

char FindingTheThirdDigit(string num)
{
    var isNumber = int.TryParse(num, out int result);
    if (isNumber == false)
    {
        throw new Exception("Input is not valid.");
    }
    if (num.Length < 3)
    {
        throw new Exception("Третьей цифры нет!");
    }
    return num[2];
}
char result = FindingTheThirdDigit(stringNumber);
Console.WriteLine(result);

// Другое решение!

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// string stringNumber = Convert.ToString(number);

// void FindingTheThirdDigit(string number)
// {
//     if (number.Length > 2)
//     {
//         Console.WriteLine($"Третья цифра числа - {number[2]}");
//     }
//     else
//     {
//         Console.WriteLine("У числа нету третьей цифры!");
//     }
// }
// FindingTheThirdDigit(stringNumber);