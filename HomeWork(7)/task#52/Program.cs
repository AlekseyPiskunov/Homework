// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

double[] resultArray = new double[array.GetLength(1)];

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[] FindArithmeticMean(int[,] arr, double[] resultArr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            resultArr[i] += arr[j, i];
        }
        resultArr[i] = resultArr[i] / arr.GetLength(0);
    }
    return resultArr;
}

void PrintResultArray(double[] resultArr)
{
    for (int i = 0; i < resultArr.Length; i++)
    {
        System.Console.Write($"{resultArr[i]}  ");
    }
}

PrintArray(array);

double[] result = FindArithmeticMean(array, resultArray);

PrintResultArray(resultArray);