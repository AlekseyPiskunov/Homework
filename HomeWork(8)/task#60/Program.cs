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
    int[] temoraryArray = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    Random random = new Random();
    int number;
    for (int i = 0; i < temoraryArray.GetLength(0); i++)
    {
        temoraryArray[i] = random.Next(10, 100);
        number = temoraryArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temoraryArray[i] == temoraryArray[j])
                {
                    temoraryArray[i] = random.Next(10, 100);
                    j = 0;
                    number = temoraryArray[i];
                }
                number = temoraryArray[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[x, y, z] = temoraryArray[count];
                count++;
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