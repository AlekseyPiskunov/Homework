//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.WriteLine("Введите первое число ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите следующее число ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst == numberSecond)
{
    Console.Write($"Числа равны друг другу! Первое число - {numberFirst} , Второе число - {numberSecond}");
}
else
{
    if (numberFirst > numberSecond)
    {
        Console.WriteLine($"Максимальное число = {numberFirst} ");
        Console.Write($"Минимальное число = {numberSecond} ");
    }
    else
    {
        Console.WriteLine($"Максимальное число = {numberSecond} ");
        Console.Write($"Минимальное число = {numberFirst} ");
    }
}