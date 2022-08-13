//______________________________________________________________
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* Вариант 1 */
// try
// {
//     Console.WriteLine("Введите пятизначное число: ");
//     int number = int.Parse(Console.ReadLine());
//     string numberStr = Convert.ToString(number);

//     if (numberStr.Length == 5)
//     {
//         Checking(numberStr);
//     }
//     else
//     {
//         Console.WriteLine("Я не знаю что с этим делать...");
//     }
// }
// catch (Exception)
// {
//     Console.WriteLine("Ошибка ввода!");
// }

// void Checking(string num)
// {
//     if (num[0] == num[4] & num[1] == num[3])
//     {
//         Console.WriteLine("Это число палиндром.");
//     }
//     else
//     {
//         Console.WriteLine("Это число не палиндром.");
//     }
// }

/* 
    Вариант 2 
*/

// try
// {
//     Console.WriteLine("Введите пятизначное число: ");
//     int number = int.Parse(Console.ReadLine());
//     string numberStr = Convert.ToString(number);

//     if (numberStr.Length == 5)
//     {
//         if (Checking(numberStr))
//         {
//             Console.WriteLine("Палиндром!");
//         }
//         else
//         {
//             Console.WriteLine("Не палиндром!");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Error.");
//     }
// }
// catch
// {
//     throw new Exception("Error.");
// }

// bool Checking(string num)
// {
//     bool result = num[0] == num[4] || num[1] == num[3];
//     return result;
// }

/*
    Вариант 3
*/
Console.WriteLine("Введите пятизначное число: ");

int Reverse(int number)
{
    string numberStr = Convert.ToString(number);
    char[] c = numberStr.ToCharArray();
    Array.Reverse(c);
    string n = new string(c);
    return Convert.ToInt32(n);
}

int number = Convert.ToInt32(Console.ReadLine());
int Rev = Reverse(number);
if (Rev == number)
{
    Console.WriteLine("Палиндром ");
}
else
{
    Console.WriteLine("Не палиндром ");
}