/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] array = new int[2, 2, 2];

int[,,] FillArray(int[,,] arr)
{
    int[] temporaryArray = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    Random random = new Random();
    for (int i = 0; i < temporaryArray.Length; i++)
    {
        temporaryArray[i] = random.Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temporaryArray[i] == temporaryArray[j])
                {
                    temporaryArray[i] = random.Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = temporaryArray[index];
                index++;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({j},{k},{i}) ");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] resultArray = FillArray(array);
PrintArray(resultArray);