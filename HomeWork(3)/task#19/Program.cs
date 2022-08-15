//______________________________________________________________
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.Write("Введите число -  ");
string? firstNumber = Console.ReadLine();
string secondNumber = string.Empty;

for (int i = firstNumber.Length - 1; i >= 0; i--)
{
    secondNumber += firstNumber[i];
}

for (int i = 0; i < secondNumber.Length; i++)
{
    System.Console.Write($" {secondNumber[i]}");
}

bool Checks(string num1, string num2)
{
    bool checks = num1 == num2;
    return checks;
}

if (Checks(firstNumber, secondNumber))
{
    System.Console.WriteLine(" | Это палиндром.");
}
else System.Console.WriteLine(" | Это не палиндром.");