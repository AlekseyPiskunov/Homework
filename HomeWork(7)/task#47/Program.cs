// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами. (m = 3, n = 4).

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.Write("Введите высоту массива: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int rows);
System.Console.Write("Введите длину массива: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int columns);

if (!isNumberM || !isNumberN)
{
    System.Console.WriteLine("Введены не верные данные!");
    return;
}

double[,] result = FillArray(rows, columns);
PrintArray(result);

double[,] FillArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-9, 10) / 2.0;
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}