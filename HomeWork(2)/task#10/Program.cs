// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
char Find(string number)
{
    var isNumber = int.TryParse(number, out int result);
    if (isNumber == false)
    {
        throw new Exception("Ввод недействителен.");
    }

    if ((number.Length < 3) || (number.Length > 3))
    {
        throw new Exception("Введено не трёхзначное число!");
    }
    return number[1];
}
char result = Find(stringNumber);
Console.WriteLine(result);