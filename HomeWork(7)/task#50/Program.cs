// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

System.Console.Write("Введите координаты по горизорнтали x: ");
bool isNumX = int.TryParse(Console.ReadLine(), out int numX);
System.Console.Write("Введите координаты по вертикали y: ");
bool isNumY = int.TryParse(Console.ReadLine(), out int numY);

if (!isNumX || !isNumY)
{
    System.Console.WriteLine("Введены не верные данные!");
    return;
}

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
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int FindElement(int[,] arr, int numX, int numY)
{
    int result = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((numY == i) && (numX == j))
            {
                result = array[i, j];
            }
        }
    }
    return result;
}

PrintArray(array);
int result = FindElement(array, numX, numY);
System.Console.WriteLine(result);