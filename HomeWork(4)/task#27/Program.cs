//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.Write("Введите число ");
string? number = Console.ReadLine();

bool isNum = int.TryParse(number, out int result);
if (isNum == false)
{
    Console.WriteLine("Ошибка! Вводите пожалуйста числа.");
    return;
}

int SumNumber(int number)
{
    int length = Convert.ToString(number).Length;
    int result = 0;

    for (int i = 0; i < length; i++)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int sum = SumNumber(result);
System.Console.WriteLine($"Сумма - {sum}");
