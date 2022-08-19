/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. 
*/
System.Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];

int[] FillArray(int[] arr) // Заполняет массив.
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
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

int FindCountEvenNumbers(int[] arr) // Поиск кол-ва чётных чисел.
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}

int[] fillArray = FillArray(array);
PrintArray(fillArray);
int findCountEvenNumbers = FindCountEvenNumbers(array);
System.Console.WriteLine($"Кол-во чётных чисел в массиве - {findCountEvenNumbers}");