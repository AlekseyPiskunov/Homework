/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] firstMatrix = new int[2, 2]
{
    {2,4},
    {3,2}
};

int[,] secondMatrix = new int[2, 2]
{
    {3,4},
    {3,3}
};

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

PrintArray(firstMatrix);
System.Console.WriteLine();
PrintArray(secondMatrix);
System.Console.WriteLine();

int[,] ResultSumTwoMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] result = new int[matrixFirst.GetLength(0), matrixFirst.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                result[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }
        }
    }
    return result;
}

int[,] result = ResultSumTwoMatrix(firstMatrix, secondMatrix);
PrintArray(result);