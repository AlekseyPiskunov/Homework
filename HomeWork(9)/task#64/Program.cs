/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

Console.Write("Введите первое число: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите второе число: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || !isNumberN)
{
    System.Console.WriteLine("Введены не верные данные!");
    return;
}

void PrintNumbers(int numFirst, int numSecond)
{
    Console.Write($"{numFirst} ");
    if (numFirst < numSecond)
    {
        PrintNumbers(numFirst + 1, numSecond);
    }
}

PrintNumbers(m, n);