int[] FillArray(int size)
{
    Random random = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(0, 100); 
    }
    return arr;
}

int Count(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 & arr[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(Count(FillArray(123)));