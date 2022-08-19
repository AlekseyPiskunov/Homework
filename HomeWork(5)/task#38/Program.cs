/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] array = new int[5];

int[] FillArray(int[] arr) // Заполняет массив.
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr) // Печатает массив.
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int[] fillArray = FillArray(array);
PrintArray(fillArray);

int FindMaxElement(int[] arr) // Ищет максимальный елемент в массиве.
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

int maxElement = FindMaxElement(array);

int FindMinElement(int[] arr, int max) // Ищет минимальный елемент в массиве.
{
    int min = max;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

int minElement = FindMinElement(array, maxElement);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами = {maxElement - minElement}");