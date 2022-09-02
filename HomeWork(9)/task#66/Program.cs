/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int SumElements(int numFirst, int numSecond)
{
    int sum = 0;
    if (numFirst <= numSecond)
    {
        return sum += numFirst + SumElements(numFirst + 1, numSecond);
    }
    else
    {
        return sum;
    }
}

int result = SumElements(m, n);
Console.WriteLine(result);