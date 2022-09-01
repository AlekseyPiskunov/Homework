﻿/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
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

void ArraySortMaxToMin(int[,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int i = 0; i < arr.GetLength(1) - 1; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < arr.GetLength(1); j++)
            {
                if (arr[k, j] > arr[k, maxPosition]) maxPosition = j;
            }
            int temporary = arr[k, i];
            arr[k, i] = arr[k, maxPosition];
            arr[k, maxPosition] = temporary;
        }
    }
}

PrintArray(array);
ArraySortMaxToMin(array);
System.Console.WriteLine();
PrintArray(array);