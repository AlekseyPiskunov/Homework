//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//________________________________________________Вариант 1
// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// double num(int numA, int numB)
// {
//     double result = Math.Pow(numA, numB);
//     return result;
// }
// System.Console.WriteLine($"Ответ - {num(numberA, numberB)}");

//________________________________________________Вариант 2
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}

int exponentiation = Exponentiation(numberA, numberB);
System.Console.WriteLine(exponentiation);