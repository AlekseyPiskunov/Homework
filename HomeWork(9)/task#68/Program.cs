/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
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

int Akkerman(int numFirst, int numSecond)
{
    if (numFirst == 0) return numSecond + 1;
    else if (numSecond == 0) return Akkerman(numFirst - 1, 1);
    else return Akkerman(numFirst - 1, Akkerman(numFirst, numSecond - 1));
}

int functionAkkerman = Akkerman(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");