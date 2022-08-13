// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 
/* 
     Вариант 1 
*/
//try
// {
//     System.Console.WriteLine("Введите число ");
//     int number = int.Parse(Console.ReadLine());

//     for (int i = 1; i <= number; i++)
//     {
//         System.Console.WriteLine(Math.Pow((i), 3));
//     }
// }
// catch (Exception)
// {
//     System.Console.WriteLine("Error.");
// }

/*  
    Вариант 2 
*/
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