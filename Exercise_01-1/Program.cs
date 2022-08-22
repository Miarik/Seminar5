int[] array = { -4, -8, 8, 2 };

int[] ReverseNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];

    }
    return arr;
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}

PrintArray(ReverseNumber(array));
Console.WriteLine();