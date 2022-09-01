/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] array = new int[5, 4]
{
    {1, 4, 7, 2}, // сумма элементов - 14
    {5, 9, 2, 3}, // сумма элементов - 19
    {8, 4, 2, 4}, // сумма элементов - 18
    {5, 2, 6, 7}, // сумма элементов - 20
    {4, 1, 3, 2}  // сумма элементов - 10
};

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[] ResultsSumRows(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[i] += arr[i, j];
        }
    }
    return result;
}

void PrintIndexMinElement(int[] arr)
{
    int minPosition = arr[0];
    int index = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minPosition)
        {
            minPosition = arr[i];
            index = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index + 1}");
}

PrintArray(array);
System.Console.WriteLine();
int[] result = ResultsSumRows(array);
PrintIndexMinElement(result);