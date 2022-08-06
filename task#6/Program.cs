// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число чётное!");
    int del = number / 2;
    Console.Write("Число получившееся после деления = ");
    Console.WriteLine(del);
    Console.Write($"Обратно умножаю получившее число: {del} * 2 = ");
    Console.WriteLine(del * 2);
    Console.Write("Остаток = ");
    Console.WriteLine(number % 2);
}
else
{
    Console.WriteLine("Число не чётное!");
    int del = number / 2;
    Console.Write("Число получившееся после деления = ");
    Console.WriteLine(del);
    Console.Write($"Обратно умножаю получившее число: {del} * 2 = ");
    Console.WriteLine(del * 2);
    Console.Write("Остаток = ");
    Console.WriteLine(number % 2);
}