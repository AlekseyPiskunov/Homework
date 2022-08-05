//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите следующее число ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
{
    Console.Write($"max = {numberFirst} ");
    Console.Write($"min = {numberSecond} ");
}
else
{
    Console.Write($"max = {numberSecond} ");
    Console.Write($"min = {numberFirst} ");
}