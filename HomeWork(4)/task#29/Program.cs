//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//________________________________________________Вариант 1
System.Console.Write("Введите числа: ");
string? number = Console.ReadLine();

bool isNum = int.TryParse(number, out int result);
if (isNum == false)
{
    System.Console.WriteLine("Ошибка! Вводите пожалуйста числа.");
    return;
}

char[] AddNewArray(string? num)
{
    char[] array = new char[num.Length];
    for (int i = 0; i < num.Length; i++)
    {
        array[i] = num[i];
    }
    return array;
}

void PrintArray(char[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

PrintArray(AddNewArray(number));

//________________________________________________Вариант 2
//________________________________________________Программа которую мы делали на Семинаре. Впринципе тоже подходит к решению.
// int[] array = new int[8];

// int[] FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }

// int[] printArray = FillArray(array);
// PrintArray(printArray);