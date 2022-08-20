/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/
int[] array = new int[4];

int[] FillArray(int[] arr) // Заполняет массив.
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-9, 10);
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

int FindSumElementsPositionNotEven(int[] arr) // Поиск суммы элементов стоящих на не чётных позициях.
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int[] fillArray = FillArray(array);
PrintArray(fillArray);
int sumElements = FindSumElementsPositionNotEven(fillArray);
System.Console.WriteLine($"Сумма элементов стоящих на не чётных позициях - {sumElements}");