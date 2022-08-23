// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Какое кол-во чисел вы будете вводить? ");
int countNumbers = int.Parse(Console.ReadLine());

int[] array = new int[countNumbers];

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int CheckingHowManyElementsAreLessThanZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            count++;
        }
    }
    return count;
}

int[] result = FillArray(array);
System.Console.WriteLine();
System.Console.Write("Массив: ");
PrintArray(result);

int count = CheckingHowManyElementsAreLessThanZero(result);
System.Console.WriteLine($"Кол-во элементов меньше нуля - {count}.");