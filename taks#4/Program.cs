// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int numberThree = Convert.ToInt32(Console.ReadLine());

int max = numberFirst;

if (numberFirst > numberTwo)
{
    max = numberFirst;
}
else
{
    max = numberTwo;
}
if (numberThree > max)
{
    max = numberThree;
}
Console.Write($"Это число является самым большим = {max} ");