//  Заполняет массив случайными уникальными числами. (Filling an array with random unique numbers)
int[] array = new int[9];

int[] FillArray(int[] arr)
{
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 10);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i] == arr[j])
                {
                    arr[i] = random.Next(1, 10);
                    j = 0;
                }
            }
        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] resultArray = FillArray(array);
PrintArray(resultArray);