// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(number);

void Find(string number)
{
    if (number.Length > 2)
    {
        Console.WriteLine(number[1]);
    }
    else
    {
        Console.WriteLine("Введено не трёхзначное число!");
    }
}
Find(stringNumber);