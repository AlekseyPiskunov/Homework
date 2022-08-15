// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

double[] TableСube(int s)
{
    double[] array = new double[s];
    for (int i = 1; i <= n; i++)
    {
        array[i - 1] = Math.Pow((i), 3);
    }
    return array;
}

double[] result = TableСube(n);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}