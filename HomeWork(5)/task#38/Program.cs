/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] array = new double[5];

double[] FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 100);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

double[] fillArray = FillArray(array);
PrintArray(fillArray);

double FindMaxElement(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double maxElement = FindMaxElement(array);

double FindMinElement(double[] arr, double max)
{
    double min = max;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double minElement = FindMinElement(array, maxElement);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами = {maxElement - minElement}");