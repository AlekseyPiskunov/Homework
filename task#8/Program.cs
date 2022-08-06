// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Напишите любое число ");
int n = Convert.ToInt32(Console.ReadLine());
int number = 0;

for (int i = number; i <= n; i = i + 2)
{
    Console.Write(i);
    Console.Write("| ");
}